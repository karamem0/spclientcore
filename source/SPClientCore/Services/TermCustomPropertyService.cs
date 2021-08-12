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

    public interface ITermCustomPropertyService
    {

        void AddObject(TermSetItem termSetItemObject, string propertyName, string propertyValue);

        void RemoveObject(TermSetItem termSetItemObject, string propertyName);

    }

    public class TermCustomPropertyService : ClientService, ITermCustomPropertyService
    {

        public TermCustomPropertyService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(TermSetItem termSetItemObject, string propertyName, string propertyValue)
        {
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            if (propertyName == null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }
            if (propertyValue == null)
            {
                throw new ArgumentNullException(nameof(propertyValue));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetCustomProperty",
                    requestPayload.CreateParameter(propertyName),
                    requestPayload.CreateParameter(propertyValue)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveObject(TermSetItem termSetItemObject, string propertyName)
        {
            if (termSetItemObject == null)
            {
                throw new ArgumentNullException(nameof(termSetItemObject));
            }
            if (propertyName == null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termSetItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "DeleteCustomProperty",
                    requestPayload.CreateParameter(propertyName)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
