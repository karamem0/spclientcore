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
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.OAuth
{

    public abstract class OAuthTokenProvider
    {

        protected OAuthTokenProvider()
        {
        }

        public abstract string CurrentAceessToken { get; }

        public abstract string GetAccessToken();

    }

}
