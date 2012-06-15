using System;
using Informedica.GenImport.Library.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informedica.GenImport.Library.Tests
{
    [TestClass]
    public class ReflectionUtilityShould
    {
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

        private class TestAttribute : Attribute
        {
        }

        private class TestClass
        {
            [Test]
            public string TestProperty { get; set; }

            public static void TestMethod()
            {
            }
        }
    }
}
