//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [ClientObject(Name = "SP.BasePermissions", Id = "{db780e5a-6bc6-41ad-8e64-9dfa761afb6d}")]
    [JsonObject()]
    public class BasePermission : ClientValueObject
    {

        public BasePermission()
        {
        }

        public BasePermission(params PermissionKind[] permissions)
        {
            foreach (var permission in permissions)
            {
                switch (permission)
                {
                    case PermissionKind.FullMask:
                        this.Low = 65535u;
                        this.High = 32767u;
                        return;
                    case PermissionKind.EmptyMask:
                        this.Low = 0u;
                        this.High = 0u;
                        return;
                    default:
                        var num1 = (int)(permission - 1);
                        var num2 = 1u;
                        if (num1 >= 0 && num1 < 32)
                        {
                            num2 <<= num1;
                            this.Low |= num2;
                        }
                        if (num1 >= 32 && num1 < 64)
                        {
                            num2 <<= num1 - 32;
                            this.High |= num2;
                        }
                        break;
                }
            }
        }

        [JsonIgnore()]
        public IEnumerable<PermissionKind> Permissions
        {
            get
            {
                if ((this.High & 32767u) == 32767u && this.Low == 65535u)
                {
                    yield return PermissionKind.FullMask;
                    yield break;
                }
                if (this.High == 0u && this.Low == 0u)
                {
                    yield return PermissionKind.EmptyMask;
                    yield break;
                }
                foreach (var permission in Enum.GetValues(typeof(PermissionKind))
                    .OfType<PermissionKind>()
                    .Where(value => value != PermissionKind.EmptyMask)
                    .Where(value => value != PermissionKind.FullMask))
                {
                    var num1 = (int)(permission - 1);
                    var num2 = 1u;
                    if (num1 >= 0 && num1 < 32)
                    {
                        num2 <<= num1;
                        if ((this.Low & num2) != 0)
                        {
                            yield return permission;
                        }
                    }
                    if (num1 >= 32 && num1 < 64)
                    {
                        num2 <<= num1 - 32;
                        if ((this.High & num2) != 0)
                        {
                            yield return permission;
                        }
                    }
                }
            }
        }

        [JsonProperty()]
        public virtual uint High { get; protected set; }

        [JsonProperty()]
        public virtual uint Low { get; protected set; }

    }

}
