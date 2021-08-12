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

    [Cmdlet("New", "KshView")]
    [OutputType(typeof(View))]
    public class NewViewCommand : ClientObjectCmdlet<IViewService>
    {

        public NewViewCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public List List { get; private set; }

        [Parameter(Mandatory = false)]
        public int BaseViewId { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Paged { get; private set; }

        [Parameter(Mandatory = false)]
        public bool PersonalView { get; private set; }

        [Parameter(Mandatory = false)]
        public int RowLimit { get; private set; }

        [Parameter(Mandatory = false)]
        public bool SetAsDefaultView { get; private set; }

        [Parameter(Mandatory = true)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public string[] ViewColumns { get; private set; }

        [Parameter(Mandatory = false)]
        public string ViewQuery { get; private set; }

        [Parameter(Mandatory = false)]
        public ViewType ViewType { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.List, this.MyInvocation.BoundParameters));
        }

    }

}
