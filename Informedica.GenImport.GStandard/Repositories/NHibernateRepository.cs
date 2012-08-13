using System.Collections.Generic;
using Informedica.DataAccess.Repositories;
using Informedica.EntityRepository.Entities;
using NHibernate;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class NHibernateRepository<TEnt> : NHibernateRepository<TEnt, int>, IRepository<TEnt>
        where TEnt : class, IEntity<TEnt, int>
    {
        private readonly IEqualityComparer<TEnt> _comparer;

        public NHibernateRepository(ISessionFactory sessionFactory, IEqualityComparer<TEnt> comparer)
            : base(sessionFactory)
        {
            _comparer = comparer;
        }

        public override void Add(TEnt entity)
        {
            Add(entity, _comparer);
        }

        public void Add(IEnumerable<TEnt> entities)
        {
            Transact(() => AddEntities(entities));
        }

        private void AddEntities(IEnumerable<TEnt> entities)
        {
            foreach (var entity in entities)
            {
                Session.Save(entity);
            }
        }
    }
}
