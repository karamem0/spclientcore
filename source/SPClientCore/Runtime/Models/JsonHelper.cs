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

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    public static class JsonHelper
    {

        public static string ReplaceDoubleToInfinity(string value)
        {
            return value.Replace("1.79769313486232E+308", "Infinity");
        }

    }

}
