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

    [Cmdlet("Get", "KshListItem")]
    [OutputType(typeof(ListItem))]
    public class GetListItemCommand : ClientObjectCmdlet<IListItemService>
    {

        public GetListItemCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        public ListItem Identity { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet2")]
        public Folder Folder { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet3")]
        public File File { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet4")]
        public string ItemUrl { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet5")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet6")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet7")]
        public List List { get; private set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet5")]
        public int ItemId { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet6")]
        public SwitchParameter All { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet7")]
        public string FolderServerRelativeUrl { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet7")]
        public ListItemCollectionPosition ListItemCollectionPosition { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet7")]
        public string ViewXml { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet6")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet7")]
        public SwitchParameter NoEnumerate { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.GetObject(this.Identity));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.GetObject(this.Folder));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.WriteObject(this.Service.GetObject(this.File));
            }
            if (this.ParameterSetName == "ParamSet4")
            {
                this.WriteObject(this.Service.GetObject(this.ItemUrl));
            }
            if (this.ParameterSetName == "ParamSet5")
            {
                this.WriteObject(this.Service.GetObject(this.List, this.ItemId));
            }
            if (this.ParameterSetName == "ParamSet6")
            {
                this.ValidateSwitchParameter(nameof(this.All));
                this.WriteObject(this.Service.GetObjectEnumerable(this.List), this.NoEnumerate ? false : true);
            }
            if (this.ParameterSetName == "ParamSet7")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(this.List, this.MyInvocation.BoundParameters), this.NoEnumerate ? false : true);
            }
        }

    }

}
