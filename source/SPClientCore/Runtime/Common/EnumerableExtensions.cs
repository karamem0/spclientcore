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
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Common
{

    public static class EnumerableExtensions
    {

        public static IEnumerable<IEnumerable<T>> Chunks<T>(this IEnumerable<T> collection, int size)
        {
            _ = collection ?? throw new ArgumentNullException(nameof(collection));
            if (size < 1)
            {
                throw new ArgumentException(string.Format(StringResources.ErrorValueCannotBeLessThan, 1), nameof(size));
            }
            while (collection.Any())
            {
                yield return collection.Take(size);
                collection = collection.Skip(size);
            }
        }

        public static IEnumerable<T> SkipLast<T>(this IEnumerable<T> collection, int count)
        {
            var array = collection.ToArray();
            for (var index = 0; index < array.Length - count; index++)
            {
                yield return array[index];
            }
        }

    }

}
