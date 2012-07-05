using System.IO;
using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class GenericNameImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : GenericNameImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializer<IGenericName> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_GenericName_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IGenericName>{
                                                    new GenericName{
                                                                         GnGnK = 1,
                                                                         GnGnAm = "Naam",
                                                                         MutKod = MutKod.RecordNotChanged
                                                                     }
                                                };

            var fileSerializerMock = new Mock<IFileSerializer<IGenericName>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new GenericNameRepository(sessionFactory).Count);
        }
    }
}
