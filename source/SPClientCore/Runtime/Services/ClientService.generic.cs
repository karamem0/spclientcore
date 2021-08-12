//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Services
{

    public abstract class ClientService<T> : ClientService where T : ClientObject
    {

        protected ClientService(ClientContext clientContext) : base(clientContext)
        {
        }

        public virtual T GetObject(T clientObject)
        {
            if (clientObject == null)
            {
                throw new ArgumentNullException(nameof(clientObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(clientObject.ObjectIdentity),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(T))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<T>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public virtual void RemoveObject(T clientObject)
        {
            if (clientObject == null)
            {
                throw new ArgumentNullException(nameof(clientObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(clientObject.ObjectIdentity),
                objectPathId => new ClientActionMethod(objectPathId, "DeleteObject"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public virtual void UpdateObject(T clientObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (clientObject == null)
            {
                throw new ArgumentNullException(nameof(clientObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectName = clientObject.ObjectType;
            var objectType = ClientObject.GetType(objectName);
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(clientObject.ObjectIdentity),
                requestPayload.CreateSetPropertyDelegates(clientObject, modificationInformation).ToArray());
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
