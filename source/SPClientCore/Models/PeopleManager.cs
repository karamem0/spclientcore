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

    [ClientObject(Name = "SP.UserProfiles.PeopleManager", Id = "{cf560d69-0fdb-4489-a216-b6b47adf8ef8}")]
    [JsonObject()]
    public class PeopleManager : ClientObject
    {

        public PeopleManager()
        {
        }

    }

}
