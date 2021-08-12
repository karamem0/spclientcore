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
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [XmlType("Property", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientRequestPropertyArray : ClientRequestProperty
    {

        public ClientRequestPropertyArray(string name, params object[] values)
        {
            this.Name = name;
            this.Type = "Array";
            this.Values = values
                .Select(value => ClientRequestValue.Create(value))
                .Select(value => new ClientRequestPropertyArrayValue(value.Type, value.Value))
                .ToArray();
        }

        [XmlAttribute()]
        public virtual string Name { get; protected set; }

        [XmlAttribute()]
        public virtual string Type { get; protected set; }

        [XmlElement("Object")]
        public virtual IEnumerable<ClientRequestPropertyArrayValue> Values { get; protected set; }

    }

}
