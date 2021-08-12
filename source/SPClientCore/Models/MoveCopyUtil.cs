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

    [ClientObject(Name = "SP.MoveCopyUtil", Id = "{c668c5ca-bbdd-435f-8008-502f3180cf20}")]
    [JsonObject()]
    public class MoveCopyUtil : ClientObject
    {

        public MoveCopyUtil()
        {
        }

    }

}
