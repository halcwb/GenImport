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
    public class PrescriptieProductenImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : PrescriptieProductenImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializerBase<IPrescriptieProduct> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_PrescriptieProducten_From_A_Stream_And_Create_Entities_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IPrescriptieProduct>{
                                                         new PrescriptieProduct{
                                                                                   MutKod = MutKod.RecordNotChanged,
                                                                                   PrKode = 1,
                                                                                   PrKBst = "",
                                                                                   PrNmNr = 1
                                                                               }
                                                     };

            var fileSerializerMock = new Mock<IFileSerializerBase<IPrescriptieProduct>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new PrescriptieProductRepository(sessionFactory).Count);
        }
    }
}
