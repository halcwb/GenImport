using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class GenericNameComparerShould
    {
        [TestMethod]
        public void Equal_When_GnGnK_Are_Equal()
        {
            var x = new GenericName { GnGnK = 2 };
            var y = new GenericName { GnGnK = 2 };

            var comparer = new GenericNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnGnK_Are_Different()
        {
            var x = new GenericName { GnGnK = 2 };
            var y = new GenericName { GnGnK = 3 };

            var comparer = new GenericNameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_GnGnK()
        {
            var genericName = new GenericName { GnGnK = 3 };
            int expectedHashCode = genericName.GnGnK.GetHashCode();

            var comparer = new GenericNameComparer();
            int result = comparer.GetHashCode(genericName);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
