using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Mappings;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class ThesauriTotalImportService : GStandardImportServiceBase<IThesauriTotal>
    {
        public ThesauriTotalImportService(string databaseFilePath, IFileSerializerBase<IThesauriTotal> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IThesauriTotal>

        public override void Import(Stream stream)
        {
           throw new NotImplementedException();
        }

        #endregion
    }
}
