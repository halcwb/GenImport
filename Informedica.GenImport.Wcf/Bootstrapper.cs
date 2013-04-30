using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Informedica.GenImport.GStandard.Mappings;
using Informedica.GenImport.GStandard.StructureMap;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using StructureMap;

namespace Informedica.GenImport.Wcf
{
    public static class Bootstrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Configure(x =>
            {
                x.AddRegistry<EqualityRegistry>();
                x.AddRegistry<FileSerializerRegistry>();
                x.AddRegistry<RepositoryRegistry>();
                x.AddRegistry<ServiceRegistry>();

                x.For<IWcfService>().Use<WcfService>();
                x.For<ISessionFactory>().Use(GetSessionFactory());
            });
        }

        private static ISessionFactory GetSessionFactory()
        {
            var config = Fluently.Configure().Database(SQLiteConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey("GStandardDbConnectionString")))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<NameMap>())
                .CurrentSessionContext<ThreadStaticSessionContext>()
                .BuildConfiguration();

            //Temp solution to create new database
            new SchemaExport(config).Execute(true, true, false);
            var factory = config.BuildSessionFactory();
            CurrentSessionContext.Bind(factory.OpenSession());

            return factory;
        }
    }
}