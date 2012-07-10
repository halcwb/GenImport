using System;
using System.IO;
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
        private readonly IRepository<TModel> _repository;

        private bool _stopImport;

        public FileImportService(string databaseFilePath, IFileSerializer<TModel> fileSerializer, IRepository<TModel> repository)
        {
            _databaseFilePath = databaseFilePath;
            _fileSerializer = fileSerializer;
            _repository = repository;
        }

        private void OpenFileAndProcess(Action<Stream> streamAction)
        {
            using (var stream = File.OpenRead(_databaseFilePath))
            {
                streamAction(stream);
            }
        }

        private void ProcessFile(Stream stream, Action<TModel> processLineAction)
        {
            var lines = _fileSerializer.ReadLines(stream);
            foreach (var model in lines)
            {
                processLineAction(model);
                if (_stopImport) break;
            }
        }

        protected virtual void Import(Stream stream)
        {
            ProcessFile(stream, n => _repository.Add(n));
        }

        #region Implementation of IImportService

        public void Start()
        {
            IsRunning = true;
            
            OpenFileAndProcess(Import);
            
            IsRunning = false;
        }

        public void Stop()
        {
            _stopImport = true;
        }

        public bool IsRunning { get; private set; }

        #endregion
    }
}
