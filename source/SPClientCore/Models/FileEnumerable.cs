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

    [ClientObject(Name = "SP.FileCollection", Id = "{d367b17c-170b-4691-a1e3-8bccf7686ce4}")]
    [JsonObject()]
    public class FileEnumerable : ClientObjectEnumerable<File>
    {

        public FileEnumerable()
        {
        }

    }

}
