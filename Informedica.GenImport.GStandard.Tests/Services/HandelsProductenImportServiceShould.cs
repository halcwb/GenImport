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
    public class HandelsProductenImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : HandelsProductenImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializerBase<IHandelsProduct> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_HandelsProducten_From_A_Stream_And_Create_Entities_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IHandelsProduct>{
                                                     new HandelsProduct{
                                                                           FsNaam = "A",
                                                                           HpKode = 1,
                                                                           HpNamN = 1,
                                                                           MsNaam = "A",
                                                                           MutKod = MutKod.RecordNotChanged,
                                                                           TsEmbM = 1,
                                                                           XsEmbM = 1
                                                                       }
                                                 };

            var fileSerializerMock = new Mock<IFileSerializerBase<IHandelsProduct>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new HandelsProductRepository(sessionFactory).Count);
        }
    }
}
