//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Tests.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("Add-KshDocumentSetWelcomePageColumn")]
    public class AddDocumentSetWelcomePageColumnCommandTests
    {

        [TestMethod()]
        public void AddDocumentSetWelcomePageColumn()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AuthorityUrl"] + context.AppSettings["Site1Url"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<ContentType>(
                    "Get-KshContentType",
                    new Dictionary<string, object>()
                    {
                        { "ContentTypeId", context.AppSettings["SiteContentType7Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshColumn",
                    new Dictionary<string, object>()
                    {
                        { "ColumnId", context.AppSettings["Column9Id"] }
                    }
                );
                var result4 = context.Runspace.InvokeCommand(
                    "Add-KshDocumentSetWelcomePageColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) },
                        { "Column", result3.ElementAt(0) }
                    }
                );
                var result5 = context.Runspace.InvokeCommand<Column>(
                    "Get-KshDocumentSetWelcomePageColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) }
                    }
                );
                var result6 = context.Runspace.InvokeCommand(
                    "Remove-KshDocumentSetWelcomePageColumn",
                    new Dictionary<string, object>()
                    {
                        { "ContentType", result2.ElementAt(0) },
                        { "Column", result3.ElementAt(0) }
                    }
                );
                var actual = result5.ToArray();
            }
        }

    }

}
