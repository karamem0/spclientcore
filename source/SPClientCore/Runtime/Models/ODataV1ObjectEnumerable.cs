//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ODataV1ObjectEnumerable<T> : ODataV1Object, IEnumerable<T> where T : ODataV1Object
    {

        public ODataV1ObjectEnumerable()
        {
        }

        [JsonConstructor()]
        public ODataV1ObjectEnumerable(T[] results)
        {
            this.Entries = results;
        }

        [JsonProperty("results")]
        public IReadOnlyList<T> Entries { get; private set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (this.Entries == null)
            {
                return Enumerable.Empty<T>().GetEnumerator();
            }
            else
            {
                return this.Entries.GetEnumerator();
            }
        }

    }

}
