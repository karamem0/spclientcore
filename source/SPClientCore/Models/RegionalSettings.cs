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

    [ClientObject(Name = "SP.RegionalSettings", Id = "{84c424a9-a1d6-46ba-8398-c46257ecd25b}")]
    [JsonObject()]
    public class RegionalSettings : ClientObject
    {

        public RegionalSettings()
        {
        }

        [JsonProperty()]
        public virtual short AdjustHijriDays { get; protected set; }

        [JsonProperty()]
        public virtual short AlternateCalendarType { get; protected set; }

        [JsonProperty()]
        public virtual string AM { get; protected set; }

        [JsonProperty()]
        public virtual short CalendarType { get; protected set; }

        [JsonProperty()]
        public virtual short Collation { get; protected set; }

        [JsonProperty("CollationLCID")]
        public virtual uint CollationLcid { get; protected set; }

        [JsonProperty()]
        public virtual uint DateFormat { get; protected set; }

        [JsonProperty()]
        public virtual string DateSeparator { get; protected set; }

        [JsonProperty()]
        public virtual string DecimalSeparator { get; protected set; }

        [JsonProperty()]
        public virtual string DigitGrouping { get; protected set; }

        [JsonProperty()]
        public virtual uint FirstDayOfWeek { get; protected set; }

        [JsonProperty()]
        public virtual short FirstWeekOfYear { get; protected set; }

        [JsonProperty()]
        public virtual bool IsEastAsia { get; protected set; }

        [JsonProperty()]
        public virtual bool IsRightToLeft { get; protected set; }

        [JsonProperty()]
        public virtual bool IsUIRightToLeft { get; protected set; }

        [JsonProperty()]
        public virtual string ListSeparator { get; protected set; }

        [JsonProperty("LocaleId")]
        public virtual uint Lcid { get; protected set; }

        [JsonProperty()]
        public virtual string NegativeSign { get; protected set; }

        [JsonProperty()]
        public virtual uint NegNumberMode { get; protected set; }

        [JsonProperty()]
        public virtual string PM { get; protected set; }

        [JsonProperty()]
        public virtual string PositiveSign { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowWeeks { get; protected set; }

        [JsonProperty()]
        public virtual string ThousandSeparator { get; protected set; }

        [JsonProperty()]
        public virtual bool Time24 { get; protected set; }

        [JsonProperty()]
        public virtual uint TimeMarkerPosition { get; protected set; }

        [JsonProperty()]
        public virtual string TimeSeparator { get; protected set; }

        [JsonProperty()]
        public virtual TimeZone TimeZone { get; protected set; }

        [JsonProperty()]
        public virtual TimeZoneEnumerable TimeZones { get; protected set; }

        [JsonProperty()]
        public virtual short WorkDayEndHour { get; protected set; }

        [JsonProperty()]
        public virtual short WorkDays { get; protected set; }

        [JsonProperty()]
        public virtual short WorkDayStartHour { get; protected set; }

    }

}
