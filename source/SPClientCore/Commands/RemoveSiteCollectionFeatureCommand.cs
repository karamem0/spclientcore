//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Remove", "KshSiteCollectionFeature")]
    [OutputType(typeof(void))]
    public class RemoveSiteCollectionFeatureCommand : ClientObjectCmdlet<ISiteCollectionFeatureService>
    {

        public RemoveSiteCollectionFeatureCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Feature Identity { get; private set; }

        [Parameter(Mandatory = false)]
        public bool Force { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.Service.RemoveObject(this.Identity.DefinitionId, this.Force);
        }

    }

}
