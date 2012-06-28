using System;
using System.IO;
using System.Text;
using System.Linq;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.IO
{
    [TestClass]
    public class GeneriekeSamenstellingFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_Naam_Model()
        {
            var expected = new GeneriekeSamenstelling
            {
                MutKod = MutKod.RecordNotChanged,
                GnMomH = 0,
                GnMwHs = StofAanduiding.H,
                GnNkPk = 050172,
                GsKode = 19,
                XnMomE = 0,
                XpEhHv = 245,
            };

            const string data =
                @"07150H0000001905017200000000000000024500000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GeneriekeSamenstellingFileSerializer();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.GnMomH, model.GnMomH);
            Assert.AreEqual(expected.GnMwHs, model.GnMwHs);
            Assert.AreEqual(expected.GnNkPk, model.GnNkPk);
            Assert.AreEqual(expected.XnMomE, model.XnMomE);
            Assert.AreEqual(expected.XpEhHv, model.XpEhHv);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_Naam_Models()
        {
            const int expectedLineCount = 5;
            string data =
                @"07150H0000001905017200000000000000024500000000000000000000000000" +
                Environment.NewLine +
                @"07150H0000003505017200000000000000021500000000000000000000000000" +
                Environment.NewLine +
                @"07150H0000007805017200000000000000023300000000000000000000000000" +
                Environment.NewLine +
                @"07150H0000010800137600000000000000023300000000000000000000000000" +
                Environment.NewLine +
                @"07150H0000032901062600000000000000021500000000000000000000000000" +
                Environment.NewLine;

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GeneriekeSamenstellingFileSerializer();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data =
                @"07150Z0000001905017200000000000000024500000000000000000000000000" +
                Environment.NewLine +
                @"07150H0000003505017200000000000000021500000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GeneriekeSamenstellingFileSerializer();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
