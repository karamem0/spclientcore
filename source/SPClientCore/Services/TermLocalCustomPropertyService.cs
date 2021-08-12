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

    public interface ITermLocalCustomPropertyService
    {

        void AddObject(Term termObject, string propertyName, string propertyValue);

        void RemoveObject(Term termObject, string propertyName);

    }

    public class TermLocalCustomPropertyService : ClientService, ITermLocalCustomPropertyService
    {

        public TermLocalCustomPropertyService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(Term termObject, string propertyName, string propertyValue)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
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
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetLocalCustomProperty",
                    requestPayload.CreateParameter(propertyName),
                    requestPayload.CreateParameter(propertyValue)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveObject(Term termObject, string propertyName)
        {
            if (termObject == null)
            {
                throw new ArgumentNullException(nameof(termObject));
            }
            if (propertyName == null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(termObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "DeleteLocalCustomProperty",
                    requestPayload.CreateParameter(propertyName)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
