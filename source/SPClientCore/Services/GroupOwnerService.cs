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

    public interface IGroupOwnerService
    {

        Principal GetObject(Group groupObject);

        void SetObject(Group groupObject, Principal principalObject);

    }

    public class GroupOwnerService : ClientService, IGroupOwnerService
    {

        public GroupOwnerService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Principal GetObject(Group groupObject)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(groupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Owner"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(false, typeof(Principal))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Principal>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void SetObject(Group groupObject, Principal principalObject)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            if (principalObject == null)
            {
                throw new ArgumentNullException(nameof(principalObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(groupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionSetProperty(
                    objectPathId,
                    "Owner",
                    new ClientRequestParameterObjectPath(
                        requestPayload.Add(new ObjectPathIdentity(principalObject.ObjectIdentity)))),
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
