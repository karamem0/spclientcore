//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Services
{

    public abstract class ClientService
    {

        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Register(ClientContext clientContext)
        {
            ServiceProvider = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.IsSubclassOf(typeof(ClientService)))
                .Where(type => type.GetInterfaces().Any())
                .Aggregate<Type, IServiceCollection>(
                    new ServiceCollection(),
                    (accumulate, source) => accumulate.AddTransient(source.GetInterfaces()[0], source))
                .AddSingleton(typeof(ClientContext), clientContext)
                .BuildServiceProvider();
        }

        public static void Unregister()
        {
            ServiceProvider = null;
        }

        protected ClientService(ClientContext clientContext)
        {
            this.ClientContext = clientContext ?? throw new ArgumentNullException(nameof(clientContext));
        }

        protected ClientContext ClientContext { get; private set; }

    }

}
