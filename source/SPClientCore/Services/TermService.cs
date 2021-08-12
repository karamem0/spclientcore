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

    public interface ITermService
    {

        Term CopyObject(Term termObject, bool copyChildren);

        Term CreateObject(TermSetItem termSetItemObject, string termName, Guid termId, uint lcid);

        void DeprecateObject(Term termObject, bool deprecated);

        Term GetObject(Term termObject);

        Term GetObject(TermLabel termLabelObject);

        Term GetObject(TermSetItem termSetItemObject, Guid termId);

        Term GetObject(TermSetItem termSetItemObject, string termName);

        IEnumerable<Term> GetObjectEnumerable(TermSetItem termSetItemObject);

        void MergeObject(Term sourceTermObject, TermSetItem destinationTermObject);

        void MoveObject(Term termObject, TermSetItem termSetItemObject);

        void RemoveObject(Term termObject);

        void UpdateObject(Term termObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TermService : ClientService<Term>, ITermService
    {

        public TermService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Term CopyObject(Term termObject, bool copyChildren)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "Copy",
                    requestPayload.CreateParameter(copyChildren)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Term))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Term>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Term CreateObject(TermSetItem termSetItemObject, string termName, Guid termId, uint lcid)
        {
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            if (termName == null)
            {
                throw new ArgumentNullException(nameof(termName));
            }
            if (termId == default)
            {
                throw new ArgumentNullException(nameof(termId));
            }
            if (lcid == default)
            {
                throw new ArgumentNullException(nameof(lcid));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "CreateTerm",
                    requestPayload.CreateParameter(termName),
                    requestPayload.CreateParameter(lcid),
                    requestPayload.CreateParameter(termId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Term))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Term>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void DeprecateObject(Term termObject, bool deprecated)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Deprecate",
                    requestPayload.CreateParameter(deprecated)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public Term GetObject(TermLabel termLabelObject)
        {
            if (termLabelObject == null)
            {
                throw new ArgumentNullException(nameof(termLabelObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termLabelObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Term"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Term))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Term>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Term GetObject(TermSetItem termSetItemObject, Guid termId)
        {
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            if (termId == default)
            {
                throw new ArgumentNullException(nameof(termId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Terms"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(termId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Term))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Term>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Term GetObject(TermSetItem termSetItemObject, string termName)
        {
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            if (termName == null)
            {
                throw new ArgumentNullException(nameof(termName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Terms"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByName",
                    requestPayload.CreateParameter(termName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermSetItem))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Term>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Term> GetObjectEnumerable(TermSetItem termSetItemObject)
        {
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Terms"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Term))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void MergeObject(Term sourceTermObject, TermSetItem destinationTermObject)
        {
            if (sourceTermObject == null)
            {
                throw new ArgumentNullException(nameof(sourceTermObject));
            }
            if (destinationTermObject == null)
            {
                throw new ArgumentNullException(nameof(destinationTermObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(sourceTermObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Merge",
                    requestPayload.CreateParameter(destinationTermObject)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void MoveObject(Term termObject, TermSetItem termSetItemObject)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Move",
                    requestPayload.CreateParameter(termSetItemObject)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public override void UpdateObject(Term termObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                requestPayload.CreateSetPropertyDelegates(termObject, modificationInformation).ToArray());
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "TermStore"));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
