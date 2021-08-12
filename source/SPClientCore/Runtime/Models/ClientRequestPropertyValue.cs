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
    public class ClientRequestPropertyValue : ClientRequestProperty
    {

        public ClientRequestPropertyValue(string name, ClientRequestValue value)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Type = value.Type;
            this.Value = value.Value;
        }

        [XmlAttribute()]
        public virtual string Name { get; protected set; }

        [XmlAttribute()]
        public virtual string Type { get; protected set; }

        [XmlText()]
        public virtual string Value { get; protected set; }

    }

}
