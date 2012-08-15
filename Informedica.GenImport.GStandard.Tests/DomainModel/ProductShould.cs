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
    public class ProductShould
    {
        #region FileLinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Known_Properties()
        {
            const int expectedCount = 4;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Product, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Product().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_AtKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Product().AtKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_HpKode_Property_With_Position_14_21()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Product().HpKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 14, 21),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_AtNmNr_Property_With_Position_22_28()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Product().AtNmNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 22, 28),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region Modulo11Attribute

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_2_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Product, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_AtKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Product().AtKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_HpKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Product().HpKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new Product
            {
                AtKode = 1
            };
            var y = new Product
            {
                AtKode = 1
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_Identity_Is_Different()
        {
            var x = new Product
            {
                AtKode = 1
            };
            var y = new Product
            {
                AtKode = 2
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new Product
            {
                AtKode = 1,
                AtNmNr = 2,
                HpKode = 3,
                MutKod = MutKod.RecordUpdated,
            };
            var to = new Product();

            from.CopyTo(to);

            Assert.IsTrue(new ProductComparer().Equals(from, to));
        }

        #endregion
    }
}