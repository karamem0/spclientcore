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

    [ClientObject(Name = "SP.Site", Id = "{e1bb82e8-0d1e-4e52-b90c-684802ab4ef6}")]
    [JsonObject()]
    public class SiteCollection : ClientObject
    {

        public SiteCollection()
        {
        }

        [JsonProperty()]
        public virtual bool AllowCreateDeclarativeWorkflow { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowDesigner { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowMasterPageEditing { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowRevertFromTemplate { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSaveDeclarativeWorkflowAsTemplate { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSavePublishDeclarativeWorkflow { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSelfServiceUpgrade { get; protected set; }

        [JsonProperty()]
        public virtual bool AllowSelfServiceUpgradeEvaluation { get; protected set; }

        [JsonProperty()]
        public virtual int AuditLogTrimmingRetention { get; protected set; }

        [JsonProperty()]
        public virtual Guid ChannelGroupId { get; protected set; }

        [JsonProperty()]
        public virtual string Classification { get; protected set; }

        [JsonProperty()]
        public virtual int CompatibilityLevel { get; protected set; }

        [JsonProperty()]
        public virtual ChangeToken CurrentChangeToken { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableAppViews { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableCompanyWideSharingLinks { get; protected set; }

        [JsonProperty()]
        public virtual bool DisableFlows { get; protected set; }

        [JsonProperty()]
        public virtual bool ExternalSharingTipsEnabled { get; protected set; }

        [JsonProperty()]
        public virtual string GeoLocation { get; protected set; }

        [JsonProperty()]
        public virtual Guid GroupId { get; protected set; }

        [JsonProperty()]
        public virtual Guid HubSiteId { get; protected set; }

        [JsonProperty()]
        public virtual Guid Id { get; protected set; }

        [JsonProperty()]
        public virtual bool IsHubSite { get; protected set; }

        [JsonProperty()]
        public virtual string LockIssue { get; protected set; }

        [JsonProperty()]
        public virtual int MaxItemsPerThrottledOperation { get; protected set; }

        [JsonProperty()]
        public virtual bool MediaTranscriptionDisabled { get; protected set; }

        [JsonProperty()]
        public virtual bool NeedsB2BUpgrade { get; protected set; }

        [JsonProperty()]
        public virtual ResourcePath ResourcePath { get; protected set; }

        [JsonProperty("PrimaryUri")]
        public virtual string PrimaryUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool ReadOnly { get; protected set; }

        [JsonProperty()]
        public virtual string RequiredDesignerVersion { get; protected set; }

        [JsonProperty()]
        public virtual int SandboxedCodeActivationCapability { get; protected set; }

        [JsonProperty()]
        public virtual Guid SensitivityLabel { get; protected set; }

        [JsonProperty()]
        public virtual string SensitivityLabelId { get; protected set; }

        [JsonProperty()]
        public virtual string ServerRelativeUrl { get; protected set; }

        [JsonProperty()]
        public virtual bool ShareByEmailEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ShareByLinkEnabled { get; protected set; }

        [JsonProperty()]
        public virtual bool ShowUrlStructure { get; protected set; }

        [JsonProperty()]
        public virtual bool TrimAuditLog { get; protected set; }

        [JsonProperty()]
        public virtual bool UIVersionConfigurationEnabled { get; protected set; }

        [JsonProperty()]
        public virtual DateTime UpgradeReminderDate { get; protected set; }

        [JsonProperty()]
        public virtual bool UpgradeScheduled { get; protected set; }

        [JsonProperty()]
        public virtual DateTime UpgradeScheduledDate { get; protected set; }

        [JsonProperty()]
        public virtual bool Upgrading { get; protected set; }

        [JsonProperty()]
        public virtual string Url { get; protected set; }

    }

}
