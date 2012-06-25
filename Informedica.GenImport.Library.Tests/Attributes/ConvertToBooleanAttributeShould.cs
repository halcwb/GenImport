using Informedica.GenImport.Library.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests.Attributes
{
    [TestClass]
    public class ConvertToBooleanAttributeShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_FalseString_To_False()
        {
            var attribute = new BooleanFormatAttribute("J", "N");
            bool result;

            Assert.IsTrue(attribute.TryParse("N", out result));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Be_Able_To_Parse_A_TrueString_To_True()
        {
            var attribute = new BooleanFormatAttribute("J", "N");
            bool result;

            Assert.IsTrue(attribute.TryParse("J", out result));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Be_Able_To_Parse_A_Wrong_String()
        {
            var attribute = new BooleanFormatAttribute("J", "N");
            bool result;

            Assert.IsFalse(attribute.TryParse("A", out result));
            Assert.IsFalse(result);
        }
    }
}
