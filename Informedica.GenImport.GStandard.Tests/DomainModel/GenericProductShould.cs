using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class GenericProductShould
    {
        #region FileLinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_13_Properties()
        {
            const int expectedCount = 13;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericProduct, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GpKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GsKode_Property_With_Position_14_21()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GsKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 14, 21),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThKtVr_Property_With_Position_22_24()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().ThKtVr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 22, 24),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GpKtVr_Property_With_Position_25_27()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpKtVr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 25, 27),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThKTwg_Property_With_Position_28_30()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().ThKTwg);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 28, 30),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThKTwg_Property_With_Position_31_33()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpKTwg);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 31, 33),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GpNmNr_Property_With_Position_34_40()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpNmNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 34, 40),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GpStNr_Property_With_Position_41_47()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpStNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 41, 47),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GpInSt_Property_With_Position_48_72()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpInSt);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 48, 72),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_SpKode_Property_With_Position_105_112()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().SpKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 105, 112),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThEhHv_Property_With_Position_127_129()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().ThEhHv);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 127, 129),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThEhHv_Property_With_Position_130_132()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().XpEhHv);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 130, 132),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region Modulo11Attribute

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_3_Properties()
        {
            const int expectedCount = 3;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericProduct, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GpKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GpKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GsKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().GsKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_SpKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericProduct().SpKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new GenericProduct
            {
                GpKode = 1
            };
            var y = new GenericProduct
            {
                GpKode = 1
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_Identity_Is_Different()
        {
            var x = new GenericProduct
            {
                GpKode = 1
            };
            var y = new GenericProduct
            {
                GpKode = 2
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new GenericProduct
            {
                GpInSt = "A",
                GpKode = 1,
                GpKtVr = 2,
                GpKTwg = 3,
                GpNmNr = 4,
                GpStNr = 5,
                GsKode = 6,
                MutKod = MutKod.RecordUpdated,
                SpKode = 7,
                ThEhHv = 8,
                ThKtVr = 9,
                ThKTwg = 10,
                XpEhHv = 11
            };
            var to = new GenericProduct();

            from.CopyTo(to);

            Assert.IsTrue(new GenericProductComparer().Equals(from, to));
        }

        #endregion
    }
}
