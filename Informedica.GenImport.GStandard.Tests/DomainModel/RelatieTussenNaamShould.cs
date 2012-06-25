using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class RelatieTussenNaamShould
    {
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_4_Known_Properties()
        {
            const int expectedCount = 4;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<RelatieTussenNaam, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmRNr_Property_With_Position_6_8()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().NmRNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 8),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNrIn_Property_With_Position_9_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().NmNrIn);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 9, 15),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_NmNrUit_Property_With_Position_16_22()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new RelatieTussenNaam().NmNrUit);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 16, 22),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
    }
}
