using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Informedica.GenImport.DataAccess.GStandard;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class GStandardFileSerializerBaseShould
    {
        #region Helpers
        private enum EnumMock
        {
            A = 1,
            B = 2
        }

        private class GStandardModelMock : IGStandardModel
        {
            [FileLinePosition(1, 1)]
            public int Id { get; set; }

            [FileLinePosition(2, 2)]
            public EnumMock Enum { get; set; }

            [FileLinePosition(3, 6)]
            public string Name { get; set; }
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
        public void Be_Able_To_Parse_A_FileLine_To_The_GStandard_Model()
        {
            const string line = "11ABCD";
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
            const string line = "1XABCD";

            var gStandardFileSerializerMock = new GStandardFileSerializerMock();
            gStandardFileSerializerMock.ParseLineToModel(line);
        }

        [TestMethod]
        public void Skip_FileLine_When_CannotParseLineException_Is_Thrown()
        {
            const int expectedLineCount = 1;
            string data = "11ABCD" + Environment.NewLine;
            data += "XABCD";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            GStandardFileSerializerMock fileSerializerMock = new GStandardFileSerializerMock();
            IEnumerable<GStandardModelMock> lines = fileSerializerMock.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }

        [TestMethod]
        public void Log_When_CannotParseLineException_Is_Thrown_On_FileLine()
        {
            //TODO create logic
            Assert.Fail();
        }
    }
}