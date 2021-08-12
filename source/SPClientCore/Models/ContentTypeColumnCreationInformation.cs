//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [ClientObject(Name = "SP.FieldLinkCreationInformation", Id = "{63fb2c92-8f65-4bbb-a658-b6cd294403f4}")]
    [JsonObject()]
    public class ContentTypeColumnCreationInformation : ClientValueObject
    {

        public ContentTypeColumnCreationInformation()
        {
        }

        public ContentTypeColumnCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty("Field")]
        public virtual Column Column { get; protected set; }

    }

}
