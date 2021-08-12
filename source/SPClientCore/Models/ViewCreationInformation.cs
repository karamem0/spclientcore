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

    [ClientObject(Name = "SP.ViewCreationInformation", Id = "{a3547807-7266-42f3-b055-afa6e840e458}")]
    [JsonObject()]
    public class ViewCreationInformation : ClientValueObject
    {

        public ViewCreationInformation()
        {
        }

        public ViewCreationInformation(IReadOnlyDictionary<string, object> parameters) : base(parameters)
        {
        }

        [JsonProperty()]
        public int BaseViewId { get; private set; }

        [JsonProperty()]
        public bool Paged { get; private set; }

        [JsonProperty()]
        public bool PersonalView { get; private set; }

        [JsonProperty()]
        public int RowLimit { get; private set; }

        [JsonProperty()]
        public bool SetAsDefaultView { get; private set; }

        [JsonProperty()]
        public string Title { get; private set; }

        [JsonProperty("ViewFields")]
        public string[] ViewColumns { get; private set; }

        [JsonProperty("Query")]
        public string ViewQuery { get; private set; }

        [JsonProperty("ViewTypeKind")]
        public ViewType ViewType { get; private set; }

    }

}
