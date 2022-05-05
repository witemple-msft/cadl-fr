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
    /// <summary> The ModelsAnalyzeResultsDocumentElementsTableCell. </summary>
    public partial class ModelsAnalyzeResultsDocumentElementsTableCell
    {
        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsTableCell. </summary>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <param name="content"></param>
        /// <param name="spans"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> or <paramref name="spans"/> is null. </exception>
        internal ModelsAnalyzeResultsDocumentElementsTableCell(int rowIndex, int columnIndex, string content, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Content = content;
            BoundingRegions = new ChangeTrackingList<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsTableCell. </summary>
        /// <param name="kind"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        /// <param name="rowSpan"></param>
        /// <param name="columnSpan"></param>
        /// <param name="content"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        internal ModelsAnalyzeResultsDocumentElementsTableCell(ModelsAnalyzeResultsDocumentElementsTableCellKind? kind, int rowIndex, int columnIndex, int? rowSpan, int? columnSpan, string content, IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions, IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> spans)
        {
            Kind = kind;
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            RowSpan = rowSpan;
            ColumnSpan = columnSpan;
            Content = content;
            BoundingRegions = boundingRegions;
            Spans = spans;
        }

        /// <summary> Gets the kind. </summary>
        public ModelsAnalyzeResultsDocumentElementsTableCellKind? Kind { get; }
        /// <summary> Gets the row index. </summary>
        public int RowIndex { get; }
        /// <summary> Gets the column index. </summary>
        public int ColumnIndex { get; }
        /// <summary> Gets the row span. </summary>
        public int? RowSpan { get; }
        /// <summary> Gets the column span. </summary>
        public int? ColumnSpan { get; }
        /// <summary> Gets the content. </summary>
        public string Content { get; }
        /// <summary> Gets the bounding regions. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> BoundingRegions { get; }
        /// <summary> Gets the spans. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> Spans { get; }
    }
}
