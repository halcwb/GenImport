using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class GeneriekeNaamMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_GeneriekeNaam()
        {
            new PersistenceSpecification<GeneriekeNaam>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.GnGnAm, "Generieke Naam")
                .CheckProperty(b => b.Id, 1)
                .VerifyTheMappings();
        }
    }
}
