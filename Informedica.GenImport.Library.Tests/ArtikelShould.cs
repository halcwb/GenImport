using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class ArtikelShould
    {
        private readonly Type _artikelType = typeof(Artikel);
        private const BindingFlags TestBindingFlags = BindingFlags.Public | BindingFlags.Instance;

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_All_Known_Properties()
        {
            var artikel = new Artikel();
            var expectedPositionsOnProperties = new Dictionary<MemberInfo, int[]>
            {
                {ReflectionUtility.GetMemberInfo(() => artikel.MutKod), new[]{5, 5}},
                {ReflectionUtility.GetMemberInfo(() => artikel.AtKode), new[]{6, 13}},
                {ReflectionUtility.GetMemberInfo(() => artikel.HpKode), new[]{14, 21}},
                {ReflectionUtility.GetMemberInfo(() => artikel.AtNmNr), new[]{22, 28}},
            };

            Assert.AreEqual(expectedPositionsOnProperties.Count, _artikelType.GetProperties(TestBindingFlags).Count(),
                            "All properties must be tested on LinePositionAttribute");

            foreach (var expectedPositionsOnProperty in expectedPositionsOnProperties)
            {
                AttributeCheck.CheckIfPropertyHasLinePositionAttribute(expectedPositionsOnProperty);
            }
        }

        [TestMethod]
        public void Have_A_Modulo11Attribute_On_Known_Properties()
        {
            var artikel = new Artikel();
            var expectedProperties = new[]{
                                              ReflectionUtility.GetMemberInfo(() => artikel.AtKode),
                                              ReflectionUtility.GetMemberInfo(() => artikel.HpKode)
                                          };

            Assert.AreEqual(expectedProperties.Count(),
                            _artikelType.GetProperties(TestBindingFlags).Sum(
                                a => a.GetCustomAttributes(typeof (Modulo11Attribute), true).Count()),
                            "Only expected properties must have a Modulo11Attribute.");

            foreach (var expectedProperty in expectedProperties)
            {
                AttributeCheck.CheckIfPropertyHasModulo11Attribute(expectedProperty);
            }
        }
    }
}