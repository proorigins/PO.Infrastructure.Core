using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PO.Infrastructure.Core.Extensions
{
    public static class TypeExtensions
    {
        public static List<Type> GetDerivedTypes(this Type type, bool forInterfaces = false)
        {
            return Assembly.GetCallingAssembly().GetTypes().Where(t => t != type && type.IsAssignableFrom(t) && (!forInterfaces || t.IsInterface)).ToList();
        }
    }
}