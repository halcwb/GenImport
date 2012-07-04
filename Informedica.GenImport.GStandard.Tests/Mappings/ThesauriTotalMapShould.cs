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
    public class ThesauriTotalMapShould : TestSessionContext
    {
        [TestMethod]
        public void Correctly_Map_ThesauriTotal()
        {
            new PersistenceSpecification<ThesauriTotal>(CurrentSession)
                .CheckProperty(b => b.Id, 1)
                .CheckProperty(b => b.MutKod, MutKod.RecordNotChanged)
                .CheckProperty(b => b.ThAKd1, 'A')
                .CheckProperty(b => b.ThAKd2, 'B')
                .CheckProperty(b => b.ThAKd3, 'C')
                .CheckProperty(b => b.ThAKd4, 'D')
                .CheckProperty(b => b.ThAKd5, 'E')
                .CheckProperty(b => b.ThAKd6, 'F')
                .CheckProperty(b => b.ThItMk, "ThItMk")
                .CheckProperty(b => b.ThNm15, "ThNm15")
                .CheckProperty(b => b.ThNm25, "ThNm25")
                .CheckProperty(b => b.ThNm4, "ThNm4")
                .CheckProperty(b => b.ThNm50, "ThNm50")
                .CheckProperty(b => b.TsItNr, 1)
                .CheckProperty(b => b.TsNr, (short)1)
                .VerifyTheMappings();
        }
    }
}
