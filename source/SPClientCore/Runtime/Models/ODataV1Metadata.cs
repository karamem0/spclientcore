//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ODataV1Metadata
    {

        public static ODataV1Metadata Create(Type type)
        {
            var attribute = type.GetCustomAttribute<ODataV1ObjectAttribute>(false);
            if (attribute != null)
            {
                if (attribute.Name != null)
                {
                    return new ODataV1Metadata(null, null, attribute.Name);
                }
            }
            return null;
        }

        public ODataV1Metadata()
        {
        }

        public ODataV1Metadata(string id, Uri uri, string type)
        {
            this.Id = id;
            this.Uri = uri;
            this.Type = type;
        }

        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("uri")]
        public Uri Uri { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

    }

}
