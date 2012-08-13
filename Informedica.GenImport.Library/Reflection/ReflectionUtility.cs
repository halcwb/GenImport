using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Informedica.GenImport.Library.Reflection
{
    public static class ReflectionUtility
    {
        [Pure]
        public static TAttribute GetAttribute<TAttribute>(MemberInfo member)
             where TAttribute : Attribute
        {
            Contract.Requires<ArgumentNullException>(member != null, "member");
            return member.GetCustomAttributes(typeof(TAttribute), true).SingleOrDefault() as TAttribute;
        }

        [Pure]
        public static bool HasAttribute<TAttribute>(MemberInfo member)
             where TAttribute : Attribute
        {
            Contract.Requires<ArgumentNullException>(member != null, "member");
            return member.GetCustomAttributes(typeof(TAttribute), true).Any();
        }

        [Pure]
        public static MemberInfo GetMemberInfo<T>(Expression<Func<T>> expression)
        {
            Contract.Requires<ArgumentNullException>(expression != null, "expression");
            MemberExpression body = (MemberExpression)expression.Body;
            return body.Member;
        }

        [Pure]
        public static MethodInfo GetMethodInfo(Expression<Action> expression)
        {
            Contract.Requires<ArgumentNullException>(expression != null, "expression");
            MethodCallExpression body = (MethodCallExpression)expression.Body;
            return body.Method;
        }

        [Pure]
        public static PropertyInfo[] GetProperties<TType, TAttribute>()
            where TAttribute : Attribute
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            return typeof(TType).GetProperties(flags).Where(HasAttribute<TAttribute>).ToArray();
        }
    }
}
