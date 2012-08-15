using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class NameComparerShould
    {
        private static IName CreateName()
        {
            return new Name
            {
                MutKod = MutKod.RecordNotChanged,
                NmEtiket = "A",
                NmMemo = "B",
                NmNaam = "C",
                NmNm40 = "D",
                NmNr = 1
            };
        }

        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = CreateName();
            var y = CreateName();

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = CreateName();
            var y = CreateName();
            y.MutKod = MutKod.RecordUpdated;

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmEtiket_Is_Different()
        {
            var x = CreateName();
            var y = CreateName();
            y.NmEtiket = "B";

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmMemo_Is_Different()
        {
            var x = CreateName();
            var y = CreateName();
            y.NmMemo = "C";

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmNaam_Is_Different()
        {
            var x = CreateName();
            var y = CreateName();
            y.NmNaam = "D";

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmNm40_Is_Different()
        {
            var x = CreateName();
            var y = CreateName();
            y.NmNm40 = "E";

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmNr_Is_Different()
        {
            var x = CreateName();
            var y = CreateName();
            y.NmNr = 2;

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var name = CreateName();
            int expectedHashCode = (byte)name.MutKod ^ name.NmEtiket.GetHashCode() ^ name.NmMemo.GetHashCode() ^
                                   name.NmNaam.GetHashCode() ^ name.NmNm40.GetHashCode() ^ name.NmNr;

            var comparer = new NameComparer();
            int result = comparer.GetHashCode(name);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
