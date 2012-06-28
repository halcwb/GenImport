using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Informedica.GenImport.GStandard.DomainModel.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class NaamMappingShould : TestSessionContext
    {
        [TestMethod]
        public void CorrectlyMapNaam()
        {
            new PersistenceSpecification<Naam>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.NmEtiket, "etiket")
                .CheckProperty(b => b.NmMemo, "memo")
                .CheckProperty(b => b.NmNaam, "naam")
                .CheckProperty(b => b.NmNm40, "naam40")
                .CheckProperty(b => b.Id, 1)
                .VerifyTheMappings();
        }
    }
}
