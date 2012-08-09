using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class ProductComparerShould
    {
        [TestMethod]
        public void Equal_CommercialProducts_When_AtKode_Are_Equal()
        {
            var x = new Product { AtKode = 2 };
            var y = new Product { AtKode = 2 };

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_CommercialProducts_When_AtKode_Are_Different()
        {
            var x = new Product { AtKode = 2 };
            var y = new Product { AtKode = 3 };

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_AtKode()
        {
            var product = new Product { AtKode = 3 };
            int expectedHashCode = product.AtKode.GetHashCode();

            var comparer = new ProductComparer();
            int result = comparer.GetHashCode(product);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
