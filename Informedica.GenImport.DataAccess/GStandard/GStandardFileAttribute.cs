using System;

namespace Informedica.GenImport.DataAccess.GStandard
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GStandardFileAttribute : Attribute
    {
        public string FileName { get; private set; }

        public GStandardFileAttribute(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException(fileName);
            FileName = fileName;
        }
    }
}
