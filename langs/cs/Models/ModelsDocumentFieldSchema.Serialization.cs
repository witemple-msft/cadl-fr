// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    public partial class ModelsDocumentFieldSchema
    {
        internal static ModelsDocumentFieldSchema DeserializeModelsDocumentFieldSchema(JsonElement element)
        {
            ModelsDocumentFieldType type = default;
            Optional<string> description = default;
            Optional<string> example = default;
            Optional<ModelsDocumentFieldSchema> items = default;
            Optional<IReadOnlyDictionary<string, ModelsDocumentFieldSchema>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new ModelsDocumentFieldType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("example"))
                {
                    example = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("items"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    items = DeserializeModelsDocumentFieldSchema(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ModelsDocumentFieldSchema> dictionary = new Dictionary<string, ModelsDocumentFieldSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeModelsDocumentFieldSchema(property0.Value));
                    }
                    properties = dictionary;
                    continue;
                }
            }
            return new ModelsDocumentFieldSchema(type, description.Value, example.Value, items.Value, Optional.ToDictionary(properties));
        }
    }
}
