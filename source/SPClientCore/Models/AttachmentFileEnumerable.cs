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

    [ClientObject(Name = "SP.AttachmentCollection", Id = "{f4e86471-7dab-4b47-b061-50a40e27140e}")]
    [JsonObject()]
    public class AttachmentFileEnumerable : ClientObjectEnumerable<AttachmentFile>
    {

        public AttachmentFileEnumerable()
        {
        }

    }

}
