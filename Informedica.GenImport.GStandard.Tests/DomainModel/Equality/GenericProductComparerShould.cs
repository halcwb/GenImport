using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class GenericProductComparerShould
    {
        [TestMethod]
        public void Equal_When_GpKode_Are_Equal()
        {
            var x = new GenericProduct { GpKode = 2 };
            var y = new GenericProduct { GpKode = 2 };

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpKode_Are_Different()
        {
            var x = new GenericProduct { GpKode = 2 };
            var y = new GenericProduct { GpKode = 3 };

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_GpKode()
        {
            var genericProduct = new GenericProduct { GpKode = 3 };
            int expectedHashCode = genericProduct.GpKode.GetHashCode();

            var comparer = new GenericProductComparer();
            int result = comparer.GetHashCode(genericProduct);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
