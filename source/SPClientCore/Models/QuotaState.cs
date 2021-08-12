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

    public enum QuotaState
    {

        None = 0,

        Normal = 1,

        Nearing = 2,

        Critical = 3,

        Exceeded = 4,

    }

}
