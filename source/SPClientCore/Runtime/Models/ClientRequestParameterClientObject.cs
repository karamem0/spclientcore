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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [XmlType("Parameter", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientRequestParameterClientObject : ClientRequestParameter
    {

        public ClientRequestParameterClientObject(ClientRequestPayload payload, object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            this.TypeId = ClientObjectAttribute.GetId(value.GetType());
            this.Properties = value.GetType()
                .GetDeclaringProperties()
                .Where(propertyInfo => propertyInfo.IsDefined(typeof(JsonPropertyAttribute)))
                .Select<PropertyInfo, ClientRequestProperty>(propertyInfo =>
                {
                    var propertyAttribute = propertyInfo.GetCustomAttribute<JsonPropertyAttribute>();
                    var propertyName = string.IsNullOrEmpty(propertyAttribute.PropertyName) ? propertyInfo.Name : propertyAttribute.PropertyName;
                    var propertyValue = propertyInfo.GetValue(value);
                    if (ClientRequestValue.TryCreate(propertyValue, out var valueObject))
                    {
                        return new ClientRequestPropertyValue(propertyName, valueObject);
                    }
                    else if (propertyValue is IDictionary dictionaryObject)
                    {
                        return new ClientRequestPropertyDictionary(propertyName, dictionaryObject);
                    }
                    else if (propertyValue is IEnumerable arrayObject)
                    {
                        return new ClientRequestPropertyArray(propertyName, arrayObject.OfType<object>().ToArray());
                    }
                    else if (propertyValue is ClientObject clientObject)
                    {
                        return new ClientRequestPropertyObjectPath(
                            propertyName,
                            payload.Add(new ObjectPathIdentity(clientObject.ObjectIdentity)));
                    }
                    else if (propertyValue is ClientValueObject clientValueObject)
                    {
                        return new ClientRequestPropertyClientValueObject(propertyName, clientValueObject);
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                })
                .ToList();
        }

        [XmlAttribute()]
        public virtual Guid TypeId { get; protected set; }

        [XmlElement("Property")]
        public virtual IEnumerable<ClientRequestProperty> Properties { get; protected set; }

    }

}
