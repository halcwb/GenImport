using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class GenericProductMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_GenericProduct()
        {
            new PersistenceSpecification<GenericProduct>(CurrentSession)
                .CheckProperty(b => b.Id, 1)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.GpInSt, "A")
                .CheckProperty(b => b.GpKtVr, (short)1)
                .CheckProperty(b => b.GpKTwg, (short)1)
                .CheckProperty(b => b.GpNmNr, 1)
                .CheckProperty(b => b.GpStNr, 1)
                .CheckProperty(b => b.GsKode, 1)
                .CheckProperty(b => b.SpKode, 1)
                .CheckProperty(b => b.ThEhHv, (short)1)
                .CheckProperty(b => b.ThKtVr, (short)1)
                .CheckProperty(b => b.XpEhHv, (short)1)
                .VerifyTheMappings();
        }
    }
}
