// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType. </summary>
    internal readonly partial struct ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType : IEquatable<ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PhoneNumberValue = "phoneNumber";

        /// <summary> phoneNumber. </summary>
        public static ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType PhoneNumber { get; } = new ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType(PhoneNumberValue);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType"/> values are the same. </summary>
        public static bool operator ==(ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType left, ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType"/> values are not the same. </summary>
        public static bool operator !=(ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType left, ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType"/>. </summary>
        public static implicit operator ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType(string value) => new ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsAnalyzeResultsDocumentElementsPhoneNumberFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
