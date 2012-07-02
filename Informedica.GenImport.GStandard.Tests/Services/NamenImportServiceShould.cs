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
    public class NamenImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : NamenImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializerBase<INaam> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_Namen_From_A_Stream_And_Create_Entities_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<INaam>{
                                          new Naam{
                                                      NmNr = 1,
                                                      MutKod = MutKod.RecordNotChanged,
                                                      NmEtiket = "NmEtiket",
                                                      NmMemo = "NmMemo",
                                                      NmNaam = "NmNaam",
                                                      NmNm40 = "NmNm40",
                                                  }
                                      };

            var fileSerializerMock = new Mock<IFileSerializerBase<INaam>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new NaamRepository(sessionFactory).Count);
        }
    }
}
