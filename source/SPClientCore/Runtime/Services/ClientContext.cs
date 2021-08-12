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
using Karamem0.SharePoint.PowerShell.Runtime.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karamem0.SharePoint.PowerShell.Runtime.Services
{

    public class ClientContext
    {

        private Uri baseAddress;

        private readonly OAuthTokenProvider oAuthTokenProvider;

        private readonly ClientHttpExecutor clientHttpExecutor;

        public ClientContext(Uri baseAddress, OAuthTokenProvider oAuthTokenProvider)
            : base()
        {
            this.baseAddress = (baseAddress != null)
                ? new Uri(baseAddress.ToString().TrimEnd('/'), UriKind.Absolute)
                : throw new ArgumentNullException(nameof(baseAddress));
            this.oAuthTokenProvider = oAuthTokenProvider ?? throw new ArgumentNullException(nameof(oAuthTokenProvider));
            this.clientHttpExecutor = new ClientHttpExecutor();
        }

        public Uri BaseAddress
        {
            get => this.baseAddress;
            set => this.baseAddress = (value != null)
                ? new Uri(value.ToString().TrimEnd('/'), UriKind.Absolute)
                : throw new ArgumentNullException(nameof(value));
        }

        public string AccessToken => this.oAuthTokenProvider.CurrentAceessToken;

        public void DeleteObject(Uri requestUrl)
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    requestMessage.Headers.Add("X-HTTP-Method", "DELETE");
                    requestMessage.Headers.Add("If-Match", "*");
                    return requestMessage;
                },
                responseMessage => Task.FromResult(default(object)));
        }

        public T GetObject<T>(Uri requestUrl) where T : ODataV1Object
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            return this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    return requestMessage;
                },
                async responseMessage =>
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync();
                    var responsePayload = JsonSerializerManager.JsonSerializer.Deserialize<ODataV1ResultPayload<T>>(responseContent);
                    if (responsePayload.Error == null)
                    {
                        return responsePayload.Entry;
                    }
                    else
                    {
                        throw new InvalidOperationException(responsePayload.Error.Message.Value);
                    }
                });
        }

        public T GetObjectV2<T>(Uri requestUrl) where T : ODataV2Object
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            return this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json");
                    return requestMessage;
                },
                async responseMessage =>
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync();
                    var responsePayload = JsonSerializerManager.JsonSerializer.Deserialize<T>(responseContent);
                    return responsePayload;
                });
        }

        public System.IO.Stream GetStream(Uri requestUrl)
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            return this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    return requestMessage;
                },
                async responseMessage => await responseMessage.Content.ReadAsStreamAsync());
        }

        public void PatchObject(Uri requestUrl, object requestPayload)
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    requestMessage.Headers.Add("X-HTTP-Method", "PATCH");
                    requestMessage.Headers.Add("If-Match", "*");
                    if (requestPayload != null)
                    {
                        var requestContent = JsonSerializerManager.JsonSerializer.Serialize(requestPayload);
                        requestMessage.Content = new StringContent(requestContent, Encoding.UTF8);
                        requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json;odata=verbose");
                    }
                    return requestMessage;
                },
                responseMessage => Task.FromResult(default(object)));
        }

        public void PostObject(Uri requestUrl, object requestPayload)
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    if (requestPayload != null)
                    {
                        var jsonContent = JsonSerializerManager.JsonSerializer.Serialize(requestPayload);
                        requestMessage.Content = new StringContent(jsonContent, Encoding.UTF8);
                        requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json;odata=verbose");
                    }
                    return requestMessage;
                },
                responseMessage => Task.FromResult(default(object)));
        }

        public T PostObject<T>(Uri requestUrl, object requestPayload) where T : ODataV1Object
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            return this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    if (requestPayload != null)
                    {
                        var requestContent = JsonSerializerManager.JsonSerializer.Serialize(requestPayload);
                        requestMessage.Content = new StringContent(requestContent, Encoding.UTF8);
                        requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json;odata=verbose");
                    }
                    return requestMessage;
                },
                async responseMessage =>
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync();
                    var responsePayload = JsonSerializerManager.JsonSerializer.Deserialize<ODataV1ResultPayload<T>>(responseContent);
                    if (responsePayload.Error == null)
                    {
                        return responsePayload.Entry;
                    }
                    else
                    {
                        throw new InvalidOperationException(responsePayload.Error.Message.Value);
                    }
                });
        }


        public void PostStream(Uri requestUrl, System.IO.Stream requestStream)
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            _ = requestStream ?? throw new ArgumentNullException(nameof(requestStream));
            this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    requestMessage.Content = new StreamContent(requestStream);
                    requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json;odata=verbose");
                    return requestMessage;
                },
                responseMessage => Task.FromResult(default(object)));
        }

        public T PostStream<T>(Uri requestUrl, System.IO.Stream requestStream) where T : ODataV1Object
        {
            _ = requestUrl ?? throw new ArgumentNullException(nameof(requestUrl));
            _ = requestStream ?? throw new ArgumentNullException(nameof(requestStream));
            return this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    requestMessage.Headers.Add("Accept", "application/json;odata=verbose");
                    requestMessage.Content = new StreamContent(requestStream);
                    requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json;odata=verbose");
                    return requestMessage;
                },
                async responseMessage =>
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync();
                    var responsePayload = JsonSerializerManager.JsonSerializer.Deserialize<ODataV1ResultPayload<T>>(responseContent);
                    if (responsePayload.Error == null)
                    {
                        return responsePayload.Entry;
                    }
                    else
                    {
                        throw new InvalidOperationException(responsePayload.Error.Message.Value);
                    }
                });
        }

        public ClientResultPayload ProcessQuery(ClientRequestPayload requestPayload)
        {
            _ = requestPayload ?? throw new ArgumentNullException(nameof(requestPayload));
            return this.clientHttpExecutor.Execute(
                () =>
                {
                    var requestUrl = this.BaseAddress.ConcatPath("_vti_bin/client.svc/ProcessQuery");
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUrl);
                    requestMessage.Headers.Add("Authorization", $"Bearer {this.oAuthTokenProvider.GetAccessToken()}");
                    var requestContent = requestPayload.ToString();
                    requestMessage.Content = new StringContent(requestContent, Encoding.UTF8);
                    requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("text/xml");
                    return requestMessage;
                },
                async responseMessage =>
                {
                    var responseContent = await responseMessage.Content.ReadAsStringAsync();
                    var responsePayload = new ClientResultPayload(responseContent);
                    if (responsePayload.ErrorInfo == null)
                    {
                        return responsePayload;
                    }
                    else
                    {
                        throw new InvalidOperationException(responsePayload.ErrorInfo.ErrorMessage);
                    }
                });
        }

    }

}
