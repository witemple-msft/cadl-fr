// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsStringIndexType. </summary>
    public readonly partial struct ModelsStringIndexType : IEquatable<ModelsStringIndexType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsStringIndexType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsStringIndexType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextElementsValue = "textElements";
        private const string UnicodeCodePointValue = "unicodeCodePoint";
        private const string Utf16CodeUnitValue = "utf16CodeUnit";

        /// <summary> textElements. </summary>
        public static ModelsStringIndexType TextElements { get; } = new ModelsStringIndexType(TextElementsValue);
        /// <summary> unicodeCodePoint. </summary>
        public static ModelsStringIndexType UnicodeCodePoint { get; } = new ModelsStringIndexType(UnicodeCodePointValue);
        /// <summary> utf16CodeUnit. </summary>
        public static ModelsStringIndexType Utf16CodeUnit { get; } = new ModelsStringIndexType(Utf16CodeUnitValue);
        /// <summary> Determines if two <see cref="ModelsStringIndexType"/> values are the same. </summary>
        public static bool operator ==(ModelsStringIndexType left, ModelsStringIndexType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsStringIndexType"/> values are not the same. </summary>
        public static bool operator !=(ModelsStringIndexType left, ModelsStringIndexType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsStringIndexType"/>. </summary>
        public static implicit operator ModelsStringIndexType(string value) => new ModelsStringIndexType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsStringIndexType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsStringIndexType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
