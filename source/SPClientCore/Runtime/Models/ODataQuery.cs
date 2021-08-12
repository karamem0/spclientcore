//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public static class ODataQuery
    {

        public static string Create<T>() where T : ODataObject
        {
            var select = Enumerable.Repeat("*", 1).Union(typeof(T)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(property => Attribute.IsDefined(property, typeof(JsonPropertyAttribute)))
                .Where(property =>
                {
                    if (property.PropertyType.IsSubclassOf(typeof(ODataObject)))
                    {
                        return false;
                    }
                    if (property.PropertyType.IsSubclassOf(typeof(ClientObject)))
                    {
                        return false;
                    }
                    return true;
                })
                .Select(property => property.Name));
            return UriQuery.Create(new Dictionary<string, object>
            {
                { "$select", string.Join(",", select) }
            });
        }

    }

}
