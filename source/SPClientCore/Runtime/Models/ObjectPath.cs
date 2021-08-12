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

    public abstract class ObjectPath : ClientRequestObject
    {

        protected ObjectPath()
        {
            this.Id = ClientRequestObject.NewId();
        }

        [XmlAttribute()]
        public virtual long Id { get; protected set; }

    }

}
