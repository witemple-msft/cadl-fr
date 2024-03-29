// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    public partial class ModelsAnalyzeResultsDocumentElementsPage
    {
        internal static ModelsAnalyzeResultsDocumentElementsPage DeserializeModelsAnalyzeResultsDocumentElementsPage(JsonElement element)
        {
            int pageNumber = default;
            double angle = default;
            double width = default;
            double height = default;
            ModelsAnalyzeResultsDocumentElementsPageUnit unit = default;
            IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> spans = default;
            IReadOnlyList<ModelsAnalyzeResultsDocumentElementsWord> words = default;
            Optional<IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSelectionMark>> selectionMarks = default;
            IReadOnlyList<ModelsAnalyzeResultsDocumentElementsLine> lines = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageNumber"))
                {
                    pageNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("angle"))
                {
                    angle = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("width"))
                {
                    width = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("height"))
                {
                    height = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = new ModelsAnalyzeResultsDocumentElementsPageUnit(property.Value.GetString());
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
                if (property.NameEquals("words"))
                {
                    List<ModelsAnalyzeResultsDocumentElementsWord> array = new List<ModelsAnalyzeResultsDocumentElementsWord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelsAnalyzeResultsDocumentElementsWord.DeserializeModelsAnalyzeResultsDocumentElementsWord(item));
                    }
                    words = array;
                    continue;
                }
                if (property.NameEquals("selectionMarks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ModelsAnalyzeResultsDocumentElementsSelectionMark> array = new List<ModelsAnalyzeResultsDocumentElementsSelectionMark>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelsAnalyzeResultsDocumentElementsSelectionMark.DeserializeModelsAnalyzeResultsDocumentElementsSelectionMark(item));
                    }
                    selectionMarks = array;
                    continue;
                }
                if (property.NameEquals("lines"))
                {
                    List<ModelsAnalyzeResultsDocumentElementsLine> array = new List<ModelsAnalyzeResultsDocumentElementsLine>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelsAnalyzeResultsDocumentElementsLine.DeserializeModelsAnalyzeResultsDocumentElementsLine(item));
                    }
                    lines = array;
                    continue;
                }
            }
            return new ModelsAnalyzeResultsDocumentElementsPage(pageNumber, angle, width, height, unit, spans, words, Optional.ToList(selectionMarks), lines);
        }
    }
}
