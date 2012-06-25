using System;
using System.Linq;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class ReflectionUtilityShould
    {
        #region Helpers
        private class TestAttribute : Attribute
        {
        }

        private class TestClass
        {
            [Test]
            public string TestProperty { get; set; }

            public string TestPropertyWithout { get; set; }

            public static void TestMethod()
            {
            }
        }
        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_GetAttribute_Is_Called_With_Member_Null()
        {
            ReflectionUtility.GetAttribute<Attribute>(null);
        }

        [TestMethod]
        public void Return_TestAttribute_When_GetAttribute_Is_Called_With_Member()
        {
            var testClass = new TestClass();
            var memberInfo = ReflectionUtility.GetMemberInfo(() => testClass.TestProperty);
            var attribute = ReflectionUtility.GetAttribute<TestAttribute>(memberInfo);
            Assert.IsNotNull(attribute);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_GetMemberInfo_Is_Called_With_Expression_Null()
        {
            ReflectionUtility.GetMemberInfo<object>(null);
        }

        [TestMethod]
        public void Return_MemberInfo_When_GetMemberInfo_Is_Called_With_Expression()
        {
            var testClass = new TestClass();
            var memberInfo = ReflectionUtility.GetMemberInfo(() => testClass.TestProperty);
            Assert.IsNotNull(memberInfo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_GetMethodInfo_Is_Called_With_Expression_Null()
        {
            ReflectionUtility.GetMethodInfo(null);
        }

        [TestMethod]
        public void Return_MethodInfo_When_GetMethodInfo_Is_Called_With_Expression()
        {
            var methodInfo = ReflectionUtility.GetMethodInfo(() => TestClass.TestMethod());
            Assert.IsNotNull(methodInfo);
        }

        [TestMethod]
        public void Return_True_When_HasAttribute_Is_Called_And_Attribute_Exists_On_MemberInfo()
        {
            var testClass = new TestClass();
            var memberInfo = ReflectionUtility.GetMemberInfo(() => testClass.TestProperty);
            Assert.IsTrue(ReflectionUtility.HasAttribute<TestAttribute>(memberInfo));
        }

        [TestMethod]
        public void Return_Fals_When_HasAttribute_Is_Called_And_Attribute_Does_Not_Exist_On_MemberInfo()
        {
            var testClass = new TestClass();
            var memberInfo = ReflectionUtility.GetMemberInfo(() => testClass.TestPropertyWithout);
            Assert.IsFalse(ReflectionUtility.HasAttribute<TestAttribute>(memberInfo));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Throw_ArgumentNullException_When_HasAttribute_Is_Called_With_Null()
        {
            ReflectionUtility.HasAttribute<TestAttribute>(null);
        }

        [TestMethod]
        public void Return_One_Property_When_GetProperties_With_AttributeType_TestAttribute_Is_Called()
        {
            const int expectedCount = 1;
            var type = typeof (TestClass);

            var properties = ReflectionUtility.GetProperties<TestAttribute>(type);
            
            Assert.AreEqual(expectedCount, properties.Count());
        }
    }
}
