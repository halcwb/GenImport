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
using NHibernate;

namespace Informedica.GenImport.GStandard.Tests.Services
{
    [TestClass]
    public class ThesauriTotalImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : ThesauriTotalImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializer<IThesauriTotal> fileSerializer, ISessionFactory sessionFactory)
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
        public void Import_The_ThesauriTotal_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IThesauriTotal>{
                                                    new ThesauriTotal{
                                                                         ThAKd1 = 'A',
                                                                         ThAKd2 = 'B',
                                                                         ThAKd3 = 'C',
                                                                         ThAKd4 = 'D',
                                                                         ThAKd5 = 'E',
                                                                         ThAKd6 = 'F',
                                                                         ThItMk = "ThItMk",
                                                                         ThNm15 = "ThNm15",
                                                                         ThNm25 = "ThNm25",
                                                                         ThNm4 = "ThNm4",
                                                                         ThNm50 = "ThNm50",
                                                                         MutKod = MutKod.RecordNotChanged,
                                                                         TsItNr = 1,
                                                                         TsNr = 1
                                                                     }
                                                };

            var fileSerializerMock = new Mock<IFileSerializer<IThesauriTotal>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new ThesauriTotalRepository(sessionFactory).Count);
        }
    }
}
