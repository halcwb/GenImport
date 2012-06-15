using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class FileLinePositionAttributeShould
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Throw_ArgumentOutOfRangeException_When_StartPosition_Larger_Than_EndPosition()
        {
            const int startPosition = 2;
            const int endPosition = 1;
            new FileLinePositionAttribute(startPosition, endPosition);

            //asert by ExpectedException
        }

        [TestMethod]
        public void Set_StartPosition_And_EndPosition_Properties_Within_Constructor()
        {
            const int startPosition = 1;
            const int endPosition = 2;
            FileLinePositionAttribute attribute = new FileLinePositionAttribute(startPosition, endPosition);
            
            Assert.AreEqual(startPosition, attribute.StartPosition);
            Assert.AreEqual(endPosition, attribute.EndPosition);
        }
    }
}