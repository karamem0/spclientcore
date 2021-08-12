//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Copy", "KshFolder")]
    [OutputType(typeof(Folder))]
    public class CopyFolderCommand : ClientObjectCmdlet<IFolderService>
    {

        public CopyFolderCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Folder Identity { get; private set; }

        [Parameter(Mandatory = true, Position = 1)]
        public Uri NewUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter KeepBoth { get; protected set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter ResetAuthorAndCreatedOnCopy { get; protected set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter RetainEditorAndModifiedOnMove { get; protected set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter ShouldBypassSharedLocks { get; protected set; }

        protected override void ProcessRecordCore()
        {
            if (this.NewUrl.IsAbsoluteUri)
            {
                var moveCopyOptions = new MoveCopyOptions(this.MyInvocation.BoundParameters);
                this.Service.CopyObject(this.Identity, this.NewUrl, moveCopyOptions);
            }
            else
            {
                throw new ArgumentException(
                    string.Format(StringResources.ErrorValueIsNotAbsoluteUrl, this.NewUrl),
                    nameof(this.NewUrl));
            }
        }

    }

}
