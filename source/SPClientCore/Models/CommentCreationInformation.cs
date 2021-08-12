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
    [ODataV1Object(Name = "Microsoft.SharePoint.Comments.comment")]
    public class CommentCreationInformation : ODataV1Object
    {

        public CommentCreationInformation()
        {
        }

        [JsonProperty("text")]
        public virtual string Text { get; protected set; }

    }

}
