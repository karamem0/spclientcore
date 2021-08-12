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

    [ClientObject(Name = "SP.Taxonomy.LabelCollection", Id = "{1849dc80-6aed-4acc-a38f-18caf1d7a216}")]
    [JsonObject()]
    public class TermLabelEnumerable : ClientObjectEnumerable<TermLabel>
    {

        public TermLabelEnumerable()
        {
        }

    }

}
