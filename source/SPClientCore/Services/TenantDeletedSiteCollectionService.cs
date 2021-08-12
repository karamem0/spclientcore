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

    public interface ITenantDeletedSiteCollectionService
    {

        TenantDeletedSiteCollection GetObject(TenantDeletedSiteCollection siteCollectionObject);

        TenantDeletedSiteCollection GetObject(Uri siteCollectionUrl);

        IEnumerable<TenantDeletedSiteCollection> GetObjectEnumerable();

        TenantOperationResult RemoveObject(TenantDeletedSiteCollection siteCollectionObject);

        void RemoveObjectAwait(TenantDeletedSiteCollection siteCollectionObject);

        TenantOperationResult RestoreObject(TenantDeletedSiteCollection siteCollectionObject);

        void RestoreObjectAwait(TenantDeletedSiteCollection siteCollectionObject);

    }

    public class TenantDeletedSiteCollectionService : TenantClientService, ITenantDeletedSiteCollectionService
    {

        public TenantDeletedSiteCollectionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public TenantDeletedSiteCollection GetObject(TenantDeletedSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(siteCollectionObject.ObjectIdentity),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantDeletedSiteCollection))
                });
            var clientObject = this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantDeletedSiteCollection>(requestPayload.GetActionId<ClientActionQuery>());
            return this.GetObject(new Uri(clientObject.Url, UriKind.Absolute));
        }

        public TenantDeletedSiteCollection GetObject(Uri siteCollectionUrl)
        {
            _ = siteCollectionUrl ?? throw new ArgumentNullException(nameof(siteCollectionUrl));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetDeletedSitePropertiesByUrl",
                    requestPayload.CreateParameter(siteCollectionUrl.ToString()),
                    requestPayload.CreateParameter(false)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantDeletedSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantDeletedSiteCollection>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TenantDeletedSiteCollection> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetDeletedSitePropertiesFromSharePoint",
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

        public TenantOperationResult RemoveObject(TenantDeletedSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            _ = siteCollectionObject.Url ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "RemoveDeletedSite",
                    requestPayload.CreateParameter(siteCollectionObject.Url)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObjectAwait(TenantDeletedSiteCollection siteCollectionObject)
        {
            this.WaitObject(this.RemoveObject(siteCollectionObject));
        }

        public TenantOperationResult RestoreObject(TenantDeletedSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            _ = siteCollectionObject.Url ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "RestoreDeletedSite",
                    requestPayload.CreateParameter(siteCollectionObject.Url)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RestoreObjectAwait(TenantDeletedSiteCollection siteCollectionObject)
        {
            this.WaitObject(this.RestoreObject(siteCollectionObject));
        }

    }

}
