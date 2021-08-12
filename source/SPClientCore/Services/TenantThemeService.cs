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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface ITenantThemeService
    {

        bool CreateObject(string themeName, IReadOnlyDictionary<string, object> creationInformation);

        TenantTheme GetObject(TenantTheme themeObject);

        TenantTheme GetObject(string themeName);

        IEnumerable<TenantTheme> GetObjectEnumerable();

        void RemoveObject(TenantTheme themeObject);

        void RemoveObject(string themeName);

        bool UpdateObject(TenantTheme themeObject, IReadOnlyDictionary<string, object> modificationInformation);

        bool UpdateObject(string themeName, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class TenantThemeService : ClientService, ITenantThemeService
    {

        public TenantThemeService(ClientContext clientContext) : base(clientContext)
        {
        }

        public bool CreateObject(string themeName, IReadOnlyDictionary<string, object> creationInformation)
        {
            if (themeName == null)
            {
                throw new ArgumentNullException(nameof(themeName));
            }
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "AddTenantTheme",
                    requestPayload.CreateParameter(themeName),
                    requestPayload.CreateParameter(JsonConvert.SerializeObject(new TenantThemeCreationInformation(creationInformation)))));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<bool>(requestPayload.GetActionId<ClientActionMethod>());
        }

        public TenantTheme GetObject(TenantTheme themeObject)
        {
            if (themeObject == null)
            {
                throw new ArgumentNullException(nameof(themeObject));
            }
            return this.GetObject(themeObject.Name);
        }

        public TenantTheme GetObject(string themeName)
        {
            if (themeName == null)
            {
                throw new ArgumentNullException(nameof(themeName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath1.Id,
                    "GetTenantTheme",
                    requestPayload.CreateParameter(themeName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(TenantTheme))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantTheme>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<TenantTheme> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                new ObjectPathMethod(objectPath1.Id, "GetAllTenantThemes"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(TenantTheme))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<TenantThemeEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void RemoveObject(TenantTheme themeObject)
        {
            if (themeObject == null)
            {
                throw new ArgumentNullException(nameof(themeObject));
            }
            this.RemoveObject(themeObject.Name);
        }

        public void RemoveObject(string themeName)
        {
            if (themeName == null)
            {
                throw new ArgumentNullException(nameof(themeName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "DeleteTenantTheme",
                    requestPayload.CreateParameter(themeName)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public bool UpdateObject(TenantTheme themeObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (themeObject == null)
            {
                throw new ArgumentNullException(nameof(themeObject));
            }
            return this.UpdateObject(themeObject.Name, modificationInformation);
        }

        public bool UpdateObject(string themeName, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (themeName == null)
            {
                throw new ArgumentNullException(nameof(themeName));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathConstructor(typeof(Tenant)));
            var objectPath2 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "UpdateTenantTheme",
                    requestPayload.CreateParameter(themeName),
                    requestPayload.CreateParameter(JsonConvert.SerializeObject(new TenantThemeCreationInformation(modificationInformation)))));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<bool>(requestPayload.GetActionId<ClientActionMethod>());
        }

    }

}
