using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Informedica.GenImport.Acceptance
{
    public class ImportGStandardTextFilesScenarios
    {
        public bool DirectoryExists(string directory)
        {
            return true;
        }

        public bool CanFindGStandardFilesInDirectory(string directory)
        {
            return false;
        }

        public bool CanReadProductsFromGStandardFilesInDirectory(string directory)
        {
            return false;
        }
    }
}
