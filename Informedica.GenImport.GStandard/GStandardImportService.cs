using System;
using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Services;
using NHibernate;

namespace Informedica.GenImport.GStandard
{
    public class GStandardImportService : IImportService
    {
        private readonly ISessionFactory _sessionFactory;
        private readonly IFileSerializerBase<IArtikel> _artikelenFileSerializer;
        private readonly IFileSerializerBase<INaam> _namenFileSerializer;
        private readonly string _databasePath;

        public GStandardImportService(ISessionFactory sessionFactory, IFileSerializerBase<IArtikel> artikelenFileSerializer, IFileSerializerBase<INaam> namenFileSerializer,
            string databasePath)
        {
            _sessionFactory = sessionFactory;
            _artikelenFileSerializer = artikelenFileSerializer;
            _namenFileSerializer = namenFileSerializer;
            _databasePath = databasePath;
        }

        public void Start()
        {
            if (_sessionFactory.IsClosed)
            {
                _sessionFactory.OpenSession();
            }

            OpenFileAndProcess(@"c:\tmp\", ImportNamen);
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        protected virtual void ImportNamen(Stream stream)
        {
            var session = _sessionFactory.GetCurrentSession();
            var query =
                session.CreateSQLQuery(
                    "INSERT INTO Naam (Id, MutKod, NmMemo, NmEtiket, NmNm40, NmNaam) VALUES (:Id, :MutKod, :NmMemo, :NmEtiket, :NmNm40, :NmNaam)");

            ProcessFile(stream, _namenFileSerializer, n => query.SetInt32("Id", n.NmNr)
                                                               .SetByte("MutKod", (byte)n.MutKod)
                                                               .SetString("NmMemo", n.NmMemo)
                                                               .SetString("NmEtiket", n.NmEtiket)
                                                               .SetString("NmNm40", n.NmNm40)
                                                               .SetString("NmNaam", n.NmNaam)
                                                               .ExecuteUpdate());
        }

        private static void OpenFileAndProcess(string filePath, Action<Stream> streamAction)
        {
            using(var stream = File.OpenRead(filePath))
            {
                streamAction(stream);
            }
        }

        private static void ProcessFile<TModel>(Stream stream, IFileSerializerBase<TModel> fileSerializer, Action<TModel> processLineAction)
            where TModel : class, IModel
        {
            var lines = fileSerializer.ReadLines(stream);
            foreach (var model in lines)
            {
                processLineAction(model);
            }
        }
    }
}
