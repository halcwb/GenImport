﻿using System;
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
    public class GStandardArtikelenFileSerializerShould
    {
        [TestMethod]
        public void Parse_All_Lines_To_Model()
        {
            const int expectedLineCount = 5;
            string data =
                @"000401210135400039527000542300001200000010090490000200404900000600 00000000   V 00000 0000020051990000000000021566       0900800000090088070000000000000000000000000009100000007547169000000000000000000000000000000000109200301062012           00000000000000000528                    00000000000000000000002750  00000000000" +
                Environment.NewLine +
                @"000401210294600040983000086000005000000010090490000100404900005000 00000000R  V 00000 0000027111985000010000050411481    03077000000307780700000000000000000000000046011110000000000000000246000002460000000000000000001092003010620120V03AAAO  V00000102917100002460                    00000000000000000000001032  00000000000" +
                Environment.NewLine +
                @"000401210391800092339000102900000600000010090490000600407400000100 00000000R  V 00000 00000280419760000003000199898      2262400000226248070000102197700000000000009511111000000000000000056300000563000000000000000000109200301062012XXXXXXXXXXX00000563000000005630                    00000000000000000000006305  00000000000" +
                Environment.NewLine +
                @"000401210398500202746000103400002000000010090490000500404900000400 00000000A  V 00000 00000111119770000003333161         0155400000060928070000000000000000000000000009100000005141509000000000000000000000000000000000109200301062012           00000000000000000344                    00000000000000000000008186  00000000000" +
                Environment.NewLine +
                @"000401210418300202886000104600020000000010090490000100404900020000U31122012R  V 00000 00000041019720000005333            0844300000084438070000000000000000000000011781111000000000000000002760000027600000000311220110109200301062012XXXXXXXXXXX00000027600000000276                    00000000000000013805001218  00000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            IGStandardArtikelenFileSerializer serializer = new GStandardArtikelenFileSerializer();
            IEnumerable<Artikel> lines = serializer.ReadLines(memoryStream);

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
                @"000401210135400039527000542300001200000010090490000200404900000600 00000000   V 00000 0000020051990000000000021566       0900800000090088070000000000000000000000000009100000007547169000000000000000000000000000000000109200301062012           00000000000000000528                    00000000000000000000002750  00000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            IGStandardArtikelenFileSerializer serializer = new GStandardArtikelenFileSerializer();
            IEnumerable<Artikel> lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
