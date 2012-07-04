using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class GenericCompositionMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_GenericComposition()
        {
            new PersistenceSpecification<GenericComposition>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.GnMomH, 123456745.456m)
                .CheckProperty(b => b.GnMwHs, SubstanceIndication.H)
                .CheckProperty(b => b.GsKode, 1)
                .CheckProperty(b => b.XnMomE, (short)1)
                .CheckProperty(b => b.XpEhHv, (short)1)
                .CheckProperty(b => b.GnNkPk, 1)
                .VerifyTheMappings();
        }
    }
}
