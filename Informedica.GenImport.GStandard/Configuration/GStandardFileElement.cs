using System.Configuration;

namespace Informedica.GenImport.GStandard.Configuration
{
    public class GStandardFileElement : ConfigurationElement
    {
        [ConfigurationProperty("filename", IsRequired = true)]
        public string FileName
        {
            get { return (string)this["filename"]; }
            set { this["filename"] = value; }
        }
    }
}
