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

    [XmlType("Object", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientRequestPropertyArrayValue : ClientRequestObject
    {

        public ClientRequestPropertyArrayValue(string type, string value)
        {
            this.Type = type;
            this.Value = value;
        }

        [XmlAttribute()]
        public virtual string Type { get; protected set; }

        [XmlText()]
        public virtual string Value { get; protected set; }

    }

}
