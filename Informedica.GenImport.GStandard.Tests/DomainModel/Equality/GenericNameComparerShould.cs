using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class GenericNameComparerShould
    {
        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };
            var y = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };

            var comparer = new GenericNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnGnK_Is_Different()
        {
            var x = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };
            var y = new GenericName
            {
                GnGnK = 4,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };

            var comparer = new GenericNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnGnAm_Is_Different()
        {
            var x = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };
            var y = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "B",
                MutKod = MutKod.RecordNotChanged
            };

            var comparer = new GenericNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };
            var y = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordUpdated
            };

            var comparer = new GenericNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var genericName = new GenericName
            {
                GnGnK = 3,
                GnGnAm = "A",
                MutKod = MutKod.RecordNotChanged
            };
            int expectedHashCode = genericName.GnGnK ^ genericName.GnGnAm.GetHashCode() ^ (byte)genericName.MutKod;

            var comparer = new GenericNameComparer();
            int result = comparer.GetHashCode(genericName);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
