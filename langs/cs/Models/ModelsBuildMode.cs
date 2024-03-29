// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsBuildMode. </summary>
    public readonly partial struct ModelsBuildMode : IEquatable<ModelsBuildMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelsBuildMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelsBuildMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TemplateValue = "template";
        private const string NeuralValue = "neural";

        /// <summary> template. </summary>
        public static ModelsBuildMode Template { get; } = new ModelsBuildMode(TemplateValue);
        /// <summary> neural. </summary>
        public static ModelsBuildMode Neural { get; } = new ModelsBuildMode(NeuralValue);
        /// <summary> Determines if two <see cref="ModelsBuildMode"/> values are the same. </summary>
        public static bool operator ==(ModelsBuildMode left, ModelsBuildMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelsBuildMode"/> values are not the same. </summary>
        public static bool operator !=(ModelsBuildMode left, ModelsBuildMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelsBuildMode"/>. </summary>
        public static implicit operator ModelsBuildMode(string value) => new ModelsBuildMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelsBuildMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelsBuildMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
