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

    public interface INavigationNodeService
    {

        NavigationNode CreateObject(NavigationNode navigationNodeObject, IReadOnlyDictionary<string, object> creationInformation);

        NavigationNode CreateObjectToQuickLaunch(IReadOnlyDictionary<string, object> creationInformation);

        NavigationNode CreateObjectToTopNavigationBar(IReadOnlyDictionary<string, object> creationInformation);

        NavigationNode GetObject(NavigationNode navigationNodeObject);

        NavigationNode GetObject(int navigationNodeId);

        NavigationNodeEnumerable GetObjectEnumerable(NavigationNode navigationNodeObject);

        void RemoveObject(NavigationNode navigationNodeObject);

        void UpdateObject(NavigationNode navigationNodeObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class NavigationNodeService : ClientService<NavigationNode>, INavigationNodeService
    {

        public NavigationNodeService(ClientContext clientContext) : base(clientContext)
        {
        }

        public NavigationNode CreateObject(NavigationNode navigationNodeObject, IReadOnlyDictionary<string, object> creationInformation)
        {
            if (navigationNodeObject == null)
            {
                throw new ArgumentNullException(nameof(navigationNodeObject));
            }
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(navigationNodeObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Children"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "Add",
                    requestPayload.CreateParameter(new NavigationNodeCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(NavigationNode))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<NavigationNode>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public NavigationNode CreateObjectToQuickLaunch(IReadOnlyDictionary<string, object> creationInformation)
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
                new ObjectPathProperty(objectPath2.Id, "Navigation"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "QuickLaunch"));
            var objectPath5 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath4.Id,
                    "Add",
                    requestPayload.CreateParameter(new NavigationNodeCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(NavigationNode))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<NavigationNode>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public NavigationNode CreateObjectToTopNavigationBar(IReadOnlyDictionary<string, object> creationInformation)
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
                new ObjectPathProperty(objectPath2.Id, "Navigation"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "TopNavigationBar"));
            var objectPath5 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath4.Id,
                    "Add",
                    requestPayload.CreateParameter(new NavigationNodeCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(NavigationNode))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<NavigationNode>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public NavigationNode GetObject(int navigationNodeId)
        {
            if (navigationNodeId == default)
            {
                throw new ArgumentNullException(nameof(navigationNodeId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Navigation"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetNodeById",
                    requestPayload.CreateParameter(navigationNodeId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(NavigationNode))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<NavigationNode>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public NavigationNodeEnumerable GetObjectEnumerable(NavigationNode navigationNodeObject)
        {
            if (navigationNodeObject == null)
            {
                throw new ArgumentNullException(nameof(navigationNodeObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(navigationNodeObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Children"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(NavigationNode))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<NavigationNodeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
