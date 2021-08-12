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

    [XmlType("Parameter", Namespace = "http://schemas.microsoft.com/sharepoint/clientquery/2009")]
    public class ClientRequestParameterArray : ClientRequestParameter
    {

        public ClientRequestParameterArray(ClientRequestPayload payload, params object[] values)
        {
            this.Type = "Array";
            this.Values = values.Select(value => payload.CreateParameter(value)).ToArray();
        }

        [XmlAttribute()]
        public virtual string Type { get; protected set; }

        [XmlElement("Object")]
        public virtual IEnumerable<ClientRequestParameter> Values { get; protected set; }

    }

}
