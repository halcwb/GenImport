using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class GenericProductRepository : NHibernateRepository<GenericProduct, int>
    {
        public GenericProductRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
