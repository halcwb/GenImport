using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    // ToDo make repository of type INaam
    public class NaamRepository : NHibernateRepository<Naam, int>
    {
        // ToDo move Comparer to constructor and make it IEqualityComparer<INaam>
        public readonly IEqualityComparer<INaam> Comparer = new NaamComparer();
        
        public NaamRepository(ISessionFactory factory) : base(factory) { }

        public override void Add(Naam item)
        {
            base.Add(item, Comparer);
        }
    }
}
