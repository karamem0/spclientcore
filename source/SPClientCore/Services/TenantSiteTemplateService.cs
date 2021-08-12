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

    public interface ITenantSiteTemplateService
    {

        IEnumerable<TenantSiteTemplate> GetObjectEnumerable(uint lcid, int compatibilityLevel);

        IEnumerable<TenantSiteTemplate> GetObjectEnumerable();

    }

    public class TenantSiteTemplateService : ClientService, ITenantSiteTemplateService
    {

        public TenantSiteTemplateService(ClientContext clientContext) : base(clientContext)
        {
        }

        public IEnumerable<TenantSiteTemplate> GetObjectEnumerable(uint lcid, int compatibilityLevel)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetSPOTenantWebTemplates",
                    requestPayload.CreateParameter(lcid),
                    requestPayload.CreateParameter(compatibilityLevel)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = ClientQuery.Empty
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantSiteTemplateEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TenantSiteTemplate> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetSPOTenantAllWebTemplates"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = ClientQuery.Empty
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantSiteTemplateEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
