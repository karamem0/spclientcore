//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public static class JsonSerializerExtensions
    {

        public static T Deserialize<T>(this JsonSerializer serializer, string value)
        {
            using (var reader = new StringReader(value))
            {
                return serializer.Deserialize<T>(new JsonTextReader(reader));
            }
        }

        public static bool TryDeserialize<T>(this JsonSerializer serializer, string value, out T result)
        {
            try
            {
                using (var reader = new StringReader(value))
                {
                    result = serializer.Deserialize<T>(new JsonTextReader(reader));
                    return true;
                }
            }
            catch (JsonException)
            {
                result = default;
                return false;
            }
        }

        public static string Serialize<T>(this JsonSerializer serializer, T value)
        {
            using (var writer = new StringWriter())
            {
                serializer.Serialize(new JsonTextWriter(writer), value);
                return writer.ToString();
            }
        }

    }

}
