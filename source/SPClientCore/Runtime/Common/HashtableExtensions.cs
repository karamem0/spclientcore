//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Common
{

    public static class HashtableExtensions
    {

        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this Hashtable hashtable)
        {
            if (hashtable == null)
            {
                throw new ArgumentNullException(nameof(hashtable));
            }
            return hashtable.Keys.Cast<object>().ToDictionary(key => (TKey)key, key => (TValue)hashtable[key]);
        }

    }

}
