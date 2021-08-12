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

    public interface IStorageEntityService
    {

        void AddObject(string key, string value, string description, string comments);

        StorageEntity GetObject(string key);

        void RemoveObject(string key);

    }

    public class StorageEntityService : ClientService, IStorageEntityService
    {

        public StorageEntityService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(string key, string value, string description, string comment)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetStorageEntity",
                    requestPayload.CreateParameter(key),
                    requestPayload.CreateParameter(value),
                    requestPayload.CreateParameter(description),
                    requestPayload.CreateParameter(comment)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public StorageEntity GetObject(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetStorageEntity",
                    requestPayload.CreateParameter(key)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(StorageEntity))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<StorageEntity>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObject(string key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "RemoveStorageEntity",
                    requestPayload.CreateParameter(key)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
