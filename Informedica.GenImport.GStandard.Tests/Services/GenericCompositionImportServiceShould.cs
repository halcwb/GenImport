using System.Collections.Generic;
using System.IO;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class GenericCompositionImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class GStandardImportServiceMock : GenericCompositionGStandardImportService
        {
            public GStandardImportServiceMock(string databaseFilePath, IFileSerializer<IGenericComposition> fileSerializer, IRepository<IGenericComposition> repository)
                : base(databaseFilePath, fileSerializer, repository)
            {
            }

            public new void Import(Stream stream)
            {
                base.Import(stream);
            }
        }

        #endregion

        [TestMethod]
        public void Import_The_GenericComposition_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IGenericComposition>{
                                                             new GenericComposition{
                                                                                           GnMomH = 1.23m,
                                                                                           GnMwHs = SubstanceIndication.H,
                                                                                           GnNkPk = 1,
                                                                                           GsKode = 1,
                                                                                           MutKod = MutKod.RecordNotChanged,
                                                                                           XnMomE = 1,
                                                                                           XpEhHv = 1
                                                                                       }
                                                         };

            var fileSerializerMock = new Mock<IFileSerializer<IGenericComposition>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var repository = new NHibernateRepository<IGenericComposition>(GetSessionFactory(), null);

            new GStandardImportServiceMock("", fileSerializerMock.Object, repository).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, repository.Count);
        }
    }
}
