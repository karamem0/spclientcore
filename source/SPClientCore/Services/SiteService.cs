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

    public interface ISiteService
    {

        Site CreateObject(IReadOnlyDictionary<string, object> creationInformation);

        Site GetObject();

        Site GetObject(Site siteObject);

        Site GetObject(SiteCollection siteCollectionObject);

        Site GetObject(List listObject);

        Site GetObject(Guid siteId);

        Site GetObject(Uri siteUrl);

        IEnumerable<Site> GetObjectEnumerable();

        void RemoveObject(Site siteObject);

        void SelectObject(Site siteObject);

        void UpdateObject(Site siteObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class SiteService : ClientService<Site>, ISiteService
    {

        public SiteService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Site CreateObject(IReadOnlyDictionary<string, object> creationInformation)
        {
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Webs"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "Add",
                    requestPayload.CreateParameter(new SiteCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Site>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Site GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Site>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Site GetObject(SiteCollection siteCollectionObject)
        {
            if (siteCollectionObject == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "OpenWeb",
                    requestPayload.CreateParameter(siteCollectionObject.ServerRelativeUrl)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Site>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Site GetObject(List listObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ParentWeb"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Site>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Site GetObject(Guid siteId)
        {
            if (siteId == default)
            {
                throw new ArgumentNullException(nameof(siteId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "OpenWebById",
                    requestPayload.CreateParameter(siteId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Site>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Site GetObject(Uri siteUrl)
        {
            if (siteUrl == null)
            {
                throw new ArgumentNullException(nameof(siteUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "OpenWeb",
                    requestPayload.CreateParameter(siteUrl.ToString())),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Site>(requestPayload.GetActionId<ClientActionQuery>());
        }
        public IEnumerable<Site> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Webs"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Site))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<SiteEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void SelectObject(Site siteObject)
        {
            if (siteObject == null)
            {
                throw new ArgumentNullException(nameof(siteObject));
            }
            this.ClientContext.BaseAddress = new Uri(siteObject.Url, UriKind.Absolute);
        }

    }

}
