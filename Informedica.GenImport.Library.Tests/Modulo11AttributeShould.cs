using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.Attributes;
using Informedica.GenImport.Library.Reflection;
using Informedica.GenImport.Library.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class Modulo11AttributeShould
    {
        private class Modulo11ObjectMock
        {
            public int Modulo11 { get; set; }
        }

        [TestMethod]
        public void Validate_And_Give_No_Error_On_Module11_With_Number_22934()
        {
            Modulo11ObjectMock objectMock = new Modulo11ObjectMock { Modulo11 = 22934 };
            IList<string> errors = new List<string>();

            IValidationAttribute attribute = new Modulo11Attribute();
            attribute.Validate(objectMock, ReflectionUtility.GetMemberInfo(() => objectMock.Modulo11), errors);

            Assert.IsFalse(errors.Any());
        }

        [TestMethod]
        public void Validate_And_Give_An_Error_On_Modulo11_With_Number_2293()
        {
            Modulo11ObjectMock objectMock = new Modulo11ObjectMock { Modulo11 = 2293 };
            IList<string> errors = new List<string>();

            IValidationAttribute attribute = new Modulo11Attribute();
            attribute.Validate(objectMock, ReflectionUtility.GetMemberInfo(() => objectMock.Modulo11), errors);

            Assert.IsTrue(errors.Any());
        }
    }
}
