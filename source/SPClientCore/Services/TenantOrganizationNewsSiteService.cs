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

    public interface ITenantOrganizationNewsSiteService
    {

        void AddObject(string organizationNewsSiteUrl);

        IEnumerable<string> GetObjectEnumerable();

        void RemoveObject(string organizationNewsSiteUrl);

    }

    public class TenantOrganizationNewsSiteService : ClientService, ITenantOrganizationNewsSiteService
    {

        public TenantOrganizationNewsSiteService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(string organizationNewsSiteUrl)
        {
            if (organizationNewsSiteUrl == null)
            {
                throw new ArgumentNullException(nameof(organizationNewsSiteUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetOrgNewsSite",
                    requestPayload.CreateParameter(organizationNewsSiteUrl)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public IEnumerable<string> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "GetOrgNewsSites"));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<IEnumerable<string>>(requestPayload.GetActionId<ClientActionMethod>());
        }

        public void RemoveObject(string organizationNewsSiteUrl)
        {
            if (organizationNewsSiteUrl == null)
            {
                throw new ArgumentNullException(nameof(organizationNewsSiteUrl));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "RemoveOrgNewsSite",
                    requestPayload.CreateParameter(organizationNewsSiteUrl)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
