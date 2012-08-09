using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class RelationBetweenNameComparerShould
    {
        [TestMethod]
        public void Equal_RelationBetweenNames_When_NmRNr_NmNrIn_NmNrUit_Are_Equal()
        {
            var x = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 3 };
            var y = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 3 };

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_RelationBetweenNames_When_NmRNr_Are_Different()
        {
            var x = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 3 };
            var y = new RelationBetweenName { NmRNr = 2, NmNrIn = 2, NmNrUit = 3 };

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_RelationBetweenNames_When_NmNrIn_Are_Different()
        {
            var x = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 3 };
            var y = new RelationBetweenName { NmRNr = 1, NmNrIn = 3, NmNrUit = 3 };

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_RelationBetweenNames_When_NmNrUit_Are_Different()
        {
            var x = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 3 };
            var y = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 4 };

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_HpKode()
        {
            var relationBetweenName = new RelationBetweenName { NmRNr = 1, NmNrIn = 2, NmNrUit = 3 };
            int expectedHashCode = relationBetweenName.NmRNr.GetHashCode() + relationBetweenName.NmNrIn.GetHashCode() +
                                   relationBetweenName.NmNrUit.GetHashCode();

            var comparer = new RelationBetweenNameComparer();
            int result = comparer.GetHashCode(relationBetweenName);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
