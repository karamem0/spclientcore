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

    public enum SharingCapabilities
    {

        Disabled = 0,

        ExternalUserSharingOnly = 1,

        ExternalUserAndGuestSharing = 2,

        ExistingExternalUserSharingOnly = 3,

    }

}
