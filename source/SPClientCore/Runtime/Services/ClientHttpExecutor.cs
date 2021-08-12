//
// Copyright (c) 2021 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/spclientcore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Common;
using Karamem0.SharePoint.PowerShell.Runtime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karamem0.SharePoint.PowerShell.Runtime.Services
{

    public class ClientHttpExecutor
    {

        private readonly HttpClient httpClient;

        public ClientHttpExecutor()
        {
            this.httpClient = new HttpClient(new ClientHttpMessageHandler());
            this.httpClient.Timeout = Timeout.InfiniteTimeSpan;
            this.httpClient.DefaultRequestHeaders.UserAgent.Add(
                new ProductInfoHeaderValue(
                    ClientConstants.UserAgent,
                    this.GetType().Assembly.GetName().Version.ToString(3)));
        }

        public void Execute(
            Func<HttpRequestMessage> requestCallback,
            Func<HttpResponseMessage, Task<object>> responseCallback
        )
        {
            _ = this.ExecuteAsync(requestCallback, responseCallback).GetAwaiter().GetResult();
        }

        public T Execute<T>(
            Func<HttpRequestMessage> requestCallback,
            Func<HttpResponseMessage, Task<T>> responseCallback
        )
        {
            return this.ExecuteAsync(requestCallback, responseCallback).GetAwaiter().GetResult();
        }

        public async Task<T> ExecuteAsync<T>(
            Func<HttpRequestMessage> requestCallback,
            Func<HttpResponseMessage, Task<T>> responseCallback
        )
        {
            if (requestCallback == null)
            {
                throw new ArgumentNullException(nameof(requestCallback));
            }
            if (responseCallback == null)
            {
                throw new ArgumentNullException(nameof(responseCallback));
            }
            var errorCount = 0;
            while (true)
            {
                var requestMessage = requestCallback.Invoke();
                var responseMessage = await this.httpClient.SendAsync(requestMessage);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return await responseCallback.Invoke(responseMessage);
                }
                else if ((int)responseMessage.StatusCode == 429 ||
                        (int)responseMessage.StatusCode == 502 ||
                        (int)responseMessage.StatusCode == 503)
                {
                    errorCount += 1;
                    if (errorCount > ClientConstants.MaxRetryCount)
                    {
                        throw new InvalidOperationException(StringResources.ErrorMaxRetryCountExceeded);
                    }
                    await Task.Delay(responseMessage.Headers.RetryAfter.Delta.GetValueOrDefault(TimeSpan.FromSeconds(errorCount + 1)));
                }
                else
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync();
                    if (JsonSerializerManager.JsonSerializer.TryDeserialize(
                        responseContent,
                        out ODataV1ResultPayload v1Payload))
                    {
                        throw new InvalidOperationException(v1Payload.Error.Message.Value);
                    }
                    if (JsonSerializerManager.JsonSerializer.TryDeserialize(
                        responseContent,
                        out ODataV2ResultPayload v2Payload))
                    {
                        throw new InvalidOperationException(v2Payload.Error.Message);
                    }
                }
            }
        }

    }

}
