using System;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public abstract class GStandardImportServiceBase<TModel> : IGStandardImportService<TModel>
        where TModel : class, IModel
    {
        protected readonly string DatabaseFilePath;
        protected readonly IFileSerializerBase<TModel> FileSerializer;
        protected bool StopImport { get; private set; }
        private readonly ISessionFactory _sessionFactory;

        protected ISession CurrentSession
        {
            get { return _sessionFactory.GetCurrentSession(); }
        }

        protected GStandardImportServiceBase(string databaseFilePath, IFileSerializerBase<TModel> fileSerializer, ISessionFactory sessionFactory)
        {
            DatabaseFilePath = databaseFilePath;
            FileSerializer = fileSerializer;
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

        protected virtual void ProcessFile(Stream stream, IFileSerializerBase<TModel> fileSerializer, Action<TModel> processLineAction)
        {
            var lines = fileSerializer.ReadLines(stream);
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
