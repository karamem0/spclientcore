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

    public enum SharingLinkKind
    {

        Uninitialized = 0,

        Direct = 1,

        OrganizationView = 2,

        OrganizationEdit = 3,

        AnonymousView = 4,

        AnonymousEdit = 5,

        Flexible = 6,

    }

}
