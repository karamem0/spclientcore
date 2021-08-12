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

    public interface IViewService
    {

        View CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation);

        View GetObject(View viewObject);

        View GetObject(List listObject, Guid viewId);

        View GetObject(List listObject, string viewTitle);

        IEnumerable<View> GetObjectEnumerable(List listObject);

        void RemoveObject(View viewObject);

        void UpdateObject(View viewObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class ViewService : ClientService<View>, IViewService
    {

        public ViewService(ClientContext clientContext) : base(clientContext)
        {
        }

        public View CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation)
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
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Views"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "Add",
                    requestPayload.CreateParameter(new ViewCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(View))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<View>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public View GetObject(List listObject, Guid viewId)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (viewId == default)
            {
                throw new ArgumentNullException(nameof(viewId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Views"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(viewId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(View))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<View>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public View GetObject(List listObject, string viewTitle)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (viewTitle == null)
            {
                throw new ArgumentNullException(nameof(viewTitle));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Views"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByTitle",
                    requestPayload.CreateParameter(viewTitle)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(View))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<View>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<View> GetObjectEnumerable(List listObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Views"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(View))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ViewEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
