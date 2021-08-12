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

    [ClientObject(Name = "SP.ChangeQuery", Id = "{887a7218-1232-4cfc-b78f-88d54e9d8ec7}")]
    [JsonObject()]
    public class ChangeQuery : ClientValueObject
    {

        public ChangeQuery()
        {
        }

        public ChangeQuery(IReadOnlyDictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.Key)
                {
                    case "BeginToken":
                        this.BeginChangeToken = (ChangeToken)parameter.Value;
                        break;
                    case "EndToken":
                        this.EndChangeToken = (ChangeToken)parameter.Value;
                        break;
                    case "FetchLimit":
                        this.FetchLimit = (long)parameter.Value;
                        break;
                    case "LatestFirst":
                        this.LatestFirst = (bool)parameter.Value;
                        break;
                    case "Objects":
                        var objects = (ChangeObjects)parameter.Value;
                        foreach (var e in Enum.GetValues(typeof(ChangeObjects)).Cast<Enum>().Where(e => objects.HasFlag(e)))
                        {
                            var property = this.GetType().GetProperty(Enum.GetName(typeof(ChangeObjects), e));
                            if (property != null)
                            {
                                property.SetValue(this, true);
                            }
                        }
                        break;
                    case "Operations":
                        var operations = (ChangeOperations)parameter.Value;
                        foreach (var e in Enum.GetValues(typeof(ChangeOperations)).Cast<Enum>().Where(e => operations.HasFlag(e)))
                        {
                            var property = this.GetType().GetProperty(Enum.GetName(typeof(ChangeOperations), e));
                            if (property != null)
                            {
                                property.SetValue(this, true);
                            }
                        }
                        break;
                    case "RecursiveAll":
                        this.RecursiveAll = (bool)parameter.Value;
                        break;
                    default:
                        break;
                }
            }
        }

        [JsonProperty()]
        public virtual bool Activity { get; protected set; }

        [JsonProperty()]
        public virtual bool Add { get; protected set; }

        [JsonProperty()]
        public virtual bool Alert { get; protected set; }

        [JsonProperty("ChangeTokenStart")]
        public virtual ChangeToken BeginChangeToken { get; protected set; }

        [JsonProperty("Field")]
        public virtual bool Column { get; protected set; }

        [JsonProperty()]
        public virtual bool ContentType { get; protected set; }

        [JsonProperty()]
        public virtual bool DeleteObject { get; protected set; }

        [JsonProperty("ChangeTokenEnd")]
        public virtual ChangeToken EndChangeToken { get; protected set; }

        [JsonProperty()]
        public virtual long FetchLimit { get; protected set; }

        [JsonProperty()]
        public virtual bool File { get; protected set; }

        [JsonProperty()]
        public virtual bool Folder { get; protected set; }

        [JsonProperty()]
        public virtual bool Group { get; protected set; }

        [JsonProperty()]
        public virtual bool GroupMembershipAdd { get; protected set; }

        [JsonProperty()]
        public virtual bool GroupMembershipDelete { get; protected set; }

        [JsonProperty()]
        public virtual bool Item { get; protected set; }

        [JsonProperty()]
        public virtual bool LatestFirst { get; protected set; }

        [JsonProperty()]
        public virtual bool List { get; protected set; }

        [JsonProperty()]
        public virtual bool Move { get; protected set; }

        [JsonProperty()]
        public virtual bool Navigation { get; protected set; }

        [JsonProperty()]
        public virtual bool RecursiveAll { get; protected set; }

        [JsonProperty()]
        public virtual bool Rename { get; protected set; }

        [JsonProperty()]
        public virtual bool RequireSecurityTrim { get; protected set; }

        [JsonProperty()]
        public virtual bool Restore { get; protected set; }

        [JsonProperty()]
        public virtual bool RoleAssignmentAdd { get; protected set; }

        [JsonProperty()]
        public virtual bool RoleAssignmentDelete { get; protected set; }

        [JsonProperty()]
        public virtual bool RoleDefinitionAdd { get; protected set; }

        [JsonProperty()]
        public virtual bool RoleDefinitionDelete { get; protected set; }

        [JsonProperty()]
        public virtual bool RoleDefinitionUpdate { get; protected set; }

        [JsonProperty()]
        public virtual bool SecurityPolicy { get; protected set; }

        [JsonProperty("Web")]
        public virtual bool Site { get; protected set; }

        [JsonProperty("Site")]
        public virtual bool SiteCollection { get; protected set; }

        [JsonProperty()]
        public virtual bool SystemUpdate { get; protected set; }

        [JsonProperty()]
        public virtual bool Update { get; protected set; }

        [JsonProperty()]
        public virtual bool User { get; protected set; }

        [JsonProperty()]
        public virtual bool View { get; protected set; }

    }

}
