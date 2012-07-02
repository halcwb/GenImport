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
            const int id = 1;
            new PersistenceSpecification<GeneriekeNaam>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.GnGnAm, "Generieke Naam")
                .CheckProperty(b => b.GnGnK, id)
                .VerifyTheMappings();
        }
    }
}
