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

    public interface ISitePageService
    {

        void AddObject(Folder folderObject, string pageName, SitePageLayoutType pageLayoutType);

        void RemoveObject(Folder folderObject, string pageName);

        void SetObject(Folder folderObject, string pageName, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class SitePageService : ClientService, ISitePageService
    {

        public SitePageService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(Folder folderObject, string pageName, SitePageLayoutType pageLayoutType)
        {
            if (folderObject == null)
            {
                throw new ArgumentNullException(nameof(folderObject));
            }
            if (pageName == null)
            {
                throw new ArgumentNullException(nameof(pageName));
            }
            var fileName = System.IO.Path.ChangeExtension(pageName, ".aspx");
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(folderObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Files"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "AddTemplateFile",
                    requestPayload.CreateParameter($"{folderObject.ServerRelativeUrl}/{fileName}"),
                    requestPayload.CreateParameter(TemplateFileType.ClientSidePage)));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "ListItemAllFields"),
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetFieldValue",
                    requestPayload.CreateParameter("ClientSideApplicationId"),
                    requestPayload.CreateParameter("b6917cb1-93a0-4b97-a84d-7cf49975d4ec")),
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetFieldValue",
                    requestPayload.CreateParameter("ContentTypeId"),
                    requestPayload.CreateParameter("0x0101009D1CB255DA76424F860D91F20E6C4118")),
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetFieldValue",
                    requestPayload.CreateParameter("PageLayoutType"),
                    requestPayload.CreateParameter(pageLayoutType.ToString())),
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetFieldValue",
                    requestPayload.CreateParameter("Title"),
                    requestPayload.CreateParameter(pageName)),
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveObject(Folder folderObject, string pageName)
        {
            if (folderObject == null)
            {
                throw new ArgumentNullException(nameof(folderObject));
            }
            if (pageName == null)
            {
                throw new ArgumentNullException(nameof(pageName));
            }
            var fileName = System.IO.Path.ChangeExtension(pageName, ".aspx");
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(folderObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Files"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByUrl",
                    requestPayload.CreateParameter(fileName)));
            var objectPath4 = requestPayload.Add(
                objectPath3,
                objectPathId => new ClientActionMethod(objectPathId, "DeleteObject"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void SetObject(Folder folderObject, string pageName, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (folderObject == null)
            {
                throw new ArgumentNullException(nameof(folderObject));
            }
            if (pageName == null)
            {
                throw new ArgumentNullException(nameof(pageName));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var fileName = System.IO.Path.ChangeExtension(pageName, ".aspx");
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(folderObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Files"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByUrl",
                    requestPayload.CreateParameter(fileName)));
            var objectPath4 = requestPayload.Add(
                new ObjectPathProperty(objectPath3.Id, "ListItemAllFields"));
            if (modificationInformation.ContainsKey("PageLayoutType"))
            {
                var objectPath5 = requestPayload.Add(
                    objectPath4,
                    objectPathId => new ClientActionMethod(
                        objectPathId,
                        "SetFieldValue",
                        requestPayload.CreateParameter("PageLayoutType"),
                        requestPayload.CreateParameter(modificationInformation["PageLayoutType"].ToString())));
            }
            if (modificationInformation.ContainsKey("Title"))
            {
                var objectPath5 = requestPayload.Add(
                    objectPath4,
                    objectPathId => new ClientActionMethod(
                        objectPathId,
                        "SetFieldValue",
                        requestPayload.CreateParameter("Title"),
                        requestPayload.CreateParameter(modificationInformation["Title"])));
            }
            var objectPath6 = requestPayload.Add(
                objectPath4,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
