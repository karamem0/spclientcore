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

    [Cmdlet("Get", "KshFolder")]
    [OutputType(typeof(Folder))]
    public class GetFolderCommand : ClientObjectCmdlet<IFolderService>
    {

        public GetFolderCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        public Folder Identity { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet2")]
        public List List { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet3")]
        public Guid FolderId { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet4")]
        public Uri FolderUrl { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet5")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet6")]
        public Folder Folder { get; private set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet5")]
        public string FolderName { get; private set; }

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
                this.WriteObject(this.Service.GetObject(this.List));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.WriteObject(this.Service.GetObject(this.FolderId));
            }
            if (this.ParameterSetName == "ParamSet4")
            {
                if (this.FolderUrl.IsAbsoluteUri)
                {
                    this.WriteObject(this.Service.GetObject(new Uri(this.FolderUrl.AbsolutePath, UriKind.Relative)));
                }
                else
                {
                    this.WriteObject(this.Service.GetObject(this.FolderUrl));
                }
            }
            if (this.ParameterSetName == "ParamSet5")
            {
                this.WriteObject(this.Service.GetObject(this.Folder, this.FolderName));
            }
            if (this.ParameterSetName == "ParamSet6")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(this.Folder), this.NoEnumerate ? false : true);
            }
            if (this.ParameterSetName == "ParamSet7")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(), this.NoEnumerate ? false : true);
            }
        }

    }

}
