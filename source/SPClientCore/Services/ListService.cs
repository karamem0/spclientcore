//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface IListService
    {

        List CreateObject(IReadOnlyDictionary<string, object> creationInformation);

        List GetObject(List listObject);

        List GetObject(ListItem listItemObject);

        List GetObject(View viewObject);

        List GetObject(Guid listId);

        List GetObject(Uri listUrl);

        List GetObject(string listTitle);

        List GetObject(LibraryType libraryType);

        IEnumerable<List> GetObjectEnumerable();

        Guid RecycleObject(List listObject);

        void RemoveObject(List listObject);

        void UpdateObject(List listObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class ListService : ClientService<List>, IListService
    {

        public ListService(ClientContext clientContext) : base(clientContext)
        {
        }

        public List CreateObject(IReadOnlyDictionary<string, object> creationInformation)
        {
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Lists"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "Add",
                    requestPayload.CreateParameter(new ListCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public List GetObject(ListItem listItemObject)
        {
            if (listItemObject == null)
            {
                throw new ArgumentNullException(nameof(listItemObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ParentList"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public List GetObject(View viewObject)
        {
            if (viewObject == null)
            {
                throw new ArgumentNullException(nameof(viewObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(string.Join(":", viewObject.ObjectIdentity.Split(':').SkipLast(2))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public List GetObject(Guid listId)
        {
            if (listId == default)
            {
                throw new ArgumentNullException(nameof(listId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Lists"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetById",
                    requestPayload.CreateParameter(listId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public List GetObject(Uri listUrl)
        {
            if (listUrl == null)
            {
                throw new ArgumentNullException(nameof(listUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetList",
                    requestPayload.CreateParameter(listUrl.ToString())),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public List GetObject(string listTitle)
        {
            if (listTitle == null)
            {
                throw new ArgumentNullException(nameof(listTitle));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Lists"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetByTitle",
                    requestPayload.CreateParameter(listTitle)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public List GetObject(LibraryType libraryType)
        {
            if (libraryType == default)
            {
                throw new ArgumentNullException(nameof(libraryType));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Lists"));
            if (libraryType == LibraryType.SitePages)
            {
                var objectPath4 = requestPayload.Add(
                    new ObjectPathMethod(objectPath3.Id, "EnsureSitePagesLibrary"),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                    objectPathId => new ClientActionQuery(objectPathId)
                    {
                        Query = new ClientQuery(true, typeof(List))
                    });
            }
            if (libraryType == LibraryType.ClientRenderedSitePages)
            {
                var objectPath4 = requestPayload.Add(
                    new ObjectPathMethod(objectPath3.Id, "EnsureClientRenderedSitePagesLibrary"),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                    objectPathId => new ClientActionQuery(objectPathId)
                    {
                        Query = new ClientQuery(true, typeof(List))
                    });
            }
            if (libraryType == LibraryType.SiteAssets)
            {
                var objectPath4 = requestPayload.Add(
                    new ObjectPathMethod(objectPath3.Id, "EnsureSiteAssetsLibrary"),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                    objectPathId => new ClientActionQuery(objectPathId)
                    {
                        Query = new ClientQuery(true, typeof(List))
                    });
            }
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<List> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Lists"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(List))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ListEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Guid RecycleObject(List listObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity),
                objectPathId => new ClientActionMethod(objectPathId, "Recycle"));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Guid>(requestPayload.GetActionId<ClientActionMethod>());
        }

    }

}
