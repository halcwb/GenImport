using Informedica.GenImport.Library.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class MathUtilsShould
    {
        [TestMethod]
        public void Return_True_With_ValidateModulo11_On_These_Numbers()
        {
            Assert.IsTrue(MathUtility.IsValidModulo11(00022934));
            Assert.IsTrue(MathUtility.IsValidModulo11(00531456));
            Assert.IsTrue(MathUtility.IsValidModulo11(00239062));
            Assert.IsTrue(MathUtility.IsValidModulo11(00239011));
            Assert.IsTrue(MathUtility.IsValidModulo11(00239038));
            Assert.IsTrue(MathUtility.IsValidModulo11(00239054));
            Assert.IsTrue(MathUtility.IsValidModulo11(00410845));
            Assert.IsTrue(MathUtility.IsValidModulo11(00410853));
        }

        [TestMethod]
        public void Return_False_With_ValidateModulo11_On_These_Numbers()
        {
            Assert.IsFalse(MathUtility.IsValidModulo11(00022943));
            Assert.IsFalse(MathUtility.IsValidModulo11(00531465));
            Assert.IsFalse(MathUtility.IsValidModulo11(00239026));
            Assert.IsFalse(MathUtility.IsValidModulo11(00230911));
            Assert.IsFalse(MathUtility.IsValidModulo11(00293038));
            Assert.IsFalse(MathUtility.IsValidModulo11(00293054));
            Assert.IsFalse(MathUtility.IsValidModulo11(00418045));
            Assert.IsFalse(MathUtility.IsValidModulo11(00140853));
        }

        [TestMethod]
        public void Return_Correct_Int_Lengths_On_These_Numbers()
        {
            Assert.AreEqual(1, MathUtility.IntLength(1));
            Assert.AreEqual(2, MathUtility.IntLength(10));
            Assert.AreEqual(3, MathUtility.IntLength(100));
            Assert.AreEqual(4, MathUtility.IntLength(1000));
            Assert.AreEqual(5, MathUtility.IntLength(10000));
            Assert.AreEqual(6, MathUtility.IntLength(100000));
            Assert.AreEqual(7, MathUtility.IntLength(1000000));
            Assert.AreEqual(8, MathUtility.IntLength(10000000));
            Assert.AreEqual(9, MathUtility.IntLength(100000000));
            Assert.AreEqual(10, MathUtility.IntLength(int.MaxValue));
        }
    }
}
