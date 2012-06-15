using System;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Informedica.GenImport.Library.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class NaamShould
    {
        private readonly Type _naamType = typeof(Naam);
        private const BindingFlags TestBindingFlags = BindingFlags.Public | BindingFlags.Instance;

        [TestMethod]
        public void Have_A_LinePositionAttribute_On_All_Known_Public_Properties()
        {
            var expectedPositionsOnProperties = new Dictionary<string, int[]>{
                                                                                 {"MutKod", new[]{5, 5}},
                                                                                 {"NmNr", new[]{6, 12}},
                                                                                 {"NmMemo", new[]{13, 18}},
                                                                                 {"NmEtiket", new[]{19, 45}},
                                                                                 {"NmNm40", new[]{46, 85}},
                                                                                 {"NmNaam", new[]{86, 135}},
                                                                             };

            Assert.AreEqual(expectedPositionsOnProperties.Count, _naamType.GetProperties(TestBindingFlags).Count(),
                            "All properties must be tested on LinePositionAttribute");

            foreach (var expectedPositionsOnProperty in expectedPositionsOnProperties)
            {
                CheckIfPropertyHasLinePositionAttribute(expectedPositionsOnProperty);
            }
        }

        private void CheckIfPropertyHasLinePositionAttribute(KeyValuePair<string, int[]> expectedPositionsOnProperty)
        {
            var propertyInfo = _naamType.GetProperty(expectedPositionsOnProperty.Key, BindingFlags.Public | BindingFlags.Instance);
            int expectedStartPosition = expectedPositionsOnProperty.Value[0];
            int expectedEndPosition = expectedPositionsOnProperty.Value[1];
            var attribute = GetAttribute<FileLinePositionAttribute>(propertyInfo);

            Assert.IsNotNull(attribute, "Property should have a LinePositionAttribute");
            Assert.AreEqual(expectedStartPosition, attribute.StartPosition);
            Assert.AreEqual(expectedEndPosition, attribute.EndPosition);
        }

        private static TAttribute GetAttribute<TAttribute>(MemberInfo member)
             where TAttribute : Attribute
        {
            if (member == null) throw new ArgumentNullException("member");
            return member.GetCustomAttributes(typeof(TAttribute), false).SingleOrDefault() as TAttribute;
        }
    }
}