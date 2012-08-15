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
    public class CommercialProductShould
    {
        #region FileLinePositionAttribute
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_7_Properties()
        {
            const int expectedCount = 7;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<CommercialProduct, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_HpKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().HpKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_HpNamN_Property_With_Position_30_36()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().HpNamN);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 30, 36),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MsNaam_Property_With_Position_37_86()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().MsNaam);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 37, 86),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_FsNaam_Property_With_Position_87_136()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().FsNaam);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 87, 136),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsEmbM_Property_With_Position_266_269()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().TsEmbM);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 266, 269),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_XsEmbM_Property_With_Position_270_275()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().XsEmbM);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 270, 275),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
        #endregion

        #region Modulo11Attribute
        [TestMethod]
        public void Have_A_Modulo11Attribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<CommercialProduct, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_HpKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new CommercialProduct().HpKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }
        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new CommercialProduct
            {
                HpKode = 1
            };
            var y = new CommercialProduct
            {
                HpKode = 1
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_Identity_Is_Different()
        {
            var x = new CommercialProduct
            {
                HpKode = 1
            };
            var y = new CommercialProduct
            {
                HpKode = 2
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var to = new CommercialProduct();

            from.CopyTo(to);

            Assert.IsTrue(new CommercialProductComparer().Equals(from, to));
        }

        #endregion
    }
}
