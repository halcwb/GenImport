using System.Collections.Generic;
using Informedica.DataAccess.Repositories;
using Informedica.EntityRepository.Entities;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class NHibernateRepository<TEnt> : NHibernateRepository<TEnt, int>, IRepository<TEnt>
        where TEnt : class, IEntity<TEnt, int>
    {
        public readonly IEqualityComparer<TEnt> Comparer;

        public NHibernateRepository(ISessionFactory factory, IEqualityComparer<TEnt> comparer) : base(factory)
        {
            Comparer = comparer;
        }

        public override void Add(TEnt entity)
        {
            base.Add(entity, Comparer);
        }
    }
}
