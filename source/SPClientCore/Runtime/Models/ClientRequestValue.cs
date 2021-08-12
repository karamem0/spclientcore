//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public class ClientRequestValue
    {

        public static ClientRequestValue Create(object input)
        {
            if (TryCreate(input, out var output))
            {
                return output;
            }
            throw new ArgumentException(
                string.Format(StringResources.ErrorValueIsInvalid, input.ToString()),
                nameof(input));
        }

        public static bool TryCreate(object input, out ClientRequestValue output)
        {
            switch (input)
            {
                case null:
                    output = new ClientRequestValue("Null", null);
                    return true;
                case Enum enumValue:
                    output = new ClientRequestValue("Enum", Convert.ToInt32(input).ToString(CultureInfo.InvariantCulture));
                    return true;
                case bool boolValue:
                    output = new ClientRequestValue("Boolean", boolValue.ToString().ToLower());
                    return true;
                case byte byteValue:
                    output = new ClientRequestValue("Byte", byteValue.ToString());
                    return true;
                case byte[] byteArrayValue:
                    output = new ClientRequestValue("Binary", Convert.ToBase64String(byteArrayValue));
                    return true;
                case char charValue:
                    output = new ClientRequestValue("Char", charValue.ToString());
                    return true;
                case short shortValue:
                    output = new ClientRequestValue("Int16", shortValue.ToString());
                    return true;
                case ushort ushortValue:
                    output = new ClientRequestValue("UInt16", ushortValue.ToString());
                    return true;
                case int intValue:
                    output = new ClientRequestValue("Int32", intValue.ToString());
                    return true;
                case uint uintValue:
                    output = new ClientRequestValue("UInt32", uintValue.ToString());
                    return true;
                case long longValue:
                    output = new ClientRequestValue("Int64", longValue.ToString());
                    return true;
                case ulong ulongValue:
                    output = new ClientRequestValue("UInt64", ulongValue.ToString());
                    return true;
                case float singleValue:
                    output = new ClientRequestValue("Single", singleValue.ToString());
                    return true;
                case double doubleValue:
                    output = new ClientRequestValue("Double", doubleValue.ToString());
                    return true;
                case decimal decimalValue:
                    output = new ClientRequestValue("Decimal", decimalValue.ToString());
                    return true;
                case DateTime dateValue:
                    output = new ClientRequestValue("DateTime", dateValue.ToString("o", CultureInfo.InvariantCulture));
                    return true;
                case Guid guidValue:
                    output = new ClientRequestValue("Guid", guidValue.ToString("B"));
                    return true;
                case string stringValue:
                    output = new ClientRequestValue("String", stringValue);
                    return true;
                case SwitchParameter switchValue:
                    output = new ClientRequestValue("Boolean", switchValue.ToBool().ToString().ToLower());
                    return true;
                case ODataObject oDataValue:
                    output = new ClientRequestValue("String", JsonSerializerManager.JsonSerializer.Serialize(oDataValue));
                    return true;
                default:
                    output = null;
                    return false;
            }
        }

        private ClientRequestValue()
        {
        }

        private ClientRequestValue(string type, string value)
        {
            this.Type = type;
            this.Value = value;
        }

        public string Type { get; private set; }

        public string Value { get; private set; }

    }

}
