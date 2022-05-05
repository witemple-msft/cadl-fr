// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType. </summary>
    internal readonly partial struct ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType : IEquatable<ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SelectionMarkValue = "selectionMark";

        /// <summary> selectionMark. </summary>
        public static ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType SelectionMark { get; } = new ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType(SelectionMarkValue);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType"/> values are the same. </summary>
        public static bool operator ==(ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType left, ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType"/> values are not the same. </summary>
        public static bool operator !=(ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType left, ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType"/>. </summary>
        public static implicit operator ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType(string value) => new ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsAnalyzeResultsDocumentElementsSelectionMarkFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}