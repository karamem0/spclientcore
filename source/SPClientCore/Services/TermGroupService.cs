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

    public interface ITermGroupService
    {

        TermGroup CreateObject(string termGroupName, Guid termGroupId);

        TermGroup GetObject(TermGroup termGroupObject);

        TermGroup GetObject(Guid termGroupId);

        TermGroup GetObject(string termGroupName);

        IEnumerable<TermGroup> GetObjectEnumerable();

        void RemoveObject(TermGroup termGroupObject);

        void UpdateObject(TermGroup termGroupObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TermGroupService : ClientService<TermGroup>, ITermGroupService
    {

        public TermGroupService(ClientContext clientContext) : base(clientContext)
        {
        }

        public TermGroup CreateObject(string termGroupName, Guid termGroupId)
        {
            if (termGroupName == null)
            {
                throw new ArgumentNullException(nameof(termGroupName));
            }
            if (termGroupId == default)
            {
                throw new ArgumentNullException(nameof(termGroupId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(TaxonomySession), "GetTaxonomySession"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetDefaultSiteCollectionTermStore"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "CreateGroup",
                    requestPayload.CreateParameter(termGroupName),
                    requestPayload.CreateParameter(termGroupId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermGroup))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermGroup>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TermGroup GetObject(Guid termGroupId)
        {
            if (termGroupId == default)
            {
                throw new ArgumentNullException(nameof(termGroupId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(TaxonomySession), "GetTaxonomySession"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetDefaultSiteCollectionTermStore"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Groups"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetById",
                    requestPayload.CreateParameter(termGroupId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermGroup))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermGroup>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TermGroup GetObject(string termGroupName)
        {
            if (termGroupName == null)
            {
                throw new ArgumentNullException(nameof(termGroupName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(TaxonomySession), "GetTaxonomySession"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetDefaultSiteCollectionTermStore"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Groups"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetByName",
                    requestPayload.CreateParameter(termGroupName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermGroup))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermGroup>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TermGroup> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticMethod(typeof(TaxonomySession), "GetTaxonomySession"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetDefaultSiteCollectionTermStore"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Groups"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TermGroup))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermGroupEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public override void UpdateObject(TermGroup termGroupObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (termGroupObject == null)
            {
                throw new ArgumentNullException(nameof(termGroupObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termGroupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                requestPayload.CreateSetPropertyDelegates(termGroupObject, modificationInformation).ToArray());
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TermStore"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
