using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class PrescriptieProductRepository : NHibernateRepository<PrescriptieProduct, int>
    {
        public PrescriptieProductRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
