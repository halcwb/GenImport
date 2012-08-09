using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class ThesauriTotalComparerShould
    {
        [TestMethod]
        public void Equal_RelationBetweenNames_When_TsNr_TsItNr_Are_Equal()
        {
            var x = new ThesauriTotal { TsNr = 1, TsItNr = 2 };
            var y = new ThesauriTotal { TsNr = 1, TsItNr = 2 };

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_RelationBetweenNames_When_TsNr_Are_Different()
        {
            var x = new ThesauriTotal { TsNr = 1, TsItNr = 2 };
            var y = new ThesauriTotal { TsNr = 2, TsItNr = 2 };

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_RelationBetweenNames_When_TsItNr_Are_Different()
        {
            var x = new ThesauriTotal { TsNr = 1, TsItNr = 2 };
            var y = new ThesauriTotal { TsNr = 2, TsItNr = 2 };

            var comparer = new ThesauriTotalComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_TsNr_TsItNr()
        {
            var thesauriTotal = new ThesauriTotal { TsNr = 1, TsItNr = 2 };
            int expectedHashCode = thesauriTotal.TsNr.GetHashCode() + thesauriTotal.TsItNr.GetHashCode();

            var comparer = new ThesauriTotalComparer();
            int result = comparer.GetHashCode(thesauriTotal);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
