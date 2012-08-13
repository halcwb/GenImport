using System;
using System.IO;
using System.Threading;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
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

        protected virtual void Import(Stream stream)
        {
            var lines = _fileSerializer.ReadLines(stream);
            Repository.Add(lines);
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
