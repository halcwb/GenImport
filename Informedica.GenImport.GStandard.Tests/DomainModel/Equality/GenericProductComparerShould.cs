using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class GenericProductComparerShould
    {
        private static IGenericProduct CreateGenericProduct()
        {
            return new GenericProduct
            {
                GpInSt = "A",
                GpKode = 1,
                GpKtVr = 2,
                GpKTwg = 3,
                GpNmNr = 4,
                GpStNr = 5,
                GsKode = 6,
                MutKod = MutKod.RecordNotChanged,
                SpKode = 7,
                ThEhHv = 8,
                ThKtVr = 9,
                ThKTwg = 10,
                XpEhHv = 11
            };
        }

        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpInSt_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GpInSt = "B";

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpKode_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GpKode = 2;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpKtVr_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GpKtVr = 3;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpKTwg_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GpKTwg = 4;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpNmNr_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GpNmNr = 5;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GpStNr_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GpStNr = 6;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GsKode_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.GsKode = 7;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.MutKod = MutKod.RecordUpdated;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_SpKode_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.SpKode = 8;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThEhHv_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.ThEhHv = 9;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThKtVr_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.ThKtVr = 10;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_ThKTwg_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.ThKTwg = 11;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_XpEhHv_Is_Different()
        {
            var x = CreateGenericProduct();
            var y = CreateGenericProduct();
            y.XpEhHv = 12;

            var comparer = new GenericProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var genericProduct = CreateGenericProduct();
            int expectedHashCode = genericProduct.GpInSt.GetHashCode() ^ genericProduct.GpKode ^ genericProduct.GpKtVr ^
                                   genericProduct.GpKTwg ^ genericProduct.GpNmNr ^
                                   genericProduct.GpStNr ^ genericProduct.GsKode ^ (byte)genericProduct.MutKod ^
                                   genericProduct.SpKode ^ genericProduct.ThEhHv ^ genericProduct.ThKtVr ^
                                   genericProduct.ThKTwg ^ genericProduct.XpEhHv;

            var comparer = new GenericProductComparer();
            int result = comparer.GetHashCode(genericProduct);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
