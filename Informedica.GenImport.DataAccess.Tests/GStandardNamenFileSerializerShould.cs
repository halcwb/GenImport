using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.DataAccess.GStandard;
using Informedica.GenImport.DataAccess.GStandard.Interfaces;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class GStandardNamenFileSerializerShould
    {
        [TestMethod]
        public void Parse_All_Lines_To_Model()
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
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            IGStandardNamenFileSerializer serializer = new GStandardNamenFileSerializer();
            IEnumerable<Naam> lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_Line_When_CannotParseLineException_Is_Thrown()
        {
            const int expectedLineCount = 1;
            string data =
                @"002000000005ABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000" +
                Environment.NewLine +
                @"00200000000ZABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            IGStandardNamenFileSerializer serializer = new GStandardNamenFileSerializer();
            IEnumerable<Naam> lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
