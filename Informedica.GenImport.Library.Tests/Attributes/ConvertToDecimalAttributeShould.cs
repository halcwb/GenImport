using System;
using Informedica.GenImport.Library.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests.Attributes
{
    [TestClass]
    public class ConvertToDecimalAttributeShould
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Throw_ArgumentOutOfRangeException_When_Precision_Less_Than_0()
        {
            new ConvertToDecimalAttribute(-1);
        }

        [TestMethod]
        public void Be_Able_To_Parse_A_String_Without_A_Separator_To_A_Decimal_With_Precision_Of_3()
        {
            const string decimalString = "1234567890";
            const decimal expectedResult = 1234567.890m;

            decimal result;
            var attribute = new ConvertToDecimalAttribute(3);
            
            Assert.IsTrue(attribute.TryParse(decimalString, out result));
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Not_Be_Able_To_Parse_A_Mallformed_String_Without_A_Separator()
        {
            const string decimalString = "A234567890";
            const decimal expectedResult = 0;

            decimal result;
            var attribute = new ConvertToDecimalAttribute(3);

            Assert.IsFalse(attribute.TryParse(decimalString, out result));
            Assert.AreEqual(expectedResult, result);
        }
    }
}
