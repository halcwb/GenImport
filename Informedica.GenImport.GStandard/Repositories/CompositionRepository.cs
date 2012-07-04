using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class CompositionRepository : NHibernateRepository<Composition, int>
    {
        public CompositionRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
