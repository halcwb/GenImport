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
    public class PrescriptionProductShould
    {
        #region LinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_3_Properties()
        {
            const int expectedCount = 3;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<PrescriptionProduct, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptionProduct().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_PrKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptionProduct().PrKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_PrNmNr_Property_With_Position_14_20()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptionProduct().PrNmNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 14, 20),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region Modulo11Attribute

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<PrescriptionProduct, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_PrKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new PrescriptionProduct().PrKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new PrescriptionProduct
            {
                PrKode = 1
            };
            var y = new PrescriptionProduct
            {
                PrKode = 1
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_Identity_Is_Different()
        {
            var x = new PrescriptionProduct
            {
                PrKode = 1
            };
            var y = new PrescriptionProduct
            {
                PrKode = 2
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new PrescriptionProduct
            {
                MutKod = MutKod.RecordUpdated,
                PrKode = 1,
                PrNmNr = 2
            };
            var to = new PrescriptionProduct();

            from.CopyTo(to);

            Assert.IsTrue(new PrescriptionProductComparer().Equals(from, to));
        }

        #endregion
    }
}
