using System;
using System.Linq;
using System.Reflection;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.DomainModel.Interfaces;
using Informedica.GenImport.Library.Reflection;

namespace Informedica.GenImport.Library.Tests.Attributes
{
    internal static class AttributeTestUtility
    {
        internal const string HasNoOrInvalidLinePositionAttributeMessage = "{0} has an invalid or missing LinePositionAttribute.";
        internal const string HasNoModulo11AttributeMessage = "{0} has a missing Modulo11Attribute.";
        internal const string HasNoOrInvalidConvertToBooleanAttributeMessage = "{0} has a missing ConvertToBooleanAttribute.";
        internal const string HasNoOrInvalidConvertToDecimalAttributeMessage = "{0} has a missing ConvertToDecimalAttribute.";

        internal static bool HasValidLinePositionAttributeOnProperty(MemberInfo propertyInfo, int expectedStartPosition, int expectedEndPosition)
        {
            var attribute = ReflectionUtility.GetAttribute<FileLinePositionAttribute>(propertyInfo);

            return attribute != null && expectedStartPosition == attribute.StartPosition &&
                   expectedEndPosition == attribute.EndPosition;
        }

        internal static bool HasModulo11AttributeOnProperty(MemberInfo memberInfo)
        {
            var attribute = ReflectionUtility.GetAttribute<Modulo11Attribute>(memberInfo);
            return attribute != null;
        }

        internal static bool HasValidConvertToBooleanAttributeOnProperty(MemberInfo memberInfo, string expectedTrueString, string expectedFalseString)
        {
            var attribute = ReflectionUtility.GetAttribute<BooleanFormatAttribute>(memberInfo);
            return attribute != null && expectedTrueString == attribute.TrueString &&
                   expectedFalseString == attribute.FalseString;
        }

        internal static bool HasValidConvertToDecimalAttributeOnProperty(MemberInfo memberInfo, int expectedPrecision)
        {
            var attribute = ReflectionUtility.GetAttribute<DecimalFormatAttribute>(memberInfo);
            return attribute != null && expectedPrecision == attribute.Precision;
        }

        internal static bool HasAttributeCount<TModel, TAttribute>(int expectedCount)
            where TModel : IModel
            where TAttribute : Attribute
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            return expectedCount ==
                   typeof(TModel).GetProperties(flags).Sum(
                       a => a.GetCustomAttributes(typeof(TAttribute), true).Count());
        }
    }
}
