using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class CommercialProductImportService : GStandardImportServiceBase<ICommercialProduct>
    {
        public CommercialProductImportService(string databaseFilePath, IFileSerializer<ICommercialProduct> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<HandelsProduct>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO CommercialProduct (Id, MutKod, FsNaam, MsNaam, HpNamN, TsEmbM, XsEmbM) VALUES (:HpKode, :MutKod, :FsNaam, :MsNaam, :HpNamN, :TsEmbM, :XsEmbM)");
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
