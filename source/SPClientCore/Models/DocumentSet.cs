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

    [ClientObject(Name = "SP.DocumentSet.DocumentSet", Id = "{e32a87f7-b866-407d-971d-027ed940d50f}")]
    [JsonObject()]
    public class DocumentSet : ClientObject
    {

        public DocumentSet()
        {
        }

    }

}
