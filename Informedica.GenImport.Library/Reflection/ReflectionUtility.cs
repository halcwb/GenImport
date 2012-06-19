using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Informedica.GenImport.Library.Reflection
{
    public static class ReflectionUtility
    {
        public static TAttribute GetAttribute<TAttribute>(MemberInfo member)
             where TAttribute : Attribute
        {
            if (member == null) throw new ArgumentNullException("member");
            return member.GetCustomAttributes(typeof(TAttribute), true).SingleOrDefault() as TAttribute;
        }

        public static MemberInfo GetMemberInfo<T>(Expression<Func<T>> expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            MemberExpression body = (MemberExpression)expression.Body;
            return body.Member;
        }

        public static MethodInfo GetMethodInfo(Expression<Action> expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            MethodCallExpression body = (MethodCallExpression)expression.Body;
            return body.Method;
        }
    }
}
