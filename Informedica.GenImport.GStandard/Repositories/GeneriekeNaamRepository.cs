using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class GeneriekeNaamRepository : NHibernateRepository<GeneriekeNaam, int>
    {
        public GeneriekeNaamRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
