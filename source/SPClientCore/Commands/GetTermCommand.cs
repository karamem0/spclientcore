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

    [Cmdlet("Get", "KshTerm")]
    [OutputType(typeof(Term))]
    public class GetTermCommand : ClientObjectCmdlet<ITermService>
    {

        public GetTermCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        public Term Identity { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet2")]
        public TermLabel TermLabel { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet4")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet5")]
        public TermSet TermSet { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet6")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet7")]
        [Parameter(Mandatory = true, ParameterSetName = "ParamSet8")]
        public Term Term { get; private set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet6")]
        public Guid TermId { get; private set; }

        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet4")]
        [Parameter(Mandatory = true, Position = 1, ParameterSetName = "ParamSet7")]
        public string TermName { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet5")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet8")]
        public SwitchParameter NoEnumerate { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.GetObject(this.Identity));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.GetObject(this.TermLabel));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.WriteObject(this.Service.GetObject(this.TermSet, this.TermId));
            }
            if (this.ParameterSetName == "ParamSet4")
            {
                this.WriteObject(this.Service.GetObject(this.TermSet, this.TermName));
            }
            if (this.ParameterSetName == "ParamSet5")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(this.TermSet), this.NoEnumerate ? false : true);
            }
            if (this.ParameterSetName == "ParamSet6")
            {
                this.WriteObject(this.Service.GetObject(this.Term, this.TermId));
            }
            if (this.ParameterSetName == "ParamSet7")
            {
                this.WriteObject(this.Service.GetObject(this.Term, this.TermName));
            }
            if (this.ParameterSetName == "ParamSet8")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(this.Term), this.NoEnumerate ? false : true);
            }
        }

    }

}
