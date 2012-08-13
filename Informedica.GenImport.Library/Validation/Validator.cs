using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Informedica.GenImport.Library.Validation
{
    public static class Validator
    {
        [Pure]
        public static IList<string> Validate(object toValidate)
        {
            List<string> errors = new List<string>();

            foreach (PropertyInfo info in toValidate.GetType().GetProperties())
            {
                foreach (object customAttribute in info.GetCustomAttributes(typeof(IValidationAttribute), true))
                {
                    ((IValidationAttribute)customAttribute).Validate(toValidate, info, errors);
                    if (info.PropertyType.IsClass || info.PropertyType.IsInterface)
                    {
                        errors.AddRange(Validate(info.GetValue(toValidate, null)));
                    }
                }
            }
            foreach (MethodInfo method in toValidate.GetType().GetMethods())
            {
                foreach (object customAttribute in method.GetCustomAttributes(typeof(IValidationAttribute), true))
                {
                    ((IValidationAttribute)customAttribute).Validate(toValidate, method, errors);
                }
            }
            return errors;
        }
    }
}
