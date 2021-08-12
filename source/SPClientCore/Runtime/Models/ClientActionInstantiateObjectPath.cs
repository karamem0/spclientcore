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

    [XmlType("ObjectPath", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientActionInstantiateObjectPath : ClientAction
    {

        public ClientActionInstantiateObjectPath(long objectPathId)
        {
            this.ObjectPathId = objectPathId;
        }

        [XmlAttribute()]
        public override long Id { get; protected set; }

        [XmlAttribute()]
        public virtual long ObjectPathId { get; protected set; }

    }

}
