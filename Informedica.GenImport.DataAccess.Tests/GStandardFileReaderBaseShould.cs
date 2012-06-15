using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class GStandardFileReaderBaseShould
    {
        [TestMethod]
        public void Be_Able_To_Parse_A_FileLine_To_The_GStandard_Model()
        {
            const string line =
                @"002000000001AAMBZ AAMBEIENZETPIL VOGEL       AAMBEIENZETPIL VOGEL                    AAMBEIENZETPIL VOGEL                              0000000000000000000000000";
            const string line2 =
                @"002000000005ABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000";

            const MutKod expectedMutKod = MutKod.RecordNotChanged;
            const int expectedNmNr = 5;
            const string expectedNmMemo = "ABC V5";
            const string expectedNmEtiket = "ABC VERB NR2  5MX2,5CM";
            const string expectedNmNm40 = "ABC VERBAND";
            const string expectedNmNaam = "ABC VERBAND NR2  5,00MX2,50CM";

            var naam = new Naam();
            Assert.AreEqual(expectedMutKod, naam.MutKod);
            Assert.AreEqual(expectedNmNr, naam.NmNr);
            Assert.AreEqual(expectedNmMemo, naam.NmMemo);
            Assert.AreEqual(expectedNmEtiket, naam.NmEtiket);
            Assert.AreEqual(expectedNmNm40, naam.NmNm40);
            Assert.AreEqual(expectedNmNaam, naam.NmNaam);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Throw_Exception_When_A_FileLine_Cannot_Be_Parsed_To_The_GStandard_Model()
        {

        }

        [TestMethod]
        public void Skip_FileLine_And_Log_When_Exception_Is_Thrown_On_FileLine()
        {
            Assert.Fail();
        }
    }
}
