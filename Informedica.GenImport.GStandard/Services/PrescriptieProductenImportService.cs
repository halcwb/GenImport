using System;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class PrescriptieProductenImportService : GStandardImportServiceBase<IPrescriptieProduct>
    {
        public PrescriptieProductenImportService(string databaseFilePath, IFileSerializerBase<IPrescriptieProduct> fileSerializer, ISessionFactory sessionFactory) : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IPrescriptieProduct>

        public override void Import(Stream stream)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
