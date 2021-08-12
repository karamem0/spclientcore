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

    public enum RoleType
    {

        None = 0,

        Guest = 1,

        Reader = 2,

        Contributor = 3,

        WebDesigner = 4,

        Administrator = 5,

        Editor = 6,

        Reviewer = 7,

        RestrictedReader = 8,

        System = 255,

    }

}
