using System;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class GenericProductImportService : GStandardImportServiceBase<IGenericProduct>
    {
        public GenericProductImportService(string databaseFilePath, IFileSerializerBase<IGenericProduct> fileSerializer, ISessionFactory sessionFactory) : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGeneriekProduct>

        public override void Import(Stream stream)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
