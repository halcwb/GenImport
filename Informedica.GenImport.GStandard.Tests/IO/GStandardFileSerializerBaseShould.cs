using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Files.Serialization;
using Informedica.GenImport.Library.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.IO
{
    [TestClass]
    public class GStandardFileSerializerBaseShould
    {
        #region Helpers
        private enum EnumMock
        {
            A = 1
        }

        private class GStandardModelMock : IGStandardModel
        {
            [FileLinePosition(1, 1)]
            public int Id { get; set; }

            [FileLinePosition(2, 2)]
            public EnumMock Enum { get; set; }

            [FileLinePosition(3, 6)]
            public string Name { get; set; }

            [FileLinePosition(7,12)]
            [DecimalFormat(3)]
            public decimal Decimal { get; set; }

            [FileLinePosition(13,13)]
            [BooleanFormat("J", "N")]
            public bool Boolean { get; set; }
        }

        private class GStandardFileSerializerMock : GStandardFileSerializerBase<GStandardModelMock>
        {
            public new GStandardModelMock ParseLineToModel(string line)
            {
                return base.ParseLineToModel(line);
            }
        }
        #endregion

        [TestMethod]
        public void Be_Able_To_Parse_A_Given_FileLine_To_The_GStandard_Model()
        {
            const string line = "11ABCD123456J";
            const int expectedId = 1;
            const EnumMock expectedEnum = EnumMock.A;
            const string expectedName = "ABCD";
            
            var gStandardFileSerializerMock = new GStandardFileSerializerMock();
            var model = gStandardFileSerializerMock.ParseLineToModel(line);

            Assert.AreEqual(expectedId, model.Id);
            Assert.AreEqual(expectedEnum, model.Enum);
            Assert.AreEqual(expectedName, model.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(CannotParseLineException))]
        public void Throw_CannotParseLineException_When_MockEnum_Cannot_Be_Parsed()
        {
            const string line = "1XABCD123456J";

            var gStandardFileSerializerMock = new GStandardFileSerializerMock();
            gStandardFileSerializerMock.ParseLineToModel(line);
        }

        [TestMethod]
        public void Skip_One_Of_Two_Lines_When_CannotParseLineException_Is_Thrown_On_One_Line()
        {
            const int expectedLineCount = 1;
            string data = "11ABCD123456J" + Environment.NewLine;
            data += "XABCD";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            GStandardFileSerializerMock fileSerializerMock = new GStandardFileSerializerMock();
            IEnumerable<GStandardModelMock> lines = fileSerializerMock.ReadLines(memoryStream);

            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Log_When_CannotParseLineException_Is_Thrown_On_FileLine()
        {
            //TODO create logic
        }

        [TestMethod]
        public void Convert_A_String_To_Boolean_When_A_BooleanFormatAttribute_Is_Present_On_A_Property()
        {
            const string data = "11ABCD123456J";
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            
            GStandardFileSerializerMock fileSerializerMock = new GStandardFileSerializerMock();
            GStandardModelMock line = fileSerializerMock.ReadLines(memoryStream).FirstOrDefault();

            Assert.IsTrue(line.Boolean);
        }

        [TestMethod]
        public void Not_Be_Able_To_Convert_When_BooleanFormatAttribute_Is_Present_On_A_Property_But_String_Format_Is_Incorrect()
        {
            const string data = "11ABCD123456O";
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);

            GStandardFileSerializerMock fileSerializerMock = new GStandardFileSerializerMock();
            GStandardModelMock line = fileSerializerMock.ReadLines(memoryStream).FirstOrDefault();

            Assert.IsNull(line);
        }

        [TestMethod]
        public void Convert_A_String_To_Decimal_When_A_DecimalFormatAttribute_Is_Present_On_A_Property()
        {
            const decimal expectedDecimal = 123.456m;
            const string data = "11ABCD123456J";
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);

            GStandardFileSerializerMock fileSerializerMock = new GStandardFileSerializerMock();
            GStandardModelMock line = fileSerializerMock.ReadLines(memoryStream).FirstOrDefault();

            Assert.AreEqual(expectedDecimal, line.Decimal);
        }

        [TestMethod]
        public void Not_Be_Able_To_Convert_When_DecimalFormatAttribute_Is_Present_On_A_Property_But_String_Format_Is_Incorrect()
        {
            const string data = "11ABCDA23456J";
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);

            GStandardFileSerializerMock fileSerializerMock = new GStandardFileSerializerMock();
            GStandardModelMock line = fileSerializerMock.ReadLines(memoryStream).FirstOrDefault();

            Assert.IsNull(line);
        }
    }
}