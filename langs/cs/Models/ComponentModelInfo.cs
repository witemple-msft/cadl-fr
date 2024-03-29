// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace FormRecognizerClient.Models
{
    /// <summary> The ComponentModelInfo. </summary>
    public partial class ComponentModelInfo
    {
        /// <summary> Initializes a new instance of ComponentModelInfo. </summary>
        /// <param name="modelId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public ComponentModelInfo(string modelId)
        {
            if (modelId == null)
            {
                throw new ArgumentNullException(nameof(modelId));
            }

            ModelId = modelId;
        }

        /// <summary> Gets the model id. </summary>
        public string ModelId { get; }
    }
}
