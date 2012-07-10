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
    public class GenericProductImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class GStandardImportServiceMock : ImportService<IGenericProduct>
        {
            public GStandardImportServiceMock(string databaseFilePath, IFileSerializer<IGenericProduct> fileSerializer, IRepository<IGenericProduct> repository)
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
        public void Import_The_GenericProduct_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IGenericProduct>{
                                                     new GenericProduct{
                                                                           GpInSt = "A",
                                                                           GpKode = 1,
                                                                           GpKtVr = 1,
                                                                           GpKTwg = 1,
                                                                           GpNmNr = 1,
                                                                           GpStNr = 1,
                                                                           GsKode = 1,
                                                                           MutKod = MutKod.RecordNotChanged,
                                                                           SpKode = 1,
                                                                           ThEhHv = 1,
                                                                           ThKtVr = 1,
                                                                           ThKTwg = 1,
                                                                           XpEhHv = 1
                                                                       }
                                                 };

            var fileSerializerMock = new Mock<IFileSerializer<IGenericProduct>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var repository = new NHibernateRepository<IGenericProduct>(GetSessionFactory(), null);

            new GStandardImportServiceMock("", fileSerializerMock.Object, repository).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, repository.Count);
        }
    }
}
