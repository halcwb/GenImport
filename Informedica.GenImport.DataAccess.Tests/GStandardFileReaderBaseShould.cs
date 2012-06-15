using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.DataAccess.Tests
{
    [TestClass]
    public class GStandardFileReaderBaseShould
    {
        #region Helpers
        private class GStandardFileReaderBaseMock : GStandardFileReaderBase<Naam>
        {
            public new Naam ParseLineToModel(string line)
            {
                return base.ParseLineToModel(line);
            }
        }
        #endregion

        [TestMethod]
        public void Be_Able_To_Parse_A_FileLine_To_The_GStandard_Model()
        {
            const string line =
                @"002000000005ABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000";

            const MutKod expectedMutKod = MutKod.RecordNotChanged;
            const int expectedNmNr = 5;
            const string expectedNmMemo = "ABC V5";
            const string expectedNmEtiket = "ABC VERB NR2  5MX2,5CM";
            const string expectedNmNm40 = "ABC VERBAND";
            const string expectedNmNaam = "ABC VERBAND NR2  5,00MX2,50CM";

            GStandardFileReaderBaseMock gStandardFileReaderBaseMock = new GStandardFileReaderBaseMock();
            var naam = gStandardFileReaderBaseMock.ParseLineToModel(line);
            
            Assert.AreEqual(expectedMutKod, naam.MutKod);
            Assert.AreEqual(expectedNmNr, naam.NmNr);
            Assert.AreEqual(expectedNmMemo, naam.NmMemo);
            Assert.AreEqual(expectedNmEtiket, naam.NmEtiket);
            Assert.AreEqual(expectedNmNm40, naam.NmNm40);
            Assert.AreEqual(expectedNmNaam, naam.NmNaam);
        }

        [TestMethod]
        [ExpectedException(typeof(CannotParseLineException))]
        public void Throw_CannotParseLineException_When_MutKot_From_FileLine_Cannot_Be_Parsed()
        {
            //Pos 11 (12 in G-Standard) is wrong
            const string line =
                @"00200000000ZABC V5ABC VERB NR2  5MX2,5CM     ABC VERBAND                             ABC VERBAND NR2  5,00MX2,50CM                     0000000000000000000000000";

            GStandardFileReaderBaseMock gStandardFileReaderBaseMock = new GStandardFileReaderBaseMock();
            gStandardFileReaderBaseMock.ParseLineToModel(line);
        }

        [TestMethod]
        public void Skip_FileLine_And_Log_When_Exception_Is_Thrown_On_FileLine()
        {
            //TODO create logic
            Assert.Fail();
        }
    }
}