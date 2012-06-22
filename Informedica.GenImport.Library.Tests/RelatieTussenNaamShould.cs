using System;
using System.Reflection;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class RelatieTussenNaamShould
    {
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Known_Properties()
        {
            Type type = typeof(RelatieTussenNaam);
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            const int expectedCount = 4;
            Assert.AreEqual(expectedCount, type.GetProperties(flags).Count(),
                            "All properties must be tested on LinePositionAttribute.");
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().MutKod);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmRNr_Property_With_Position_6_8()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().NmRNr);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 6, 8),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNrIn_Property_With_Position_9_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().NmNrIn);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 9, 15),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNrUit_Property_With_Position_16_22()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().NmNrUit);
            Assert.IsTrue(AttributeCheck.HasValidLinePositionAttributeOnProperty(info, 16, 22),
                          string.Format(AttributeCheck.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
    }
}
