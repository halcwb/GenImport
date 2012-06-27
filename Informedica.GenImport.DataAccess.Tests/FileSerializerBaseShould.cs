﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class FileSerializerBaseShould
    {
        #region Helpers
        private class ModelMock : IModel
        {
            public string Line { get; set; }
        }

        private class FileSerializerBaseMock : FileSerializerBase<ModelMock>
        {
            protected override ModelMock ParseLineToModel(string line)
            {
                return new ModelMock { Line = line };
            }
        }
        #endregion

        [TestMethod]
        public void Should_Read_Lines_From_Stream_And_Parse_To_Model()
        {
            const int expectedLineCount = 3;
            string data = "line 1" + Environment.NewLine;
            data += "line 2" + Environment.NewLine;
            data += "line 3";

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            MemoryStream memoryStream = new MemoryStream(dataBytes);
            FileSerializerBaseMock fileSerializerBaseMock = new FileSerializerBaseMock();
            IEnumerable<ModelMock> lines = fileSerializerBaseMock.ReadLines(memoryStream);

            Assert.IsNotNull(lines);
            Assert.AreEqual(expectedLineCount, lines.Count());
        }
    }
}