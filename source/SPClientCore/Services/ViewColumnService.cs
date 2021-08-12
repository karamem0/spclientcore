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

    public interface IViewColumnService
    {

        void AddObject(View viewObject, Column columnObject);

        void AddObject(View viewObject, string columnName);

        IEnumerable<string> GetObjectEnumerable(View viewObject);

        void MoveObject(View viewObject, Column columnObject, int columnIndex);

        void MoveObject(View viewObject, string columnName, int columnIndex);

        void RemoveObject(View viewObject, Column columnObject);

        void RemoveObject(View viewObject, string columnName);

        void RemoveObjectAll(View viewObject);

    }

    public class ViewColumnService : ClientService, IViewColumnService
    {

        public ViewColumnService(ClientContext clientContext) : base(clientContext)
        {
        }

        public void AddObject(View viewObject, Column columnObject)
        {
            if (columnObject == null)
            {
                throw new ArgumentNullException(nameof(columnObject));
            }
            this.AddObject(viewObject, columnObject.Name);
        }

        public void AddObject(View viewObject, string columnName)
        {
            if (viewObject == null)
            {
                throw new ArgumentNullException(nameof(viewObject));
            }
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(viewObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ViewFields"));
            var objectPath3 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Add",
                    requestPayload.CreateParameter(columnName)));
            var objectPath4 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public IEnumerable<string> GetObjectEnumerable(View viewObject)
        {
            if (viewObject == null)
            {
                throw new ArgumentNullException(nameof(viewObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(viewObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ViewFields"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(ViewColumnEnumerable)),
                    ChildItemQuery = new ClientQuery(true)
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ViewColumnEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void MoveObject(View viewObject, Column columnObject, int columnIndex)
        {
            if (columnObject == null)
            {
                throw new ArgumentNullException(nameof(columnObject));
            }
            this.MoveObject(viewObject, columnObject.Name, columnIndex);
        }

        public void MoveObject(View viewObject, string columnName, int columnIndex)
        {
            if (viewObject == null)
            {
                throw new ArgumentNullException(nameof(viewObject));
            }
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }
            if (columnIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(columnIndex));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(viewObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ViewFields"));
            var objectPath3 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "MoveFieldTo",
                    requestPayload.CreateParameter(columnName),
                    requestPayload.CreateParameter(columnIndex)));
            var objectPath4 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveObject(View viewObject, Column columnObject)
        {
            if (columnObject == null)
            {
                throw new ArgumentNullException(nameof(columnObject));
            }
            this.RemoveObject(viewObject, columnObject.Name);
        }

        public void RemoveObject(View viewObject, string columnName)
        {
            if (viewObject == null)
            {
                throw new ArgumentNullException(nameof(viewObject));
            }
            if (columnName == null)
            {
                throw new ArgumentNullException(nameof(columnName));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(viewObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ViewFields"));
            var objectPath3 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "Remove",
                    requestPayload.CreateParameter(columnName)));
            var objectPath4 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void RemoveObjectAll(View viewObject)
        {
            if (viewObject == null)
            {
                throw new ArgumentNullException(nameof(viewObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(viewObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "ViewFields"));
            var objectPath3 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(objectPathId, "RemoveAll"));
            var objectPath4 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
