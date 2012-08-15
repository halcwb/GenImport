using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class RelationBetweenNameComparerShould
    {
        private static IRelationBetweenName CreateRelationBetweenName()
        {
            return new RelationBetweenName
            {
                MutKod = MutKod.RecordNotChanged,
                NmNrIn = 1,
                NmNrUit = 2,
                NmRNr = 3
            };
        }

        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = CreateRelationBetweenName();
            var y = CreateRelationBetweenName();

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = CreateRelationBetweenName();
            var y = CreateRelationBetweenName();
            y.MutKod = MutKod.RecordUpdated;

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmNrIn_Is_Different()
        {
            var x = CreateRelationBetweenName();
            var y = CreateRelationBetweenName();
            y.NmNrIn = 2;

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmNrUit_Is_Different()
        {
            var x = CreateRelationBetweenName();
            var y = CreateRelationBetweenName();
            y.NmNrUit = 3;

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmRNr_Is_Different()
        {
            var x = CreateRelationBetweenName();
            var y = CreateRelationBetweenName();
            y.NmRNr = 4;

            var comparer = new RelationBetweenNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var relationBetweenName = CreateRelationBetweenName();
            int expectedHashCode = (byte)relationBetweenName.MutKod ^ relationBetweenName.NmNrIn ^
                                   relationBetweenName.NmNrUit ^ relationBetweenName.NmRNr;

            var comparer = new RelationBetweenNameComparer();
            int result = comparer.GetHashCode(relationBetweenName);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
