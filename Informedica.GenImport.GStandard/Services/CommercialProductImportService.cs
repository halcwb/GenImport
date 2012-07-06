using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class CommercialProductGStandardImportService : GStandardImportServiceBase<ICommercialProduct>
    {
        public CommercialProductGStandardImportService(string databaseFilePath, IFileSerializer<ICommercialProduct> fileSerializer, IRepository<ICommercialProduct> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        #region Overrides of GStandardImportServiceBase<ICommercialProduct>

        public override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));

            //var query =
            //    CurrentSession.CreateSQLQuery(
            //        "INSERT INTO CommercialProduct (Id, MutKod, FsNaam, MsNaam, HpNamN, TsEmbM, XsEmbM) VALUES (:HpKode, :MutKod, :FsNaam, :MsNaam, :HpNamN, :TsEmbM, :XsEmbM)");
            //ProcessFile(stream, n => query.SetInt32("HpKode", n.HpKode)
            //                             .SetByte("MutKod", (byte)n.MutKod)
            //                             .SetString("FsNaam", n.FsNaam)
            //                             .SetString("MsNaam", n.MsNaam)
            //                             .SetInt32("HpNamN", n.HpNamN)
            //                             .SetInt16("TsEmbM", n.TsEmbM)
            //                             .SetInt32("XsEmbM", n.XsEmbM)
            //                             .ExecuteUpdate());
        }

        #endregion
    }
}
