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

    public interface IRegionalSettingsService
    {

        RegionalSettings GetObject();

        void UpdateObject(IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class RegionalSettingsService : ClientService<RegionalSettings>, IRegionalSettingsService
    {

        public RegionalSettingsService(ClientContext clientContext) : base(clientContext)
        {
        }

        public RegionalSettings GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "RegionalSettings"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(RegionalSettings))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<RegionalSettings>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void UpdateObject(IReadOnlyDictionary<string, object> modificationInformation)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "RegionalSettings"));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                requestPayload.CreateSetPropertyDelegates(typeof(RegionalSettings), modificationInformation).ToArray());
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
