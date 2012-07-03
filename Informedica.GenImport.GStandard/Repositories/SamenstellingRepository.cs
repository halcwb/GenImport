using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class SamenstellingRepository : NHibernateRepository<Samenstelling, int>
    {
        public SamenstellingRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
