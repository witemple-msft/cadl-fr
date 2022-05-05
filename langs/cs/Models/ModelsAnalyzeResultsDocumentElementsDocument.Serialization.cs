// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    public partial class ModelsAnalyzeResultsDocumentElementsDocument
    {
        internal static ModelsAnalyzeResultsDocumentElementsDocument DeserializeModelsAnalyzeResultsDocumentElementsDocument(JsonElement element)
        {
            string docType = default;
            Optional<IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion>> boundingRegions = default;
            IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> spans = default;
            IReadOnlyDictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties> fields = default;
            double confidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docType"))
                {
                    docType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingRegions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ModelsAnalyzeResultsDocumentElementsBoundingRegion> array = new List<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelsAnalyzeResultsDocumentElementsBoundingRegion.DeserializeModelsAnalyzeResultsDocumentElementsBoundingRegion(item));
                    }
                    boundingRegions = array;
                    continue;
                }
                if (property.NameEquals("spans"))
                {
                    List<ModelsAnalyzeResultsDocumentElementsSpan> array = new List<ModelsAnalyzeResultsDocumentElementsSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelsAnalyzeResultsDocumentElementsSpan.DeserializeModelsAnalyzeResultsDocumentElementsSpan(item));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    Dictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties> dictionary = new Dictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties.DeserializeComponents1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties(property0.Value));
                    }
                    fields = dictionary;
                    continue;
                }
                if (property.NameEquals("confidence"))
                {
                    confidence = property.Value.GetDouble();
                    continue;
                }
            }
            return new ModelsAnalyzeResultsDocumentElementsDocument(docType, Optional.ToList(boundingRegions), spans, fields, confidence);
        }
    }
}
