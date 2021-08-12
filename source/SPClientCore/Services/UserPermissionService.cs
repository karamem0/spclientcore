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

    public interface IUserPermissionService
    {

        BasePermission GetObject(User userObject, SecurableObject securableObject);

    }

    public class UserPermissionService : ClientService, IUserPermissionService
    {

        public UserPermissionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public BasePermission GetObject(User userObject, SecurableObject securableObject)
        {
            if (userObject == null)
            {
                throw new ArgumentNullException(nameof(userObject));
            }
            if (securableObject == null)
            {
                throw new ArgumentNullException(nameof(securableObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(securableObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPath => new ClientActionMethod(
                    objectPath1.Id,
                    "GetUserEffectivePermissions",
                    requestPayload.CreateParameter(userObject.LoginName)));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<BasePermission>(requestPayload.GetActionId<ClientActionMethod>());
        }

    }

}
