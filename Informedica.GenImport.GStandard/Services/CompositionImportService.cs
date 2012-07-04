using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class CompositionImportService : GStandardImportServiceBase<IComposition>
    {
        public CompositionImportService(string databaseFilePath, IFileSerializerBase<IComposition> fileSerializer, ISessionFactory sessionFactory) : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO Composition (MutKod, ThsrTc, Code, SrtCde, GnGnK, GnHoev, TsGneH, GnEenh, GnStam, StHoev, TsStEh, StEenh, StAdd) VALUES (:MutKod, :ThsrTc, :Code, :SrtCde, :GnGnK, :GnHoev, :TsGneH, :GnEenh, :GnStam, :StHoev, :TsStEh, :StEenh, :StAdd)");
            ProcessFile(stream, n => query.SetByte("MutKod", (byte)n.MutKod)
                                         .SetInt16("ThsrTc", n.ThsrTc)
                                         .SetInt32("Code", n.Code)
                                         .SetInt32("SrtCde", n.SrtCde)
                                         .SetInt32("GnGnK", n.GnGnK)
                                         .SetDecimal("GnHoev", n.GnHoev)
                                         .SetInt16("TsGneH", n.TsGneH)
                                         .SetInt32("GnEenh", n.GnEenh)
                                         .SetInt32("GnStam", n.GnStam)
                                         .SetDecimal("StHoev", n.StHoev)
                                         .SetInt16("TsStEh", n.TsStEh)
                                         .SetInt32("StEenh", n.StEenh)
                                         .SetBoolean("StAdd", n.StAdd)
                                         .ExecuteUpdate());
        }
    }
}
