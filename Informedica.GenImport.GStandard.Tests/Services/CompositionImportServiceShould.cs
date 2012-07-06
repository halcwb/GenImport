﻿using System.IO;
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
    public class CompositionImportServiceShould : TestSessionContext
    {
        #region Helpers

        private class ImportServiceMock : CompositionImportService
        {
            public ImportServiceMock(string databasePath, IFileSerializer<IComposition> fileSerializer, ISessionFactory sessionFactory)
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

            var sessionFactory = GetSessionFactory();

            new ImportServiceMock("", fileSerializerMock.Object, sessionFactory).Import(new MemoryStream());

            Assert.AreEqual(expectedCount, new CompositionRepository(sessionFactory).Count);
        }
    }
}