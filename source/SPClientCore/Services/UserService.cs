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

    public interface IUserService
    {

        User CreateObject(IReadOnlyDictionary<string, object> creationInformation);

        User EnsureObject(string userLoginName);

        User GetObject();

        User GetObject(User userObject);

        User GetObject(int userId);

        User GetObject(string userName);

        IEnumerable<User> GetObjectEnumerable();

        void UpdateObject(User userObject, IReadOnlyDictionary<string, object> modificationInformation);

        void RemoveObject(User userObject);

    }

    public class UserService : ClientService<User>, IUserService
    {

        public UserService(ClientContext clientContext) : base(clientContext)
        {
        }

        public User CreateObject(IReadOnlyDictionary<string, object> creationInformation)
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
                new ObjectPathProperty(objectPath2.Id, "SiteUsers"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "Add",
                    requestPayload.CreateParameter(new UserCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(User))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public User EnsureObject(string userLoginName)
        {
            if (userLoginName == null)
            {
                throw new ArgumentNullException(nameof(userLoginName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "EnsureUser",
                    requestPayload.CreateParameter(userLoginName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(User))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public User GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "CurrentUser"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(User))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<User>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public User GetObject(int userId)
        {
            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "SiteUsers"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
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

        public User GetObject(string userName)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(userName, "^[ci]:0"))
            {
                var requestPayload = new ClientRequestPayload();
                var objectPath1 = requestPayload.Add(
                    new ObjectPathStaticProperty(typeof(Context), "Current"));
                var objectPath2 = requestPayload.Add(
                    new ObjectPathProperty(objectPath1.Id, "Web"));
                var objectPath3 = requestPayload.Add(
                    new ObjectPathProperty(objectPath2.Id, "SiteUsers"));
                var objectPath4 = requestPayload.Add(
                    new ObjectPathMethod(
                        objectPath3.Id,
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
                    new ObjectPathStaticProperty(typeof(Context), "Current"));
                var objectPath2 = requestPayload.Add(
                    new ObjectPathProperty(objectPath1.Id, "Web"));
                var objectPath3 = requestPayload.Add(
                    new ObjectPathProperty(objectPath2.Id, "SiteUsers"));
                var objectPath4 = requestPayload.Add(
                    new ObjectPathMethod(
                        objectPath3.Id,
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

        public IEnumerable<User> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "SiteUsers"),
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

    }

}
