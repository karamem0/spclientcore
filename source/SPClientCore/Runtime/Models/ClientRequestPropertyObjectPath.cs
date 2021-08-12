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
    public class ClientRequestPropertyObjectPath : ClientRequestProperty
    {

        public ClientRequestPropertyObjectPath(string name, ObjectPath objectPath)
        {
            this.Name = name;
            this.ObjectPathId = objectPath.Id;
        }

        [XmlAttribute()]
        public virtual string Name { get; protected set; }

        [XmlAttribute()]
        public virtual long ObjectPathId { get; protected set; }

    }

}
