﻿using FluentNHibernate.Testing;
using Informedica.GenImport.GStandard.DomainModel;
using Informedica.GenImport.GStandard.DomainModel.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.GStandard.Tests.Mappings
{
    [TestClass]
    public class PrescriptionProductMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_PrescriptionProduct()
        {
            new PersistenceSpecification<PrescriptionProduct>(CurrentSession)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.PrKode, 1)
                .CheckProperty(b => b.PrNmNr, 1)
                .VerifyTheMappings();
        }
    }
}
