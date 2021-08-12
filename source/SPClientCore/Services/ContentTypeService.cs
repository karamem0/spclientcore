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

    public interface IContentTypeService
    {

        ContentType CreateObject(IReadOnlyDictionary<string, object> creationInformation);

        ContentType CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation);

        ContentType CreateObject(List listObject, ContentType contentTypeObject);

        ContentType GetObject(ContentType contentTypeObject);

        ContentType GetObject(string contentTypeId);

        ContentType GetObject(List listObject, string contentTypeId);

        IEnumerable<ContentType> GetObjectEnumerable();

        IEnumerable<ContentType> GetObjectEnumerable(List listObject);

        void RemoveObject(ContentType contentTypeObject);

        void UpdateObject(ContentType contentTypeObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class ContentTypeService : ClientService<ContentType>, IContentTypeService
    {

        public ContentTypeService(ClientContext clientContext) : base(clientContext)
        {
        }

        public ContentType CreateObject(IReadOnlyDictionary<string, object> creationInformation)
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
                new ObjectPathProperty(objectPath2.Id, "ContentTypes"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "Add",
                    requestPayload.CreateParameter(new ContentTypeCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentType>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public ContentType CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ContentTypes"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "Add",
                    requestPayload.CreateParameter(new ContentTypeCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentType>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public ContentType CreateObject(List listObject, ContentType contentTypeObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (contentTypeObject == null)
            {
                throw new ArgumentNullException(nameof(contentTypeObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ContentTypes"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "AddExistingContentType",
                    requestPayload.CreateParameter(contentTypeObject)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentType>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public ContentType GetObject(string contentTypeId)
        {
            if (contentTypeId == null)
            {
                throw new ArgumentNullException(nameof(contentTypeId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "ContentTypes"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetById",
                    requestPayload.CreateParameter(contentTypeId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentType>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public ContentType GetObject(List listObject, string contentTypeId)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (contentTypeId == null)
            {
                throw new ArgumentNullException(nameof(contentTypeId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ContentTypes"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(contentTypeId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentType>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<ContentType> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "ContentTypes"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentTypeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<ContentType> GetObjectEnumerable(List listObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ContentTypes"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(ContentType))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ContentTypeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
