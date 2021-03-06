﻿using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class CompositionShould
    {
        #region FileLinePositionAttribute
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_13_Known_Properties()
        {
            const int expectedCount = 13;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Composition, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThsrTc_Property_With_Position_6_9()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().ThsrTc);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 9),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_SrtCde_Property_With_Position_10_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().SrtCde);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 10, 15),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_Code_Property_With_Position_16_23()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().Code);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 16, 23),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnGnK_Property_With_Position_24_29()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnGnK);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 24, 29),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnHoev_Property_With_Position_30_41()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 30, 41),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsGneH_Property_With_Position_42_45()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().TsGneH);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 42, 45),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnEenh_Property_With_Position_46_51()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnEenh);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 46, 51),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnStam_Property_With_Position_52_57()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnStam);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 52, 57),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_StHoev_Property_With_Position_58_69()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().StHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 58, 69),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsStEh_Property_With_Position_70_73()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().TsStEh);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 70, 73),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_StEenh_Property_With_Position_74_79()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().StEenh);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 74, 79),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_StAdd_Property_With_Position_80_80()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().StAdd);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 80, 80),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
        #endregion

        #region Modulo11Attribute
        [TestMethod]
        public void Have_A_Modulo11Attribute_On_2_Known_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Composition, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GnGnK_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnGnK);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GnStam_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnStam);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }
        #endregion

        #region ConvertToDecimalAttribute
        [TestMethod]
        public void Have_A_ConvertToDecimalAttribute_On_2_Known_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Composition, DecimalFormatAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_ConvertToDecimalAttribute_On_GnHoev_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().GnHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToDecimalAttributeOnProperty(info, 3),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToDecimalAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_ConvertToDecimalAttribute_On_StHoev_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().StHoev);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToDecimalAttributeOnProperty(info, 3),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToDecimalAttributeMessage, info.Name));
        }
        #endregion

        #region ConvertToBooleanAttribute
        [TestMethod]
        public void Have_A_ConvertToBooleanAttribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Composition, BooleanFormatAttribute>(expectedCount));
        }
        
        [TestMethod]
        public void Have_A_Valid_ConvertToBooleanAttribute_On_StAdd_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Composition().StAdd);
            Assert.IsTrue(AttributeTestUtility.HasValidConvertToBooleanAttributeOnProperty(info, "J", "N"),
                          string.Format(AttributeTestUtility.HasNoOrInvalidConvertToBooleanAttributeMessage, info.Name));
        }
        #endregion

        #region IsIdentical
        
        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };
            var y = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_Code_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };
            var y = new Composition
            {
                Code = 2,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_GnGnK_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };
            var y = new Composition
            {
                Code = 1,
                GnGnK = 3,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_GnHoev_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };
            var y = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 4,
                GnEenh = 4,
                SrtCde = 5,
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_GnEenh_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };
            var y = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 5,
                SrtCde = 5,
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_SrtCde_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 5,
            };
            var y = new Composition
            {
                Code = 1,
                GnGnK = 2,
                GnHoev = 3,
                GnEenh = 4,
                SrtCde = 6,
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo
        
        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordUpdated,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 10,
                TsStEh = 11
            };
            var to = new Composition();

            from.CopyTo(to);

            Assert.IsTrue(new CompositionComparer().Equals(from, to));
        }

        #endregion
    }
}
