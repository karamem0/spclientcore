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

    public interface ISiteCollectionFeatureService
    {

        void AddObject(Guid featureId, bool force, FeatureDefinitionScope scope);

        Feature GetObject(Feature featureObject);

        Feature GetObject(Guid featureId);

        IEnumerable<Feature> GetObjectEnumerable();

        void RemoveObject(Guid featureId, bool force);

    }

    public class SiteCollectionFeatureService : ClientService<Feature>, ISiteCollectionFeatureService
    {

        public SiteCollectionFeatureService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(Guid featureId, bool force, FeatureDefinitionScope scope)
        {
            if (featureId == default)
            {
                throw new ArgumentNullException(nameof(featureId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Features"));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Add",
                    requestPayload.CreateParameter(featureId),
                    requestPayload.CreateParameter(force),
                    requestPayload.CreateParameter(scope)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public Feature GetObject(Guid featureId)
        {
            if (featureId == default)
            {
                throw new ArgumentNullException(nameof(featureId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Features"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetById",
                    requestPayload.CreateParameter(featureId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Feature))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Feature>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Feature> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Features"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Feature))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<FeatureEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObject(Guid featureId, bool force)
        {
            if (featureId == default)
            {
                throw new ArgumentNullException(nameof(featureId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Features"));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Remove",
                    requestPayload.CreateParameter(featureId),
                    requestPayload.CreateParameter(force)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
