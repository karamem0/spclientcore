//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karamem0.SharePoint.PowerShell.Runtime.Services
{

    public class ClientHttpMessageHandler : DelegatingHandler
    {

        public ClientHttpMessageHandler() : base(new HttpClientHandler())
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            Trace.WriteLine(requestMessage);
            if (requestMessage.Content != null)
            {
                Trace.WriteLine(await requestMessage.Content.ReadAsStringAsync());
            }
            var responseMessage = await base.SendAsync(requestMessage, cancellationToken);
            Trace.WriteLine(responseMessage);
            if (responseMessage.Content != null)
            {
                Trace.WriteLine(await responseMessage.Content.ReadAsStringAsync());
            }
            return responseMessage;
        }

    }

}
