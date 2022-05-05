// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsDocTypeInfo. </summary>
    public partial class ModelsDocTypeInfo
    {
        /// <summary> Initializes a new instance of ModelsDocTypeInfo. </summary>
        /// <param name="fieldSchema"> Dictionary of &lt;Models.DocumentFieldSchema&gt;. </param>
        /// <param name="fieldConfidence"> Any object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fieldSchema"/> or <paramref name="fieldConfidence"/> is null. </exception>
        internal ModelsDocTypeInfo(IReadOnlyDictionary<string, ModelsDocumentFieldSchema> fieldSchema, object fieldConfidence)
        {
            if (fieldSchema == null)
            {
                throw new ArgumentNullException(nameof(fieldSchema));
            }
            if (fieldConfidence == null)
            {
                throw new ArgumentNullException(nameof(fieldConfidence));
            }

            FieldSchema = fieldSchema;
            FieldConfidence = fieldConfidence;
        }

        /// <summary> Initializes a new instance of ModelsDocTypeInfo. </summary>
        /// <param name="description"></param>
        /// <param name="buildMode"></param>
        /// <param name="fieldSchema"> Dictionary of &lt;Models.DocumentFieldSchema&gt;. </param>
        /// <param name="fieldConfidence"> Any object. </param>
        internal ModelsDocTypeInfo(string description, ModelsBuildMode? buildMode, IReadOnlyDictionary<string, ModelsDocumentFieldSchema> fieldSchema, object fieldConfidence)
        {
            Description = description;
            BuildMode = buildMode;
            FieldSchema = fieldSchema;
            FieldConfidence = fieldConfidence;
        }

        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> Gets the build mode. </summary>
        public ModelsBuildMode? BuildMode { get; }
        /// <summary> Dictionary of &lt;Models.DocumentFieldSchema&gt;. </summary>
        public IReadOnlyDictionary<string, ModelsDocumentFieldSchema> FieldSchema { get; }
        /// <summary> Any object. </summary>
        public object FieldConfidence { get; }
    }
}
