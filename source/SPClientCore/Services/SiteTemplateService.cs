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

    public interface ISiteTemplateService
    {

        SiteTemplate GetObject(string name, uint lcid, bool includeCrossLanguage);

        IEnumerable<SiteTemplate> GetObjectEnumerable(uint lcid, bool includeCrossLanguage);

    }

    public class SiteTemplateService : ClientService, ISiteTemplateService
    {

        public SiteTemplateService(ClientContext clientContext) : base(clientContext)
        {
        }

        public SiteTemplate GetObject(string name, uint lcid, bool includeCrossLanguage)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (lcid == default)
            {
                throw new ArgumentNullException(nameof(lcid));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetAvailableWebTemplates",
                    requestPayload.CreateParameter(lcid),
                    requestPayload.CreateParameter(includeCrossLanguage)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetByName",
                    requestPayload.CreateParameter(name)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(SiteTemplate))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<SiteTemplate>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<SiteTemplate> GetObjectEnumerable(uint lcid, bool includeCrossLanguage)
        {
            if (lcid == default)
            {
                throw new ArgumentNullException(nameof(lcid));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetAvailableWebTemplates",
                    requestPayload.CreateParameter(lcid),
                    requestPayload.CreateParameter(includeCrossLanguage)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(SiteTemplate))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<SiteTemplateEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
