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

    public interface IGroupMemberService
    {

        User AddObject(Group groupObject, User memberObject);

        User GetObject(Group groupObject, int userId);

        User GetObject(Group groupObject, string userName);

        IEnumerable<User> GetObjectEnumerable(Group groupObject);

        void RemoveObject(Group groupObject, User memberObject);

    }

    public class GroupMemberService : ClientService, IGroupMemberService
    {

        public GroupMemberService(ClientContext clientContext) : base(clientContext)
        {
        }

        public User AddObject(Group groupObject, User memberObject)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            if (memberObject == null)
            {
                throw new ArgumentNullException(nameof(memberObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(groupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Users"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "AddUser",
                    requestPayload.CreateParameter(memberObject)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(User))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public User GetObject(Group groupObject, int userId)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(groupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Users"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(userId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(User))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public User GetObject(Group groupObject, string userName)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(userName, "^[ci]:0"))
            {
                var requestPayload = new ClientRequestPayload();
                var objectPath1 = requestPayload.Add(
                    new ObjectPathIdentity(groupObject.ObjectIdentity));
                var objectPath2 = requestPayload.Add(
                    new ObjectPathProperty(objectPath1.Id, "Users"));
                var objectPath3 = requestPayload.Add(
                    new ObjectPathMethod(
                        objectPath2.Id,
                        "GetByLoginName",
                        requestPayload.CreateParameter(userName)),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                    objectPathId => new ClientActionQuery(objectPathId)
                    {
                        Query = new ClientQuery(true, typeof(User))
                    });
                return this.ClientContext
                    .ProcessQuery(requestPayload)
                    .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
            }
            else
            {
                var requestPayload = new ClientRequestPayload();
                var objectPath1 = requestPayload.Add(
                    new ObjectPathIdentity(groupObject.ObjectIdentity));
                var objectPath2 = requestPayload.Add(
                    new ObjectPathProperty(objectPath1.Id, "Users"));
                var objectPath3 = requestPayload.Add(
                    new ObjectPathMethod(
                        objectPath2.Id,
                        "GetByEmail",
                        requestPayload.CreateParameter(userName)),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                    objectPathId => new ClientActionQuery(objectPathId)
                    {
                        Query = new ClientQuery(true, typeof(User))
                    });
                return this.ClientContext
                    .ProcessQuery(requestPayload)
                    .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
            }
        }

        public IEnumerable<User> GetObjectEnumerable(Group groupObject)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(groupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Users"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(User))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<UserEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObject(Group groupObject, User memberObject)
        {
            if (groupObject == null)
            {
                throw new ArgumentNullException(nameof(groupObject));
            }
            if (memberObject == null)
            {
                throw new ArgumentNullException(nameof(memberObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(groupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Users"));
            var objectPath3 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Remove",
                    requestPayload.CreateParameter(memberObject)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
