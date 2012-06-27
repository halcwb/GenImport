using FluentNHibernate.Cfg;
using Informedica.DataAccess.Configurations;
using Informedica.GenImport.GStandard.Mappings;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;

namespace Informedica.GenImport.GStandard.DataAccess
{
    public static class SessionFactoryManager
    {
        public const string Test = "TestGenImport";

        static SessionFactoryManager()
        {
            ConfigurationManager.Instance.AddInMemorySqLiteEnvironment<NaamMap>(Test);
        }

        public static ISessionFactory GetSessionFactory()
        {
            return GetSessionFactory(Test);
        }

        public static void BuildSchema(string environment)
        {
            GetEnvironmentConfiguration(environment).BuildSchema();
        }

        public static ISessionFactory GetSessionFactory(string environment)
        {
            return GetEnvironmentConfiguration(environment).GetSessionFactory();
        }

        private static IEnvironmentConfiguration GetEnvironmentConfiguration(string name)
        {
            if (name == Test) return new EnvironmentConfiguration(name, GetConfig(), GetDbConfig());
            return ConfigurationManager.Instance.GetConfiguration(name);
        }

        private static IDatabaseConfig GetDbConfig()
        {
            return new SqLiteConfig();
        }

        private static Configuration GetConfig()
        {
            var config = Fluently.Configure()
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<NaamMap>())
                .CurrentSessionContext<ThreadStaticSessionContext>()
                .ExposeConfiguration(x => x.SetProperty("connection.release_mode", "on_close"));
            return config.Database(GetDbConfig().Configurer).BuildConfiguration();
        }
    }
}
