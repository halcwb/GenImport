using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Informedica.GenImport.Library.Tests.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests.DomainModel
{
    [TestClass]
    public class ArtikelShould
    {
        #region FileLinePositionAttribute
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Known_Properties()
        {
            const int expectedCount = 4;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Artikel, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_AtKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().AtKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_HpKode_Property_With_Position_14_21()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().HpKode);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 14, 21),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_AtNmNr_Property_With_Position_22_28()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().AtNmNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 22, 28),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
        #endregion

        #region Modulo11Attribute
        [TestMethod]
        public void Have_A_Modulo11Attribute_On_2_Properties()
        {
            const int expectedCount = 2;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<Artikel, Modulo11Attribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_AtKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().AtKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_HpKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().HpKode);
            Assert.IsTrue(AttributeTestUtility.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeTestUtility.HasNoModulo11AttributeMessage, info.Name));
        }
        #endregion
    }
}