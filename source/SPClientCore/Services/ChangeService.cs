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

    public interface IChangeService
    {

        IEnumerable<Change> GetObjectEnumerable(SiteCollection siteCollectionObject, ChangeQuery changeQueryObject);

        IEnumerable<Change> GetObjectEnumerable(Site siteObject, ChangeQuery changeQueryObject);

        IEnumerable<Change> GetObjectEnumerable(List listObject, ChangeQuery changeQueryObject);

    }

    public class ChangeService : ClientService, IChangeService
    {

        public ChangeService(ClientContext clientContext) : base(clientContext)
        {
        }

        public IEnumerable<Change> GetObjectEnumerable(SiteCollection siteCollectionObject, ChangeQuery changeQueryObject)
        {
            if (siteCollectionObject == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(siteCollectionObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetChanges",
                    requestPayload.CreateParameter(changeQueryObject)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Change))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ChangeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Change> GetObjectEnumerable(Site siteObject, ChangeQuery changeQueryObject)
        {
            if (siteObject == null)
            {
                throw new ArgumentNullException(nameof(siteObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(siteObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetChanges",
                    requestPayload.CreateParameter(changeQueryObject)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Change))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ChangeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Change> GetObjectEnumerable(List listObject, ChangeQuery changeQueryObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetChanges",
                    requestPayload.CreateParameter(changeQueryObject)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Change))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ChangeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
