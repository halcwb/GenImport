using Informedica.GenImport.Library.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class MathUtilsShould
    {
        [TestMethod]
        public void Return_True_With_ValidateMod11_On_These_Numbers()
        {
            Assert.IsTrue(MathUtils.IsValidMod11(00022934));
            Assert.IsTrue(MathUtils.IsValidMod11(00531456));
            Assert.IsTrue(MathUtils.IsValidMod11(00239062));
            Assert.IsTrue(MathUtils.IsValidMod11(00239011));
            Assert.IsTrue(MathUtils.IsValidMod11(00239038));
            Assert.IsTrue(MathUtils.IsValidMod11(00239054));
            Assert.IsTrue(MathUtils.IsValidMod11(00410845));
            Assert.IsTrue(MathUtils.IsValidMod11(00410853));
        }

        [TestMethod]
        public void Return_False_With_ValidateMod11_On_These_Numbers()
        {
            Assert.IsFalse(MathUtils.IsValidMod11(00022943));
            Assert.IsFalse(MathUtils.IsValidMod11(00531465));
            Assert.IsFalse(MathUtils.IsValidMod11(00239026));
            Assert.IsFalse(MathUtils.IsValidMod11(00230911));
            Assert.IsFalse(MathUtils.IsValidMod11(00293038));
            Assert.IsFalse(MathUtils.IsValidMod11(00293054));
            Assert.IsFalse(MathUtils.IsValidMod11(00418045));
            Assert.IsFalse(MathUtils.IsValidMod11(00140853));
        }

        [TestMethod]
        public void Return_Correct_Int_Lengths_On_These_Numbers()
        {
            Assert.AreEqual(1, MathUtils.IntLength(1));
            Assert.AreEqual(2, MathUtils.IntLength(10));
            Assert.AreEqual(3, MathUtils.IntLength(100));
            Assert.AreEqual(4, MathUtils.IntLength(1000));
            Assert.AreEqual(5, MathUtils.IntLength(10000));
            Assert.AreEqual(6, MathUtils.IntLength(100000));
            Assert.AreEqual(7, MathUtils.IntLength(1000000));
            Assert.AreEqual(8, MathUtils.IntLength(10000000));
            Assert.AreEqual(9, MathUtils.IntLength(100000000));
            Assert.AreEqual(10, MathUtils.IntLength(int.MaxValue));
        }
    }
}
