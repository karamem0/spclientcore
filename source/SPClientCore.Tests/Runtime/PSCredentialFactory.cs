//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using System.Security;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests.Runtime
{

    public static class PSCredentialFactory
    {

        public static PSCredential CreateCredential(string userName, string password)
        {
            return PSCredentialFactory.CreateCredential(new NetworkCredential(userName, password));
        }

        public static PSCredential CreateCredential(string userName, SecureString password)
        {
            return PSCredentialFactory.CreateCredential(new NetworkCredential(userName, password));
        }

        public static PSCredential CreateCredential(NetworkCredential credential)
        {
            return new PSCredential(credential.UserName, credential.SecurePassword);
        }

    }

}
