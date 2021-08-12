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

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public class ClientObjectAttribute : Attribute
    {

        public static Guid GetId(Type type)
        {
            var objectAttribute = type.GetCustomAttribute<ClientObjectAttribute>();
            if (objectAttribute == null)
            {
                throw new InvalidOperationException();
            }
            return Guid.Parse(objectAttribute.Id);
        }

        public static string GetName(Type type)
        {
            var objectAttribute = type.GetCustomAttribute<ClientObjectAttribute>();
            if (objectAttribute == null)
            {
                throw new InvalidOperationException();
            }
            return objectAttribute.Name;
        }

        public ClientObjectAttribute()
        {
        }

        public string Id { get; set; }

        public string Name { get; set; }

    }

}
