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

    public enum AlertEventType
    {

        All = -1,

        AddObject = 1,

        ModifyObject = 2,

        DeleteObject = 4,

        Discussion = 4080,

    }

}
