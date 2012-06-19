using System.Collections.Generic;
using System.Reflection;

namespace Informedica.GenImport.Library.Validation
{
    public interface IValidationAttribute
    {
        void Validate(object o, MemberInfo memberInfo, IList<string> errors);
    }
}
