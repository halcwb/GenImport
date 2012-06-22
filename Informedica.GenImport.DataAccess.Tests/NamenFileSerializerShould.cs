using System;
using System.IO;
using System.Text;
using System.Linq;
using Informedica.GenImport.DataAccess.GStandard;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class NamenFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_Naam_Model()
        {
            var expected = new Naam
            {
                MutKod = MutKod.RecordNotChanged,
                NmNr = 2,
                NmMemo = "ABBOI2",
                NmEtiket = "ABBOKINASE 250.000IE INJPDR",
                NmNm40 = "ABBOKINASE",
                NmNaam = "ABBOKINASE INJECTIEPOEDER FLACON 250.000IE"
            };

            const string data =
                @"002000000002ABBOI2ABBOKINASE 250.000IE INJPDRABBOKINASE                              ABBOKINASE INJECTIEPOEDER FLACON 250.000IE        0000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new NamenFileSerializer();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.NmEtiket, model.NmEtiket);
            Assert.AreEqual(expected.NmMemo, model.NmMemo);
            Assert.AreEqual(expected.NmNaam, model.NmNaam);
            Assert.AreEqual(expected.NmNm40, model.NmNm40);
            Assert.AreEqual(expected.NmNr, model.NmNr);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_Naam_Models()
        {
            const int expectedLineCount = 5;
            string data =
                @"002000000001AAMBZ AAMBEIENZETPIL VOGEL       AAMBEIENZETPIL VOGEL                    AAMBEIENZETPIL VOGEL                              0000000000000000000000000" +
                Environment.NewLine +
                @"002000000002ABBOI2ABBOKINASE 250.000IE INJPDRABBOKINASE                              ABBOKINASE INJECTIEPOEDER FLACON 250.000IE        0000000000000000000000000" +
                Environment.NewLine +
                @"002000000003ABBOT2ABBOTICINE 200MG KAUWTABLETABBOTICINE                              ABBOTICINE KAUWTABLET 200MG                       0000000000000000000000000" +
                Environment.NewLine +
                @"002000000005ABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000" +
                Environment.NewLine +
                @"002000000007ABC V6ABC VERB NR7  6,85MX3,75CM ABC VERBAND                             ABC VERBAND NR7  6,85MX3,75CM                     0000000000000000000000000" +
                Environment.NewLine;

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new NamenFileSerializer();
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
                @"00200000000ZABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new NamenFileSerializer();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
