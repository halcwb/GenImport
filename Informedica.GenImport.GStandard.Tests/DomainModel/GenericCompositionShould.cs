using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class GenericCompositionShould
    {
        #region FileLinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_7_Known_Properties()
        {
            const int expectedCount = 7;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericComposition, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnMwHs_Property_With_Position_6_6()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GnMwHs);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 6),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GsKode_Property_With_Position_7_14()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GsKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 7, 14),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnNkPk_Property_With_Position_15_20()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GnNkPk);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 15, 20),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnMomH_Property_With_Position_21_32()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GnMomH);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 21, 32),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_XnMomE_Property_With_Position_33_35()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().XnMomE);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 33, 35),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_XpEhHv_Property_With_Position_36_38()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().XpEhHv);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 36, 38),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region Modulo11Attribute

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_2_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericComposition, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GsKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GsKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GnNkPk_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GnNkPk);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        #endregion

        #region DecimalFormatAttribute

        [TestMethod]
        public void Have_A_ConvertToDecimalAttribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericComposition, DecimalFormatAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_ConvertToDecimalAttribute_On_GnHoev_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericComposition().GnMomH);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToDecimalAttributeOnProperty(info, 3),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToDecimalAttributeMessage, info.Name));
        }

        #endregion
    }
}
