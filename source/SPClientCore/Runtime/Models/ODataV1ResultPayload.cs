//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ODataV1ResultPayload
    {

        public ODataV1ResultPayload()
        {
        }

        [JsonProperty("error")]
        public virtual ODataV1Error Error { get; protected set; }

    }

}
