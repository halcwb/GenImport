using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class PrescriptionProductImportService : GStandardImportServiceBase<IPrescriptionProduct>
    {
        
        public PrescriptionProductImportService(string databaseFilePath, IFileSerializer<IPrescriptionProduct> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IPrescriptieProduct>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO PrescriptionProduct (Id, MutKod, PrNmNr) VALUES (:PrKode, :MutKod, :PrNmNr)");
            ProcessFile(stream, n => query.SetInt32("PrKode", n.PrKode)
                                         .SetByte("MutKod", (byte)n.MutKod)
                                         .SetInt32("PrNmNr", n.PrNmNr)
                                         .ExecuteUpdate());
        }

        #endregion
    }
}
