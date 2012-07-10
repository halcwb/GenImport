using System.Configuration;
using System.IO;
using Informedica.GenImport.GStandard.Configuration;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.Services;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            GStandardConfigurationSection config = (GStandardConfigurationSection)ConfigurationManager.GetSection("GStandard");

            For<IImportService>().Singleton().Use<GStandardImportService>(); //singleton

            For<IImportService<ICommercialProduct>>().Use<ImportService<ICommercialProduct>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder,config.CommercialProductFile.FileName));

            For<IImportService<IComposition>>().Use<ImportService<IComposition>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.CompostionFile.FileName));

            For<IImportService<IGenericComposition>>().Use<ImportService<IGenericComposition>>();
            For<IImportService<IGenericName>>().Use<ImportService<IGenericName>>();
            For<IImportService<IGenericProduct>>().Use<ImportService<IGenericProduct>>();
            For<IImportService<IName>>().Use<ImportService<IName>>();
            For<IImportService<IPrescriptionProduct>>().Use<ImportService<IPrescriptionProduct>>();
            For<IImportService<IProduct>>().Use<ImportService<IProduct>>();
            For<IImportService<IRelationBetweenName>>().Use<ImportService<IRelationBetweenName>>();
            For<IImportService<IThesauriTotal>>().Use<ImportService<IThesauriTotal>>();
        }
    }
}
