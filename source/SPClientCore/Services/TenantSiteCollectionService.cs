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
using System.Threading;
using System.Threading.Tasks;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface ITenantSiteCollectionService
    {

        TenantOperationResult CreateObject(IReadOnlyDictionary<string, object> creationInformation);

        void CreateObjectAwait(IReadOnlyDictionary<string, object> creationInformation);

        TenantSiteCollection GetObject(TenantSiteCollection siteCollectionObject);

        TenantSiteCollection GetObject(Uri siteCollectionUrl);

        TenantSiteCollection GetObjectAwait(TenantSiteCollection siteCollectionObject);

        TenantSiteCollection GetObjectAwait(Uri siteCollectionUrl);

        IEnumerable<TenantSiteCollection> GetObjectEnumerable();

        IEnumerable<TenantSiteCollection> GetObjectEnumerable(IReadOnlyDictionary<string, object> filterInformation);

        TenantOperationResult LockObject(TenantSiteCollection siteCollectionObject);

        void LockObjectAwait(TenantSiteCollection siteCollectionObject);

        TenantOperationResult RemoveObject(TenantSiteCollection siteCollectionObject);

        void RemoveObjectAwait(TenantSiteCollection siteCollectionObject);

        TenantOperationResult UnlockObject(TenantSiteCollection siteCollectionObject);

        void UnlockObjectAwait(TenantSiteCollection siteCollectionObject);

        TenantOperationResult UpdateObject(TenantSiteCollection siteCollectionObject, IReadOnlyDictionary<string, object> modificationInformation);

        void UpdateObjectAwait(TenantSiteCollection siteCollectionObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TenantSiteCollectionService : TenantClientService, ITenantSiteCollectionService
    {

        public TenantSiteCollectionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public TenantOperationResult CreateObject(IReadOnlyDictionary<string, object> creationInformation)
        {
            _ = creationInformation ?? throw new ArgumentNullException(nameof(creationInformation));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "CreateSite",
                    requestPayload.CreateParameter(new TenantSiteCollectionCreationInformation(creationInformation))),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void CreateObjectAwait(IReadOnlyDictionary<string, object> creationInformation)
        {
            this.WaitObject(this.CreateObject(creationInformation));
        }

        public TenantSiteCollection GetObject(TenantSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(siteCollectionObject.ObjectIdentity),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantSiteCollection>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TenantSiteCollection GetObject(Uri siteCollectionUrl)
        {
            _ = siteCollectionUrl ?? throw new ArgumentNullException(nameof(siteCollectionUrl));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetSitePropertiesByUrl",
                    requestPayload.CreateParameter(siteCollectionUrl.ToString()),
                    requestPayload.CreateParameter(false)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantSiteCollection>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TenantSiteCollection GetObjectAwait(TenantSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            return this.GetObjectAwait(new Uri(siteCollectionObject.Url, UriKind.Absolute));
        }

        public TenantSiteCollection GetObjectAwait(Uri siteCollectionUrl)
        {
            _ = siteCollectionUrl ?? throw new ArgumentNullException(nameof(siteCollectionUrl));
            while (true)
            {
                var errorCount = 0;
                try
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ClientConstants.TenantServiceWaitSeconds));
                    var siteCollectionObject = this.GetObject(siteCollectionUrl);
                    if (siteCollectionObject.Status == "Active")
                    {
                        return siteCollectionObject;
                    }
                }
                catch
                {
                    errorCount += 1;
                    if (errorCount > ClientConstants.MaxRetryCount)
                    {
                        throw;
                    }
                }
            }
        }

        public IEnumerable<TenantSiteCollection> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                    new ObjectPathMethod(
                    objectPath1.Id,
                    "GetSitePropertiesFromSharePoint",
                    requestPayload.CreateParameter(null),
                    requestPayload.CreateParameter(false)
                ),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TenantSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantSiteCollectionEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TenantSiteCollection> GetObjectEnumerable(IReadOnlyDictionary<string, object> filterInformation)
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                    new ObjectPathMethod(
                    objectPath1.Id,
                    "GetSitePropertiesFromSharePointByFilters",
                    requestPayload.CreateParameter(new TenantSiteCollectionFilter(filterInformation))
                ),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TenantSiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantSiteCollectionEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public TenantOperationResult LockObject(TenantSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(siteCollectionObject.ObjectIdentity),
                objectPathId => new ClientActionSetProperty(
                    objectPathId,
                    "LockState",
                    requestPayload.CreateParameter("NoAccess")));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "Update"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void LockObjectAwait(TenantSiteCollection siteCollectionObject)
        {
            this.WaitObject(this.LockObject(siteCollectionObject));
        }

        public TenantOperationResult RemoveObject(TenantSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            _ = siteCollectionObject.Url ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "RemoveSite",
                    requestPayload.CreateParameter(siteCollectionObject.Url)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObjectAwait(TenantSiteCollection siteCollectionObject)
        {
            this.WaitObject(this.RemoveObject(siteCollectionObject));
        }

        public TenantOperationResult UnlockObject(TenantSiteCollection siteCollectionObject)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(siteCollectionObject.ObjectIdentity),
                objectPathId => new ClientActionSetProperty(
                    objectPathId,
                    "LockState",
                    requestPayload.CreateParameter("Unlock")));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "Update"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void UnlockObjectAwait(TenantSiteCollection siteCollectionObject)
        {
            this.WaitObject(this.UnlockObject(siteCollectionObject));
        }

        public TenantOperationResult UpdateObject(TenantSiteCollection siteCollectionObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            _ = siteCollectionObject ?? throw new ArgumentNullException(nameof(siteCollectionObject));
            _ = modificationInformation ?? throw new ArgumentNullException(nameof(modificationInformation));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(siteCollectionObject.ObjectIdentity),
                requestPayload.CreateSetPropertyDelegates(siteCollectionObject, modificationInformation).ToArray());
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "Update"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantOperationResult))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void UpdateObjectAwait(TenantSiteCollection siteCollectionObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            this.WaitObject(this.UpdateObject(siteCollectionObject, modificationInformation));
        }

    }

}
