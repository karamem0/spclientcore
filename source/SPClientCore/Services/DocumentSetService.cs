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

    public interface IDocumentSetService
    {

        string CreateObject(Folder folderObject, string documentSetName, ContentType contentTypeObject);

    }

    public class DocumentSetService : ClientService, IDocumentSetService
    {

        public DocumentSetService(ClientContext clientContext) : base(clientContext)
        {
        }

        public string CreateObject(Folder folderObject, string documentSetName, ContentType contentTypeObject)
        {
            if (folderObject == null)
            {
                throw new ArgumentNullException(nameof(folderObject));
            }
            if (documentSetName == null)
            {
                throw new ArgumentNullException(nameof(documentSetName));
            }
            if (contentTypeObject == null)
            {
                throw new ArgumentNullException(nameof(contentTypeObject));
            }
            var requestPayload = new ClientRequestPayload();
            requestPayload.Actions.Add(
                new ClientActionStaticMethod(
                    typeof(DocumentSet),
                    "Create",
                    requestPayload.CreateParameter(folderObject),
                    requestPayload.CreateParameter(documentSetName),
                    requestPayload.CreateParameter(contentTypeObject.Id)
                ));
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<string>(requestPayload.GetActionId<ClientActionStaticMethod>());
        }

    }

}
