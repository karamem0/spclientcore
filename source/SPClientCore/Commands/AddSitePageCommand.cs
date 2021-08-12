//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Add", "KshSitePage")]
    [OutputType(typeof(void))]
    public class AddSitePageCommand : ClientObjectCmdlet<IListService, IFolderService, ISitePageService>
    {

        public AddSitePageCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet1")]
        public List List { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public string PageName { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet2")]
        public SitePageLayoutType PageLayoutType { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                var folderObject = this.Service2.GetObject(this.List);
                this.Service3.AddObject(folderObject, this.PageName, this.PageLayoutType);
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                var listObject = this.Service1.GetObject(LibraryType.ClientRenderedSitePages);
                var folderObject = this.Service2.GetObject(listObject);
                this.Service3.AddObject(folderObject, this.PageName, this.PageLayoutType);
            }
        }

    }

}
