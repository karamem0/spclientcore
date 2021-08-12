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
using System.Xml.Linq;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface IColumnTaxonomyService
    {

        ColumnTaxonomy CreateObject(IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions);

        ColumnTaxonomy CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions);

        void RemoveObject(ColumnTaxonomy columnTaxonomyObject);

        void SetObjectValue(ColumnTaxonomy columnTaxonomyObject, ListItem listItemObject, IEnumerable<Term> termCollection, uint lcid);

        void UpdateObject(ColumnTaxonomy columnTaxonomyObject, IReadOnlyDictionary<string, object> modificationInformation);

    }

    public class ColumnTaxonomyService : ClientService<ColumnTaxonomy>, IColumnTaxonomyService
    {

        public ColumnTaxonomyService(ClientContext clientContext) : base(clientContext)
        {
        }

        public ColumnTaxonomy CreateObject(IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions)
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
                    requestPayload.CreateParameter(SchemaXmlColumn.Create(
                        new XElement("Field", new XAttribute("Type", "TaxonomyFieldType")),
                        creationInformation)),
                    requestPayload.CreateParameter(addToDefaultView),
                    requestPayload.CreateParameter(addColumnOptions)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ColumnTaxonomy>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public ColumnTaxonomy CreateObject(List listObject, IReadOnlyDictionary<string, object> creationInformation, bool addToDefaultView, AddColumnOptions addColumnOptions)
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
                    requestPayload.CreateParameter(SchemaXmlColumn.Create(
                        new XElement("Field", new XAttribute("Type", "TaxonomyFieldType")),
                        creationInformation)),
                    requestPayload.CreateParameter(addToDefaultView),
                    requestPayload.CreateParameter(addColumnOptions)),
                objectPathId => new ClientActionInstantiateObjectPath(objectPathId),
                objectPathId => new ClientActionQuery(objectPathId)
                {
                    Query = new ClientQuery(true, typeof(Column))
                });
            return this.ClientContext
                .ProcessQuery(requestPayload)
                .ToObject<ColumnTaxonomy>(requestPayload.GetActionId<ClientActionQuery>());
        }

        public void SetObjectValue(ColumnTaxonomy columnTaxonomyObject, ListItem listItemObject, IEnumerable<Term> termCollection, uint lcid)
        {
            if (columnTaxonomyObject == null)
            {
                throw new ArgumentNullException(nameof(columnTaxonomyObject));
            }
            if (listItemObject == null)
            {
                throw new ArgumentNullException(nameof(listItemObject));
            }
            if (termCollection == null)
            {
                throw new ArgumentNullException(nameof(termCollection));
            }
            var requestPayload = new ClientRequestPayload();
            var objectPath1 = requestPayload.Add(
                new ObjectPathIdentity(columnTaxonomyObject.ObjectIdentity));
            var objectPath2 = requestPayload.Add(
                new ObjectPathIdentity(listItemObject.ObjectIdentity));
            var objectPath3 = requestPayload.Add(
                objectPath1,
                objectPathId => new ClientActionMethod(
                    objectPathId,
                    "SetFieldValueByCollection",
                    requestPayload.CreateParameter(objectPath2),
                    requestPayload.CreateParameter(termCollection),
                    requestPayload.CreateParameter(lcid)));
            var objectPath4 = requestPayload.Add(
                objectPath2,
                objectPathId => new ClientActionMethod(objectPathId, "Update"));
            _ = this.ClientContext.ProcessQuery(requestPayload);
        }

    }

}
