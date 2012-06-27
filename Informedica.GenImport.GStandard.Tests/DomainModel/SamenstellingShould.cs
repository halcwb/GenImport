using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class SamenstellingShould
    {
        #region FileLinePositionAttribute
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_13_Known_Properties()
        {
            const int expectedCount = 13;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Samenstelling, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThsrTc_Property_With_Position_6_9()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().ThsrTc);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 9),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_SrtCde_Property_With_Position_10_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().SrtCde);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 10, 15),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_Code_Property_With_Position_16_23()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().Code);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 16, 23),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnGnK_Property_With_Position_24_29()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnGnK);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 24, 29),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnHoev_Property_With_Position_30_41()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 30, 41),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsGneH_Property_With_Position_42_45()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().TsGneH);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 42, 45),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnEenh_Property_With_Position_46_51()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnEenh);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 46, 51),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnStam_Property_With_Position_52_57()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnStam);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 52, 57),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_StHoev_Property_With_Position_58_69()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().StHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 58, 69),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsStEh_Property_With_Position_70_73()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().TsStEh);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 70, 73),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_StEenh_Property_With_Position_74_79()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().StEenh);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 74, 79),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_StAdd_Property_With_Position_80_80()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().StAdd);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 80, 80),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
        #endregion

        #region Modulo11Attribute
        [TestMethod]
        public void Have_A_Modulo11Attribute_On_2_Known_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Samenstelling, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GnGnK_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnGnK);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GnStam_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnStam);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }
        #endregion

        #region ConvertToDecimalAttribute
        [TestMethod]
        public void Have_A_ConvertToDecimalAttribute_On_2_Known_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Samenstelling, DecimalFormatAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_ConvertToDecimalAttribute_On_GnHoev_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().GnHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToDecimalAttributeOnProperty(info, 3),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToDecimalAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_ConvertToDecimalAttribute_On_StHoev_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().StHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToDecimalAttributeOnProperty(info, 3),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToDecimalAttributeMessage, info.Name));
        }
        #endregion

        #region ConvertToBooleanAttribute
        [TestMethod]
        public void Have_A_ConvertToBooleanAttribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Samenstelling, BooleanFormatAttribute>(expectedCount));
        }
        
        [TestMethod]
        public void Have_A_Valid_ConvertToBooleanAttribute_On_StAdd_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Samenstelling().StAdd);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToBooleanAttributeOnProperty(info, "J", "N"),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToBooleanAttributeMessage, info.Name));
        }
        #endregion
    }
}
