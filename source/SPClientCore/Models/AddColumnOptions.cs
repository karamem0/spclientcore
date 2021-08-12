//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [Flags()]
    public enum AddColumnOptions
    {

        DefaultValue = 0,

        AddToDefaultContentType = 1,

        AddToNoContentType = 2,

        AddToAllContentTypes = 4,

        AddColumnInternalNameHint = 8,

        AddColumnToDefaultView = 16,

        AddColumnCheckDisplayName = 32,

    }

}
