using System;
using System.Linq.Expressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Informedica.GenImport.Library.DomainModel.GStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Informedica.GenImport.Library.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class NaamShould
    {
        [TestMethod]
        public void Have_A_LinePositionAttribute_On_All_Public_Properties()
        {
            PropertyInfo[] propertyInfos = typeof(Naam).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var propertyInfo in propertyInfos)
            {
                Assert.IsTrue(MemberHasAttribute<FileLinePositionAttribute>(propertyInfo));
            }
        }

        private static bool MemberHasAttribute<TAttribute>(MemberInfo member)
            where TAttribute : Attribute
        {
            return member.GetCustomAttributes(typeof(TAttribute), false).Any();
        }
    }
}