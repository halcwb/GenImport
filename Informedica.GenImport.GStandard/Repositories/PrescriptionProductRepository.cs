using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class PrescriptionProductRepository : NHibernateRepository<PrescriptionProduct, int>
    {
        public PrescriptionProductRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
