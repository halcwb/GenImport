﻿using System.Collections.Generic;
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
    public class PrescriptionProductImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class GStandardImportServiceMock : FileImportService<IPrescriptionProduct>
        {
            public GStandardImportServiceMock(string databaseFilePath, IFileSerializer<IPrescriptionProduct> fileSerializer, IRepository<IPrescriptionProduct> repository)
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
        public void Import_The_PrescriptionProduct_From_A_Stream_And_Create_An_Entity_In_The_Database()
        {
            const int expectedCount = 1;
            var lines = new List<IPrescriptionProduct>{
                                                         new PrescriptionProduct{
                                                                                   MutKod = MutKod.RecordNotChanged,
                                                                                   PrKode = 1,
                                                                                   PrNmNr = 1
                                                                               }
                                                     };

            var fileSerializerMock = new Mock<IFileSerializer<IPrescriptionProduct>>(MockBehavior.Strict);
            fileSerializerMock.Setup(s => s.ReadLines(It.IsAny<Stream>())).Returns(lines);

            var repository = new NHibernateRepository<IPrescriptionProduct>(GetSessionFactory(), null);

            new GStandardImportServiceMock("", fileSerializerMock.Object, repository).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, repository.Count);
        }
    }
}
