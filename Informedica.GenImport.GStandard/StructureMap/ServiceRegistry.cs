using System.Configuration;
using System.IO;
using Informedica.GenImport.GStandard.Configuration;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Services;
using Informedica.GenImport.Library.Services;
using Informedica.GenImport.Library.UnitOfWork;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            RegisterImportServices();

            For<IDataService>().Use<DataService>();
            //For<IUnitOfWork>().Use<NHibernateUnitOfWork>();
        }

        private void RegisterImportServices()
        {
            GStandardConfigurationSection config = (GStandardConfigurationSection)ConfigurationManager.GetSection("GStandard");

            For<IImportService>().Singleton().Use<GStandardImportService>(); //singleton

            For<IImportService<ICommercialProduct>>().Use<FileImportService<ICommercialProduct>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.CommercialProductFile.FileName));
            For<IImportService<IComposition>>().Use<FileImportService<IComposition>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.CompostionFile.FileName));
            For<IImportService<IGenericComposition>>().Use<FileImportService<IGenericComposition>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.GenericCompostionFile.FileName));
            For<IImportService<IGenericName>>().Use<FileImportService<IGenericName>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.GenericNameFile.FileName));
            For<IImportService<IGenericProduct>>().Use<FileImportService<IGenericProduct>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.GenericProductFile.FileName));
            For<IImportService<IName>>().Use<FileImportService<IName>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.NameFile.FileName));
            For<IImportService<IPrescriptionProduct>>().Use<FileImportService<IPrescriptionProduct>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.PrescriptionProductFile.FileName));
            For<IImportService<IProduct>>().Use<FileImportService<IProduct>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.ProductFile.FileName));
            For<IImportService<IRelationBetweenName>>().Use<FileImportService<IRelationBetweenName>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.RelationBetweenNameFile.FileName));
            For<IImportService<IThesauriTotal>>().Use<FileImportService<IThesauriTotal>>()
                .Ctor<string>("databaseFilePath").Is(Path.Combine(config.DatabaseFolder, config.ThesauriTotalFile.FileName));
        }
    }
}
