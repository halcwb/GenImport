using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class GenericCompositionImportService : GStandardImportServiceBase<IGenericComposition>
    {
        public GenericCompositionImportService(string databaseFilePath, IFileSerializerBase<IGenericComposition> fileSerializer, ISessionFactory sessionFactory)
            : base(databaseFilePath, fileSerializer, sessionFactory)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGeneriekeSamenstelling>

        public override void Import(Stream stream)
        {
            var query =
                CurrentSession.CreateSQLQuery(
                    "INSERT INTO GenericComposition (Id, MutKod, GnMwHs, GnNkPk, GnMomH, XnMomE, XpEhHv) VALUES (:GsKode, :MutKod, :GnMwHs, :GnNkPk, :GnMomH, :XnMomE, :XpEhHv)");
            ProcessFile(stream, n => query.SetInt32("GsKode", n.GsKode)
                                                         .SetByte("MutKod", (byte)n.MutKod)
                                                         .SetByte("GnMwHs", (byte)n.GnMwHs)
                                                         .SetInt32("GnNkPk", n.GnNkPk)
                                                         .SetDecimal("GnMomH", n.GnMomH)
                                                         .SetInt16("XnMomE", n.XnMomE)
                                                         .SetInt16("XpEhHv", n.XpEhHv)
                                                         .ExecuteUpdate());
        }

        #endregion
    }
}
