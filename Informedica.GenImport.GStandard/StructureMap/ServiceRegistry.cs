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

            For<IImportService<ICommercialProduct>>().Use<FileImportService<ICommercialProduct>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder,config.CommercialProductFile.FileName));

            For<IImportService<IComposition>>().Use<FileImportService<IComposition>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.CompostionFile.FileName));

            For<IImportService<IGenericComposition>>().Use<FileImportService<IGenericComposition>>();
            For<IImportService<IGenericName>>().Use<FileImportService<IGenericName>>();
            For<IImportService<IGenericProduct>>().Use<FileImportService<IGenericProduct>>();
            For<IImportService<IName>>().Use<FileImportService<IName>>();
            For<IImportService<IPrescriptionProduct>>().Use<FileImportService<IPrescriptionProduct>>();
            For<IImportService<IProduct>>().Use<FileImportService<IProduct>>();
            For<IImportService<IRelationBetweenName>>().Use<FileImportService<IRelationBetweenName>>();
            For<IImportService<IThesauriTotal>>().Use<FileImportService<IThesauriTotal>>();
        }
    }
}
