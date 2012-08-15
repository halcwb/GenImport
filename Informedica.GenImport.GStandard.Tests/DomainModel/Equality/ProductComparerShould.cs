using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class ProductComparerShould
    {
        private static IProduct CreateProduct()
        {
            return new Product
            {
                AtKode = 1,
                AtNmNr = 2,
                HpKode = 3,
                MutKod = MutKod.RecordNotChanged
            };
        }

        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = CreateProduct();
            var y = CreateProduct();

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_AtKode_Is_Different()
        {
            var x = CreateProduct();
            var y = CreateProduct();
            y.AtKode = 2;

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_AtNmNr_Is_Different()
        {
            var x = CreateProduct();
            var y = CreateProduct();
            y.AtNmNr = 3;

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_HpKode_Is_Different()
        {
            var x = CreateProduct();
            var y = CreateProduct();
            y.HpKode = 4;

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = CreateProduct();
            var y = CreateProduct();
            y.MutKod = MutKod.RecordUpdated;

            var comparer = new ProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var product = CreateProduct();
            int expectedHashCode = product.AtKode ^ product.AtNmNr ^ product.HpKode ^ (byte)product.MutKod;

            var comparer = new ProductComparer();
            int result = comparer.GetHashCode(product);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
