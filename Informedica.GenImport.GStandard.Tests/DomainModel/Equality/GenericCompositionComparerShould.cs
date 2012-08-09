using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.DomainModel.Equality
{
    [TestClass]
    public class GenericCompositionComparerShould
    {
        [TestMethod]
        public void Equal_When_GnMwHs_GsKode_GnNkPk_Are_Equal()
        {
            var x = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 1, GnNkPk = 2 };
            var y = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 1, GnNkPk = 2 };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnMwHs_Are_Different()
        {
            var x = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 1, GnNkPk = 2 };
            var y = new GenericComposition { GnMwHs = SubstanceIndication.W, GsKode = 1, GnNkPk = 2 };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GsKode_Are_Different()
        {
            var x = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 1, GnNkPk = 2 };
            var y = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 4, GnNkPk = 2 };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Not_Equal_When_GnNkPk_Are_Different()
        {
            var x = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 1, GnNkPk = 2 };
            var y = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 1, GnNkPk = 4 };

            var comparer = new GenericCompositionComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_GnMwHs_GsKode_GnNkPk()
        {
            var genericComposition = new GenericComposition { GnMwHs = SubstanceIndication.H, GsKode = 2, GnNkPk = 3 };
            int expectedHashCode = genericComposition.GnMwHs.GetHashCode() + genericComposition.GsKode.GetHashCode() +
                                   genericComposition.GnNkPk.GetHashCode();

            var comparer = new GenericCompositionComparer();
            int result = comparer.GetHashCode(genericComposition);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
