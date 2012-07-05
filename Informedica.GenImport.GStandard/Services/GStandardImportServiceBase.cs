using System;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Services;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public abstract class GStandardImportServiceBase<TModel> : IImportService<TModel>
        where TModel : class, IModel
    {
        protected readonly string DatabaseFilePath;
        private readonly IFileSerializer<TModel> _fileSerializer;
        private readonly ISessionFactory _sessionFactory;

        protected ISession CurrentSession
        {
            get { return _sessionFactory.GetCurrentSession(); }
        }

        protected bool StopImport { get; private set; }

        //TODO use Repository<TEnt, TId> instead of ISessionFactory
        protected GStandardImportServiceBase(string databaseFilePath, IFileSerializer<TModel> fileSerializer, ISessionFactory sessionFactory)
        {
            DatabaseFilePath = databaseFilePath;
            _fileSerializer = fileSerializer;
            _sessionFactory = sessionFactory;
        }

        private void OpenFileAndProcess(string fileName, Action<Stream> streamAction)
        {
            string filePath = Path.Combine(DatabaseFilePath, fileName);
            using (var stream = File.OpenRead(filePath))
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

        public abstract void Import(Stream stream);

        #region Implementation of IImportService
        
        public void Start()
        {
            OpenFileAndProcess(DatabaseFilePath, Import);
        }
        
        public void Stop()
        {
            StopImport = true;
        }

        #endregion
    }
}
