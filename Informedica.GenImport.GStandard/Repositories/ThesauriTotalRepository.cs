using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class ThesauriTotalRepository : NHibernateRepository<ThesauriTotal, int>
    {
        public ThesauriTotalRepository(ISessionFactory factory) : base(factory)
        {
        }
    }
}
