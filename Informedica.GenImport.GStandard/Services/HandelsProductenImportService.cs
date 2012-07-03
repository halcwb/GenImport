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
        public HandelsProductenImportService(string databaseFilePath, IFileSerializerBase<IHandelsProduct> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<HandelsProduct>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO HandelsProduct (HpKode, MutKod, FsNaam, MsNaam, HpNamN, TsEmbM, XsEmbM) VALUES (:HpKode, :MutKod, :FsNaam, :MsNaam, :HpNamN, :TsEmbM, :XsEmbM)");
            ProcessFile(stream, n => query.SetInt32("HpKode", n.HpKode)
                                         .SetByte("MutKod", (byte)n.MutKod)
                                         .SetString("FsNaam", n.FsNaam)
                                         .SetString("MsNaam", n.MsNaam)
                                         .SetInt32("HpNamN", n.HpNamN)
                                         .SetInt16("TsEmbM", n.TsEmbM)
                                         .SetInt32("XsEmbM", n.XsEmbM)
                                         .ExecuteUpdate());
        }

        #endregion
    }
}
