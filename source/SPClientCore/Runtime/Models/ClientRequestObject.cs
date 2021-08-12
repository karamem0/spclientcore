//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public abstract class ClientRequestObject
    {

        private static long id;

        public static long NewId()
        {
            return Interlocked.Increment(ref ClientRequestObject.id);
        }

        public static long CurrentId()
        {
            return Interlocked.Read(ref ClientRequestObject.id);
        }

        protected ClientRequestObject()
        {
        }

        public override string ToString()
        {
            var encoding = new UTF8Encoding(false);
            var settings = new XmlWriterSettings()
            {
                Encoding = encoding,
                Indent = false,
                NamespaceHandling = NamespaceHandling.OmitDuplicates,
                OmitXmlDeclaration = true,
            };
            using (var stream = new MemoryStream())
            {
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    this.WriteXml(writer);
                }
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public virtual void WriteXml(XmlWriter writer, string typeName = null)
        {
            if (typeName == null)
            {
                var typeAttribute = this.GetType().GetCustomAttribute<XmlTypeAttribute>(false);
                if (typeAttribute == null)
                {
                    writer.WriteStartElement(this.GetType().Name);
                }
                else
                {
                    writer.WriteStartElement(typeAttribute.TypeName, typeAttribute.Namespace);
                }
            }
            else
            {
                writer.WriteStartElement(typeName);
            }
            foreach (var propertyInfo in this.GetType().GetDeclaringProperties())
            {
                if (propertyInfo.TryGetValue(this, out var value))
                {
                    var attributeAttribute = propertyInfo.GetCustomAttribute<XmlAttributeAttribute>();
                    if (attributeAttribute != null)
                    {
                        if (ClientRequestValue.TryCreate(value, out var requestValue))
                        {
                            writer.WriteAttributeString(
                                string.IsNullOrEmpty(attributeAttribute.AttributeName)
                                    ? propertyInfo.Name
                                    : attributeAttribute.AttributeName,
                                requestValue.Value);
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    var elementAttribute = propertyInfo.GetCustomAttribute<XmlElementAttribute>();
                    if (elementAttribute != null)
                    {
                        if (ClientRequestValue.TryCreate(value, out var requestValue))
                        {
                            writer.WriteElementString(
                                string.IsNullOrEmpty(elementAttribute.ElementName)
                                    ? propertyInfo.Name
                                    : elementAttribute.ElementName,
                                requestValue.Value);
                        }
                        else if (value is ClientRequestObject requestObject)
                        {
                            requestObject.WriteXml(writer,
                                string.IsNullOrEmpty(elementAttribute.ElementName)
                                    ? propertyInfo.Name
                                    : elementAttribute.ElementName);
                        }
                        else if (value is IEnumerable elementValues)
                        {
                            foreach (var elementValue in elementValues)
                            {
                                if (ClientRequestValue.TryCreate(elementValue, out var elementRequestValue))
                                {
                                    writer.WriteElementString(
                                        string.IsNullOrEmpty(elementAttribute.ElementName)
                                            ? propertyInfo.Name
                                            : elementAttribute.ElementName,
                                        elementRequestValue.Value);
                                }
                                else if (elementValue is ClientRequestObject elementRequestObject)
                                {
                                    elementRequestObject.WriteXml(writer,
                                        string.IsNullOrEmpty(elementAttribute.ElementName)
                                            ? propertyInfo.Name
                                            : elementAttribute.ElementName);
                                }
                                else
                                {
                                    throw new InvalidOperationException();
                                }
                            }
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    var textAttribute = propertyInfo.GetCustomAttribute<XmlTextAttribute>();
                    if (textAttribute != null)
                    {
                        if (ClientRequestValue.TryCreate(value, out var requestValue))
                        {
                            writer.WriteValue(requestValue.Value);
                        }
                        else
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    var arrayAttribute = propertyInfo.GetCustomAttribute<XmlArrayAttribute>();
                    if (arrayAttribute != null)
                    {
                        if (value is IEnumerable elements)
                        {
                            writer.WriteStartElement(
                                string.IsNullOrEmpty(arrayAttribute.ElementName)
                                    ? propertyInfo.Name
                                    : arrayAttribute.ElementName);
                            foreach (var element in elements)
                            {
                                if (element is ClientRequestObject requestObject)
                                {
                                    requestObject.WriteXml(writer);
                                }
                                else
                                {
                                    throw new InvalidOperationException();
                                }
                            }
                            writer.WriteEndElement();
                        }
                    }
                }
            }
            writer.WriteEndElement();
        }

    }

}
