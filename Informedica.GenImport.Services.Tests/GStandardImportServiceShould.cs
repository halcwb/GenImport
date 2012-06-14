using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Services.Tests
{
    [TestClass]
    public class GStandardImportServiceShould
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_If_Constructor_Is_Called_With_Database_Directory_Null()
        {

        }

        [TestMethod]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void Throw_DirectoryNotFoundException_If_Constructor_Is_Called_With_Invalid_Database_Directory()
        {

        }

        [TestMethod]
        public void Start_Watching_Database_Directory_For_Changes_When_Started()
        {
            IImportService importService = new GStandardImportService(@"c:\temp");
            importService.Start();
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void Stop_Watching_Database_Directory_For_Changes_When_Stopped()
        {
            IImportService importService = new GStandardImportService(@"c:\temp");
            importService.Stop();
            Assert.IsTrue(false);
        }
    }
}
