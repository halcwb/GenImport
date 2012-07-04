using System.Collections.Generic;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.DataAccess.Repositories;
using Informedica.GenImport.GStandard.DomainModel.Equality;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    // ToDo make repository of type INaam
    public class NameRepository : NHibernateRepository<Name, int>
    {
        // ToDo move Comparer to constructor and make it IEqualityComparer<INaam>
        public readonly IEqualityComparer<IName> Comparer = new NameComparer();
        
        public NameRepository(ISessionFactory factory) : base(factory) { }

        public override void Add(Name item)
        {
            base.Add(item, Comparer);
        }
    }
}
