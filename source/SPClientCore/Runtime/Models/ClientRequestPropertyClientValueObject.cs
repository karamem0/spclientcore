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
using System.Xml;
using System.Xml.Serialization;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [XmlType("Property", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientRequestPropertyClientValueObject : ClientRequestProperty
    {

        public ClientRequestPropertyClientValueObject(string name, ClientValueObject value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            this.Name = name;
            this.TypeId = ClientObjectAttribute.GetId(value.GetType());
            this.Values = value.GetType()
                .GetDeclaringProperties()
                .Where(propertyInfo => propertyInfo.IsDefined(typeof(JsonPropertyAttribute)))
                .Select(propertyInfo =>
                {
                    var propertyAttribute = propertyInfo.GetCustomAttribute<JsonPropertyAttribute>();
                    var propertyName = string.IsNullOrEmpty(propertyAttribute.PropertyName) ? propertyInfo.Name : propertyAttribute.PropertyName;
                    var propertyValue = propertyInfo.GetValue(value);
                    if (ClientRequestValue.TryCreate(propertyValue, out var valueObject))
                    {
                        return new ClientRequestPropertyValue(propertyName, valueObject);
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                })
                .ToList();
        }

        [XmlAttribute()]
        public virtual string Name { get; protected set; }

        [XmlAttribute()]
        public virtual Guid TypeId { get; protected set; }

        [XmlElement("Property")]
        public virtual IEnumerable<ClientRequestPropertyValue> Values { get; protected set; }

    }

}
