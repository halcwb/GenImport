using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class CompositionComparerShould
    {
        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_Code_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 2,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_GnEenh_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 3,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_GnGnK_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 4,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_GnHoev_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 5,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_GnStam_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 6,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordUpdated,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_SrtCde_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 7,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_StAdd_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = false,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_StEenh_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 8,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_StHoev_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 9,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_ThsrTc_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 10,
                TsGneH = 11,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_TsGneH_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 12,
                TsStEh = 12
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_When_TsStEh_Is_Different()
        {
            var x = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };
            var y = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 13
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }



        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var composition = new Composition
            {
                Code = 1,
                GnEenh = 2,
                GnGnK = 3,
                GnHoev = 4,
                GnStam = 5,
                MutKod = MutKod.RecordNotChanged,
                SrtCde = 6,
                StAdd = true,
                StEenh = 7,
                StHoev = 8,
                ThsrTc = 9,
                TsGneH = 11,
                TsStEh = 12
            };

            int expectedHashCode = composition.Code ^ composition.GnEenh ^ composition.GnGnK ^
                                   composition.GnHoev.GetHashCode() ^ composition.GnStam ^
                                   (byte)composition.MutKod ^ composition.SrtCde ^ composition.StAdd.GetHashCode() ^
                                   composition.StEenh ^ composition.StHoev.GetHashCode() ^
                                   composition.ThsrTc ^ composition.TsGneH ^ composition.TsStEh;

            var comparer = new CompositionComparer();
            int result = comparer.GetHashCode(composition);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
