//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface IImageService
    {

        ImageItem UploadObject(List listObject, string fileName, System.IO.Stream fileContent);

        ImageItem UploadObject(ListItem listItemObject, string fileName, System.IO.Stream fileContent);

    }

    public class ImageService : ClientService, IImageService
    {

        public ImageService(ClientContext clientContext) : base(clientContext)
        {
        }

        public ImageItem UploadObject(List listObject, string fileName, System.IO.Stream fileContent)
        {
            _ = listObject ?? throw new ArgumentNullException(nameof(listObject));
            _ = fileName ?? throw new ArgumentNullException(nameof(fileName));
            _ = fileContent ?? throw new ArgumentNullException(nameof(fileContent));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath("_api/web/uploadimage(listtitle=@v1,imagename=@v2,listid=@v3,itemid=@v4)")
                .ConcatQuery(UriQuery.Create(new Dictionary<string, object>()
                {
                    { "@v1", listObject.Title },
                    { "@v2", fileName },
                    { "@v3", listObject.Id },
                    { "@v4", 0 }
                }, true));
            return this.ClientContext
                .PostStream<ODataV1MethodReturnValue>(requestUrl, fileContent)
                .GetValue<ImageItem>("UploadImage");
        }

        public ImageItem UploadObject(ListItem listItemObject, string fileName, System.IO.Stream fileContent)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            _ = fileName ?? throw new ArgumentNullException(nameof(fileName));
            _ = fileContent ?? throw new ArgumentNullException(nameof(fileContent));
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ParentList"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true)
                });
            var listObject = this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(requestPayload.GetActionId<ClientActionQuery>());
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath("_api/web/uploadimage(listtitle=@v1,imagename=@v2,listid=@v3,itemid=@v4)")
                .ConcatQuery(UriQuery.Create(new Dictionary<string, object>()
                {
                    { "@v1", listObject.Title },
                    { "@v2", fileName },
                    { "@v3", listObject.Id },
                    { "@v4", listItemObject.Id }
                }, true));
            return this.ClientContext
                .PostStream<ODataV1MethodReturnValue>(requestUrl, fileContent)
                .GetValue<ImageItem>("UploadImage");
        }

    }

}
