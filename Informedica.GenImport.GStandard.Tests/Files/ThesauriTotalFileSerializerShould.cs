using System;
using System.IO;
using System.Linq;
using System.Text;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Files
{
    [TestClass]
    public class ThesauriTotalFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_ThesauriTotal_Model()
        {
            var expected = new ThesauriTotal
            {
                MutKod = MutKod.RecordNotChanged,
                TsItNr = 205,
                TsNr = 1,
                ThItMk = "CM",
                ThNm4 = "CM",
                ThNm15 = "CENTIMETER",
                ThNm25 = "cm",
                ThNm50 = "CENTIMETER",
                ThAKd1 = "",
                ThAKd2 = "",
                ThAKd3 = "",
                ThAKd4 = "",
                ThAKd5 = "",
                ThAKd6 = ""
            };
            const string data = "090200001000205CMCM  CENTIMETER     cm                       CENTIMETER                                              00000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<ThesauriTotal>();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.TsItNr, model.TsItNr);
            Assert.AreEqual(expected.TsNr, model.TsNr);
            Assert.AreEqual(expected.ThItMk, model.ThItMk);
            Assert.AreEqual(expected.ThNm4, model.ThNm4);
            Assert.AreEqual(expected.ThNm15, model.ThNm15);
            Assert.AreEqual(expected.ThNm25, model.ThNm25);
            Assert.AreEqual(expected.ThNm50, model.ThNm50);
            Assert.AreEqual(expected.ThAKd1, model.ThAKd1);
            Assert.AreEqual(expected.ThAKd2, model.ThAKd2);
            Assert.AreEqual(expected.ThAKd3, model.ThAKd3);
            Assert.AreEqual(expected.ThAKd4, model.ThAKd4);
            Assert.AreEqual(expected.ThAKd5, model.ThAKd5);
            Assert.AreEqual(expected.ThAKd6, model.ThAKd6);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_5_ThesauriTotal_Models()
        {
            const int expectedLineCount = 5;
            string data =
                "090200001000000  NVT NIET VAN TOEPASn.v.t.                   NIET VAN TOEPASSING                                     00000000000" +
                Environment.NewLine +
                "090200001000201ABABW ANTITOXINE B.W.ABW                      ANTITOXINE BINDINGS WAARDE   (ZIE RIV VAD.'81, 16)      00000000000" +
                Environment.NewLine +
                "090200001000202AEAE  ANTITOXISCHE EHAE                       ANTITOXISCHE EENHEID         (ZIE RIV VAD.'81, 16)      00000000000" +
                Environment.NewLine +
                "090200001000203BQBECQBECQUEREL      Bq                       BECQUEREL                                               00000000000" +
                Environment.NewLine +
                "090200001000205CMCM  CENTIMETER     cm                       CENTIMETER                                              00000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<ThesauriTotal>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data =
                @"002000000005ABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000" +
                Environment.NewLine +
                @"000401210135400039527000542300001200000010090490000200404900000600 00000000   V 00000 0000020051990000000000021566       0900800000090088070000000000000000000000000009100000007547169000000000000000000000000000000000109200301062012           00000000000000000528                    00000000000000000000002750  00000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<ThesauriTotal>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
