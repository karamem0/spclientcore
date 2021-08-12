//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Common
{

    public static class TypeExtensions
    {

        public static bool IsGenericSubclassOf(this Type targetType, Type genericType)
        {
            var compareType = targetType;
            while (true)
            {
                if (compareType == null || compareType == typeof(object))
                {
                    return false;
                }
                if (compareType.IsGenericType)
                {
                    if (compareType.GetGenericTypeDefinition() == genericType)
                    {
                        return true;
                    }
                }
                compareType = compareType.BaseType;
            }
        }

        public static T GetCustomAttribute<T>(this Type type) where T : Attribute
        {
            return (T)Attribute.GetCustomAttribute(type, typeof(T));
        }

        public static T GetCustomAttribute<T>(this Type type, bool inherit) where T : Attribute
        {
            return (T)Attribute.GetCustomAttribute(type, typeof(T), inherit);
        }

        public static PropertyInfo GetDeclaringProperty(this Type type, string name)
        {
            return type.GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        }

        public static PropertyInfo[] GetDeclaringProperties(this Type type)
        {
            return type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
        }

    }

}
