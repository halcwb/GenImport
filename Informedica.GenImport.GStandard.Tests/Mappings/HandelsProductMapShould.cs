using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class HandelsProductMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_HandelsProduct()
        {
            const int id = 1;
            new PersistenceSpecification<HandelsProduct>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.FsNaam, "Firma stam naam")
                .CheckProperty(b => b.HpKode, id)
                .CheckProperty(b=>b.HpNamN, 1)
                .CheckProperty(b=>b.MsNaam, "Merk stam naam")
                .CheckProperty(b=>b.TsEmbM, (short)1)
                .CheckProperty(b=>b.XsEmbM, 1)
                .VerifyTheMappings();
        }
    }
}
