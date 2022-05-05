// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsSelectionMarkState. </summary>
    public readonly partial struct ModelsAnalyzeResultsDocumentElementsSelectionMarkState : IEquatable<ModelsAnalyzeResultsDocumentElementsSelectionMarkState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsAnalyzeResultsDocumentElementsSelectionMarkState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SelectedValue = "selected";
        private const string UnselectedValue = "unselected";

        /// <summary> selected. </summary>
        public static ModelsAnalyzeResultsDocumentElementsSelectionMarkState Selected { get; } = new ModelsAnalyzeResultsDocumentElementsSelectionMarkState(SelectedValue);
        /// <summary> unselected. </summary>
        public static ModelsAnalyzeResultsDocumentElementsSelectionMarkState Unselected { get; } = new ModelsAnalyzeResultsDocumentElementsSelectionMarkState(UnselectedValue);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkState"/> values are the same. </summary>
        public static bool operator ==(ModelsAnalyzeResultsDocumentElementsSelectionMarkState left, ModelsAnalyzeResultsDocumentElementsSelectionMarkState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkState"/> values are not the same. </summary>
        public static bool operator !=(ModelsAnalyzeResultsDocumentElementsSelectionMarkState left, ModelsAnalyzeResultsDocumentElementsSelectionMarkState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsAnalyzeResultsDocumentElementsSelectionMarkState"/>. </summary>
        public static implicit operator ModelsAnalyzeResultsDocumentElementsSelectionMarkState(string value) => new ModelsAnalyzeResultsDocumentElementsSelectionMarkState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsAnalyzeResultsDocumentElementsSelectionMarkState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsAnalyzeResultsDocumentElementsSelectionMarkState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
