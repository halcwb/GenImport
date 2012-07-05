using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class NameImportService : GStandardImportServiceBase<IName>
    {
        public NameImportService(string databasePath, IFileSerializer<IName> fileSerializer, ISessionFactory sessionFactory)
            : base(databasePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<INaam>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO Name (Id, MutKod, NmMemo, NmEtiket, NmNm40, NmNaam) VALUES (:NmNr, :MutKod, :NmMemo, :NmEtiket, :NmNm40, :NmNaam)");
            ProcessFile(stream, n => query.SetInt32("NmNr", n.NmNr)
                                                               .SetByte("MutKod", (byte)n.MutKod)
                                                               .SetString("NmMemo", n.NmMemo)
                                                               .SetString("NmEtiket", n.NmEtiket)
                                                               .SetString("NmNm40", n.NmNm40)
                                                               .SetString("NmNaam", n.NmNaam)
                                                               .ExecuteUpdate());
        }

        #endregion
    }
}
