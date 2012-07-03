using System;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class SamenstellingenImportService : GStandardImportServiceBase<ISamenstelling>
    {
        public SamenstellingenImportService(string databaseFilePath, IFileSerializerBase<ISamenstelling> fileSerializer, ISessionFactory sessionFactory) : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        public override void Import(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
