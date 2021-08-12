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

    [Cmdlet("Update", "KshList")]
    [OutputType(typeof(List))]
    public class UpdateListCommand : ClientObjectCmdlet<IListService>
    {

        public UpdateListCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public List Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public bool ContentTypesEnabled { get; private set; }

        [Parameter(Mandatory = false)]
        public string DefaultContentApprovalWorkflowId { get; private set; }

        [Parameter(Mandatory = false)]
        public string DefaultDisplayFormUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public string DefaultEditFormUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public string DefaultNewFormUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public string Description { get; private set; }

        [Parameter(Mandatory = false)]
        public string Direction { get; private set; }

        [Parameter(Mandatory = false)]
        public bool DisableCommenting { get; private set; }

        [Parameter(Mandatory = false)]
        public bool DisableGridEditing { get; private set; }

        [Parameter(Mandatory = false)]
        public string DocumentTemplateUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public DraftVisibilityType DraftVersionVisibility { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnableAttachments { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnableFolderCreation { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnableMinorVersions { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnableModeration { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EnableVersioning { get; private set; }

        [Parameter(Mandatory = false)]
        public bool ForceCheckout { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Hidden { get; private set; }

        [Parameter(Mandatory = false)]
        public bool IrmEnabled { get; private set; }

        [Parameter(Mandatory = false)]
        public bool IrmExpire { get; private set; }

        [Parameter(Mandatory = false)]
        public bool IrmReject { get; private set; }

        [Parameter(Mandatory = false)]
        public bool IsApplicationList { get; private set; }

        [Parameter(Mandatory = false)]
        public DateTime LastItemModifiedDate { get; private set; }

        [Parameter(Mandatory = false)]
        public bool MultipleDataList { get; private set; }

        [Parameter(Mandatory = false)]
        public bool NoCrawl { get; private set; }

        [Parameter(Mandatory = false)]
        public bool OnQuickLaunch { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public string ValidationFormula { get; private set; }

        [Parameter(Mandatory = false)]
        public string ValidationMessage { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.UpdateObject(this.Identity, this.MyInvocation.BoundParameters);
            if (this.PassThru)
            {
                this.WriteObject(this.Service.GetObject(this.Identity));
            }
        }

    }

}
