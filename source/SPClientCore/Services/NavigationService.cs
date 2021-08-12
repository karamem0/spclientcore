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

    public interface INavigationService
    {

        Navigation GetObject();

        void SetObject(IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class NavigationService : ClientService, INavigationService
    {

        public NavigationService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Navigation GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Navigation"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Navigation))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Navigation>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void SetObject(IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Navigation"),
                requestPayload.CreateSetPropertyDelegates(typeof(Navigation), modificationInformation).ToArray());
            var objectPath4 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
