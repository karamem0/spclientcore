//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public static class FlagsParser
    {

        public static T Parse<T>(IReadOnlyDictionary<string, object> parameters) where T : Enum
        {
            var type = typeof(T);
            if (type.IsDefined(typeof(FlagsAttribute), false))
            {
                var names = Enum.GetNames(type);
                var keys = parameters
                    .Where(parameter => parameter.Value is SwitchParameter)
                    .Where(parameter => (SwitchParameter)parameter.Value)
                    .Where(parameter => names.Contains(parameter.Key))
                    .Select(parameter => parameter.Key)
                    .ToList();
                if (keys.Any())
                {
                    return (T)Enum.Parse(type, string.Join(",", keys));
                }
                else
                {
                    return default;
                }
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

    }

}
