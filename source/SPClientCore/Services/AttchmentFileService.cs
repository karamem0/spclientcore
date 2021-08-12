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

    public interface IAttachmentFileService
    {

        System.IO.Stream DownloadObject(AttachmentFile attachmentFileObject);

        AttachmentFile GetObject(AttachmentFile attachmentFileObject);

        AttachmentFile GetObject(ListItem listItemObject, string attachmentFileName);

        IEnumerable<AttachmentFile> GetObjectEnumerable(ListItem listItemObject);

        void RecycleObject(AttachmentFile attachmentFileObject);

        void RemoveObject(AttachmentFile attachmentFileObject);

        void UploadObject(ListItem listItemObject, string attachmentFileName, System.IO.Stream attachmentFileContent);

    }

    public class AttachmentFileService : ClientService<AttachmentFile>, IAttachmentFileService
    {

        public AttachmentFileService(ClientContext clientContext) : base(clientContext)
        {
        }

        public System.IO.Stream DownloadObject(AttachmentFile attachmentFileObject)
        {
            if (attachmentFileObject == null)
            {
                throw new ArgumentNullException(nameof(attachmentFileObject));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/getfilebyserverrelativeurl('{0}')/openbinarystream",
                    attachmentFileObject.ServerRelativeUrl);
            return this.ClientContext.GetStream(requestUrl);
        }

        public AttachmentFile GetObject(ListItem listItemObject, string attachmentFileName)
        {
            if (listItemObject == null)
            {
                throw new ArgumentNullException(nameof(listItemObject));
            }
            if (attachmentFileName == null)
            {
                throw new ArgumentNullException(nameof(attachmentFileName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "AttachmentFiles"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByFileName",
                    requestPayload.CreateParameter(attachmentFileName)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(AttachmentFile))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<AttachmentFile>(ObjectPath.CurrentId());
        }

        public IEnumerable<AttachmentFile> GetObjectEnumerable(ListItem listItemObject)
        {
            if (listItemObject == null)
            {
                throw new ArgumentNullException(nameof(listItemObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "AttachmentFiles"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(AttachmentFile))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<AttachmentFileEnumerable>(ObjectPath.CurrentId());
        }

        public void RecycleObject(AttachmentFile attachmentFileObject)
        {
            if (attachmentFileObject == null)
            {
                throw new ArgumentNullException(nameof(attachmentFileObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(attachmentFileObject.ObjectIdentity),
                objectPathId => new ClientActionMethod(objectPathId, "RecycleObject"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void UploadObject(ListItem listItemObject, string attachmentFileName, System.IO.Stream attachmentFileContent)
        {
            if (listItemObject == null)
            {
                throw new ArgumentNullException(nameof(listItemObject));
            }
            if (attachmentFileName == null)
            {
                throw new ArgumentNullException(nameof(attachmentFileName));
            }
            if (attachmentFileContent == null)
            {
                throw new ArgumentNullException(nameof(attachmentFileContent));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listItemObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ParentList"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(List))
                });
            var listObject = this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<List>(ObjectPath.CurrentId());
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/attachmentfiles/add(filename='{2}')",
                    listObject.Id,
                    listItemObject.Id,
                    attachmentFileName);
            this.ClientContext.PostStream(requestUrl, attachmentFileContent);
        }

    }

}
