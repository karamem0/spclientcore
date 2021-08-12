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

    public interface IDocumentLibraryService
    {

        DocumentLibraryInformation GetObject();

        IEnumerable<DocumentLibraryInformation> GetObjectEnumerable();

        IEnumerable<DocumentLibraryInformation> GetObjectEnumerable(bool includePageLibraries);

    }

    public class DocumentLibraryService : ClientService, IDocumentLibraryService
    {

        public DocumentLibraryService(ClientContext clientContext) : base(clientContext)
        {
        }

        public DocumentLibraryInformation GetObject()
        {
            var requestPayload = new ClientRequestPayload();
            requestPayload.Actions.Add(
                new ClientActionStaticMethod(
                    typeof(Site),
                    "DefaultDocumentLibraryUrl",
                    requestPayload.CreateParameter(this.ClientContext.BaseAddress.ToString())
                ));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<DocumentLibraryInformation>(requestPayload.GetActionId<ClientActionStaticMethod>());
        }

        public IEnumerable<DocumentLibraryInformation> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            requestPayload.Actions.Add(
                new ClientActionStaticMethod(
                    typeof(Site),
                    "GetDocumentLibraries",
                    requestPayload.CreateParameter(this.ClientContext.BaseAddress.ToString())
                ));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List<DocumentLibraryInformation>>(requestPayload.GetActionId<ClientActionStaticMethod>());
        }

        public IEnumerable<DocumentLibraryInformation> GetObjectEnumerable(bool includePageLibraries)
        {
            var requestPayload = new ClientRequestPayload();
            requestPayload.Actions.Add(
                new ClientActionStaticMethod(
                    typeof(Site),
                    "GetDocumentAndMediaLibraries",
                    requestPayload.CreateParameter(this.ClientContext.BaseAddress.ToString()),
                    requestPayload.CreateParameter(includePageLibraries)
                ));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List<DocumentLibraryInformation>>(requestPayload.GetActionId<ClientActionStaticMethod>());
        }

    }

}
