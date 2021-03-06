﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Serialization
{
    [TestClass]
    public class RelationBetweenNameFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_RelationBetweenName_Model()
        {
            var expected = new RelationBetweenName
            {
                MutKod = MutKod.RecordNotChanged,
                NmRNr = 001,
                NmNrIn = 0000127,
                NmNrUit = 0000123
            };
            const string data = "00250001000012700001230000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<RelationBetweenName>();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.NmNrIn, model.NmNrIn);
            Assert.AreEqual(expected.NmNrUit, model.NmNrUit);
            Assert.AreEqual(expected.NmRNr, model.NmRNr);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_5_RelationBetweenName_Models()
        {
            const int expectedLineCount = 5;
            string data =
                "00250001000012700001230000000000" + Environment.NewLine +
                "00250001000012700001250000000000" + Environment.NewLine +
                "00250001000012700366920000000000" + Environment.NewLine +
                "00250001000012700558020000000000" + Environment.NewLine +
                "00250001000012700564910000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<RelationBetweenName>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data =
                "0025000R000012700001230000000000" + Environment.NewLine +
                "00250001000012700001250000000000" + Environment.NewLine;

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<RelationBetweenName>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
