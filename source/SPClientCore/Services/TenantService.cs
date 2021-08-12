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

    public interface ITenantService
    {

        Tenant GetObject();

        void SetObject(IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TenantService : ClientService, ITenantService
    {

        public TenantService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Tenant GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Tenant))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Tenant>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void SetObject(IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)),
                requestPayload.CreateSetPropertyDelegates(typeof(Tenant), modificationInformation).ToArray());
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
