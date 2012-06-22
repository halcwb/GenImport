using System;
using System.Reflection;
using System.Linq;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class ArtikelShould
    {
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Known_Properties()
        {
            Type type = typeof(Artikel);
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            const int expectedCount = 4;
            Assert.AreEqual(expectedCount, type.GetProperties(flags).Count(),
                            "All properties must be tested on LinePositionAttribute.");
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().MutKod);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_AtKode_Property_With_Position_6_13()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().AtKode);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 6, 13),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_HpKode_Property_With_Position_14_21()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().HpKode);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 14, 21),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_AtNmNr_Property_With_Position_22_28()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().AtNmNr);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 22, 28),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_2_Properties()
        {
            Type type = typeof(Artikel);
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            const int expectedCount = 2;
            
            Assert.AreEqual(expectedCount,
                            type.GetProperties(flags).Sum(
                                a => a.GetCustomAttributes(typeof (Modulo11Attribute), true).Count()),
                            "Only expected properties must have a Modulo11Attribute.");
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_AtKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().AtKode);
            Assert.IsTrue(AttributeCheck.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeCheck.HasNoModulo11AttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_HpKode_Property()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Artikel().HpKode);
            Assert.IsTrue(AttributeCheck.HasModulo11AttributeOnProperty(info),
                          string.Format(AttributeCheck.HasNoModulo11AttributeMessage, info.Name));
        }
    }
}