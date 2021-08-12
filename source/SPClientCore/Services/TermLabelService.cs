//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface ITermLabelService
    {

        TermLabel CreateObject(Term termObject, string name, uint lcid, bool isDefault);

        TermLabel GetObject(TermLabel termLabelObject);

        TermLabel GetObject(Term termObject, string name);

        TermLabel GetObject(Term termObject, string name, uint lcid);

        IEnumerable<TermLabel> GetObjectEnumerable(Term termObject);

        void RemoveObject(TermLabel termLabelObject);

        void SetObjectAsDefault(TermLabel termLabelObject);

        void UpdateObject(TermLabel termLabelObject, IReadOnlyDictionary<string, object> modificationInformation);

        void UpdateObjectAwait(TermLabel termLabelObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TermLabelService : ClientService<TermLabel>, ITermLabelService
    {

        public TermLabelService(ClientContext clientContext) : base(clientContext)
        {
        }

        public TermLabel CreateObject(Term termObject, string name, uint lcid, bool isDefault)
        {
            _ = termObject ?? throw new ArgumentNullException(nameof(termObject));
            _ = name ?? throw new ArgumentNullException(nameof(name));
            _ = (lcid != default) ? lcid : throw new ArgumentNullException(nameof(lcid));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "CreateLabel",
                    requestPayload.CreateParameter(name),
                    requestPayload.CreateParameter(lcid),
                    requestPayload.CreateParameter(isDefault)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermLabel))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermLabel>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TermLabel GetObject(Term termObject, string name)
        {
            _ = termObject ?? throw new ArgumentNullException(nameof(termObject));
            _ = name ?? throw new ArgumentNullException(nameof(name));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Labels"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByValue",
                    requestPayload.CreateParameter(name)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TermLabel))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermLabel>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TermLabel GetObject(Term termObject, string name, uint lcid)
        {
            _ = termObject ?? throw new ArgumentNullException(nameof(termObject));
            _ = name ?? throw new ArgumentNullException(nameof(name));
            _ = (lcid != default) ? lcid : throw new ArgumentNullException(nameof(lcid));
            return this.GetObjectEnumerable(termObject)
                .Where(termLabelObject => termLabelObject.Name == name)
                .Where(termLabelObject => termLabelObject.Lcid == lcid)
                .SingleOrDefault();
        }

        public IEnumerable<TermLabel> GetObjectEnumerable(Term termObject)
        {
            _ = termObject ?? throw new ArgumentNullException(nameof(termObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Labels"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TermLabel))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TermLabelEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public override void RemoveObject(TermLabel termLabelObject)
        {
            _ = termLabelObject ?? throw new ArgumentNullException(nameof(termLabelObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termLabelObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "DeleteObject"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Term"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "TermStore"));
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void SetObjectAsDefault(TermLabel termLabelObject)
        {
            _ = termLabelObject ?? throw new ArgumentNullException(nameof(termLabelObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termLabelObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "SetAsDefaultForLanguage"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Term"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "TermStore"));
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }
        public override void UpdateObject(TermLabel termLabelObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            _ = termLabelObject ?? throw new ArgumentNullException(nameof(termLabelObject));
            _ = modificationInformation ?? throw new ArgumentNullException(nameof(modificationInformation));
            this.UpdateObjectAwait(termLabelObject, modificationInformation);
            var termLabelObjectIdentity = Regex.Replace(
                termLabelObject.ObjectIdentity,
                ";(.+);(.+);(.+)$",
                string.Format(
                    ";{0};{1};$3",
                    modificationInformation.GetValueOrDefault(nameof(TermLabel.Lcid), "$1"),
                    modificationInformation.GetValueOrDefault(nameof(TermLabel.Name), "$2")));
            while (true)
            {
                var requestPayload = new ClientRequestPayload();
                var objectPath = requestPayload.Add(
                    new ObjectPathIdentity(termLabelObjectIdentity),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
                if (this.ClientContext.ProcessQuery(requestPayload).IsNull(requestPayload.GetActionId<ClientActionInstantiateObjectPath>()))
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ClientConstants.TermLabelServiceWaitSeconds));
                }
                else
                {
                    return;
                }
            }
        }

        public void UpdateObjectAwait(TermLabel termLabelObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            _ = termLabelObject ?? throw new ArgumentNullException(nameof(termLabelObject));
            _ = modificationInformation ?? throw new ArgumentNullException(nameof(modificationInformation));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termLabelObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                requestPayload.CreateSetPropertyDelegates(termLabelObject, modificationInformation).ToArray());
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Term"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "TermStore"));
            var objectPath5 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(objectPathId, "CommitAll"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }


    }

}
