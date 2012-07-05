using System.Collections.Generic;
using System.IO;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class GenericCompositionImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : GenericCompositionImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializer<IGenericComposition> fileSerializer, ISessionFactory sessionFactory)
                : base(databasePath, fileSerializer, sessionFactory)
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

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new GenericCompositionRepository(sessionFactory).Count);
        }
    }
}
