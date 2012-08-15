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
    public class GenericNameShould
    {
        #region FileLinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_3_Properties()
        {
            const int expectedCount = 3;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericName, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericName().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnGnK_Property_With_Position_6_11()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericName().GnGnK);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 11),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_GnGnAm_Property_With_Position_12_61()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericName().GnGnAm);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 12, 61),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region Modulo11Attribute

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_1_Property()
        {
            const int expectedCount = 1;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<GenericName, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_GnGnK_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new GenericName().GnGnK);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new GenericName
            {
                GnGnK = 1
            };
            var y = new GenericName
            {
                GnGnK = 1
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_Identity_Is_Different()
        {
            var x = new GenericName
            {
                GnGnK = 1
            };
            var y = new GenericName
            {
                GnGnK = 2
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new GenericName
            {
                GnGnAm = "A",
                GnGnK = 3,
                MutKod = MutKod.RecordUpdated,
            };
            var to = new GenericName();

            from.CopyTo(to);

            Assert.IsTrue(new GenericNameComparer().Equals(from, to));
        }

        #endregion
    }
}
