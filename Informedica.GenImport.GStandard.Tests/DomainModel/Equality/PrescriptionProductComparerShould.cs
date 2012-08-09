using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class PrescriptionProductComparerShould
    {
        [TestMethod]
        public void Equal_When_PrKode_Are_Equal()
        {
            var x = new PrescriptionProduct { PrKode = 2 };
            var y = new PrescriptionProduct { PrKode = 2 };

            var comparer = new PrescriptionProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_PrKode_Are_Different()
        {
            var x = new PrescriptionProduct { PrKode = 2 };
            var y = new PrescriptionProduct { PrKode = 3 };

            var comparer = new PrescriptionProductComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_PrKode()
        {
            var prescriptionProduct = new PrescriptionProduct { PrKode = 3 };
            int expectedHashCode = prescriptionProduct.PrKode.GetHashCode();

            var comparer = new PrescriptionProductComparer();
            int result = comparer.GetHashCode(prescriptionProduct);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
