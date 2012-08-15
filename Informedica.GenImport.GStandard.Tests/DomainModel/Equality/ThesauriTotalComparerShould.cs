using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class ThesauriTotalComparerShould
    {
        private static IThesauriTotal CreateThesauriTotal()
        {
            return new ThesauriTotal
            {
                MutKod = MutKod.RecordNotChanged,
                ThAKd1 = "A",
                ThAKd2 = "B",
                ThAKd3 = "C",
                ThAKd4 = "D",
                ThAKd5 = "E",
                ThAKd6 = "F",
                ThItMk = "G",
                ThNm15 = "H",
                ThNm25 = "I",
                ThNm4 = "J",
                ThNm50 = "K",
                TsItNr = 1,
                TsNr = 2
            };
        }

        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.MutKod = MutKod.RecordUpdated;

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThAKd1_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThAKd1 = "B";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThAKd2_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThAKd2 = "C";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThAKd3_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThAKd3 = "D";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThAKd4_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThAKd4 = "E";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThAKd5_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThAKd5 = "F";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThAKd6_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThAKd6 = "G";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThItMk_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThItMk = "H";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThNm15_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThNm15 = "I";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThNm25_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThNm25 = "J";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThNm4_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThNm4 = "K";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThNm50_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.ThNm50 = "L";

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_TsItNr_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.TsItNr = 2;

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_TsNr_Is_Different()
        {
            var x = CreateThesauriTotal();
            var y = CreateThesauriTotal();
            y.TsNr = 3;

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var thesauriTotal = CreateThesauriTotal();
            int expectedHashCode =
                (byte)thesauriTotal.MutKod ^ thesauriTotal.ThAKd1.GetHashCode() ^ thesauriTotal.ThAKd2.GetHashCode() ^
                thesauriTotal.ThAKd3.GetHashCode() ^ thesauriTotal.ThAKd4.GetHashCode() ^
                thesauriTotal.ThAKd5.GetHashCode() ^ thesauriTotal.ThAKd6.GetHashCode() ^
                thesauriTotal.ThItMk.GetHashCode() ^ thesauriTotal.ThNm15.GetHashCode() ^
                thesauriTotal.ThNm25.GetHashCode() ^ thesauriTotal.ThNm4.GetHashCode() ^
                thesauriTotal.ThNm50.GetHashCode() ^ thesauriTotal.TsNr ^ thesauriTotal.TsItNr;

            var comparer = new ThesauriTotalComparer();
            int result = comparer.GetHashCode(thesauriTotal);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
