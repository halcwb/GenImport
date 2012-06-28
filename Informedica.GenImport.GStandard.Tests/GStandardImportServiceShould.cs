using System.IO;
using System.Collections.Generic;
using Informedica.GenImport.DataAccess;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NHibernate;
using TypeMock.ArrangeActAssert;

namespace Informedica.GenImport.GStandard.Tests
{
    [TestClass]
    public class GStandardImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class GStandardImportServiceMock : GStandardImportService
        {
            public GStandardImportServiceMock(ISessionFactory sessionFactory, IFileSerializerBase<IArtikel> artikelenFileSerializer, IFileSerializerBase<INaam> namenFileSerializer, string databasePath)
                : base(sessionFactory, artikelenFileSerializer, namenFileSerializer, databasePath)
            {
            }

            public new void ImportNamen(Stream stream)
            {
                base.ImportNamen(stream);
            }
        }
        #endregion

        [Isolated]
        [TestMethod]
        public void Import_The_NamenFile_When_Import_Is_Started()
        {
            //var fake = Isolate.Fake.Instance<GStandardImportService>(Members.CallOriginal);
            //fake.Start();
            //Isolate.NonPublic.WhenCalled(fake, "")..WillReturn();
        }

        [TestMethod]
        public void Import_The_NamenFile_And_Create_Entities_In_The_Database()
        {
            var lines = new List<Naam>{
                                          new Naam{
                                                      NmNr = 1,
                                                      MutKod = MutKod.RecordNotChanged,
                                                      NmEtiket = "NmEtiket",
                                                      NmMemo = "NmMemo",
                                                      NmNaam = "NmNaam",
                                                      NmNm40 = "NmNm40",
                                                  }
                                      };

            var artikelenFileSerializerMock = new Mock<IFileSerializerBase<IArtikel>>(MockBehavior.Loose);
            var namenFileSerializerMock = new Mock<IFileSerializerBase<INaam>>(MockBehavior.Strict);
            namenFileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new GStandardImportServiceMock(sessionFactory,
                                           artikelenFileSerializerMock.Object,
                                           namenFileSerializerMock.Object, "").ImportNamen(new MemoryStream());

            int entityCount = new NaamRepository(sessionFactory).Count;

            Assert.AreEqual(1, entityCount);
        }
    }
}
