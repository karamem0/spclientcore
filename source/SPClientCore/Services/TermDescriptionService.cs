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

    public interface ITermDescriptionService
    {

        string GetObject(Term termObject, uint lcid);

        void SetObject(Term termObject, string description, uint lcid);

    }

    public class TermDescriptionService : ClientService, ITermDescriptionService
    {

        public TermDescriptionService(ClientContext clientContext) : base(clientContext)
        {
        }

        public string GetObject(Term termObject, uint lcid)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            if (lcid == default)
            {
                throw new ArgumentNullException(nameof(lcid));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "GetDescription",
                    requestPayload.CreateParameter(lcid)));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<string>(requestPayload.GetActionId<ClientActionMethod>());
        }

        public void SetObject(Term termObject, string description, uint lcid)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }
            if (lcid == default)
            {
                throw new ArgumentNullException(nameof(lcid));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetDescription",
                    requestPayload.CreateParameter(description),
                    requestPayload.CreateParameter(lcid)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
