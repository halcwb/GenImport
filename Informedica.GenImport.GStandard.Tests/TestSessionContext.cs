using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Informedica.GenImport.GStandard.Mappings;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace Informedica.GenImport.GStandard.Tests
{
    public class TestSessionContext
    {
        protected static ISession CurrentSession { 
            get { return GetSessionFactory().GetCurrentSession(); }
        }

        protected static ISessionFactory GetSessionFactory()
        {
            return GetSessionFactory(x => x.FluentMappings.AddFromAssemblyOf<NameMap>());
        }

        protected static ISessionFactory GetSessionFactory(Action<MappingConfiguration> mappings)
        {
            var config = Fluently.Configure().Database(SQLiteConfiguration.Standard.InMemory())
                .Mappings(mappings)
                .CurrentSessionContext<ThreadStaticSessionContext>()
                .BuildConfiguration();
            var fact = config.BuildSessionFactory();

            CurrentSessionContext.Bind(fact.OpenSession());
            new SchemaExport(config).Execute(true, true, false, fact.GetCurrentSession().Connection, null);

            return fact;
        }
    }
}
