using System;
using System.Collections.Generic;
using System.Reflection;
using Informedica.GenImport.Library.Utilities;
using Informedica.GenImport.Library.Validation;

namespace Informedica.GenImport.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Modulo11Attribute : Attribute, IValidationAttribute
    {
        private const string ValidationMessage = "property {0} has invalid module 11 value {1}.";

        public void Validate(object o, MemberInfo memberInfo, IList<string> errors)
        {
            if(memberInfo is PropertyInfo)
            {
                Validate(o, memberInfo as PropertyInfo, errors);
            }
        }

        private static void Validate(object o, PropertyInfo propertyInfo, IList<string> errors)
        {
            object value = propertyInfo.GetValue(o, null);
            if (!MathUtils.IsValidModulo11((int)value))
            {
                errors.Add(string.Format(ValidationMessage, propertyInfo.Name, value));
            }
        }
    }
}
