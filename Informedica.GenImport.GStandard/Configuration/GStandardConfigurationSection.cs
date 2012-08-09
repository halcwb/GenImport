using System.Configuration;

namespace Informedica.GenImport.GStandard.Configuration
{
    public class GStandardConfigurationSection : ConfigurationSection
    {
        private const string DatabaseFolderConfigurationName = "databaseFolder";
        private const string CommercialProductFileConfigurationName = "commercialProductFile";
        private const string CompostionFileConfigurationName = "compostionFile";
        private const string GenericCompostionFileConfigurationName = "GenericCompostionFile";
        private const string GenericNameFileConfigurationName = "genericNameFile";
        private const string GenericProductFileConfigurationName = "genericProductFile";
        private const string NameFileConfigurationName = "nameFile";
        private const string ProductFileConfigurationName = "productFile";
        private const string PrescriptionProductFileConfigurationName = "prescriptionProductFile";
        private const string ThesauriTotalFileConfigurationName = "thesauriTotalFile";

        [ConfigurationProperty(DatabaseFolderConfigurationName, IsRequired = true)]
        public string DatabaseFolder
        {
            get { return (string)this[DatabaseFolderConfigurationName]; }
            set { this[DatabaseFolderConfigurationName] = value; }
        }

        [ConfigurationProperty(CommercialProductFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement CommercialProductFile {
            get { return (GStandardFileConfigurationElement)this[CommercialProductFileConfigurationName]; }
            set { this[CommercialProductFileConfigurationName] = value; }
        }

        [ConfigurationProperty(CompostionFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement CompostionFile
        {
            get { return (GStandardFileConfigurationElement)this[CompostionFileConfigurationName]; }
            set { this[CompostionFileConfigurationName] = value; }
        }

        [ConfigurationProperty(GenericCompostionFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement GenericCompostionFile
        {
            get { return (GStandardFileConfigurationElement)this[GenericCompostionFileConfigurationName]; }
            set { this[GenericCompostionFileConfigurationName] = value; }
        }

        [ConfigurationProperty(GenericNameFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement GenericNameFile
        {
            get { return (GStandardFileConfigurationElement)this[GenericNameFileConfigurationName]; }
            set { this[GenericNameFileConfigurationName] = value; }
        }

        [ConfigurationProperty(GenericProductFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement GenericProductFile
        {
            get { return (GStandardFileConfigurationElement)this[GenericProductFileConfigurationName]; }
            set { this[GenericProductFileConfigurationName] = value; }
        }

        [ConfigurationProperty(NameFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement NameFile
        {
            get { return (GStandardFileConfigurationElement)this[NameFileConfigurationName]; }
            set { this[NameFileConfigurationName] = value; }
        }

        [ConfigurationProperty(PrescriptionProductFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement PrescriptionProductFile
        {
            get { return (GStandardFileConfigurationElement)this[PrescriptionProductFileConfigurationName]; }
            set { this[PrescriptionProductFileConfigurationName] = value; }
        }

        [ConfigurationProperty(ProductFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement ProductFile
        {
            get { return (GStandardFileConfigurationElement)this[ProductFileConfigurationName]; }
            set { this[ProductFileConfigurationName] = value; }
        }

        [ConfigurationProperty(ThesauriTotalFileConfigurationName, IsRequired = true)]
        public GStandardFileConfigurationElement ThesauriTotalFile
        {
            get { return (GStandardFileConfigurationElement)this[ThesauriTotalFileConfigurationName]; }
            set { this[ThesauriTotalFileConfigurationName] = value; }
        }
    }
}