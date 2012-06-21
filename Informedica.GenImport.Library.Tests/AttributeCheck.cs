﻿using System.Collections.Generic;
using System.Reflection;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    internal static class AttributeCheck
    {
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

        internal static void CheckIfPropertyHasModulo11Attribute(MemberInfo memberInfo)
        {
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(memberInfo);

            Assert.IsNotNull(attribute, "Property should have a Modulo11Attribute");
        }
    }
}
