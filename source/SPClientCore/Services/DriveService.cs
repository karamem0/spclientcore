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

    public interface IDriveService
    {

        Drive GetObject(Drive driveObject);

        Drive GetObject(string driveId);

        IEnumerable<Drive> GetObjectEnumerable();

    }

    public class DriveService : ClientService, IDriveService
    {

        public DriveService(ClientContext clientContext) : base(clientContext)
        {
        }

        public Drive GetObject(Drive driveObject)
        {
            if (driveObject == null)
            {
                throw new ArgumentNullException(nameof(driveObject));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/v2.0/drives/{0}",
                    driveObject.Id)
                .ConcatQuery(ODataQuery.Create<Drive>());
            return this.ClientContext.GetObjectV2<Drive>(requestUrl);
        }

        public Drive GetObject(string driveId)
        {
            if (driveId == null)
            {
                throw new ArgumentNullException(nameof(driveId));
            }
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath(
                    "_api/v2.0/drives/{0}",
                    driveId)
                .ConcatQuery(ODataQuery.Create<Drive>());
            return this.ClientContext.GetObjectV2<Drive>(requestUrl);
        }

        public IEnumerable<Drive> GetObjectEnumerable()
        {
            var requestUrl = this.ClientContext.BaseAddress
                .ConcatPath("_api/v2.0/drives")
                .ConcatQuery(ODataQuery.Create<Drive>());
            return this.ClientContext.GetObjectV2<ODataV2ObjectEnumerable<Drive>>(requestUrl);
        }

    }

}
