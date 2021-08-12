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

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public class ObjectPathCollection : IEnumerable<ObjectPath>
    {

        private readonly IDictionary<long, ObjectPath> collection;

        public ObjectPathCollection()
        {
            this.collection = new Dictionary<long, ObjectPath>();
        }

        public ObjectPath this[long id] => this.collection[id];

        public void Add(ObjectPath item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.collection.Add(item.Id, item);
        }

        public void Remove(long id)
        {
            _ = this.collection.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<ObjectPath> GetEnumerator()
        {
            return this.collection.Values.GetEnumerator();
        }

    }

}
