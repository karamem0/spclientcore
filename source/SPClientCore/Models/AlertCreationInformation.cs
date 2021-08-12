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

    [ClientObject(Name = "SP.AlertCreationInformation", Id = "{f0c12e8e-54f5-4e31-b015-f4f824eea024}")]
    [JsonObject()]
    public class AlertCreationInformation : ClientValueObject
    {

        public AlertCreationInformation()
        {
        }

        public AlertCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public virtual AlertFrequency AlertFrequency { get; protected set; }

        [JsonProperty()]
        public virtual string AlertTemplateName { get; protected set; }

        [JsonProperty()]
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
        public virtual int EventTypeBitmask { get; protected set; }

        [JsonProperty()]
        public virtual string Filter { get; protected set; }

        [JsonProperty()]
        public virtual List List { get; protected set; }

        [JsonProperty("Item")]
        public virtual ListItem ListItem { get; protected set; }

        [JsonProperty()]
        public virtual IReadOnlyDictionary<string, string> Properties { get; protected set; }

        [JsonProperty()]
        public virtual AlertStatus Status { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual User User { get; protected set; }

    }

}
