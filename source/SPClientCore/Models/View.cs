//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [ClientObject(Name = "SP.View", Id = "{2399f45d-1784-4965-9a5f-a3415790a0d0}")]
    [JsonObject()]
    public class View : ClientObject
    {

        public View()
        {
        }

        [JsonProperty()]
        public string Aggregations { get; private set; }

        [JsonProperty()]
        public string AggregationsStatus { get; private set; }

        [JsonProperty()]
        public string AssociatedContentTypeId { get; private set; }

        [JsonProperty()]
        public string BaseViewId { get; private set; }

        [JsonProperty()]
        public string CalendarViewStyles { get; private set; }

        [JsonProperty()]
        public string ColumnWidth { get; private set; }

        [JsonProperty()]
        public ContentTypeId ContentTypeId { get; private set; }

        [JsonProperty()]
        public string CustomFormatter { get; private set; }

        [JsonProperty()]
        public string CustomOrder { get; private set; }

        [JsonProperty()]
        public bool DefaultView { get; private set; }

        [JsonProperty()]
        public bool DefaultViewForContentType { get; private set; }

        [JsonProperty()]
        public bool EditorModified { get; private set; }

        [JsonProperty()]
        public string Formats { get; private set; }

        [JsonProperty()]
        public string GridLayout { get; private set; }

        [JsonProperty()]
        public bool Hidden { get; private set; }

        [JsonProperty()]
        public string HtmlSchemaXml { get; private set; }

        [JsonProperty()]
        public Guid Id { get; private set; }

        [JsonProperty()]
        public string ImageUrl { get; private set; }

        [JsonProperty()]
        public bool IncludeRootFolder { get; private set; }

        [JsonProperty()]
        public string JSLink { get; private set; }

        [JsonProperty()]
        public string ListViewXml { get; private set; }

        [JsonProperty()]
        public string Method { get; private set; }

        [JsonProperty()]
        public bool MobileDefaultView { get; private set; }

        [JsonProperty()]
        public bool MobileView { get; private set; }

        [JsonProperty()]
        public string ModerationType { get; private set; }

        [JsonProperty()]
        public string NewDocumentTemplates { get; private set; }

        [JsonProperty()]
        public bool OrderedView { get; private set; }

        [JsonProperty()]
        public bool Paged { get; private set; }

        [JsonProperty()]
        public ListPageRenderType PageRenderType { get; private set; }

        [JsonProperty()]
        public bool PersonalView { get; private set; }

        [JsonProperty()]
        public bool ReadOnlyView { get; private set; }

        [JsonProperty()]
        public bool RequiresClientIntegration { get; private set; }

        [JsonProperty()]
        public int RowLimit { get; private set; }

        [JsonProperty()]
        public ViewScope Scope { get; private set; }

        [JsonProperty()]
        public ResourcePath ServerRelativePath { get; private set; }

        [JsonProperty()]
        public string ServerRelativeUrl { get; private set; }

        [JsonProperty()]
        public string StyleId { get; private set; }

        [JsonProperty()]
        public bool TabularView { get; private set; }

        [JsonProperty()]
        public bool Threaded { get; private set; }

        [JsonProperty()]
        public string Title { get; private set; }

        [JsonProperty()]
        public string Toolbar { get; private set; }

        [JsonProperty()]
        public string ToolbarTemplateName { get; private set; }

        [JsonProperty()]
        public string ViewData { get; private set; }

        [JsonProperty()]
        public string ViewJoins { get; private set; }

        [JsonProperty("ViewProjectedFields")]
        public string ViewProjectedColumns { get; private set; }

        [JsonProperty()]
        public string ViewQuery { get; private set; }

        [JsonProperty()]
        public string ViewType { get; private set; }

        [JsonProperty()]
        public string ViewType2 { get; private set; }

        [JsonProperty()]
        public string VisualizationInfo { get; private set; }

    }

}
