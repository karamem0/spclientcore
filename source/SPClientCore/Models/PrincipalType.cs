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
    public enum PrincipalType
    {

        None = 0,

        User = 1,

        DistributionList = 2,

        SecurityGroup = 4,

        SharePointGroup = 8,

        All = 15,

    }

}
