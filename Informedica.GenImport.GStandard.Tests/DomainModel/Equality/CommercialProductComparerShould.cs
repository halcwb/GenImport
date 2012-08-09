using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class CommercialProductComparerShould
    {
        [TestMethod]
        public void Equal_CommercialProducts_When_HpKode_Are_Equal()
        {
            var x = new CommercialProduct { HpKode = 2 };
            var y = new CommercialProduct { HpKode = 2 };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_CommercialProducts_When_HpKode_Are_Different()
        {
            var x = new CommercialProduct { HpKode = 2 };
            var y = new CommercialProduct { HpKode = 3 };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_HpKode()
        {
            var commercialProduct = new CommercialProduct { HpKode = 3 };
            int expectedHashCode = commercialProduct.HpKode.GetHashCode();
            
            var comparer = new CommercialProductComparer();
            int result = comparer.GetHashCode(commercialProduct);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
