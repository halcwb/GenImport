using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class PrescriptieProductShould
    {
        #region LinePositionAttribute
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Properties()
        {
            const int expectedCount = 4;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<PrescriptieProduct, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptieProduct().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_PrKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptieProduct().PrKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_PrNmNr_Property_With_Position_14_20()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptieProduct().PrNmNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 14, 20),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_PrKBst_Property_With_Position_21_30()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptieProduct().PrKBst);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 21, 30),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
        #endregion

        #region Modulo11Attribute
        [TestMethod]
        public void Have_A_Modulo11Attribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<PrescriptieProduct, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_PrKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptieProduct().PrKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }
        #endregion
    }
}
