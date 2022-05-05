// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    public partial class ComponentModelInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("modelId");
            writer.WriteStringValue(ModelId);
            writer.WriteEndObject();
        }
    }
}