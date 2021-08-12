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
    public enum PersonalSiteCapabilities
    {

        None = 0,

        Profile = 1,

        Social = 2,

        Storage = 4,

        MyTasksDashboard = 8,

        Education = 16,

        Guest = 32,

    }

}
