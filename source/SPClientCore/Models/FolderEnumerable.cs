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

    [ClientObject(Name = "SP.FolderCollection", Id = "{b6b425aa-9e17-4205-a4aa-b82c2c3f884d}")]
    [JsonObject()]
    public class FolderEnumerable : ClientObjectEnumerable<Folder>
    {

        public FolderEnumerable()
        {
        }

    }

}
