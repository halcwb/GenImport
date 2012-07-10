using System.Configuration;

namespace Informedica.GenImport.GStandard.Configuration
{
    public class GStandardConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("databaseFolder", IsRequired = true)]
        public string DatabaseFolder
        {
            get { return (string)this["databaseFolder"]; }
            set { this["databaseFolder"] = value; }
        }

        [ConfigurationProperty("commercialProductFile", IsRequired = true)]
        public GStandardFileElement CommercialProductFile {
            get { return (GStandardFileElement)this["commercialProductFile"]; }
            set { this["commercialProductFile"] = value; }
        }

        [ConfigurationProperty("compostionFile", IsRequired = true)]
        public GStandardFileElement CompostionFile
        {
            get { return (GStandardFileElement)this["compostionFile"]; }
            set { this["compostionFile"] = value; }
        }
    }
}