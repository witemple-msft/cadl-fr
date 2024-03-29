// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType. </summary>
    internal readonly partial struct ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType : IEquatable<ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CountryRegionValue = "countryRegion";

        /// <summary> countryRegion. </summary>
        public static ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType CountryRegion { get; } = new ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType(CountryRegionValue);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType"/> values are the same. </summary>
        public static bool operator ==(ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType left, ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType"/> values are not the same. </summary>
        public static bool operator !=(ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType left, ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType"/>. </summary>
        public static implicit operator ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType(string value) => new ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
