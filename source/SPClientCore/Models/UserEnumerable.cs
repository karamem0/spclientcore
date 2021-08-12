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

    [ClientObject(Name = "SP.UserCollection", Id = "{e090781e-8899-4672-9b3d-a78f49fad19d}")]
    [JsonObject()]
    public class UserEnumerable : ClientObjectEnumerable<User>
    {

        public UserEnumerable()
        {
        }

    }

}
