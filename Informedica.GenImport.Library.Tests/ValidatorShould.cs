using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class ValidatorShould
    {
        #region Helpers
        private class ValidationAttributeMock : Attribute, IValidationAttribute
        {
            public void Validate(object o, MemberInfo memberInfo, IList<string> errors)
            {
                object value = ((PropertyInfo)memberInfo).GetValue(o, null);
                if (value != null && ((string)value).Length > 5)
                {
                    errors.Add("error");
                }
            }
        }

        private class ValidationObjectMock
        {
            [ValidationAttributeMock]
            public string Value { get; set; }

            [ValidationAttributeMock]
            public string Value2 { get; set; }
        }
        #endregion

        [TestMethod]
        public void Validate_All_Properties_Marked_With_An_IValidationAttribute_And_Return_No_Errors()
        {
            ValidationObjectMock validationObjectMock = new ValidationObjectMock { Value = "abcd", Value2 = "abcd" };
            IList<string> errors = Validator.Validate(validationObjectMock);

            Assert.IsFalse(errors.Any());
        }

        [TestMethod]
        public void Validate_All_Properties_Marked_With_An_IValidationAttribute_And_Return_One_Error()
        {
            ValidationObjectMock validationObjectMock = new ValidationObjectMock { Value = "abcdefg", Value2 = "abcd"};
            IList<string> errors = Validator.Validate(validationObjectMock);

            Assert.AreEqual(1, errors.Count);
        }

        [TestMethod]
        public void Validate_All_Properties_Marked_With_An_IValidationAttribute_And_Return_Two_Errors()
        {
            ValidationObjectMock validationObjectMock = new ValidationObjectMock { Value = "abcdefg", Value2 = "abcdefg" };
            IList<string> errors = Validator.Validate(validationObjectMock);

            Assert.AreEqual(2, errors.Count);
        }
    }
}
