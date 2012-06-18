using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class FileReaderBaseShould
    {
        #region Helpers
        private class ModelMock : IModel
        {
            public string Line { get; set; }
        }

        private class FileReaderBaseMock : FileReaderBase<ModelMock>
        {
            protected override ModelMock ParseLineToModel(string line)
            {
                return new ModelMock{Line = line};
            }
        }
        #endregion

        [TestMethod]
        public void Should_Read_Multiple_Lines_From_Stream()
        {
            const int expectedLineCount = 3;
            string data = "line 1" + Environment.NewLine;
            data += "line 2" + Environment.NewLine;
            data += "line 3";

            byte[] dataBytes = UTF8Encoding.Default.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);

            FileReaderBaseMock fileReaderBaseMock = new FileReaderBaseMock();
            IEnumerable<ModelMock> lines = fileReaderBaseMock.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}
