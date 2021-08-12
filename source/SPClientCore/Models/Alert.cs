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

    [ClientObject(Name = "SP.Alert", Id = "{004daa6c-acc5-48fc-877a-2604a2cb3358}")]
    [JsonObject()]
    public class Alert : ClientObject
    {

        public Alert()
        {
        }

        [JsonProperty()]
        public virtual AlertFrequency AlertFrequency { get; protected set; }

        [JsonProperty()]
        public virtual string AlertTemplateName { get; protected set; }

        [JsonProperty()]
        [ClientQueryCondition("NotImmediate")]
        public virtual DateTime AlertTime { get; protected set; }

        [JsonProperty()]
        public virtual AlertType AlertType { get; protected set; }

        [JsonProperty()]
        public virtual bool AlwaysNotify { get; protected set; }

        [JsonProperty()]
        public virtual AlertDeliveryChannel DeliveryChannels { get; protected set; }

        [JsonProperty()]
        public virtual AlertEventType EventType { get; protected set; }

        [JsonProperty()]
        public virtual string Filter { get; protected set; }

        [JsonProperty("ID")]
        public virtual Guid Id { get; protected set; }

        [JsonProperty("ListID")]
        public virtual Guid ListId { get; protected set; }

        [JsonProperty("ItemID")]
        [ClientQueryCondition("ListItem")]
        public virtual int ListItemId { get; protected set; }

        [JsonProperty()]
        public virtual string ListUrl { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> Properties { get; protected set; }

        [JsonProperty()]
        public virtual AlertStatus Status { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual int UserId { get; protected set; }

    }

}
