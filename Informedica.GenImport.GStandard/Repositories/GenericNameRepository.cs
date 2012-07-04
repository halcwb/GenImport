using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class GenericNameRepository : NHibernateRepository<GenericName, int>
    {
        public GenericNameRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
