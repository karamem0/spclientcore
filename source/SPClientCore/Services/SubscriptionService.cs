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

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface ISubscriptionService
    {

        Subscription CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation);

        Subscription GetObject(Subscription subscriptionObject);

        Subscription GetObject(List listObject, Guid subscriptionId);

        IEnumerable<Subscription> GetObjectEnumerable(List listObject);

        void UpdateObject(Subscription subscriptionObject, IReadOnlyDictionary<string, object> modificationInformation);

        void RemoveObject(Subscription subscriptionObject);

    }

    public class SubscriptionService : ClientService, ISubscriptionService
    {

        public SubscriptionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Subscription CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var listUrl = this.ClientContext.BaseAddress
                .ConcatPath("_api/web/lists('{0}')", listObject.Id);
            var requestUrl = listUrl
                .ConcatPath("subscriptions")
                .ConcatQuery(ODataQuery.Create<Subscription>());
            var requestPayload = new ODataV1RequestPayload<SubscriptionCreationInformation>(
                creationInformation
                    .Concat(new Dictionary<string, object>()
                    {
                        { "Resource", listUrl.ToString() }
                    })
                    .ToDictionary(item => item.Key, item => item.Value));
            return this.ClientContext.PostObject<Subscription>(requestUrl, requestPayload.Entity);
        }

        public Subscription GetObject(Subscription subscriptionObject)
        {
            if (subscriptionObject == null)
            {
                throw new ArgumentNullException(nameof(subscriptionObject));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/subscriptions('{1}')",
                    subscriptionObject.Resource,
                    subscriptionObject.Id)
                .ConcatQuery(ODataQuery.Create<Subscription>());
            return this.ClientContext.GetObject<Subscription>(requestUrl);
        }

        public Subscription GetObject(List listObject, Guid subscriptionId)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (subscriptionId == default)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/subscriptions('{1}')",
                    listObject.Id,
                    subscriptionId)
                .ConcatQuery(ODataQuery.Create<Subscription>());
            return this.ClientContext.GetObject<Subscription>(requestUrl);
        }

        public IEnumerable<Subscription> GetObjectEnumerable(List listObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath("_api/web/lists('{0}')/subscriptions", listObject.Id)
                .ConcatQuery(ODataQuery.Create<Subscription>());
            return this.ClientContext.GetObject<ODataV1ObjectEnumerable<Subscription>>(requestUrl);
        }

        public void UpdateObject(Subscription subscriptionObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (subscriptionObject == null)
            {
                throw new ArgumentNullException(nameof(subscriptionObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/subscriptions('{1}')",
                    subscriptionObject.Resource,
                    subscriptionObject.Id);
            var requestPayload = new ODataV1RequestPayload<SubscriptionModificationInformation>(modificationInformation);
            this.ClientContext.PatchObject(requestUrl, requestPayload.Entity);
        }

        public void RemoveObject(Subscription subscriptionObject)
        {
            if (subscriptionObject == null)
            {
                throw new ArgumentNullException(nameof(subscriptionObject));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/subscriptions('{1}')",
                    subscriptionObject.Resource,
                    subscriptionObject.Id);
            this.ClientContext.DeleteObject(requestUrl);
        }

    }

}
