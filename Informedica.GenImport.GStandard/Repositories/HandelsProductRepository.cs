using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class HandelsProductRepository : NHibernateRepository<HandelsProduct, int>
    {
        public HandelsProductRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
