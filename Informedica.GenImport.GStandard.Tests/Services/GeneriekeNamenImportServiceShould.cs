using System.IO;
using System.Collections.Generic;
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
    public class GeneriekeNamenImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : GeneriekeNamenImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializerBase<IGeneriekeNaam> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_GeneriekeNamen_From_A_Stream_And_Create_Entities_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IGeneriekeNaam>{
                                                    new GeneriekeNaam{
                                                                         GnGnK = 1,
                                                                         GnGnAm = "Naam",
                                                                         MutKod = MutKod.RecordNotChanged
                                                                     }
                                                };

            var fileSerializerMock = new Mock<IFileSerializerBase<IGeneriekeNaam>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new GeneriekeNaamRepository(sessionFactory).Count);
        }
    }
}
