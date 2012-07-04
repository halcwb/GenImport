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
            var config = Fluently.Configure().Database(SQLiteConfiguration.Standard.UsingFile("c:/tmp/test.db")) // InMemory())
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<NameMap>())
                .CurrentSessionContext<ThreadStaticSessionContext>()
                .ExposeConfiguration(x => x.SetProperty("prepare_sql", "true"))
                .BuildConfiguration();
            var fact = config.BuildSessionFactory();

            CurrentSessionContext.Bind(fact.OpenSession());
            new SchemaExport(config).Execute(true, true, false, fact.GetCurrentSession().Connection, null);

            return fact;
        }

    }
}
