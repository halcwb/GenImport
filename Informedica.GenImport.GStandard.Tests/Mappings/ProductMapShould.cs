using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class ProductMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_Product()
        {
            new PersistenceSpecification<Product>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.AtNmNr, 123)
                .CheckProperty(b => b.HpKode, 456)
                .VerifyTheMappings();
        }
    }
}
