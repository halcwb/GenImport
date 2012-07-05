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
    public class GenericNameFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_GenericName_Model()
        {
            var expected = new GenericName
            {
                GnGnAm = "COMBINATIE PREPARAAT",
                GnGnK =  00019,
                MutKod = MutKod.RecordNotChanged
            };
            const string data =
                @"07500000019COMBINATIE PREPARAAT                              000019000019SW000000000000000                                   000000000000 0000000000000000000XX   000000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<GenericName>();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.GnGnAm, model.GnGnAm);
            Assert.AreEqual(expected.GnGnK, model.GnGnK);
            Assert.AreEqual(expected.MutKod, model.MutKod);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_5_GenericName_Models()
        {
            const int expectedLineCount = 5;
            string data =
                @"07500000019COMBINATIE PREPARAAT                              000019000019SW000000000000000                                   000000000000 0000000000000000000XX   000000000000000000000000000000" +
                Environment.NewLine +
                @"07500000027CYCLOPROPAAN                                      000027000027SW000000000075194C3H6                               000000420800 0000004208000000000XX   000000000000000000000000000000" +
                Environment.NewLine +
                @"07500000035LACHGAS                                           000035000035SW000010010024972N2O                                000000440100 0000004401000000000XX   000000000000000000000000000000" +
                Environment.NewLine +
                @"07500000043CHLOROFORM                                        000043000043SB000000000067663CHCl3                              000001194000 0000011940000147600ML   000000000000000000000000000000" +
                Environment.NewLine +
                @"07500000051ENFLURAAN                                         000051000051SW000000013838169C3H2ClF5O                          000001845000 0000018450000000000XX   000000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<GenericName>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data =
                @"0750000007AETHER                                             000078000078SB000000000060297(C2H5)2O                           000000741200 0000007412000071500MG   000000000000000000000000000000" +
                Environment.NewLine +
                @"07500000051ENFLURAAN                                         000051000051SW000000013838169C3H2ClF5O                          000001845000 0000018450000000000XX   000000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<GenericName>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
