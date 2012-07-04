using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class CompositionMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_Composition()
        {
            new PersistenceSpecification<Composition>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.Code, 1)
                .CheckProperty(b => b.GnEenh, 1)
                .CheckProperty(b => b.GnGnK, 1)
                .CheckProperty(b => b.GnHoev, 1.0m)
                .CheckProperty(b => b.GnStam, 1)
                .CheckProperty(b => b.SrtCde, 1)
                .CheckProperty(b => b.StAdd, true)
                .CheckProperty(b => b.StEenh, 1)
                .CheckProperty(b => b.StHoev, 1.5m)
                .CheckProperty(b => b.ThsrTc, (short)1)
                .CheckProperty(b => b.TsGneH, (short)1)
                .CheckProperty(b => b.TsStEh, (short)1)
                .VerifyTheMappings();
        }
    }
}
