using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class CommercialProductRepository : NHibernateRepository<CommercialProduct, int>
    {
        public CommercialProductRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
