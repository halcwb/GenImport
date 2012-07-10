using Informedica.GenImport.GStandard.StructureMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using StructureMap;

namespace Informedica.GenImport.GStandard.Tests
{
    [TestClass]
    public class StructureMap : TestSessionContext
    {
        [TestMethod]
        public void Be_Able_To_Initialize_From_Its_Configuration()
        {
            ObjectFactory.Initialize(x=>
                                     {
                                         x.For<ISessionFactory>().Use(GetSessionFactory());
                                         x.AddRegistry<EqualityRegistry>();
                                         x.AddRegistry<FileSerializerRegistry>();   
                                         x.AddRegistry<RepositoryRegistry>();
                                         x.AddRegistry<ServiceRegistry>();
                                     } );

            ObjectFactory.AssertConfigurationIsValid();
        }
    }
}
