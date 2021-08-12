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

    public interface ITenantHubSiteService
    {

        HubSite CreateObject(string siteCollectionUrl, IReadOnlyDictionary<string, object> creationInformation);

        HubSite GetObject(Guid hubSiteId);

        HubSite GetObject(string hubSiteUrl);

        IEnumerable<HubSite> GetObjectEnumerable();

        void RemoveObject(HubSite hubSiteObject);

        void UpdateObject(HubSite hubSiteObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TenantHubSiteService : ClientService<HubSite>, ITenantHubSiteService
    {

        public TenantHubSiteService(ClientContext clientContext) : base(clientContext)
        {
        }

        public HubSite CreateObject(string siteCollectionUrl, IReadOnlyDictionary<string, object> creationInformation)
        {
            if (siteCollectionUrl == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionUrl));
            }
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "RegisterHubSiteWithCreationInformation",
                    requestPayload.CreateParameter(siteCollectionUrl),
                    requestPayload.CreateParameter(new HubSiteCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(HubSite))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<HubSite>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public HubSite GetObject(Guid hubSiteId)
        {
            if (hubSiteId == default)
            {
                throw new ArgumentNullException(nameof(hubSiteId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetHubSitePropertiesById",
                    requestPayload.CreateParameter(hubSiteId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(HubSite))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<HubSite>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public HubSite GetObject(string hubSiteUrl)
        {
            if (hubSiteUrl == null)
            {
                throw new ArgumentNullException(nameof(hubSiteUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetHubSitePropertiesByUrl",
                    requestPayload.CreateParameter(hubSiteUrl)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(HubSite))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<HubSite>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<HubSite> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetHubSitesProperties"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(HubSite))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<HubSiteEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public override void RemoveObject(HubSite hubSiteObject)
        {
            if (hubSiteObject == null)
            {
                throw new ArgumentNullException(nameof(hubSiteObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "UnregisterHubSite",
                    requestPayload.CreateParameter(hubSiteObject.SiteCollectionUrl)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public override void UpdateObject(HubSite hubSiteObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (hubSiteObject == null)
            {
                throw new ArgumentNullException(nameof(hubSiteObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetHubSitePropertiesByUrl",
                    requestPayload.CreateParameter(hubSiteObject.SiteCollectionUrl)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty
                });
            var objectPath3 = requestPayload.Add(
                objectPath2,
                requestPayload.CreateSetPropertyDelegates(hubSiteObject, modificationInformation).ToArray());
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
