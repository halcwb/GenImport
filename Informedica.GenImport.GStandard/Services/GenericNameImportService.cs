using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class GenericNameImportService : GStandardImportServiceBase<IGenericName>
    {
        public GenericNameImportService(string databaseFileFilePath, IFileSerializer<IGenericName> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFileFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGeneriekeNaam>

        public override void Import(Stream stream)
        {
            var query = CurrentSession.CreateSQLQuery(
                "INSERT INTO GenericName (Id, MutKod, GnGnAm) VALUES (:GnGnK, :MutKod, :GnGnAm)");
            ProcessFile(stream, n => query.SetInt32("GnGnK", n.GnGnK)
                                                         .SetByte("MutKod", (byte)n.MutKod)
                                                         .SetString("GnGnAm", n.GnGnAm)
                                                         .ExecuteUpdate());
        }

        #endregion
    }
}
