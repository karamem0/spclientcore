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

    public enum ListTemplateType
    {

        InvalidType = -1,

        NoListTemplate = 0,

        GenericList = 100,

        DocumentLibrary = 101,

        Survey = 102,

        Links = 103,

        Announcements = 104,

        Contacts = 105,

        Events = 106,

        Tasks = 107,

        DiscussionBoard = 108,

        PictureLibrary = 109,

        DataSources = 110,

        XmlForm = 115,

        NoCodeWorkflows = 117,

        WorkflowProcess = 118,

        WebPageLibrary = 119,

        CustomGrid = 120,

        WorkflowHistory = 140,

        GanttTasks = 150,

        IssuesTracking = 1100,

    }

}
