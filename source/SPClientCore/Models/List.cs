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

    [ClientObject(Name = "SP.List", Id = "{d89f0b18-614e-4b4a-bac0-fd6142b55448}")]
    [JsonObject()]
    public class List : SecurableObject
    {

        public List()
        {
        }

        [JsonProperty()]
        public virtual bool AllowContentTypes { get; protected set; }

        [JsonProperty()]
        public virtual int BaseTemplate { get; protected set; }

        [JsonProperty()]
        public virtual BaseType BaseType { get; protected set; }

        [JsonProperty()]
        public virtual BrowserFileHandling BrowserFileHandling { get; protected set; }

        [JsonProperty()]
        public virtual bool ContentTypesEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool CrawlNonDefaultViews { get; protected set; }

        [JsonProperty()]
        public virtual DateTime Created { get; protected set; }

        [JsonProperty()]
        public virtual ChangeToken CurrentChangeToken { get; protected set; }

        [JsonProperty()]
        public virtual CustomActionElementEnumerable CustomActionElements { get; protected set; }

        [JsonProperty()]
        public virtual ListDataSource DataSource { get; protected set; }

        [JsonProperty()]
        public virtual Guid DefaultContentApprovalWorkflowId { get; protected set; }

        [JsonProperty()]
        public virtual string DefaultDisplayFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string DefaultEditFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool DefaultItemOpenUseListSetting { get; protected set; }

        [JsonProperty()]
        public virtual string DefaultNewFormUrl { get; protected set; }

        [JsonProperty()]
        public virtual string DefaultViewUrl { get; protected set; }

        [JsonProperty()]
        public virtual string Description { get; protected set; }

        [JsonProperty()]
        public virtual string Direction { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableCommenting { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableGridEditing { get; protected set; }

        [JsonProperty()]
        public virtual string DocumentTemplateUrl { get; protected set; }

        [JsonProperty()]
        public virtual DraftVisibilityType DraftVersionVisibility { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableAttachments { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableFolderCreation { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableMinorVersions { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableModeration { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableRequestSignOff { get; protected set; }

        [JsonProperty()]
        public virtual bool EnableVersioning { get; protected set; }

        [JsonProperty()]
        public virtual string EntityTypeName { get; protected set; }

        [JsonProperty()]
        public virtual bool ExemptFromBlockDownloadOfNonViewableFiles { get; protected set; }

        [JsonProperty()]
        public virtual bool FileSavePostProcessingEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ForceCheckout { get; protected set; }

        [JsonProperty()]
        public virtual bool HasExternalDataSource { get; protected set; }

        [JsonProperty()]
        public override bool HasUniqueRoleAssignments { get; protected set; }

        [JsonProperty()]
        public virtual bool Hidden { get; protected set; }

        [JsonProperty()]
        public virtual Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual ResourcePath ImagePath { get; protected set; }

        [JsonProperty()]
        public virtual string ImageUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool IrmEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool IrmExpire { get; protected set; }

        [JsonProperty()]
        public virtual bool IrmReject { get; protected set; }

        [JsonProperty()]
        public virtual bool IsApplicationList { get; protected set; }

        [JsonProperty()]
        public virtual bool IsCatalog { get; protected set; }

        [JsonProperty()]
        public virtual bool IsPrivate { get; protected set; }

        [JsonProperty()]
        public virtual bool IsSiteAssetsLibrary { get; protected set; }

        [JsonProperty()]
        public virtual int ItemCount { get; protected set; }

        [JsonProperty()]
        public virtual DateTime LastItemDeletedDate { get; protected set; }

        [JsonProperty()]
        public virtual DateTime LastItemModifiedDate { get; protected set; }

        [JsonProperty()]
        public virtual DateTime LastItemUserModifiedDate { get; protected set; }

        [JsonProperty()]
        public virtual ListExperience ListExperienceOptions { get; protected set; }

        [JsonProperty()]
        public virtual string ListItemEntityTypeFullName { get; protected set; }

        [JsonProperty()]
        public virtual int MajorVersionLimit { get; protected set; }

        [JsonProperty()]
        public virtual int MajorWithMinorVersionsLimit { get; protected set; }

        [JsonProperty()]
        public virtual bool MultipleDataList { get; protected set; }

        [JsonProperty()]
        public virtual bool NoCrawl { get; protected set; }

        [JsonProperty("ParentWebPath")]
        public virtual ResourcePath ParentSitePath { get; protected set; }

        [JsonProperty("ParentWebUrl")]
        public virtual string ParentSiteUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool ParserDisabled { get; protected set; }

        [JsonProperty()]
        public virtual string SchemaXml { get; protected set; }

        [JsonProperty()]
        public virtual bool ServerTemplateCanCreateFolders { get; protected set; }

        [JsonProperty()]
        public virtual Guid TemplateFeatureId { get; protected set; }

        [JsonProperty()]
        public virtual string Title { get; protected set; }

        [JsonProperty()]
        public virtual string ValidationFormula { get; protected set; }

        [JsonProperty()]
        public virtual string ValidationMessage { get; protected set; }

    }

}
