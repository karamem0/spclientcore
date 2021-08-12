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

    [ClientObject(Name = "SP.AttachmentCreationInformation", Id = "{edf6309c-8142-4133-921e-4d6aec35550d}")]
    [JsonObject()]
    public class AttachmentFileCreationInformation : ClientValueObject
    {

        public AttachmentFileCreationInformation()
        {
        }

        public AttachmentFileCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual System.IO.Stream ContentStream { get; protected set; }

        [JsonProperty()]
        public virtual string FileName { get; protected set; }

    }

}
