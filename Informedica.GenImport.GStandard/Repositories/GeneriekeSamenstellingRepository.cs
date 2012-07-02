using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class GeneriekeSamenstellingRepository : NHibernateRepository<GeneriekeSamenstelling, int>
    {
        public GeneriekeSamenstellingRepository(ISessionFactory factory)
            : base(factory)
        {
        }
    }
}
