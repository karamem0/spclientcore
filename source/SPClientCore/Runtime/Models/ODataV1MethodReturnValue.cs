//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ODataV1MethodReturnValue : ODataV1Object
    {

        public ODataV1MethodReturnValue()
        {
        }

        public virtual T GetValue<T>(string methodName) where T : ODataV1Object
        {
            _ = methodName ?? throw new ArgumentNullException(nameof(methodName));
            return this.ExtensionProperties[methodName].ToObject<T>(JsonSerializerManager.JsonSerializer);
        }

    }

}
