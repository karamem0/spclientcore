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
using System.Net.Http;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    public abstract class OAuthContext
    {

        protected OAuthContext()
        {
            this.HttpClient = new HttpClient();
        }

        protected HttpClient HttpClient { get; }

    }

}
