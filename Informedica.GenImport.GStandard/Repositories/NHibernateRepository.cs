using System.Linq;
using System.Collections.Generic;
using Informedica.DataAccess.Repositories;
using Informedica.EntityRepository.Entities;
using NHibernate;
using NHibernate.Context;

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
           Add(entity, Comparer);
        }

        protected override ISession Session
        {
            get
            {
#warning hack, remove
                //TODO temporary fix, should be removed later!
                if(!CurrentSessionContext.HasBind(Factory))
                {
                    CurrentSessionContext.Bind(Factory.OpenSession());
                }
                return base.Session;
            }
        }

        ///// <summary>
        ///// Will save without Transact, because of UnitOfWork implementation.
        ///// </summary>
        ///// <param name="item"></param>
        ///// <param name="comparer"></param>
        //public override void Add(TEnt item, IEqualityComparer<TEnt> comparer)
        //{
        //    //TODO add or update
        //    if (this.Contains(item, comparer)) return;
        //    Session.Save(item);
        //}

        //public ISessionFactory SessionFactory { get { return Factory; } }

        public IQuery CreateSqlQuery(string query)
        {
            return Session.CreateSQLQuery(query);
        }
    }
}
