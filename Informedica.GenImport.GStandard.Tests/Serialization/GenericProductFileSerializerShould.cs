using System;
using System.IO;
using System.Text;
using System.Linq;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Serialization
{
    [TestClass]
    public class GenericProductFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_GenericName_Model()
        {
            var expected = new GenericProduct
            {
                GpInSt = "10MG/ML",
                MutKod = MutKod.RecordNotChanged,
                GpKode = 86,
                GpKtVr = 500,
                GpKTwg = 7,
                GpNmNr = 59510,
                GpStNr = 59511,
                GsKode = 86,
                SpKode = 86,
                ThEhHv = 2,
                ThKtVr = 6,
                ThKTwg = 7,
                XpEhHv = 233,
            };
            const string data =
                @"0711000000086000000860065000070070059510005951110MG/ML                  0000000000009200000004101200000000000086058003S01EB01 0022330000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<GenericProduct>();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);

            Assert.AreEqual(expected.GpInSt, model.GpInSt);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.GpKode, model.GpKode);
            Assert.AreEqual(expected.GpKtVr, model.GpKtVr);
            Assert.AreEqual(expected.GpKTwg, model.GpKTwg);
            Assert.AreEqual(expected.GpNmNr, model.GpNmNr);
            Assert.AreEqual(expected.GpStNr, model.GpStNr);
            Assert.AreEqual(expected.GsKode, model.GsKode);
            Assert.AreEqual(expected.SpKode, model.SpKode);
            Assert.AreEqual(expected.ThEhHv, model.ThEhHv);
            Assert.AreEqual(expected.ThKtVr, model.ThKtVr);
            Assert.AreEqual(expected.ThKTwg, model.ThKTwg);
            Assert.AreEqual(expected.XpEhHv, model.XpEhHv);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_5_GenericProduct_Models()
        {
            const int expectedLineCount = 5;
            string data =
                "0711000000086000000860065000070070059510005951110MG/ML                  0000000000009200000004101200000000000086058003S01EB01 0022330000000000000000000000000000" +
                Environment.NewLine +
                "07110000001320000013200628000700900073280028654200MG                    0000000000009200000004101200000000000132058004M01AE01 0022450000000000000000000000000000" +
                Environment.NewLine +
                "0711000000175000001750063000070090025063003295425MG                     0000000000009200000004101200000000000175058004M01AB01 0022450000000000000000000000000000" +
                Environment.NewLine +
                "0711000000280000002800062300070090059521005952212,5/25MG                0000000000009200000004101200000000000280058004N07CA52 0022450000000000000000000000000000" +
                Environment.NewLine +
                "071100000029900000299006230007009005952300329955MG                      0000000000009200000004101200000000000299058004G03DC02 0022450000000000000000000000000000";
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<GenericProduct>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
