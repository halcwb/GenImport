using Informedica.GenImport.GStandard.Attributes;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.Tests.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel
{
    [TestClass]
    public class ThesauriTotaalShould
    {
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_14_Known_Properties()
        {
            const int expectedCount = 14;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<ThesauriTotaal, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsNr_Property_With_Position_6_9()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().TsNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 9),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsItNr_Property_With_Position_10_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().TsItNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 10, 15),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThItMk_Property_With_Position_16_17()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThItMk);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 16, 17),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm4_Property_With_Position_18_21()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThNm4);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 18, 21),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm15_Property_With_Position_22_36()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThNm15);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 22, 36),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm25_Property_With_Position_37_61()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThNm25);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 37, 61),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm50_Property_With_Position_62_111()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThNm50);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 62, 111),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd1_Property_With_Position_112_112()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThAKd1);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 112, 112),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd2_Property_With_Position_113_113()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThAKd2);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 113, 113),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd3_Property_With_Position_114_114()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThAKd3);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 114, 114),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd4_Property_With_Position_115_115()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThAKd4);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 115, 115),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd5_Property_With_Position_116_116()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThAKd5);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 116, 116),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd6_Property_With_Position_117_117()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotaal().ThAKd6);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 117, 117),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }
    }
}