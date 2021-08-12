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

    public interface ITermSetService
    {

        TermSet CreateObject(TermGroup termGroupObject, string termSetName, Guid termSetId, uint lcid);

        TermSet GetObject(TermSet termSetObject);

        TermSet GetObject(TermGroup termGroupObject, Guid termSetId);

        TermSet GetObject(TermGroup termGroupObject, string termSetName);

        IEnumerable<TermSet> GetObjectEnumerable(TermGroup termGroupObject);

        void RemoveObject(TermSet termSetObject);

        void UpdateObject(TermSet termSetObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TermSetService : ClientService<TermSet>, ITermSetService
    {

        public TermSetService(ClientContext clientContext) : base(clientContext)
        {
        }

        public TermSet CreateObject(TermGroup termGroupObject, string termSetName, Guid termSetId, uint lcid)
        {
            if (termGroupObject == null)
            {
                throw new ArgumentNullException(nameof(termGroupObject));
            }
            if (termSetName == null)
            {
                throw new ArgumentNullException(nameof(termSetName));
            }
            if (termSetId == default)
            {
                throw new ArgumentNullException(nameof(termSetId));
            }
            if (lcid == default)
            {
                throw new ArgumentNullException(nameof(lcid));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termGroupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "CreateTermSet",
                    requestPayload.CreateParameter(termSetName),
                    requestPayload.CreateParameter(termSetId),
                    requestPayload.CreateParameter(lcid)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermSet))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermSet>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TermSet GetObject(TermGroup termGroupObject, Guid termSetId)
        {
            if (termGroupObject == null)
            {
                throw new ArgumentNullException(nameof(termGroupObject));
            }
            if (termSetId == default)
            {
                throw new ArgumentNullException(nameof(termSetId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termGroupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "TermSets"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(termSetId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermSet))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermSet>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TermSet GetObject(TermGroup termGroupObject, string termSetName)
        {
            if (termGroupObject == null)
            {
                throw new ArgumentNullException(nameof(termGroupObject));
            }
            if (termSetName == null)
            {
                throw new ArgumentNullException(nameof(termSetName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termGroupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "TermSets"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByName",
                    requestPayload.CreateParameter(termSetName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermSet))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermSet>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TermSet> GetObjectEnumerable(TermGroup termGroupObject)
        {
            if (termGroupObject == null)
            {
                throw new ArgumentNullException(nameof(termGroupObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termGroupObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "TermSets"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TermSet))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermSetEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public override void UpdateObject(TermSet termSetObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (termSetObject == null)
            {
                throw new ArgumentNullException(nameof(termSetObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                requestPayload.CreateSetPropertyDelegates(termSetObject, modificationInformation).ToArray());
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TermStore"));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
