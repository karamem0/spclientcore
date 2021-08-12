//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface ITenantCdnService
    {

        void AddOrigin(TenantCdnType cdnType, string cdnOrigin);

        bool GetEnabled(TenantCdnType cdnType);

        IEnumerable<string> GetOriginEnumerable(TenantCdnType cdnType);

        IEnumerable<string> GetPolicyEnumerable(TenantCdnType cdnType);

        void SetEnabled(TenantCdnType cdnType, bool cdnEnabled, bool noDefaultOrigins);

        void SetPolicy(TenantCdnType cdnType, TenantCdnPolicyType cdnPolicyType, string cdnPolicyValue);

        void RemoveOrigin(TenantCdnType cdnType, string cdnOrigin);

    }

    public class TenantCdnService : ClientService, ITenantCdnService
    {

        public TenantCdnService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddOrigin(TenantCdnType cdnType, string cdnOrigin)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "AddTenantCdnOrigin",
                    requestPayload.CreateParameter(cdnType),
                    requestPayload.CreateParameter(cdnOrigin)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public bool GetEnabled(TenantCdnType cdnType)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "GetTenantCdnEnabled",
                    requestPayload.CreateParameter(cdnType)));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<bool>(requestPayload.GetActionId<ClientActionMethod>());
        }

        public IEnumerable<string> GetOriginEnumerable(TenantCdnType cdnType)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "GetTenantCdnOrigins",
                    requestPayload.CreateParameter(cdnType)));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<IEnumerable<string>>(requestPayload.GetActionId<ClientActionMethod>());
        }

        public IEnumerable<string> GetPolicyEnumerable(TenantCdnType cdnType)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "GetTenantCdnPolicies",
                    requestPayload.CreateParameter(cdnType)));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<IEnumerable<string>>(requestPayload.GetActionId<ClientActionMethod>());
        }

        public void SetEnabled(TenantCdnType cdnType, bool cdnEnabled, bool noDefaultOrigins)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetTenantCdnEnabled",
                    requestPayload.CreateParameter(cdnType),
                    requestPayload.CreateParameter(cdnEnabled)));
            if (noDefaultOrigins)
            {
            }
            else
            {
                var objectPath3 = requestPayload.Add(
                    objectPath1,
                    objectPathId => new ClientActionMethod(
                        objectPathId,
                        "CreateTenantCdnDefaultOrigins",
                        requestPayload.CreateParameter(cdnType)));
            }
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void SetPolicy(TenantCdnType cdnType, TenantCdnPolicyType cdnPolicyType, string cdnPolicyValue)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetTenantCdnPolicy",
                    requestPayload.CreateParameter(cdnType),
                    requestPayload.CreateParameter(cdnPolicyType),
                    requestPayload.CreateParameter(cdnPolicyValue)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveOrigin(TenantCdnType cdnType, string cdnOrigin)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "RemoveTenantCdnOrigin",
                    requestPayload.CreateParameter(cdnType),
                    requestPayload.CreateParameter(cdnOrigin)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
