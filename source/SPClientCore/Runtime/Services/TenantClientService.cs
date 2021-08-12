//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Karamem0.SharePoint.PowerShell.Runtime.Services
{

    public abstract class TenantClientService : ClientService
    {

        protected TenantClientService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void WaitObject(TenantOperationResult operationResultObject)
        {
            while (true)
            {
                Thread.Sleep(operationResultObject.PollingInterval);
                if (operationResultObject.IsComplete)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(ClientConstants.TenantServiceWaitSeconds));
                    break;
                }
                if (operationResultObject.HasTimedout)
                {
                    throw new InvalidOperationException(StringResources.ErrorOperationTimeout);
                }
                var requestPayload = new ClientRequestPayload();
                var objectPath = requestPayload.Add(
                    new ObjectPathIdentity(operationResultObject.ObjectIdentity),
                    objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                    objectPathId => new ClientActionQuery(objectPathId)
                    {
                        Query = new ClientQuery(true, typeof(TenantOperationResult))
                    });
                operationResultObject = this.ClientContext
                    .ProcessQuery(requestPayload)
                    .ToObject<TenantOperationResult>(requestPayload.GetActionId<ClientActionQuery>());
            }
        }

    }

}
