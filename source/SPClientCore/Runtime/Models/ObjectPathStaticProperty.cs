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
using System.Xml.Serialization;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [XmlType("StaticProperty", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ObjectPathStaticProperty : ObjectPath
    {

        public ObjectPathStaticProperty(Type type, string name)
        {
            _ = type ?? throw new ArgumentNullException(nameof(type));
            this.TypeId = ClientObjectAttribute.GetId(type);
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        [XmlAttribute()]
        public override long Id { get; protected set; }

        [XmlAttribute()]
        public virtual Guid TypeId { get; protected set; }

        [XmlAttribute()]
        public virtual string Name { get; protected set; }

    }

}
