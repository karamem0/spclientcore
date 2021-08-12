//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Commands
{

    public abstract class ClientObjectCmdlet<T> : ClientObjectCmdlet
    {

        protected ClientObjectCmdlet()
        {
            if (ClientService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            this.Service = ClientService.ServiceProvider.GetService<T>();
        }

        protected T Service { get; private set; }

    }

    public abstract class ClientObjectCmdlet<T1, T2> : ClientObjectCmdlet
    {

        protected ClientObjectCmdlet()
        {
            if (ClientService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            this.Service1 = ClientService.ServiceProvider.GetService<T1>();
            this.Service2 = ClientService.ServiceProvider.GetService<T2>();
        }

        protected T1 Service1 { get; private set; }

        protected T2 Service2 { get; private set; }

    }

    public abstract class ClientObjectCmdlet<T1, T2, T3> : ClientObjectCmdlet
    {

        protected ClientObjectCmdlet()
        {
            if (ClientService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            this.Service1 = ClientService.ServiceProvider.GetService<T1>();
            this.Service2 = ClientService.ServiceProvider.GetService<T2>();
            this.Service3 = ClientService.ServiceProvider.GetService<T3>();
        }

        protected T1 Service1 { get; private set; }

        protected T2 Service2 { get; private set; }

        protected T3 Service3 { get; private set; }

    }

}
