// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsCountryRegionField. </summary>
    internal partial class ModelsAnalyzeResultsDocumentElementsCountryRegionField
    {
        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsCountryRegionField. </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="spans"></param>
        /// <param name="confidence"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal ModelsAnalyzeResultsDocumentElementsCountryRegionField(ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType type, string content, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans, double confidence)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            Type = type;
            Content = content;
            BoundingRegions = new ChangeTrackingList<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            Spans = spans.ToList();
            Confidence = confidence;
        }

        /// <summary> Gets the type. </summary>
        public ModelsAnalyzeResultsDocumentElementsCountryRegionFieldType Type { get; }
        /// <summary> Gets the value country region. </summary>
        public string ValueCountryRegion { get; }
        /// <summary> Gets the content. </summary>
        public string Content { get; }
        /// <summary> Gets the bounding regions. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> BoundingRegions { get; }
        /// <summary> Gets the spans. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> Spans { get; }
        /// <summary> Gets the confidence. </summary>
        public double Confidence { get; }
    }
}
