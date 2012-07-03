using System;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class HandelsProductenImportService : GStandardImportServiceBase<IHandelsProduct>
    {
        public HandelsProductenImportService(string databaseFilePath, IFileSerializerBase<IHandelsProduct> fileSerializer, ISessionFactory sessionFactory) : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<HandelsProduct>

        public override void Import(Stream stream)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
