using Informedica.GenImport.GStandard.DomainModel;
using Informedica.DataAccess.Repositories;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class NaamRepository : NHibernateRepository<Naam, int>
    {
        public NaamRepository(ISessionFactory factory) : base(factory) { }

        public override void Add(Naam item)
        {
            //base.Add(item, Comparer);
        }
    }
}
