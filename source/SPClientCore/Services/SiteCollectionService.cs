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

    public interface ISiteCollectionService
    {

        SiteCollection GetObject();

        SiteCollection GetObject(SiteCollection siteCollectionObject);

        SiteCollection GetObject(Uri siteCollectionUrl);

    }

    public class SiteCollectionService : ClientService<SiteCollection>, ISiteCollectionService
    {

        public SiteCollectionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public SiteCollection GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Site"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(SiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<SiteCollection>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public SiteCollection GetObject(Uri siteCollectionUrl)
        {
            if (siteCollectionUrl == null)
            {
                throw new ArgumentNullException(nameof(siteCollectionUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetSiteByUrl",
                    requestPayload.CreateParameter(siteCollectionUrl.ToString()),
                    requestPayload.CreateParameter(false)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(SiteCollection))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<SiteCollection>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
