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

    public interface ISiteCollectionAppCatalogService
    {

        void AddObject(Uri siteCollectionUrl);

        SiteCollectionAppCatalog GetObject(SiteCollectionAppCatalog siteCollectionAppCatalogObject);

        IEnumerable<SiteCollectionAppCatalog> GetObjectEnumerable();

        void RemoveObject(Uri siteCollectionUrl);

        void RemoveObject(Guid siteCollectionId);

    }

    public class SiteCollectionAppCatalogService : ClientService<SiteCollectionAppCatalog>, ISiteCollectionAppCatalogService
    {

        public SiteCollectionAppCatalogService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(Uri siteCollectionUrl)
        {
            if (siteCollectionUrl == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TenantAppCatalog"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "SiteCollectionAppCatalogsSites"));
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Add",
                    requestPayload.CreateParameter(siteCollectionUrl.ToString())));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public IEnumerable<SiteCollectionAppCatalog> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TenantAppCatalog"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "SiteCollectionAppCatalogsSites"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(SiteCollectionAppCatalog))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<SiteCollectionAppCatalogEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObject(Uri siteCollectionUrl)
        {
            if (siteCollectionUrl == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TenantAppCatalog"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "SiteCollectionAppCatalogsSites"));
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Remove",
                    requestPayload.CreateParameter(siteCollectionUrl.ToString())));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveObject(Guid siteCollectionId)
        {
            if (siteCollectionId == default)
            {
                throw new ArgumentNullException(nameof(siteCollectionId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TenantAppCatalog"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "SiteCollectionAppCatalogsSites"));
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "RemoveById",
                    requestPayload.CreateParameter(siteCollectionId)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
