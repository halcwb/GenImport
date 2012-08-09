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
    public class NameComparerShould
    {
        [TestMethod]
        public void Equal_When_NmNr_Are_Equal()
        {
            var x = new Name { NmNr = 2 };
            var y = new Name { NmNr = 2 };

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Not_Equal_When_NmNr_Are_Different()
        {
            var x = new Name { NmNr = 2 };
            var y = new Name { NmNr = 3 };

            var comparer = new NameComparer();
            bool result = comparer.Equals(x, y);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_Correct_HashCode_From_NmNr()
        {
            var name = new Name { NmNr = 3 };
            int expectedHashCode = name.NmNr.GetHashCode();

            var comparer = new NameComparer();
            int result = comparer.GetHashCode(name);

            Assert.AreEqual(expectedHashCode, result);
        }
    }
}
