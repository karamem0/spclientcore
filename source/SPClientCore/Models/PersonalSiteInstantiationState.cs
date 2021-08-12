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

    public enum PersonalSiteInstantiationState
    {

        Uninitialized = 0,

        Enqueued = 1,

        Created = 2,

        Deleted = 3,
        PermissionsGeneralFailure = 4096,

        PermissionsUPANotGranted = 4097,

        PermissionsUserNotLicensed = 4098,

        PermissionsSelfServiceSiteCreationDisabled = 4099,

        PermissionsNoMySitesInPeopleLight = 4100,

        PermissionsEmptyHostUrl = 4101,

        PermissionsHostFailedToInitializePersonalSiteContext = 4102,

        ErrorGeneralFailure = 8192,

        ErrorManagedPathDoesNotExist = 8193,

        ErrorLanguageNotInstalled = 8194,

        ErrorPartialCreate = 8195,

        ErrorPersonalSiteAlreadyExists = 8196,

        ErrorRootSiteNotPresent = 8197,

        ErrorSelfServiceSiteCreateCallFailed = 8198,

    }

}
