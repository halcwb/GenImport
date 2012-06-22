using System;
using System.Collections.Generic;
using System.Reflection;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    internal static class AttributeCheck
    {
        public const string HasNoOrInvalidLinePositionAttributeMessage = "{0} has an invalid or missing LinePositionAttribute.";
        public const string HasNoModulo11AttributeMessage = "{0} has a missing Modulo11Attribute.";

        [Obsolete]
        internal static void CheckIfPropertyHasLinePositionAttribute(KeyValuePair<MemberInfo, int[]> expectedPositionsOnProperty)
        {
            var propertyInfo = expectedPositionsOnProperty.Key;
            int expectedStartPosition = expectedPositionsOnProperty.Value[0];
            int expectedEndPosition = expectedPositionsOnProperty.Value[1];
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(propertyInfo);

            Assert.IsNotNull(attribute, string.Format("Property {0} should have a LinePositionAttribute", propertyInfo.Name));
            Assert.AreEqual(expectedStartPosition, attribute.StartPosition);
            Assert.AreEqual(expectedEndPosition, attribute.EndPosition);
        }

        internal static bool HasValidLinePositionAttributeOnProperty(MemberInfo propertyInfo, int expectedStartPosition, int expectedEndPosition)
        {
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(propertyInfo);

            return attribute != null && expectedStartPosition == attribute.StartPosition &&
                   expectedEndPosition == attribute.EndPosition;
        }

        internal static bool HasModulo11AttributeOnProperty(MemberInfo memberInfo)
        {
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(memberInfo);
            return attribute != null;
        }
    }
}
