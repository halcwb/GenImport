using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class ThesauriTotalImportService : GStandardImportServiceBase<IThesauriTotal>
    {
        public ThesauriTotalImportService(string databaseFilePath, IFileSerializer<IThesauriTotal> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IThesauriTotal>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    @"INSERT INTO ThesauriTotal (MutKod, ThAKd1, ThAKd2, ThAKd3, ThAKd4, ThAKd5, ThAKd6, ThItMk, ThNm15, ThNm25, ThNm4, ThNm50, TsItNr, TsNr) 
                    VALUES (:MutKod, :ThAKd1, :ThAKd2, :ThAKd3, :ThAKd4, :ThAKd5, :ThAKd6, :ThItMk, :ThNm15, :ThNm25, :ThNm4, :ThNm50, :TsItNr, :TsNr)");
            ProcessFile(stream, n => query.SetByte("MutKod", (byte)n.MutKod)
                                         .SetCharacter("ThAKd1", n.ThAKd1)
                                         .SetCharacter("ThAKd2", n.ThAKd2)
                                         .SetCharacter("ThAKd3", n.ThAKd3)
                                         .SetCharacter("ThAKd4", n.ThAKd4)
                                         .SetCharacter("ThAKd5", n.ThAKd5)
                                         .SetCharacter("ThAKd6", n.ThAKd6)
                                         .SetString("ThItMk", n.ThItMk)
                                         .SetString("ThNm15", n.ThNm15)
                                         .SetString("ThNm25", n.ThNm25)
                                         .SetString("ThNm4", n.ThNm4)
                                         .SetString("ThNm50", n.ThNm50)
                                         .SetInt32("TsItNr", n.TsItNr)
                                         .SetInt16("TsNr", n.TsNr)
                                         .ExecuteUpdate());
        }

        #endregion
    }
}
