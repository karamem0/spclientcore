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

    public interface IListTemplateService
    {

        ListTemplate GetObject(ListTemplate listTemplateObject);

        ListTemplate GetObject(string listTemplateTitle);

        IEnumerable<ListTemplate> GetObjectEnumerable();

    }

    public class ListTemplateService : ClientService<ListTemplate>, IListTemplateService
    {

        public ListTemplateService(ClientContext clientContext) : base(clientContext)
        {
        }

        public ListTemplate GetObject(string listTemplateTitle)
        {
            if (listTemplateTitle == null)
            {
                throw new ArgumentNullException(nameof(listTemplateTitle));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "ListTemplates"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetByName",
                    requestPayload.CreateParameter(listTemplateTitle)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ListTemplate))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ListTemplate>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<ListTemplate> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "ListTemplates"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(ListTemplate))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ListTemplateEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

    }

}
