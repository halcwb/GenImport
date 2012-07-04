using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class GenericNameMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_GenericName()
        {
            new PersistenceSpecification<GenericName>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.GnGnAm, "Generic Name")
                .CheckProperty(b => b.Id, 1)
                .VerifyTheMappings();
        }
    }
}
