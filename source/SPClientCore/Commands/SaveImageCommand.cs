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

    [Cmdlet("Save", "KshImage")]
    [OutputType(typeof(ImageItem))]
    public class SaveImageCommand : ClientObjectCmdlet<IImageService>
    {

        public SaveImageCommand()
        {
        }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        public List List { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public ListItem ListItem { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public System.IO.Stream Content { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public string FileName { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.UploadObject(this.List, this.FileName, this.Content));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.UploadObject(this.ListItem, this.FileName, this.Content));
            }
        }

    }

}
