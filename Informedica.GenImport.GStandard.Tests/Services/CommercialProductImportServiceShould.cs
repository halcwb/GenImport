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
    public class CommercialProductImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : CommercialProductImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializer<ICommercialProduct> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_CommercialProduct_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<ICommercialProduct>{
                                                     new CommercialProduct{
                                                                           FsNaam = "A",
                                                                           HpKode = 1,
                                                                           HpNamN = 1,
                                                                           MsNaam = "A",
                                                                           MutKod = MutKod.RecordNotChanged,
                                                                           TsEmbM = 1,
                                                                           XsEmbM = 1
                                                                       }
                                                 };

            var fileSerializerMock = new Mock<IFileSerializer<ICommercialProduct>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new CommercialProductRepository(sessionFactory).Count);
        }
    }
}
