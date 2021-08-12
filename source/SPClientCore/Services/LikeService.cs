//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Services
{

    public interface ILikeService
    {

        IEnumerable<LikedUser> GetObjectEnumerable(Comment commentObject);

        IEnumerable<LikedUser> GetObjectEnumerable(ListItem listItemObject);

        void LikeObject(Comment commentObject);

        void LikeObject(ListItem listItemObject);

        void UnlikeObject(Comment commentObject);

        void UnlikeObject(ListItem listItemObject);

    }

    public class LikeService : ClientService, ILikeService
    {

        public LikeService(ClientContext clientContext) : base(clientContext)
        {
        }

        public IEnumerable<LikedUser> GetObjectEnumerable(Comment commentObject)
        {
            _ = commentObject ?? throw new ArgumentNullException(nameof(commentObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})/likedby",
                    commentObject.ListId,
                    commentObject.ItemId,
                    commentObject.Id);
            return this.ClientContext.GetObject<ODataV1ObjectEnumerable<LikedUser>>(requestUrl);
        }

        public IEnumerable<LikedUser> GetObjectEnumerable(ListItem listItemObject)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/likedby",
                    listItemObject.ObjectIdentity.Split(':').SkipLast(2).Last(),
                    listItemObject.Id);
            return this.ClientContext.GetObject<ODataV1ObjectEnumerable<LikedUser>>(requestUrl);
        }

        public void LikeObject(Comment commentObject)
        {
            _ = commentObject ?? throw new ArgumentNullException(nameof(commentObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})/like",
                    commentObject.ListId,
                    commentObject.ItemId,
                    commentObject.Id);
            this.ClientContext.PostObject(requestUrl, null);
        }

        public void LikeObject(ListItem listItemObject)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/like",
                    listItemObject.ObjectIdentity.Split(':').SkipLast(2).Last(),
                    listItemObject.Id);
            this.ClientContext.PostObject(requestUrl, null);
        }

        public void UnlikeObject(Comment commentObject)
        {
            _ = commentObject ?? throw new ArgumentNullException(nameof(commentObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})/unlike",
                    commentObject.ListId,
                    commentObject.ItemId,
                    commentObject.Id);
            this.ClientContext.PostObject(requestUrl, null);
        }

        public void UnlikeObject(ListItem listItemObject)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/unlike",
                    listItemObject.ObjectIdentity.Split(':').SkipLast(2).Last(),
                    listItemObject.Id);
            this.ClientContext.PostObject(requestUrl, null);
        }

    }

}
