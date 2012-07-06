using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class GenericCompositionGStandardImportService : GStandardImportServiceBase<IGenericComposition>
    {
        public GenericCompositionGStandardImportService(string databaseFilePath, IFileSerializer<IGenericComposition> fileSerializer, IRepository<IGenericComposition> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGeneriekeSamenstelling>

        public override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));

            //var query =
            //    CurrentSession.CreateSQLQuery(
            //        "INSERT INTO GenericComposition (Id, MutKod, GnMwHs, GnNkPk, GnMomH, XnMomE, XpEhHv) VALUES (:GsKode, :MutKod, :GnMwHs, :GnNkPk, :GnMomH, :XnMomE, :XpEhHv)");
            //ProcessFile(stream, n => query.SetInt32("GsKode", n.GsKode)
            //                                             .SetByte("MutKod", (byte)n.MutKod)
            //                                             .SetByte("GnMwHs", (byte)n.GnMwHs)
            //                                             .SetInt32("GnNkPk", n.GnNkPk)
            //                                             .SetDecimal("GnMomH", n.GnMomH)
            //                                             .SetInt16("XnMomE", n.XnMomE)
            //                                             .SetInt16("XpEhHv", n.XpEhHv)
            //                                             .ExecuteUpdate());
        }

        #endregion
    }
}
