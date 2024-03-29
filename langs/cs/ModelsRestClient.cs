// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using FormRecognizerClient.Models;

namespace FormRecognizerClient
{
    internal partial class ModelsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of ModelsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ModelsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2022-01-30-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetPageRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/formrecognizer/documentModels", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PageModelsModelSummary>> GetPageAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPageRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PageModelsModelSummary value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PageModelsModelSummary.DeserializePageModelsModelSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PageModelsModelSummary> GetPage(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetPageRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PageModelsModelSummary value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PageModelsModelSummary.DeserializePageModelsModelSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCopyModelToRequest(string modelId, CopyAuthorization body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/formrecognizer/documentModels/", false);
            uri.AppendPath(modelId, true);
            uri.AppendPath(":copyTo", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="modelId"> The String to use. </param>
        /// <param name="body"> The CopyAuthorization to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public async Task<ResponseWithHeaders<ModelsCopyModelToHeaders>> CopyModelToAsync(string modelId, CopyAuthorization body = null, CancellationToken cancellationToken = default)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            using var message = CreateCopyModelToRequest(modelId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ModelsCopyModelToHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="modelId"> The String to use. </param>
        /// <param name="body"> The CopyAuthorization to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public ResponseWithHeaders<ModelsCopyModelToHeaders> CopyModelTo(string modelId, CopyAuthorization body = null, CancellationToken cancellationToken = default)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            using var message = CreateCopyModelToRequest(modelId, body);
            _pipeline.Send(message, cancellationToken);
            var headers = new ModelsCopyModelToHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeRequest(string modelId, string pages, string locale, Enum1? stringIndexType, ModelsAnalyzeRequest body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/formrecognizer/documentModels/", false);
            uri.AppendPath(modelId, true);
            uri.AppendPath(":analyze", false);
            if (pages != null)
            {
                uri.AppendQuery("pages", pages, true);
            }
            if (locale != null)
            {
                uri.AppendQuery("locale", locale, true);
            }
            if (stringIndexType != null)
            {
                uri.AppendQuery("stringIndexType", stringIndexType.Value.ToString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="modelId"> The String to use. </param>
        /// <param name="pages"> The String to use. </param>
        /// <param name="locale"> The String to use. </param>
        /// <param name="stringIndexType"> The Enum1 to use. </param>
        /// <param name="body"> The ModelsAnalyzeRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public async Task<ResponseWithHeaders<ModelsAnalyzeHeaders>> AnalyzeAsync(string modelId, string pages = null, string locale = null, Enum1? stringIndexType = null, ModelsAnalyzeRequest body = null, CancellationToken cancellationToken = default)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            using var message = CreateAnalyzeRequest(modelId, pages, locale, stringIndexType, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new ModelsAnalyzeHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="modelId"> The String to use. </param>
        /// <param name="pages"> The String to use. </param>
        /// <param name="locale"> The String to use. </param>
        /// <param name="stringIndexType"> The Enum1 to use. </param>
        /// <param name="body"> The ModelsAnalyzeRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public ResponseWithHeaders<ModelsAnalyzeHeaders> Analyze(string modelId, string pages = null, string locale = null, Enum1? stringIndexType = null, ModelsAnalyzeRequest body = null, CancellationToken cancellationToken = default)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            using var message = CreateAnalyzeRequest(modelId, pages, locale, stringIndexType, body);
            _pipeline.Send(message, cancellationToken);
            var headers = new ModelsAnalyzeHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 202:
                    return ResponseWithHeaders.FromValue(headers, message.Response);
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
