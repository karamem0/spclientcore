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

    public enum ListPageRenderType
    {

        Undefined = 0,

        MultipeWePart = 1,

        JSLinkCustomization = 2,

        XslLinkCustomization = 3,

        NoSPList = 4,

        HasBusinessDataField = 5,

        HasTaskOutcomeField = 6,

        HasPublishingfield = 7,

        HasGeolocationField = 8,

        HasCustomActionWithCode = 9,

        HasMetadataNavFeature = 10,

        SpecialViewType = 11,

        ListTypeNoSupportForModernMode = 12,

        AnonymousUser = 13,

        ListSettingOff = 14,

        SiteSettingOff = 15,

        WebSettingOff = 16,

        TenantSettingOff = 17,

        CustomizedForm = 18,

        DocLibNewForm = 19,

        UnsupportedFieldTypeInForm = 20,

        InvalidFieldTypeInForm = 21,

        InvalidControModeInForm = 22,

        CustomizedPage = 23,

        ListTemplateNotSupported = 24,

        WikiPage = 25,

        DropOffLibrary = 26,

        IsUnghosted = 27,

        Modern = 100,

    }

}
