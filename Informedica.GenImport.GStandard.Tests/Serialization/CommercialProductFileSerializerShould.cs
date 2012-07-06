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
    public class CommercialProductFileSerializerShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_Given_Line_To_A_CommercialProduct_Model()
        {
            var expected = new CommercialProduct
            {
                FsNaam = "",
                HpKode = 13099,
                HpNamN = 12591,
                MsNaam = "PLAQUENIL",
                MutKod = MutKod.RecordNotChanged,
                TsEmbM = 74,
                XsEmbM = 0
            };

            const string data =
                @"003100001309900000051000000000012591PLAQUENIL                                                                                           002000001200000000000000300000000010000000            0068000000083600000000000000000001091   N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000215200000001525000000153000000000000000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<CommercialProduct>();
            var lines = serializer.ReadLines(memoryStream);

            var model = lines.FirstOrDefault();
            Assert.IsNotNull(model);
            Assert.AreEqual(expected.MutKod, model.MutKod);
            Assert.AreEqual(expected.FsNaam, model.FsNaam);
            Assert.AreEqual(expected.HpKode, model.HpKode);
            Assert.AreEqual(expected.HpNamN, model.HpNamN);
            Assert.AreEqual(expected.MsNaam, model.MsNaam);
            Assert.AreEqual(expected.TsEmbM, model.TsEmbM);
            Assert.AreEqual(expected.XsEmbM, model.XsEmbM);
        }

        [TestMethod]
        public void Be_Able_To_Parse_5_Lines_To_5_CommercialProduct_Models()
        {
            const int expectedLineCount = 5;
            string data =
                "003100001309900000051000000000012591PLAQUENIL                                                                                           002000001200000000000000300000000010000000            0068000000083600000000000000000001091   N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000215200000001525000000153000000000000000000000000000000000000000" +
                Environment.NewLine +
                "003100001349800000086000000000012823PRIMATOUR                                                                                           002000001200000000000000139000000010000000            0068000000009408890000000000000001492 # N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000115200000001525000000153000000000000000000000000000000000000000" +
                Environment.NewLine +
                "003100001352800000094000000000012828PRIMOLUT-N                                                                                          002000001200000000000001000000000010000000            0068000000039900000000000000000001511P  N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000215200000001525000000153000000000000000000000000000000000000000" +
                Environment.NewLine +
                "003100001356000000108000000000012833PRIMPERAN                                                                                           002000001200000000000000333000000010000000            0068000000102210410000000000000001551 # S0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200023300000000000000151000000215200000001525000000153000000000000000000000000000000000000000" +
                Environment.NewLine +
                "003100001384600000124000000000012885PROGYNOVA                                                                                           002000001200000000000000500000000010000000            0068000000039800000000000000000001831P  N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000215200000001525000000153000000000000000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<CommercialProduct>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data =
                "003100001309900000051000000000012591PLAQUENIL                                                                                           002000001200000000000000300000000010000000            0068000000083600000000000000000001091   N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000215200000001525000000153000000000000000000000000000000000000000" +
                Environment.NewLine +
                "0031000013498000000860000000000A2823PRIMATOUR                                                                                           002000001200000000000000139000000010000000            0068000000009408890000000000000001492 # N0002000245000000000000X00780000000007400000000750000000076000000N00790000000080000000008100000000820000000006000000L000 0000000120000000000000 0002000245000200024500000000000000151000000115200000001525000000153000000000000000000000000000000000000000";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            var memoryStream = new MemoryStream(dataBytes);
            var serializer = new GStandardFileSerializer<CommercialProduct>();
            var lines = serializer.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
