using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class CommercialProductComparerShould
    {
        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_FsNaam_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "B",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_HpKode_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 2,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_HpNamN_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 3,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_MsNaam_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "C",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordAdded,
                TsEmbM = 3,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_TsEmbM_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 4,
                XsEmbM = 4
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_XsEmbM_Is_Different()
        {
            var x = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 4
            };
            var y = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 5
            };

            var comparer = new CommercialProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_HpKode()
        {
            var commercialProduct = new CommercialProduct
            {
                FsNaam = "A",
                HpKode = 1,
                HpNamN = 2,
                MsNaam = "B",
                MutKod = MutKod.RecordUpdated,
                TsEmbM = 3,
                XsEmbM = 5
            };

            int expectedHashCode = commercialProduct.FsNaam.GetHashCode() ^ commercialProduct.HpKode ^
                                   commercialProduct.HpNamN ^ commercialProduct.MsNaam.GetHashCode() ^
                                   (byte)commercialProduct.MutKod ^ commercialProduct.TsEmbM ^ commercialProduct.XsEmbM;

            var comparer = new CommercialProductComparer();
            int result = comparer.GetHashCode(commercialProduct);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
