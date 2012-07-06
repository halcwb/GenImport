using System.IO;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.Library.Serialization;
using NHibernate;

namespace Informedica.GenImport.GStandard.Services
{
    public class GenericProductGStandardImportService : GStandardImportServiceBase<IGenericProduct>
    {
        public GenericProductGStandardImportService(string databaseFilePath, IFileSerializer<IGenericProduct> fileSerializer, IRepository<IGenericProduct> repository)
            : base(databaseFilePath, fileSerializer, repository)
        {
        }

        #region Overrides of GStandardImportServiceBase<IGenericProduct>

        public override void Import(Stream stream)
        {
            ProcessFile(stream, n => Repository.Add(n));

            //            var query = CurrentSession.CreateSQLQuery(
            //                @"INSERT INTO GenericProduct (Id, MutKod, GpInSt, GpKtVr, GpKTwg, GpNmNr, GpStNr, GsKode, SpKode, ThEhHv, ThKtVr, ThKTwg, XpEhHv) 
            //                  VALUES (:GpKode, :MutKod, :GpInSt, :GpKtVr, :GpKTwg, :GpNmNr, :GpStNr, :GsKode, :SpKode, :ThEhHv, :ThKtVr, :ThKTwg, :XpEhHv)");
            //            ProcessFile(stream, n => query.SetInt32("GpKode", n.GpKode)
            //                                                         .SetByte("MutKod", (byte)n.MutKod)
            //                                                         .SetString("GpInSt", n.GpInSt)
            //                                                         .SetInt16("GpKtVr", n.GpKtVr)
            //                                                         .SetInt16("GpKTwg", n.GpKTwg)
            //                                                         .SetInt32("GpNmNr", n.GpNmNr)
            //                                                         .SetInt32("GpStNr", n.GpStNr)
            //                                                         .SetInt32("GsKode", n.GsKode)
            //                                                         .SetInt32("SpKode", n.SpKode)
            //                                                         .SetInt16("ThEhHv", n.ThEhHv)
            //                                                         .SetInt16("ThKtVr", n.ThKtVr)
            //                                                         .SetInt16("ThKTwg", n.ThKTwg)
            //                                                         .SetInt16("XpEhHv", n.XpEhHv)
            //                                                         .ExecuteUpdate());
        }

        #endregion
    }
}
