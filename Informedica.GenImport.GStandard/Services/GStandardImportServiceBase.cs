using System;
using System.IO;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using Informedica.GenImport.Library.Services;

namespace Informedica.GenImport.GStandard.Services
{
    public abstract class GStandardImportServiceBase<TModel> : IImportService<TModel>
        where TModel : class, IGStandardModel<TModel>
    {
        protected readonly string DatabaseFilePath;
        private readonly IFileSerializer<TModel> _fileSerializer;
        protected readonly IRepository<TModel> Repository;

        protected bool StopImport { get; private set; }

        protected GStandardImportServiceBase(string databaseFilePath, IFileSerializer<TModel> fileSerializer, IRepository<TModel> repository)
        {
            DatabaseFilePath = databaseFilePath;
            _fileSerializer = fileSerializer;
            Repository = repository;
        }

        private void OpenFileAndProcess(Action<Stream> streamAction)
        {
            using (var stream = File.OpenRead(DatabaseFilePath))
            {
                streamAction(stream);
            }
        }

        protected virtual void ProcessFile(Stream stream, Action<TModel> processLineAction)
        {
            var lines = _fileSerializer.ReadLines(stream);
            foreach (var model in lines)
            {
                processLineAction(model);
                if (StopImport) break;
            }
        }

        protected abstract void Import(Stream stream);

        #region Implementation of IImportService
        
        public void Start()
        {
            OpenFileAndProcess(Import);
        }
        
        public void Stop()
        {
            StopImport = true;
        }

        #endregion
    }
}
