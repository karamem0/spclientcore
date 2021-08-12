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

    public interface ITenantDeletedPersonalSiteCollectionService
    {

        IEnumerable<TenantDeletedSiteCollection> GetObjectEnumerable();

        IEnumerable<TenantDeletedSiteCollection> GetObjectEnumerable(Uri siteCollectionUrl);

    }

    public class TenantDeletedPersonalSiteCollectionService : ClientService, ITenantDeletedPersonalSiteCollectionService
    {

        public TenantDeletedPersonalSiteCollectionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public IEnumerable<TenantDeletedSiteCollection> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetAllDeletedPersonalSitesPropertiesAllVersions",
                    requestPayload.CreateParameter(null)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TenantDeletedSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantDeletedSiteCollectionsEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TenantDeletedSiteCollection> GetObjectEnumerable(Uri siteCollectionUrl)
        {
            if (siteCollectionUrl == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetDeletedPersonalSitePropertiesAllVersions",
                    requestPayload.CreateParameter(siteCollectionUrl.ToString())),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantDeletedSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantDeletedSiteCollectionsEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
