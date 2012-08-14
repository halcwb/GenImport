using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class GenericCompositionComparerShould
    {
        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5

            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnMomH_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };
            var y = new GenericComposition
            {
                GnMomH = 2,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnMwHs_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.W,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnNkPk_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 3,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GsKode_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5

            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 4,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordNotChanged,
                XnMomE = 4,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_XnMomE_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5

            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 5,
                XpEhHv = 5
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_XpEhHv_Is_Different()
        {
            var x = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5

            };
            var y = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 6
            };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_GnMwHs_GsKode_GnNkPk()
        {
            var genericComposition = new GenericComposition
            {
                GnMomH = 1,
                GnMwHs = SubstanceIndication.H,
                GnNkPk = 2,
                GsKode = 3,
                MutKod = MutKod.RecordUpdated,
                XnMomE = 4,
                XpEhHv = 5
            };

            int expectedHashCode = genericComposition.GnMomH.GetHashCode() ^ (byte)genericComposition.GnMwHs ^
                                   genericComposition.GnNkPk ^ genericComposition.GsKode ^
                                   (byte)genericComposition.MutKod ^ genericComposition.XnMomE ^
                                   genericComposition.XpEhHv;

            var comparer = new GenericCompositionComparer();
            int result = comparer.GetHashCode(genericComposition);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
