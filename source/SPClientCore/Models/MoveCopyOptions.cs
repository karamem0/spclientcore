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

    [ClientObject(Name = "SP.MoveCopyOptions", Id = "{b3ff81b8-6cec-4ad3-ae27-9d5cff515d8e}")]
    [JsonObject()]
    public class MoveCopyOptions : ClientValueObject
    {

        public MoveCopyOptions()
        {
        }

        public MoveCopyOptions(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual bool KeepBoth { get; protected set; }

        [JsonProperty()]
        public virtual bool ResetAuthorAndCreatedOnCopy { get; protected set; }

        [JsonProperty()]
        public virtual bool RetainEditorAndModifiedOnMove { get; protected set; }

        [JsonProperty()]
        public virtual bool ShouldBypassSharedLocks { get; protected set; }

    }

}
