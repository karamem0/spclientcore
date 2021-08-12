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

    [ClientObject(Name = "SP.FeatureCollection", Id = "{8b9c0015-193d-4062-8e98-8d23c303eedd}")]
    [JsonObject()]
    public class FeatureEnumerable : ClientObjectEnumerable<Feature>
    {

        public FeatureEnumerable()
        {
        }

    }

}
