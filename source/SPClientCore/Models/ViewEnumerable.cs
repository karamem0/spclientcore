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

    [ClientObject(Name = "SP.ViewCollection", Id = "{03c5d7a9-9541-4482-9919-ca0cccf565a0}")]
    [JsonObject()]
    public class ViewEnumerable : ClientObjectEnumerable<View>
    {

        public ViewEnumerable()
        {
        }

    }

}
