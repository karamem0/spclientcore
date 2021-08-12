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

    public interface IRoleDefinitionService
    {

        RoleDefinition CreateObject(IReadOnlyDictionary<string, object> creationInformation);

        RoleDefinition GetObject(RoleDefinition roleDefinitionObject);

        RoleDefinition GetObject(int roleDefinitionId);

        RoleDefinition GetObject(string roleDefinitionName);

        IEnumerable<RoleDefinition> GetObjectEnumerable();

        void RemoveObject(RoleDefinition roleDefinitionObject);

        void UpdateObject(RoleDefinition roleDefinitionObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class RoleDefinitionService : ClientService<RoleDefinition>, IRoleDefinitionService
    {

        public RoleDefinitionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public RoleDefinition CreateObject(IReadOnlyDictionary<string, object> creationInformation)
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
                new ObjectPathProperty(objectPath2.Id, "RoleDefinitions"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "Add",
                    requestPayload.CreateParameter(new RoleDefinitionCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(RoleDefinition))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<RoleDefinition>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public RoleDefinition GetObject(int roleDefinitionId)
        {
            if (roleDefinitionId == default)
            {
                throw new ArgumentNullException(nameof(roleDefinitionId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "RoleDefinitions"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetById",
                    requestPayload.CreateParameter(roleDefinitionId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(RoleDefinition))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<RoleDefinition>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public RoleDefinition GetObject(string roleDefinitionName)
        {
            if (roleDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(roleDefinitionName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "RoleDefinitions"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetByName",
                    requestPayload.CreateParameter(roleDefinitionName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(RoleDefinition))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<RoleDefinition>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<RoleDefinition> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "RoleDefinitions"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(RoleDefinition))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<RoleDefinitionEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
