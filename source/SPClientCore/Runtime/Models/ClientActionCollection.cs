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

    public class ClientActionCollection : IEnumerable<ClientAction>
    {

        private readonly IDictionary<long, ClientAction> collection;

        public ClientActionCollection()
        {
            this.collection = new Dictionary<long, ClientAction>();
        }

        public ClientAction this[long id] => this.collection[id];

        public void Add(ClientAction item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.collection.Add(item.Id, item);
        }

        public void AddRange(IEnumerable<ClientAction> items)
        {
            foreach (var item in items)
            {
                this.Add(item);
            }
        }

        public void Remove(long id)
        {
            _ = this.collection.Remove(id);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<ClientAction> GetEnumerator()
        {
            return this.collection.Values.GetEnumerator();
        }

    }

}
