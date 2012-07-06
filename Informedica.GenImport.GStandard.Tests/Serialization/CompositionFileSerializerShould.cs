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
    public class CompositionFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_Compostion_Model()
        {
            var expected = new Composition
            {
                MutKod = MutKod.RecordNotChanged,
                Code = 13099,
                GnEenh = 229,
                GnGnK = 1198,
                GnHoev = 200,
                GnStam = 41858,
                SrtCde = 1,
                StAdd = true,
                StEenh = 229,
                StHoev = 154.814m,
                ThsrTc = 1850,
                TsGneH = 2,
                TsStEh = 2
            };

            const string data =
                @"0731018500000010001309900119800000020000000020002290418580000001548140002000229J0000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<Composition>();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.Code, model.Code);
            Assert.AreEqual(expected.GnEenh, model.GnEenh);
            Assert.AreEqual(expected.GnGnK, model.GnGnK);
            Assert.AreEqual(expected.GnHoev, model.GnHoev);
            Assert.AreEqual(expected.GnStam, model.GnStam);
            Assert.AreEqual(expected.SrtCde, model.SrtCde);
            Assert.AreEqual(expected.StAdd, model.StAdd);
            Assert.AreEqual(expected.StEenh, model.StEenh);
            Assert.AreEqual(expected.StHoev, model.StHoev);
            Assert.AreEqual(expected.ThsrTc, model.ThsrTc);
            Assert.AreEqual(expected.TsGneH, model.TsGneH);
            Assert.AreEqual(expected.TsStEh, model.TsStEh);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_5_Compostion_Models()
        {
            const int expectedLineCount = 5;
            string data =
                "0731018500000010001309900119800000020000000020002290418580000001548140002000229J0000000000000000" +
                Environment.NewLine +
                "0731018500000010001349800217800000001250000020002290021780000000125000002000229N0000000000000000" +
                Environment.NewLine +
                "0731018500000010001349803408800000002500000020002290383770000000222980002000229N0000000000000000" +
                Environment.NewLine +
                "0731018500000010001352800954700000000500000020002290095470000000050000002000229J0000000000000000" +
                Environment.NewLine +
                "0731018500000010001356005656100000000500000020002290444310000000044580002000229J0000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<Composition>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data =
                "0731018500000010001309900119800000020000000020002290418580000001548140002000229J0000000000000000" +
                Environment.NewLine +
                "0731018500000010001349800217800000001250000020002290021780000000125000002000229T0000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<Composition>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
