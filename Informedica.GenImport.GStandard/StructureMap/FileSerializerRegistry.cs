using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using Informedica.GenImport.GStandard.Serialization;
using Informedica.GenImport.Library.Serialization;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class FileSerializerRegistry : Registry
    {
        public FileSerializerRegistry()
        {
            For<IFileSerializer<ICommercialProduct>>().Use<GStandardFileSerializer<CommercialProduct>>();
            For<IFileSerializer<IComposition>>().Use<GStandardFileSerializer<Composition>>();
            For<IFileSerializer<IGenericComposition>>().Use<GStandardFileSerializer<GenericComposition>>();
            For<IFileSerializer<IGenericName>>().Use<GStandardFileSerializer<GenericName>>();
            For<IFileSerializer<IGenericProduct>>().Use<GStandardFileSerializer<GenericProduct>>();
            For<IFileSerializer<IName>>().Use<GStandardFileSerializer<Name>>();
            For<IFileSerializer<IPrescriptionProduct>>().Use<GStandardFileSerializer<PrescriptionProduct>>();
            For<IFileSerializer<IProduct>>().Use<GStandardFileSerializer<Product>>();
            For<IFileSerializer<IRelationBetweenName>>().Use<GStandardFileSerializer<RelationBetweenName>>();
            For<IFileSerializer<IThesauriTotal>>().Use<GStandardFileSerializer<ThesauriTotal>>();

            For<IRepository<ICommercialProduct>>().Use<NHibernateRepository<ICommercialProduct>>();
            For<IRepository<IComposition>>().Use<NHibernateRepository<IComposition>>();
            For<IRepository<IGenericComposition>>().Use<NHibernateRepository<IGenericComposition>>();
            For<IRepository<IGenericName>>().Use<NHibernateRepository<IGenericName>>();
            For<IRepository<IGenericProduct>>().Use<NHibernateRepository<IGenericProduct>>();
            For<IRepository<IName>>().Use<NHibernateRepository<IName>>();
            For<IRepository<IPrescriptionProduct>>().Use<NHibernateRepository<IPrescriptionProduct>>();
            For<IRepository<IProduct>>().Use<NHibernateRepository<IProduct>>();
            For<IRepository<IRelationBetweenName>>().Use<NHibernateRepository<IRelationBetweenName>>();
            For<IRepository<IThesauriTotal>>().Use<NHibernateRepository<IThesauriTotal>>();



        }
    }
}
