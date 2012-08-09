using System;
using System.IO;
using System.Threading;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
    //TODO might want to introduce UnitOfWork
    public class FileImportService<TModel> : IImportService<TModel>
        where TModel : class, IGStandardModel<TModel>
    {
        private readonly string _databaseFilePath;
        private readonly IFileSerializer<TModel> _fileSerializer;
        protected readonly IRepository<TModel> Repository;
        private CancellationToken _cancellationToken;

        public FileImportService(string databaseFilePath, IFileSerializer<TModel> fileSerializer, IRepository<TModel> repository)
        {
            _databaseFilePath = databaseFilePath;
            _fileSerializer = fileSerializer;
            Repository = repository;
        }

        private void OpenFileAndProcess(Action<Stream> streamAction)
        {
            using (var stream = File.OpenRead(_databaseFilePath))
            {
                streamAction(stream);
            }
        }

        protected void ProcessFile(Stream stream, Action<TModel> processLineAction)
        {
            var lines = _fileSerializer.ReadLines(stream);
            foreach (var model in lines)
            {
                processLineAction(model);
                if (_cancellationToken.IsCancellationRequested)
                {
                    break;
                }
            }
        }

        protected virtual void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));
        }

        #region Implementation of IImportService

        public void Start(CancellationToken cancellationToken)
        {
            _cancellationToken = cancellationToken;
            
            IsRunning = true;
            
            OpenFileAndProcess(Import);
            
            IsRunning = false;
        }

        public bool IsRunning { get; private set; }

        #endregion
    }
}
