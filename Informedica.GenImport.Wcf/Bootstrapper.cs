using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Informedica.GenImport.GStandard.Mappings;
using Informedica.GenImport.GStandard.StructureMap;
using NHibernate;
using NHibernate.Context;
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
            var config = Fluently.Configure().Database(SQLiteConfiguration.Standard.UsingFile("c:/tmp/test.db"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<NameMap>())
                .CurrentSessionContext<ThreadStaticSessionContext>()
                .BuildConfiguration();
            
            return config.BuildSessionFactory();
        }
    }
}