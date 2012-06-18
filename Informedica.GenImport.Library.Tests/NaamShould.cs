using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class NaamShould
    {
        private readonly Type _naamType = typeof(Naam);
        private const BindingFlags TestBindingFlags = BindingFlags.Public | BindingFlags.Instance;

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_All_Known_Public_Properties()
        {
            var naam = new Naam();
            var expectedPositionsOnProperties = new Dictionary<MemberInfo, int[]>
            {
                {ReflectionUtility.GetMemberInfo(() => naam.MutKod), new[]{5, 5}},
                {ReflectionUtility.GetMemberInfo(() => naam.NmNr), new[]{6, 12}},
                {ReflectionUtility.GetMemberInfo(() => naam.NmMemo), new[]{13, 18}},
                {ReflectionUtility.GetMemberInfo(() => naam.NmEtiket), new[]{19, 45}},
                {ReflectionUtility.GetMemberInfo(() => naam.NmNm40), new[]{46, 85}},
                {ReflectionUtility.GetMemberInfo(() => naam.NmNaam), new[]{86, 135}},
            };

            Assert.AreEqual(expectedPositionsOnProperties.Count, _naamType.GetProperties(TestBindingFlags).Count(),
                            "All properties must be tested on LinePositionAttribute");

            foreach (var expectedPositionsOnProperty in expectedPositionsOnProperties)
            {
                CheckIfPropertyHasLinePositionAttribute(expectedPositionsOnProperty);
            }
        }

        private static void CheckIfPropertyHasLinePositionAttribute(KeyValuePair<MemberInfo, int[]> expectedPositionsOnProperty)
        {
            var propertyInfo = expectedPositionsOnProperty.Key;
            int expectedStartPosition = expectedPositionsOnProperty.Value[0];
            int expectedEndPosition = expectedPositionsOnProperty.Value[1];
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(propertyInfo);

            Assert.IsNotNull(attribute, "Property should have a LinePositionAttribute");
            Assert.AreEqual(expectedStartPosition, attribute.StartPosition);
            Assert.AreEqual(expectedEndPosition, attribute.EndPosition);
        }
    }
}