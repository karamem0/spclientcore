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

    public interface ICommentService
    {

        Comment CreateObject(ListItem listItemObject, IReadOnlyDictionary<string, object> creationInformation);

        Comment CreateObject(Comment commentObject, IReadOnlyDictionary<string, object> creationInformation);

        Comment GetObject(Comment commentObject);

        Comment GetObject(ListItem listItemObject, int commentId);

        IEnumerable<Comment> GetObjectEnumerable(ListItem listItemObject);

        void RemoveObject(Comment commentObject);

    }

    public class CommentService : ClientService, ICommentService
    {

        public CommentService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Comment CreateObject(ListItem listItemObject, IReadOnlyDictionary<string, object> creationInformation)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments",
                    listItemObject.ObjectIdentity.Split(':').SkipLast(2).Last(),
                    listItemObject.Id)
                .ConcatQuery(ODataQuery.Create<Comment>());
            var requestPayload = new ODataV1RequestPayload<CommentCreationInformation>(creationInformation);
            return this.ClientContext.PostObject<Comment>(requestUrl, requestPayload.Entity);
        }

        public Comment CreateObject(Comment commentObject, IReadOnlyDictionary<string, object> creationInformation)
        {
            _ = commentObject ?? throw new ArgumentNullException(nameof(commentObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})/replies",
                    commentObject.ListId,
                    commentObject.ItemId,
                    commentObject.Id)
                .ConcatQuery(ODataQuery.Create<Comment>());
            var requestPayload = new ODataV1RequestPayload<CommentCreationInformation>(creationInformation);
            return this.ClientContext.PostObject<Comment>(requestUrl, requestPayload.Entity);
        }

        public Comment GetObject(Comment commentObject)
        {
            _ = commentObject ?? throw new ArgumentNullException(nameof(commentObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})",
                    commentObject.ListId,
                    commentObject.ItemId,
                    commentObject.Id)
                .ConcatQuery(ODataQuery.Create<Comment>());
            return this.ClientContext.GetObject<Comment>(requestUrl);
        }

        public Comment GetObject(ListItem listItemObject, int commentId)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            _ = (commentId != default) ? commentId : throw new ArgumentNullException(nameof(commentId));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})",
                    listItemObject.ObjectIdentity.Split(':').SkipLast(2).Last(),
                    listItemObject.Id,
                    commentId)
                .ConcatQuery(ODataQuery.Create<Comment>());
            return this.ClientContext.GetObject<Comment>(requestUrl);
        }

        public IEnumerable<Comment> GetObjectEnumerable(ListItem listItemObject)
        {
            _ = listItemObject ?? throw new ArgumentNullException(nameof(listItemObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments",
                    listItemObject.ObjectIdentity.Split(':').SkipLast(2).Last(),
                    listItemObject.Id)
                .ConcatQuery(ODataQuery.Create<Comment>());
            return this.ClientContext.GetObject<ODataV1ObjectEnumerable<Comment>>(requestUrl);
        }

        public void RemoveObject(Comment commentObject)
        {
            _ = commentObject ?? throw new ArgumentNullException(nameof(commentObject));
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/web/lists('{0}')/items({1})/comments({2})",
                    commentObject.ListId,
                    commentObject.ItemId,
                    commentObject.Id);
            this.ClientContext.DeleteObject(requestUrl);
        }

    }

}
