using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class PrescriptionProductComparerShould
    {
        private static IPrescriptionProduct GetPrescriptionProduct()
        {
            return new PrescriptionProduct
            {
                MutKod = MutKod.RecordNotChanged,
                PrKode = 1,
                PrNmNr = 2
            };
        }

        [TestMethod]
        public void Equal_When_All_Fields_Are_Equal()
        {
            var x = GetPrescriptionProduct();
            var y = GetPrescriptionProduct();

            var comparer = new PrescriptionProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_MutKod_Is_Different()
        {
            var x = GetPrescriptionProduct();
            var y = GetPrescriptionProduct();
            y.MutKod = MutKod.RecordUpdated;

            var comparer = new PrescriptionProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_PrKode_Is_Different()
        {
            var x = GetPrescriptionProduct();
            var y = GetPrescriptionProduct();
            y.PrKode = 2;

            var comparer = new PrescriptionProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_PrNmNr_Is_Different()
        {
            var x = GetPrescriptionProduct();
            var y = GetPrescriptionProduct();
            y.PrNmNr = 3;

            var comparer = new PrescriptionProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_Fields()
        {
            var prescriptionProduct = GetPrescriptionProduct();
            int expectedHashCode = (byte)prescriptionProduct.MutKod ^ prescriptionProduct.PrKode ^
                                   prescriptionProduct.PrNmNr;

            var comparer = new PrescriptionProductComparer();
            int result = comparer.GetHashCode(prescriptionProduct);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
