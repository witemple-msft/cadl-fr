// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace FormRecognizerClient.Models
{
    /// <summary> The ResourceInfo. </summary>
    public partial class ResourceInfo
    {
        /// <summary> Initializes a new instance of ResourceInfo. </summary>
        /// <param name="customDocumentModels"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDocumentModels"/> is null. </exception>
        internal ResourceInfo(CustomDocumentModelInfo customDocumentModels)
        {
            if (customDocumentModels == null)
            {
                throw new ArgumentNullException(nameof(customDocumentModels));
            }

            CustomDocumentModels = customDocumentModels;
        }

        /// <summary> Gets the custom document models. </summary>
        public CustomDocumentModelInfo CustomDocumentModels { get; }
    }
}