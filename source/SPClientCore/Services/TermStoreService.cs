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

    public interface ITermStoreService
    {

        TermStore GetObject();

        void UpdateObject(IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TermStoreService : ClientService, ITermStoreService
    {

        public TermStoreService(ClientContext clientContext) : base(clientContext)
        {
        }

        public TermStore GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(TaxonomySession), "GetTaxonomySession"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetDefaultSiteCollectionTermStore"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermStore))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermStore>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void UpdateObject(IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(TaxonomySession), "GetTaxonomySession"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetDefaultSiteCollectionTermStore"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath3 = requestPayload.Add(
                objectPath2,
                requestPayload.CreateSetPropertyDelegates(typeof(TermStore), modificationInformation).ToArray());
            var objectPath4 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
