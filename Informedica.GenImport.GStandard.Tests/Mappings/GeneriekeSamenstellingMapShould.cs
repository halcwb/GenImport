using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class GeneriekeSamenstellingMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_GeneriekeSamenstelling()
        {
            new PersistenceSpecification<GeneriekeSamenstelling>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.GnMomH, 123456745.456m)
                .CheckProperty(b => b.GnMwHs, StofAanduiding.H)
                .CheckProperty(b => b.GsKode, 1)
                .CheckProperty(b => b.XnMomE, (short)1)
                .CheckProperty(b => b.XpEhHv, (short)1)
                .CheckProperty(b => b.GnNkPk, 1)
                .VerifyTheMappings();
        }
    }
}
