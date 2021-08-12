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

    public enum RecycleBinItemType
    {

        None = 0,

        File = 1,

        FileVersion = 2,

        ListItem = 3,

        List = 4,

        Folder = 5,

        FolderWithLists = 6,

        Attachment = 7,

        ListItemVersion = 8,

        CascadeParent = 9,

    }

}
