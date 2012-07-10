using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Informedica.GenImport.GStandard.Repositories;
using StructureMap.Configuration.DSL;

namespace Informedica.GenImport.GStandard.StructureMap
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For<IRepository<ICommercialProduct>>().Use<NHibernateRepository<ICommercialProduct>>();
            For<IRepository<IComposition>>().Use<NHibernateRepository<IComposition>>();
            For<IRepository<IGenericComposition>>().Use<NHibernateRepository<IGenericComposition>>();
            For<IRepository<IGenericName>>().Use<NHibernateRepository<IGenericName>>();
            For<IRepository<IGenericProduct>>().Use<NHibernateRepository<IGenericProduct>>();
            For<IRepository<IName>>().Use<NHibernateRepository<IName>>();
            For<IRepository<IProduct>>().Use<NHibernateRepository<IProduct>>();
            For<IRepository<IRelationBetweenName>>().Use<NHibernateRepository<IRelationBetweenName>>();
            For<IRepository<IThesauriTotal>>().Use<NHibernateRepository<IThesauriTotal>>();
        }
    }
}
