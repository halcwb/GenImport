using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class GeneriekeNamenImportService : GStandardImportServiceBase<IGeneriekeNaam>
    {
        public GeneriekeNamenImportService(string databaseFileFilePath, IFileSerializerBase<IGeneriekeNaam> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFileFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGeneriekeNaam>

        public override void Import(Stream stream)
        {
            var query = CurrentSession.CreateSQLQuery(
                "INSERT INTO GeneriekeNaam (GnGnK, MutKod, GnGnAm) VALUES (:GnGnK, :MutKod, :GnGnAm)");
            ProcessFile(stream, FileSerializer, n => query.SetInt32("GnGnK", n.GnGnK)
                                                         .SetByte("MutKod", (byte)n.MutKod)
                                                         .SetString("GnGnAm", n.GnGnAm)
                                                         .ExecuteUpdate());
        }

        #endregion
    }
}
