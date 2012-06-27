using Informedica.GenImport.GStandard.DomainModel;
using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class NaamRepository : NHibernateRepository<Naam, int>
    {
        public readonly NaamComparer Comparer = new NaamComparer();
        
        public NaamRepository(ISessionFactory factory) : base(factory) { }

        public override void Add(Naam item)
        {
            base.Add(item, Comparer);
        }
    }
}
