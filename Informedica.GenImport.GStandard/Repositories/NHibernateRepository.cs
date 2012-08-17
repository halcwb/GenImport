using System.Collections.Generic;
using System.Linq;
using Informedica.DataAccess.Repositories;
using Informedica.EntityRepository.Entities;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using NHibernate;
using NHibernate.Context;
using NHibernate.Linq;

namespace Informedica.GenImport.GStandard.Repositories
{
    public class NHibernateRepository<TEnt> : NHibernateRepository<TEnt, int>, IRepository<TEnt>
        where TEnt : class, IEntity<TEnt, int>, ICopyable<TEnt>
    {
        private readonly IEqualityComparer<TEnt> _comparer;

        public NHibernateRepository(ISessionFactory sessionFactory, IEqualityComparer<TEnt> comparer)
            : base(sessionFactory)
        {
            _comparer = comparer;
        }

        public override void Add(TEnt entity)
        {
            Transact(() => AddEntity(entity));
        }

        protected virtual void AddEntity(TEnt entity)
        {
            if (this.Contains(entity, _comparer)) return;
            
            var dbEntity = this.SingleOrDefault(e => e.IsIdentical(entity));

            if(dbEntity != null)
            {
                var copyable = entity as ICopyable<TEnt>;
                copyable.CopyTo(dbEntity);
            }
            else
            {
                dbEntity = entity;
            }
            Session.SaveOrUpdate(dbEntity);
        }

        public virtual void Add(IEnumerable<TEnt> entities)
        {
            Transact(() => AddEntities(entities));
        }

        protected virtual void AddEntities(IEnumerable<TEnt> entities)
        {
            foreach (var entity in entities)
            {
                AddEntity(entity);
            }
        }

        protected override ISession Session
        {
            get
            {
                if(!CurrentSessionContext.HasBind(Factory))
                {
                    CurrentSessionContext.Bind(Factory.OpenSession());
                }
                return base.Session;
            }
        }

        public virtual IQueryable<TEnt> GetQueryable()
        {
            return Session.Query<TEnt>();
        }
    }
}
