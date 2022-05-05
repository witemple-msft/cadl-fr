// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsStringFieldType. </summary>
    internal readonly partial struct ModelsAnalyzeResultsDocumentElementsStringFieldType : IEquatable<ModelsAnalyzeResultsDocumentElementsStringFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsAnalyzeResultsDocumentElementsStringFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsAnalyzeResultsDocumentElementsStringFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";

        /// <summary> string. </summary>
        public static ModelsAnalyzeResultsDocumentElementsStringFieldType String { get; } = new ModelsAnalyzeResultsDocumentElementsStringFieldType(StringValue);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsStringFieldType"/> values are the same. </summary>
        public static bool operator ==(ModelsAnalyzeResultsDocumentElementsStringFieldType left, ModelsAnalyzeResultsDocumentElementsStringFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsStringFieldType"/> values are not the same. </summary>
        public static bool operator !=(ModelsAnalyzeResultsDocumentElementsStringFieldType left, ModelsAnalyzeResultsDocumentElementsStringFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsAnalyzeResultsDocumentElementsStringFieldType"/>. </summary>
        public static implicit operator ModelsAnalyzeResultsDocumentElementsStringFieldType(string value) => new ModelsAnalyzeResultsDocumentElementsStringFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsAnalyzeResultsDocumentElementsStringFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsAnalyzeResultsDocumentElementsStringFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}