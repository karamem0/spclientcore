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

    [JsonObject()]
    public class Subscription : ODataV1Object
    {

        public Subscription()
        {
        }

        [JsonProperty("clientState")]
        public virtual string ClientState { get; protected set; }

        [JsonProperty("expirationDateTime")]
        public virtual DateTime ExpirationDateTime { get; protected set; }

        [JsonProperty("id")]
        public virtual Guid Id { get; protected set; }

        [JsonProperty("notificationUrl")]
        public virtual string NotificationUrl { get; protected set; }

        [JsonProperty("resource")]
        public virtual Guid Resource { get; protected set; }

        [JsonProperty("resourceData")]
        public virtual string ResourceData { get; protected set; }

    }

}
