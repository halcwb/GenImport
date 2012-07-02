using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class PrescriptieProductenImportService : GStandardImportServiceBase<IPrescriptieProduct>
    {
        public PrescriptieProductenImportService(string databaseFilePath, IFileSerializerBase<IPrescriptieProduct> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IPrescriptieProduct>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO PrescriptieProduct (PrKode, MutKod, PrKBst, PrNmNr) VALUES (:PrKode, :MutKod, :PrKBst, :PrNmNr)");
            ProcessFile(stream, n => query.SetInt32("PrKode", n.PrKode)
                                         .SetByte("MutKod", (byte)n.MutKod)
                                         .SetString("PrKBst", n.PrKBst)
                                         .SetInt32("PrNmNr", n.PrNmNr)
                                         .ExecuteUpdate());
        }

        #endregion
    }
}
