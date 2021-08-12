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

    public enum ViewType
    {

        None = 0,

        Html = 1,

        Grid = 0x800,

        Calendar = 0x80000,

        Recurrence = 8193,

        Chart = 0x20000,

        Gantt = 0x4000000,

    }

}
