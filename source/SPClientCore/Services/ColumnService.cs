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
using Karamem0.SharePoint.PowerShell.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface IColumnService
    {

        Column CreateObject(ColumnType columnType, IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions);

        Column CreateObject(List listObject, ColumnType columnType, IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions);

        Column GetObject(Column columnObject);

        Column GetObject(Guid columnId);

        Column GetObject(string columnTitle);

        Column GetObject(ContentType contentTypeObject, Guid columnId);

        Column GetObject(ContentType contentTypeObject, string columnTitle);

        Column GetObject(List listObject, Guid columnId);

        Column GetObject(List listObject, string columnTitle);

        IEnumerable<Column> GetObjectEnumerable();

        IEnumerable<Column> GetObjectEnumerable(ContentType contentTypeObject);

        IEnumerable<Column> GetObjectEnumerable(List listObject);

        void RemoveObject(Column columnObject);

        void UpdateObject(Column columnObject, IReadOnlyDictionary<string, object> modificationInformation);

        void UpdateObject(Column columnObject, IReadOnlyDictionary<string, object> modificationInformation, bool pushChanges);

    }

    public class ColumnService : ClientService<Column>, IColumnService
    {

        public ColumnService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Column CreateObject(ColumnType columnType, IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions)
        {
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Fields"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "AddFieldAsXml",
                    requestPayload.CreateParameter(SchemaXmlColumn.Create(columnType, creationInformation)),
                    requestPayload.CreateParameter(addToDefaultView),
                    requestPayload.CreateParameter(addColumnOptions)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column CreateObject(List listObject, ColumnType columnType, IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (creationInformation == null)
            {
                throw new ArgumentNullException(nameof(creationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "AddFieldAsXml",
                    requestPayload.CreateParameter(SchemaXmlColumn.Create(columnType, creationInformation)),
                    requestPayload.CreateParameter(addToDefaultView),
                    requestPayload.CreateParameter(addColumnOptions)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column GetObject(Guid columnId)
        {
            if (columnId == default)
            {
                throw new ArgumentNullException(nameof(columnId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Fields"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetById",
                    requestPayload.CreateParameter(columnId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column GetObject(string columnTitle)
        {
            if (columnTitle == null)
            {
                throw new ArgumentNullException(nameof(columnTitle));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Fields"));
            var objectPath4 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath3.Id,
                    "GetByInternalNameOrTitle",
                    requestPayload.CreateParameter(columnTitle)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column GetObject(ContentType contentTypeObject, Guid columnId)
        {
            if (contentTypeObject == null)
            {
                throw new ArgumentNullException(nameof(contentTypeObject));
            }
            if (columnId == default)
            {
                throw new ArgumentNullException(nameof(columnId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(contentTypeObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(columnId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column GetObject(ContentType contentTypeObject, string columnTitle)
        {
            if (contentTypeObject == null)
            {
                throw new ArgumentNullException(nameof(contentTypeObject));
            }
            if (columnTitle == null)
            {
                throw new ArgumentNullException(nameof(columnTitle));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(contentTypeObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByInternalNameOrTitle",
                    requestPayload.CreateParameter(columnTitle)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column GetObject(List listObject, Guid columnId)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (columnId == default)
            {
                throw new ArgumentNullException(nameof(columnId));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetById",
                    requestPayload.CreateParameter(columnId)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public Column GetObject(List listObject, string columnTitle)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            if (columnTitle == null)
            {
                throw new ArgumentNullException(nameof(columnTitle));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathMethod(
                    objectPath2.Id,
                    "GetByInternalNameOrTitle",
                    requestPayload.CreateParameter(columnTitle)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<Column>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Column> GetObjectEnumerable()
        {
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathStaticProperty(typeof(Context), "Current"));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Web"));
            var objectPath3 = requestPayload.Add(
                new ObjectPathProperty(objectPath2.Id, "Fields"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ColumnEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Column> GetObjectEnumerable(ContentType contentTypeObject)
        {
            if (contentTypeObject == null)
            {
                throw new ArgumentNullException(nameof(contentTypeObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(contentTypeObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ColumnEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public IEnumerable<Column> GetObjectEnumerable(List listObject)
        {
            if (listObject == null)
            {
                throw new ArgumentNullException(nameof(listObject));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(listObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathProperty(objectPath1.Id, "Fields"),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = ClientQuery.Empty,
                    ChildItemQuery = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ColumnEnumerable>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public override void UpdateObject(Column columnObject, IReadOnlyDictionary<string, object> modificationInformation)
        {
            if (columnObject == null)
            {
                throw new ArgumentNullException(nameof(columnObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectName = columnObject.ObjectType;
            var objectType = ClientObject.GetType(objectName);
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(columnObject.ObjectIdentity),
                objectPathId => new ClientActionSetProperty(
                    objectPathId,
                    "SchemaXml",
                    requestPayload.CreateParameter(SchemaXmlColumn.Create(columnObject.SchemaXml, modificationInformation))),
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

        public void UpdateObject(Column columnObject, IReadOnlyDictionary<string, object> modificationInformation, bool pushChanges)
        {
            if (columnObject == null)
            {
                throw new ArgumentNullException(nameof(columnObject));
            }
            if (modificationInformation == null)
            {
                throw new ArgumentNullException(nameof(modificationInformation));
            }
            var requestPayload = new ClientRequestPayload();
            var objectName = columnObject.ObjectType;
            var objectType = ClientObject.GetType(objectName);
            var objectPath = requestPayload.Add(
                new ObjectPathIdentity(columnObject.ObjectIdentity),
                objectPathId => new ClientActionSetProperty(
                    objectPathId,
                    "SchemaXml",
                    requestPayload.CreateParameter(SchemaXmlColumn.Create(columnObject.SchemaXml, modificationInformation))),
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "UpdateAndPushChanges",
                    requestPayload.CreateParameter(pushChanges)));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
