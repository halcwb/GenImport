using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;

namespace Informedica.GenImport.GStandard.Services
{
    public class PrescriptionProductGStandardImportService : GStandardImportServiceBase<IPrescriptionProduct>
    {
        public PrescriptionProductGStandardImportService(string databaseFilePath, IFileSerializer<IPrescriptionProduct> fileSerializer, IRepository<IPrescriptionProduct> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        #region Overrides of GStandardImportServiceBase<IPrescriptieProduct>

        public override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));

            //var query =
            //    CurrentSession.CreateSQLQuery(
            //        "INSERT INTO PrescriptionProduct (Id, MutKod, PrNmNr) VALUES (:PrKode, :MutKod, :PrNmNr)");
            //ProcessFile(stream, n => query.SetInt32("PrKode", n.PrKode)
            //                             .SetByte("MutKod", (byte)n.MutKod)
            //                             .SetInt32("PrNmNr", n.PrNmNr)
            //                             .ExecuteUpdate());
        }

        #endregion
    }
}
