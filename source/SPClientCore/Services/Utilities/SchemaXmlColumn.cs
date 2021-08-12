//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Karamem0.SharePoint.PowerShell.Services.Utilities
{

    public static class SchemaXmlColumn
    {

        public static string Create(ColumnType type, IReadOnlyDictionary<string, object> parameters)
        {
            return Create(new XElement("Field", new XAttribute("Type", new SchemaXmlValue(type))), parameters);
        }

        public static string Create(string text, IReadOnlyDictionary<string, object> parameters)
        {
            return Create(XElement.Parse(text), parameters);
        }

        public static string Create(XElement element, IReadOnlyDictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.Key)
                {
                    case "AllowMultipleValues":
                        element.SetAttributeValue("Mult", new SchemaXmlValue(parameter.Value));
                        break;
                    case "CalendarType":
                        var value = parameter.Value as CalendarType?;
                        if (value != null)
                        {
                            element.SetAttributeValue("CalType", new SchemaXmlValue((int)value.GetValueOrDefault()));
                        }
                        break;
                    case "ChoiceFormat":
                        element.SetAttributeValue("Format", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Choices":
                        if (parameter.Value is IEnumerable<string> choices)
                        {
                            element.Add(new XElement("CHOICES",
                                choices.Select(choice => new XElement("CHOICE", new SchemaXmlValue(choice)))));
                        }
                        break;
                    case "ClientSideComponentId":
                        element.SetAttributeValue("ClientSideComponentId", new SchemaXmlValue(parameter.Value));
                        break;
                    case "ClientSideComponentProperties":
                        element.SetAttributeValue("ClientSideComponentProperties", new SchemaXmlValue(parameter.Value));
                        break;
                    case "ClientValidationFormula":
                        if (parameter.Value != null)
                        {
                            var formula = parameter.Value as string;
                            var message = parameters["ClientValidationMessage"] as string;
                            element.Add(new XElement("ClientValidationFormula",
                                new XAttribute("ClientValidationMessage", message),
                                new XText(formula)));
                        }
                        break;
                    case "Columns":
                        if (parameter.Value is IEnumerable<Column> columns)
                        {
                            element.Add(new XElement("FieldRefs",
                                columns.Select(column => new XElement("FieldRef",
                                    new XAttribute("ID", new SchemaXmlValue(column.Id)),
                                    new XAttribute("Name", new SchemaXmlValue(column.Name))))));
                        }
                        break;
                    case "CurrencyLcid":
                        element.SetAttributeValue("LCID", new SchemaXmlValue(parameter.Value));
                        break;
                    case "CustomFormatter":
                        element.SetAttributeValue("CustomFormatter", new SchemaXmlValue(parameter.Value));
                        break;
                    case "DateFormat":
                        element.SetAttributeValue("Format", new SchemaXmlValue(parameter.Value));
                        break;
                    case "DefaultFormula":
                        element.SetElementValue("DefaultFormula", new SchemaXmlValue(parameter.Value));
                        break;
                    case "DefaultValue":
                        element.SetElementValue("Default", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Description":
                        element.SetAttributeValue("Description", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Direction":
                        element.SetAttributeValue("Direction", new SchemaXmlValue(parameter.Value));
                        break;
                    case "EnforceUniqueValues":
                        element.SetAttributeValue("EnforceUniqueValues", new SchemaXmlValue(parameter.Value));
                        break;
                    case "FillInChoice":
                        element.SetAttributeValue("FillInChoice", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Formula":
                        element.SetElementValue("Formula", new SchemaXmlValue(parameter.Value));
                        break;
                    case "FriendlyFormat":
                        element.SetAttributeValue("FriendlyDisplayFormat", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Group":
                        element.SetAttributeValue("Group", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Hidden":
                        element.SetAttributeValue("CanToggleHidden", new SchemaXmlValue(parameter.Value));
                        element.SetAttributeValue("Hidden", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Id":
                        element.SetAttributeValue("ID", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Indexed":
                        element.SetAttributeValue("Indexed", new SchemaXmlValue(parameter.Value));
                        break;
                    case "JSLink":
                        element.SetAttributeValue("JSLink", new SchemaXmlValue(parameter.Value));
                        break;
                    case "MaxLength":
                        element.SetAttributeValue("Max", new SchemaXmlValue(parameter.Value));
                        break;
                    case "MaxValue":
                        element.SetAttributeValue("Max", new SchemaXmlValue(parameter.Value));
                        break;
                    case "MinValue":
                        element.SetAttributeValue("Min", new SchemaXmlValue(parameter.Value));
                        break;
                    case "LookupColumnName":
                        element.SetAttributeValue("ShowField", new SchemaXmlValue(parameter.Value));
                        break;
                    case "LookupListId":
                        element.SetAttributeValue("List", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Name":
                        element.SetAttributeValue("Name", new SchemaXmlValue(parameter.Value));
                        break;
                    case "NoCrawl":
                        element.SetAttributeValue("NoCrawl", new SchemaXmlValue(parameter.Value));
                        break;
                    case "NumberFormat":
                        element.SetAttributeValue("Decimals", new SchemaXmlValue(parameter.Value));
                        break;
                    case "NumberOfLines":
                        element.SetAttributeValue("NumLines", new SchemaXmlValue(parameter.Value));
                        break;
                    case "OutputType":
                        element.SetAttributeValue("ResultType", new SchemaXmlValue(parameter.Value));
                        break;
                    case "ReadOnly":
                        element.SetAttributeValue("ReadOnly", new SchemaXmlValue(parameter.Value));
                        break;
                    case "RelationshipDeleteBehavior":
                        element.SetAttributeValue("RelationshipDeleteBehavior", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Required":
                        element.SetAttributeValue("Required", new SchemaXmlValue(parameter.Value));
                        break;
                    case "RestrictedMode":
                        element.SetAttributeValue("RestrictedMode", new SchemaXmlValue(parameter.Value));
                        break;
                    case "RichText":
                        element.SetAttributeValue("RichText", new SchemaXmlValue(parameter.Value));
                        break;
                    case "RichTextMode":
                        element.SetAttributeValue("RichTextMode", new SchemaXmlValue(parameter.Value));
                        break;
                    case "SelectionGroupId":
                        element.SetAttributeValue("UserSelectionScope", new SchemaXmlValue(parameter.Value));
                        break;
                    case "SelectionMode":
                        element.SetAttributeValue("UserSelectionMode", new SchemaXmlValue(parameter.Value));
                        break;
                    case "ShowAsPercentage":
                        element.SetAttributeValue("Percentage", new SchemaXmlValue(parameter.Value));
                        break;
                    case "StaticName":
                        element.SetAttributeValue("StaticName", new SchemaXmlValue(parameter.Value));
                        break;
                    case "Title":
                        element.SetAttributeValue("DisplayName", new SchemaXmlValue(parameter.Value));
                        break;
                    case "UnlimitedLengthInDocumentLibrary":
                        element.SetAttributeValue("UnlimitedLengthInDocumentLibrary", new SchemaXmlValue(parameter.Value));
                        break;
                    case "UrlFormat":
                        element.SetAttributeValue("Format", new SchemaXmlValue(parameter.Value));
                        break;
                    case "ValidationFormula":
                        if (parameter.Value != null)
                        {
                            var formula = parameter.Value as string;
                            var message = parameters["ValidationMessage"] as string;
                            element.Add(new XElement("Validation",
                                new XAttribute("Message", message),
                                new XText(formula)));
                        }
                        break;
                    default:
                        break;
                }
            }
            return element.ToString(SaveOptions.DisableFormatting);
        }

    }

}
