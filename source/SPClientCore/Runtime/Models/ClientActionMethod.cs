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

    [XmlType("Method", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientActionMethod : ClientAction
    {

        public ClientActionMethod(long objectPathId, string name, params ClientRequestParameter[] parameters)
        {
            this.ObjectPathId = objectPathId;
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Parameters = parameters;
        }

        [XmlAttribute()]
        public override long Id { get; protected set; }

        [XmlAttribute()]
        public virtual long ObjectPathId { get; protected set; }

        [XmlAttribute()]
        public virtual string Name { get; set; }

        [XmlArray()]
        public virtual IEnumerable<ClientRequestParameter> Parameters { get; protected set; }

    }

}
