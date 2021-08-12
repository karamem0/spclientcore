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

    [Cmdlet("Unlock", "KshFile")]
    [OutputType(typeof(File))]
    public class UnlockFileCommand : ClientObjectCmdlet<IFileService>
    {

        public UnlockFileCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet2")]
        public File Identity { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        public string Comment { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        public CheckInType CheckInType { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public SwitchParameter Undo { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet2")]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.Service.CheckInObject(this.Identity, this.Comment, this.CheckInType);
                if (this.PassThru)
                {
                    this.WriteObject(this.Service.GetObject(this.Identity));
                }
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.ValidateSwitchParameter(nameof(this.Undo));
                this.Service.UndoCheckOutObject(this.Identity);
                if (this.PassThru)
                {
                    this.WriteObject(this.Service.GetObject(this.Identity));
                }
            }
        }

    }

}
