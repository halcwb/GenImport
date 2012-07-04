using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class GenericCompositionRepository : NHibernateRepository<GenericComposition, int>
    {
        public GenericCompositionRepository(ISessionFactory factory)
            : base(factory)
        {
        }
    }
}
