using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class CompositionComparerShould
    {
        [TestMethod]
        public void Equal_Compositions_When_Keys_Are_Equal()
        {
            var x = new Composition{
                                       SrtCde = 123456,
                                       Code = 12,
                                       GnGnK = 34,
                                       GnHoev = 500,
                                       GnEenh = 2
                                   };
            var y = new Composition{
                                       SrtCde = 123456,
                                       Code = 12,
                                       GnGnK = 34,
                                       GnHoev = 500,
                                       GnEenh = 2
                                   };
            
            var comparer = new CompositionComparer();
            Assert.IsTrue(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_Compositions_When_SrtCode_Is_Different()
        {
            var x = new Composition
            {
                SrtCde = 1234567891,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };
            var y = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_Compositions_When_Code_Is_Different()
        {
            var x = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };
            var y = new Composition
            {
                SrtCde = 123456,
                Code = 15,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_Compositions_When_GnGnK_Is_Different()
        {
            var x = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };
            var y = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 36,
                GnHoev = 500,
                GnEenh = 2
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_Compositions_When_GnHoev_Is_Different()
        {
            var x = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };
            var y = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 600,
                GnEenh = 2
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Not_Equal_Compositions_When_GnEenh_Is_Different()
        {
            var x = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 1
            };
            var y = new Composition
            {
                SrtCde = 123456,
                Code = 12,
                GnGnK = 34,
                GnHoev = 500,
                GnEenh = 2
            };

            var comparer = new CompositionComparer();
            Assert.IsFalse(comparer.Equals(x, y));
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_SrtCde_Code_GnGnK_GnHoev_GnEenh()
        {
            var composition = new Composition{
                                                 Code = 1,
                                                 SrtCde = 2,
                                                 GnGnK = 3,
                                                 GnHoev = 4,
                                                 GnEenh = 5
                                             };

            int expectedHashCode = composition.Code.GetHashCode() + composition.SrtCde.GetHashCode() +
                                   composition.GnGnK.GetHashCode() + composition.GnHoev.GetHashCode() +
                                   composition.GnEenh.GetHashCode();

            var comparer = new CompositionComparer();
            int result = comparer.GetHashCode(composition);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
