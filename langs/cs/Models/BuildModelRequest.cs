// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    /// <summary> The BuildModelRequest. </summary>
    public partial class BuildModelRequest
    {
        /// <summary> Initializes a new instance of BuildModelRequest. </summary>
        /// <param name="modelId"></param>
        /// <param name="buildMode"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public BuildModelRequest(string modelId, ModelsBuildMode buildMode)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            ModelId = modelId;
            BuildMode = buildMode;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets the model id. </summary>
        public string ModelId { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets the build mode. </summary>
        public ModelsBuildMode BuildMode { get; }
        /// <summary> Gets or sets the azure blob source. </summary>
        public AzureBlobContentSource AzureBlobSource { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
