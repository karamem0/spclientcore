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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("New-KshListItem")]
    public class NewListItemCommandTests
    {

        [TestMethod()]
        public void CreateListItem()
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
                var result2 = context.Runspace.InvokeCommand<List>(
                    "Get-KshList",
                    new Dictionary<string, object>()
                    {
                        { "ListId", context.AppSettings["List1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<ColumnLookupValue>(
                    "Initialize-KshColumnLookupValue",
                    new Dictionary<string, object>()
                    {
                        { "LookupId", context.AppSettings["ListItem1Id"] },
                    }
                );
                var result4 = context.Runspace.InvokeCommand<ColumnUserValue>(
                    "Initialize-KshColumnUserValue",
                    new Dictionary<string, object>()
                    {
                        { "LookupId", context.AppSettings["User1Id"] },
                    }
                );
                var result5 = context.Runspace.InvokeCommand<ColumnUrlValue>(
                    "Initialize-KshColumnUrlValue",
                    new Dictionary<string, object>()
                    {
                        { "Url", "https://www.example.com" },
                        { "Description", "Test Value 0" }
                    }
                );
                var result6 = context.Runspace.InvokeCommand<ColumnGeolocationValue>(
                    "Initialize-KshColumnGeolocationValue",
                    new Dictionary<string, object>()
                    {
                        { "Latitude", 10 },
                        { "Longitude", 10 }
                    }
                );
                var result7 = context.Runspace.InvokeCommand<TermGroup>(
                    "Get-KshTermGroup",
                    new Dictionary<string, object>()
                    {
                        { "TermGroupId", context.AppSettings["TermGroup1Id"] }
                    }
                );
                var result8 = context.Runspace.InvokeCommand<TermSet>(
                    "Get-KshTermSet",
                    new Dictionary<string, object>()
                    {
                        { "TermGroup", result7.ElementAt(0) },
                        { "TermSetId", context.AppSettings["TermSet1Id"] }
                    }
                );
                var result9 = context.Runspace.InvokeCommand<Term>(
                    "Get-KshTerm",
                    new Dictionary<string, object>()
                    {
                        { "TermSet", result8.ElementAt(0) },
                        { "TermId", context.AppSettings["Term1Id"] }
                    }
                );
                var result10 = context.Runspace.InvokeCommand<ColumnTaxonomyValue>(
                    "Initialize-KshColumnTaxonomyValue",
                    new Dictionary<string, object>()
                    {
                        { "Term", result9.ElementAt(0) }
                    }
                );
                var result11 = context.Runspace.InvokeCommand<ImageItem>(
                    "Save-KshImage",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "FileName", "TestFile0.png" },
                        { "Content", new System.IO.MemoryStream(Convert.FromBase64String(
                            "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABAQMAAAAl21bKAAAAA1BMVEUAAACnej3aAAAAAXRSTlMA" +
                            "QObYZgAAAApJREFUCNdjYAAAAAIAAeIhvDMAAAAASUVORK5CYII="
                        )) }
                    }
                );
                var result12 = context.Runspace.InvokeCommand<ColumnImageValue>(
                    "Initialize-KshColumnImageValue",
                    new Dictionary<string, object>()
                    {
                        { "ImageItem", result11.ElementAt(0) },
                        { "ColumnName", "TestColumn17" }
                    }
                );
                var result13 = context.Runspace.InvokeCommand<ListItem>(
                    "New-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "List", result2.ElementAt(0) },
                        { "Value", new Hashtable()
                            {
                                { "TestColumn1", "Test Value 0" },
                                { "TestColumn2", "Test Value 0" },
                                { "TestColumn3", "Test Value 0" },
                                { "TestColumn4", new[] { "Test Value 0" } },
                                { "TestColumn5", 1 },
                                { "TestColumn6", 200 },
                                { "TestColumn7", new DateTime(2010, 10, 10) },
                                { "TestColumn8", result3.ElementAt(0) },
                                { "TestColumn9", new[] { result3.ElementAt(0) } },
                                { "TestColumn10", true },
                                { "TestColumn11", result4.ElementAt(0) },
                                { "TestColumn12", new[] { result4.ElementAt(0) } },
                                { "TestColumn13", result5.ElementAt(0) },
                                { "TestColumn15", result6.ElementAt(0) },
                                { "TestColumn16", result10.ElementAt(0) },
                                { "TestColumn17", result12.ElementAt(0) }
                            }
                        }
                    }
                );
                var result14 = context.Runspace.InvokeCommand(
                    "Remove-KshListItem",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result13.ElementAt(0) }
                    }
                );
                var result15 = context.Runspace.InvokeCommand<File>(
                    "Get-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "FileUrl", result11.ElementAt(0).ServerRelativeUrl }
                    }
                );
                var result16 = context.Runspace.InvokeCommand(
                    "Remove-KshFile",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result15.ElementAt(0) }
                    }
                );
                var actual = result13.ElementAt(0);
            }
        }

    }

}
