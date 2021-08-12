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

    public interface IUserProfileService
    {

        UserProfile GetObject();

    }

    public class UserProfileService : ClientService, IUserProfileService
    {

        public UserProfileService(ClientContext clientContext) : base(clientContext)
        {
        }

        public UserProfile GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(ProfileLoader), "GetProfileLoader"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetUserProfile"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(UserProfile))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<UserProfile>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
