using System;
using System.Reflection;
using System.Text;
using System.Collections.Generic;
using System.Linq;
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
        public void Have_A_LinePositionAttribute_On_All_Known_Public_Properties()
        {
            var naam = new Artikel();
            var expectedPositionsOnProperties = new Dictionary<MemberInfo, int[]>
            {
                {ReflectionUtility.GetMemberInfo(() => naam.MutKod), new[]{5, 5}},
                {ReflectionUtility.GetMemberInfo(() => naam.AtKode), new[]{6, 13}},
                {ReflectionUtility.GetMemberInfo(() => naam.HpKode), new[]{14, 21}},
                {ReflectionUtility.GetMemberInfo(() => naam.AtNmNr), new[]{22, 28}},
            };

            Assert.AreEqual(expectedPositionsOnProperties.Count, _artikelType.GetProperties(TestBindingFlags).Count(),
                            "All properties must be tested on LinePositionAttribute");

            foreach (var expectedPositionsOnProperty in expectedPositionsOnProperties)
            {
                AttributeCheck.CheckIfPropertyHasLinePositionAttribute(expectedPositionsOnProperty);
            }
        }
    }
}