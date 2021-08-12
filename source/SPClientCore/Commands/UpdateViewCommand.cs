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

    [Cmdlet("Update", "KshView")]
    [OutputType(typeof(View))]
    public class UpdateViewCommand : ClientObjectCmdlet<IViewService>
    {

        public UpdateViewCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public View Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public string Aggregations { get; private set; }

        [Parameter(Mandatory = false)]
        public string AggregationsStatus { get; private set; }

        [Parameter(Mandatory = false)]
        public string AssociatedContentTypeId { get; private set; }

        [Parameter(Mandatory = false)]
        public string CalendarViewStyles { get; private set; }

        [Parameter(Mandatory = false)]
        public ContentTypeId ContentTypeId { get; private set; }

        [Parameter(Mandatory = false)]
        public string CustomOrder { get; private set; }

        [Parameter(Mandatory = false)]
        public bool DefaultView { get; private set; }

        [Parameter(Mandatory = false)]
        public bool DefaultViewForContentType { get; private set; }

        [Parameter(Mandatory = false)]
        public bool EditorModified { get; private set; }

        [Parameter(Mandatory = false)]
        public string Formats { get; private set; }

        [Parameter(Mandatory = false)]
        public string GridLayout { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Hidden { get; private set; }

        [Parameter(Mandatory = false)]
        public string ImageUrl { get; private set; }

        [Parameter(Mandatory = false)]
        public bool IncludeRootFolder { get; private set; }

        [Parameter(Mandatory = false)]
        public string JSLink { get; private set; }

        [Parameter(Mandatory = false)]
        public string ListViewXml { get; private set; }

        [Parameter(Mandatory = false)]
        public string Method { get; private set; }

        [Parameter(Mandatory = false)]
        public bool MobileDefaultView { get; private set; }

        [Parameter(Mandatory = false)]
        public bool MobileView { get; private set; }

        [Parameter(Mandatory = false)]
        public string NewDocumentTemplates { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Paged { get; private set; }

        [Parameter(Mandatory = false)]
        public int RowLimit { get; private set; }

        [Parameter(Mandatory = false)]
        public ViewScope Scope { get; private set; }

        [Parameter(Mandatory = false)]
        public bool TabularView { get; private set; }

        [Parameter(Mandatory = false)]
        public string Title { get; private set; }

        [Parameter(Mandatory = false)]
        public string Toolbar { get; private set; }

        [Parameter(Mandatory = false)]
        public string ViewData { get; private set; }

        [Parameter(Mandatory = false)]
        public string ViewJoins { get; private set; }

        [Parameter(Mandatory = false)]
        public string ViewProjectedColumns { get; private set; }

        [Parameter(Mandatory = false)]
        public string ViewQuery { get; private set; }

        [Parameter(Mandatory = false)]
        public string ViewType2 { get; private set; }

        [Parameter(Mandatory = false)]
        public string VisualizationInfo { get; private set; }

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
