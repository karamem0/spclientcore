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
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services.Utilities
{

    public class SchemaXmlValue
    {

        private readonly object value;

        public SchemaXmlValue(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            switch (this.value)
            {
                case null:
                    return null;
                case Enum enumValue:
                    return enumValue.ToString();
                case bool boolValue:
                    return boolValue.ToString().ToUpper();
                case byte byteValue:
                    return byteValue.ToString();
                case byte[] byteArrayValue:
                    return Convert.ToBase64String(byteArrayValue);
                case char charValue:
                    return charValue.ToString();
                case short shortValue:
                    return shortValue.ToString();
                case ushort ushortValue:
                    return ushortValue.ToString();
                case int intValue:
                    return intValue.ToString();
                case uint uintValue:
                    return uintValue.ToString();
                case long longValue:
                    return longValue.ToString();
                case ulong ulongValue:
                    return ulongValue.ToString();
                case float singleValue:
                    return singleValue.ToString();
                case double doubleValue:
                    return doubleValue.ToString();
                case decimal decimalValue:
                    return decimalValue.ToString();
                case DateTime dateValue:
                    return dateValue.ToString("s");
                case Guid guidValue:
                    return guidValue.ToString("B");
                case string stringValue:
                    return stringValue;
                case SwitchParameter switchValue:
                    return switchValue.ToBool().ToString().ToUpper();
                default:
                    throw new InvalidOperationException(
                        string.Format(StringResources.ErrorValueIsInvalid, this.value.ToString()));
            }
        }

    }

}
