using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class NameMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_Name()
        {
            new PersistenceSpecification<Name>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.NmEtiket, "etiket")
                .CheckProperty(b => b.NmMemo, "memo")
                .CheckProperty(b => b.NmNaam, "naam")
                .CheckProperty(b => b.NmNm40, "naam40")
                .VerifyTheMappings();
        }
    }
}
