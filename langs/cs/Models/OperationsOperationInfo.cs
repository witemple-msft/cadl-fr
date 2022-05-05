// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    /// <summary> The OperationsOperationInfo. </summary>
    public partial class OperationsOperationInfo
    {
        /// <summary> Initializes a new instance of OperationsOperationInfo. </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="kind"></param>
        /// <param name="resourceLocation"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal OperationsOperationInfo(string operationId, OperationsOperationStatus status, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, OperationsOperationKind kind, string resourceLocation)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }
            if (resourceLocation == null)
            {
                throw new ArgumentNullException(nameof(resourceLocation));
            }

            OperationId = operationId;
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Kind = kind;
            ResourceLocation = resourceLocation;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of OperationsOperationInfo. </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="percentCompleted"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="kind"></param>
        /// <param name="resourceLocation"></param>
        /// <param name="apiVersion"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        internal OperationsOperationInfo(string operationId, OperationsOperationStatus status, int? percentCompleted, DateTimeOffset createdDateTime, DateTimeOffset lastUpdatedDateTime, OperationsOperationKind kind, string resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            Kind = kind;
            ResourceLocation = resourceLocation;
            ApiVersion = apiVersion;
            Tags = tags;
        }

        /// <summary> Gets the operation id. </summary>
        public string OperationId { get; }
        /// <summary> Gets the status. </summary>
        public OperationsOperationStatus Status { get; }
        /// <summary> Gets the percent completed. </summary>
        public int? PercentCompleted { get; }
        /// <summary> Gets the created date time. </summary>
        public DateTimeOffset CreatedDateTime { get; }
        /// <summary> Gets the last updated date time. </summary>
        public DateTimeOffset LastUpdatedDateTime { get; }
        /// <summary> Gets the kind. </summary>
        public OperationsOperationKind Kind { get; }
        /// <summary> Gets the resource location. </summary>
        public string ResourceLocation { get; }
        /// <summary> Gets the api version. </summary>
        public string ApiVersion { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
