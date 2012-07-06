using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;

namespace Informedica.GenImport.GStandard.Services
{
    public class NameGStandardImportService : GStandardImportServiceBase<IName>
    {
        public NameGStandardImportService(string databaseFilePath, IFileSerializer<IName> fileSerializer, IRepository<IName> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        #region Overrides of GStandardImportServiceBase<IName>

        public override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));

            //var query =
            //    CurrentSession.CreateSQLQuery(
            //        "INSERT INTO Name (Id, MutKod, NmMemo, NmEtiket, NmNm40, NmNaam) VALUES (:NmNr, :MutKod, :NmMemo, :NmEtiket, :NmNm40, :NmNaam)");
            //ProcessFile(stream, n => query.SetInt32("NmNr", n.NmNr)
            //                                                   .SetByte("MutKod", (byte)n.MutKod)
            //                                                   .SetString("NmMemo", n.NmMemo)
            //                                                   .SetString("NmEtiket", n.NmEtiket)
            //                                                   .SetString("NmNm40", n.NmNm40)
            //                                                   .SetString("NmNaam", n.NmNaam)
            //                                                   .ExecuteUpdate());
        }

        #endregion
    }
}
