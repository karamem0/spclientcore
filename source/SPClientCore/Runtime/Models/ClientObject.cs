//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public class ClientObject
    {

        private static readonly IReadOnlyDictionary<string, Type> ClientObjectDictionary =
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => type.IsSubclassOf(typeof(ClientObject)))
                .Where(type => type.IsDefined(typeof(ClientObjectAttribute)))
                .Select(type => new
                {
                    Type = type,
                    Attribute = type.GetCustomAttribute<ClientObjectAttribute>()
                })
                .Where(value => value.Attribute.Name != null)
                .ToDictionary(value => value.Attribute.Name, value => value.Type);

        public static Type GetType(string name)
        {
            return ClientObjectDictionary
                .Where(item => item.Key == name)
                .Select(item => item.Value)
                .SingleOrDefault();
        }

        public static Type GetType<T>(string name)
        {
            var type = GetType(name);
            if (type == null)
            {
                if (typeof(T).IsGenericSubclassOf(typeof(ClientObjectEnumerable<>)))
                {
                    return typeof(T);
                }
                else
                {
                    return typeof(ClientObject);
                }
            }
            else
            {
                return type;
            }
        }

        public ClientObject()
        {
            this.ExtensionProperties = new Dictionary<string, JToken>();
        }

        [JsonIgnore()]
        public object this[string key] =>
            this.ExtensionProperties
                .Select(item => ClientResultValue.Create(item))
                .Where(item => item.Key == key)
                .Select(item => item.Value)
                .SingleOrDefault();

        [JsonIgnore()]
        public IEnumerable<string> ExtensionKeys => this.ExtensionProperties
            .Select(item => ClientResultValue.Create(item))
            .Select(item => item.Key)
            .ToArray();

        [JsonProperty("_ObjectIdentity_")]
        internal string ObjectIdentity { get; private set; }

        [JsonProperty("_ObjectType_")]
        internal string ObjectType { get; private set; }

        [JsonProperty("_ObjectVersion_")]
        internal string ObjectVersion { get; private set; }

        [JsonExtensionData()]
        protected Dictionary<string, JToken> ExtensionProperties { get; private set; }

    }

}
