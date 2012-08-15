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
    public class ThesauriTotalShould
    {
        #region FileLinePositionAttribute

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_14_Known_Properties()
        {
            const int expectedCount = 14;
            Assert.IsTrue(AttributeTestUtility.HasAttributeCount<ThesauriTotal, FileLinePositionAttribute>(expectedCount));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_MutKod_Property_With_Position_5_5()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().MutKod);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 5, 5),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsNr_Property_With_Position_6_9()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().TsNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 6, 9),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_TsItNr_Property_With_Position_10_15()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().TsItNr);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 10, 15),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThItMk_Property_With_Position_16_17()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThItMk);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 16, 17),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm4_Property_With_Position_18_21()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThNm4);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 18, 21),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm15_Property_With_Position_22_36()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThNm15);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 22, 36),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm25_Property_With_Position_37_61()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThNm25);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 37, 61),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThNm50_Property_With_Position_62_111()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThNm50);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 62, 111),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd1_Property_With_Position_112_112()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThAKd1);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 112, 112),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd2_Property_With_Position_113_113()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThAKd2);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 113, 113),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd3_Property_With_Position_114_114()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThAKd3);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 114, 114),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd4_Property_With_Position_115_115()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThAKd4);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 115, 115),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd5_Property_With_Position_116_116()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThAKd5);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 116, 116),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        [TestMethod]
        public void Have_A_Valid_LinePositionAttribute_On_ThAKd6_Property_With_Position_117_117()
        {
            var info = ReflectionUtility.GetMemberInfo(() => new ThesauriTotal().ThAKd6);
            Assert.IsTrue(AttributeTestUtility.HasValidLinePositionAttributeOnProperty(info, 117, 117),
                          string.Format(AttributeTestUtility.HasNoOrInvalidLinePositionAttributeMessage, info.Name));
        }

        #endregion

        #region IsIdentical

        [TestMethod]
        public void Return_True_On_IsIdentical_When_Identity_Is_Equal()
        {
            var x = new ThesauriTotal
            {
                TsItNr = 1,
                TsNr = 2
            };
            var y = new ThesauriTotal
            {
                TsItNr = 1,
                TsNr = 2
            };

            Assert.IsTrue(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_TsItNr_Is_Different()
        {
            var x = new ThesauriTotal
            {
                TsItNr = 1,
                TsNr = 2
            };
            var y = new ThesauriTotal
            {
                TsItNr = 2,
                TsNr = 2
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        [TestMethod]
        public void Return_False_On_IsIdentical_When_TsNr_Is_Different()
        {
            var x = new ThesauriTotal
            {
                TsItNr = 1,
                TsNr = 2
            };
            var y = new ThesauriTotal
            {
                TsItNr = 1,
                TsNr = 3
            };

            Assert.IsFalse(x.IsIdentical(y));
        }

        #endregion

        #region CopyTo

        [TestMethod]
        public void Copy_All_Fields_From_One_To_Another()
        {
            var from = new ThesauriTotal
            {
                MutKod = MutKod.RecordUpdated,
                ThAKd1 = "A",
                ThAKd2 = "B",
                ThAKd3 = "C",
                ThAKd4 = "D",
                ThAKd5 = "E",
                ThAKd6 = "F",
                ThItMk = "G",
                ThNm15 = "H",
                ThNm25 = "I",
                ThNm4 =  "J",
                ThNm50 = "K",
                TsItNr = 1,
                TsNr = 2

            };
            var to = new ThesauriTotal();

            from.CopyTo(to);

            Assert.IsTrue(new ThesauriTotalComparer().Equals(from, to));
        }

        #endregion
    }
}