// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsDocumentFieldType. </summary>
    public readonly partial struct ModelsDocumentFieldType : IEquatable<ModelsDocumentFieldType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsDocumentFieldType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsDocumentFieldType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";
        private const string DateValue = "date";
        private const string TimeValue = "time";
        private const string PhoneNumberValue = "phoneNumber";
        private const string NumberValue = "number";
        private const string IntegerValue = "integer";
        private const string SelectionMarkValue = "selectionMark";
        private const string CountryRegionValue = "countryRegion";
        private const string SignatureValue = "signature";
        private const string ArrayValue = "array";
        private const string ObjectValue = "object";
        private const string CurrencyValue = "currency";

        /// <summary> string. </summary>
        public static ModelsDocumentFieldType String { get; } = new ModelsDocumentFieldType(StringValue);
        /// <summary> date. </summary>
        public static ModelsDocumentFieldType Date { get; } = new ModelsDocumentFieldType(DateValue);
        /// <summary> time. </summary>
        public static ModelsDocumentFieldType Time { get; } = new ModelsDocumentFieldType(TimeValue);
        /// <summary> phoneNumber. </summary>
        public static ModelsDocumentFieldType PhoneNumber { get; } = new ModelsDocumentFieldType(PhoneNumberValue);
        /// <summary> number. </summary>
        public static ModelsDocumentFieldType Number { get; } = new ModelsDocumentFieldType(NumberValue);
        /// <summary> integer. </summary>
        public static ModelsDocumentFieldType Integer { get; } = new ModelsDocumentFieldType(IntegerValue);
        /// <summary> selectionMark. </summary>
        public static ModelsDocumentFieldType SelectionMark { get; } = new ModelsDocumentFieldType(SelectionMarkValue);
        /// <summary> countryRegion. </summary>
        public static ModelsDocumentFieldType CountryRegion { get; } = new ModelsDocumentFieldType(CountryRegionValue);
        /// <summary> signature. </summary>
        public static ModelsDocumentFieldType Signature { get; } = new ModelsDocumentFieldType(SignatureValue);
        /// <summary> array. </summary>
        public static ModelsDocumentFieldType Array { get; } = new ModelsDocumentFieldType(ArrayValue);
        /// <summary> object. </summary>
        public static ModelsDocumentFieldType Object { get; } = new ModelsDocumentFieldType(ObjectValue);
        /// <summary> currency. </summary>
        public static ModelsDocumentFieldType Currency { get; } = new ModelsDocumentFieldType(CurrencyValue);
        /// <summary> Determines if two <see cref="ModelsDocumentFieldType"/> values are the same. </summary>
        public static bool operator ==(ModelsDocumentFieldType left, ModelsDocumentFieldType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsDocumentFieldType"/> values are not the same. </summary>
        public static bool operator !=(ModelsDocumentFieldType left, ModelsDocumentFieldType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsDocumentFieldType"/>. </summary>
        public static implicit operator ModelsDocumentFieldType(string value) => new ModelsDocumentFieldType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsDocumentFieldType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsDocumentFieldType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
