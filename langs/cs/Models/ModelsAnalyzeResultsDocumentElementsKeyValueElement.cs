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
    /// <summary> The ModelsAnalyzeResultsDocumentElementsKeyValueElement. </summary>
    public partial class ModelsAnalyzeResultsDocumentElementsKeyValueElement
    {
        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsKeyValueElement. </summary>
        /// <param name="content"></param>
        /// <param name="spans"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal ModelsAnalyzeResultsDocumentElementsKeyValueElement(string content, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            Content = content;
            BoundingRegions = new ChangeTrackingList<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsKeyValueElement. </summary>
        /// <param name="content"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        internal ModelsAnalyzeResultsDocumentElementsKeyValueElement(string content, IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions, IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> spans)
        {
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
        }

        /// <summary> Gets the content. </summary>
        public string Content { get; }
        /// <summary> Gets the bounding regions. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> BoundingRegions { get; }
        /// <summary> Gets the spans. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> Spans { get; }
    }
}
