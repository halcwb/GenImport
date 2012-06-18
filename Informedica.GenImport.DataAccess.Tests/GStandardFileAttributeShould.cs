using System;
using Informedica.GenImport.DataAccess.GStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class GStandardFileAttributeShould
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_FileName_IsNull()
        {
            new GStandardFileAttribute(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_FileName_IsEmpty()
        {
            new GStandardFileAttribute("");
        }
    }
}
