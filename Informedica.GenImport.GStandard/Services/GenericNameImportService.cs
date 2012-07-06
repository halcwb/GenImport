using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;

namespace Informedica.GenImport.GStandard.Services
{
    public class GenericNameGStandardImportService : GStandardImportServiceBase<IGenericName>
    {
        public GenericNameGStandardImportService(string databaseFilePath, IFileSerializer<IGenericName> fileSerializer, IRepository<IGenericName> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGenericName>

        public override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));

            //var query = CurrentSession.CreateSQLQuery(
            //    "INSERT INTO GenericName (Id, MutKod, GnGnAm) VALUES (:GnGnK, :MutKod, :GnGnAm)");
            //ProcessFile(stream, n => query.SetInt32("GnGnK", n.GnGnK)
            //                                             .SetByte("MutKod", (byte)n.MutKod)
            //                                             .SetString("GnGnAm", n.GnGnAm)
            //                                             .ExecuteUpdate());
        }

        #endregion
    }
}
