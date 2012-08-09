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

namespace Informedica.GenImport.GStandard.Tests.Services.ImportServices
{
    [TestClass]
    public class CompositionImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class GStandardImportServiceMock : FileImportService<IComposition>
        {
            public GStandardImportServiceMock(string databaseFilePath, IFileSerializer<IComposition> fileSerializer, IRepository<IComposition> repository)
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
        public void Import_The_Composition_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IComposition>{
                                                    new Composition{
                                                                         Code = 1,
                                                                         GnEenh = 1,
                                                                         GnGnK = 1,
                                                                         GnHoev = 1.5m,
                                                                         GnStam = 1,
                                                                         MutKod = MutKod.RecordNotChanged,
                                                                         SrtCde = 1,
                                                                         StAdd = true,
                                                                         StEenh = 1,
                                                                         StHoev = 1.5m,
                                                                         ThsrTc = 1,
                                                                         TsGneH = 1,
                                                                         TsStEh = 1
                                                                     }
                                                };

            var fileSerializerMock = new Mock<IFileSerializer<IComposition>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var repository = new NHibernateRepository<IComposition>(GetSessionFactory(), null);

            new GStandardImportServiceMock("", fileSerializerMock.Object, repository).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, repository.Count);
        }
    }
}
