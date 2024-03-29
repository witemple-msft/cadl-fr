// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsIntegerFieldType. </summary>
    internal readonly partial struct ModelsAnalyzeResultsDocumentElementsIntegerFieldType : IEquatable<ModelsAnalyzeResultsDocumentElementsIntegerFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsAnalyzeResultsDocumentElementsIntegerFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsAnalyzeResultsDocumentElementsIntegerFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntegerValue = "integer";

        /// <summary> integer. </summary>
        public static ModelsAnalyzeResultsDocumentElementsIntegerFieldType Integer { get; } = new ModelsAnalyzeResultsDocumentElementsIntegerFieldType(IntegerValue);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsIntegerFieldType"/> values are the same. </summary>
        public static bool operator ==(ModelsAnalyzeResultsDocumentElementsIntegerFieldType left, ModelsAnalyzeResultsDocumentElementsIntegerFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsIntegerFieldType"/> values are not the same. </summary>
        public static bool operator !=(ModelsAnalyzeResultsDocumentElementsIntegerFieldType left, ModelsAnalyzeResultsDocumentElementsIntegerFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsAnalyzeResultsDocumentElementsIntegerFieldType"/>. </summary>
        public static implicit operator ModelsAnalyzeResultsDocumentElementsIntegerFieldType(string value) => new ModelsAnalyzeResultsDocumentElementsIntegerFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsAnalyzeResultsDocumentElementsIntegerFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsAnalyzeResultsDocumentElementsIntegerFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
