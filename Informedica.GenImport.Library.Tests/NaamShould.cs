using System;
using System.Linq;
using System.Reflection;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class NaamShould
    {
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_6_Known_Properties()
        {
            Type type = typeof(Naam);
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            const int expectedCount = 6;
            Assert.AreEqual(expectedCount, type.GetProperties(flags).Count(),
                            "All properties must be tested on LinePositionAttribute.");
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Naam().MutKod);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNr_Property_With_Position_6_12()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Naam().NmNr);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 6, 12),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmMemo_Property_With_Position_13_18()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Naam().NmMemo);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 13, 18),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmEtiket_Property_With_Position_19_45()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Naam().NmEtiket);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 19,45 ),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNm40_Property_With_Position_46_85()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Naam().NmNm40);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 46, 85),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmEtiket_Property_With_Position_86_135()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new Naam().NmNaam);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 86, 135),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
    }
}