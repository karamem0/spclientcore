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
    public enum ChangeOperations
    {

        None = 0,

        Add = 1,

        Update = 2,

        DeleteObject = 4,

        Rename = 8,

        Move = 16,

        Restore = 32,

        RoleDefinitionAdd = 64,

        RoleDefinitionDelete = 128,

        RoleDefinitionUpdate = 256,

        RoleAssignmentAdd = 512,

        RoleAssignmentDelete = 1024,

        GroupMembershipAdd = 2048,

        GroupMembershipDelete = 4096,

        SystemUpdate = 8192,

        Navigation = 16384,

        All = 32767,

    }

}
