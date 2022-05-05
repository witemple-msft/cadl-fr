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
    /// <summary> The ModelsAnalyzeResultsDocumentElementsDocument. </summary>
    public partial class ModelsAnalyzeResultsDocumentElementsDocument
    {
        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsDocument. </summary>
        /// <param name="docType"></param>
        /// <param name="spans"></param>
        /// <param name="fields"> Dictionary of &lt;components·1jq6pnz·schemas·models-analyzeresults-documentelements-document·properties·fields·additionalproperties&gt;. </param>
        /// <param name="confidence"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="docType"/>, <paramref name="spans"/> or <paramref name="fields"/> is null. </exception>
        internal ModelsAnalyzeResultsDocumentElementsDocument(string docType, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans, IReadOnlyDictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties> fields, double confidence)
        {
            if (docType == null)
            {
                throw new ArgumentNullException(nameof(docType));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }
            if (fields == null)
            {
                throw new ArgumentNullException(nameof(fields));
            }

            DocType = docType;
            BoundingRegions = new ChangeTrackingList<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            Spans = spans.ToList();
            Fields = fields;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsDocument. </summary>
        /// <param name="docType"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        /// <param name="fields"> Dictionary of &lt;components·1jq6pnz·schemas·models-analyzeresults-documentelements-document·properties·fields·additionalproperties&gt;. </param>
        /// <param name="confidence"></param>
        internal ModelsAnalyzeResultsDocumentElementsDocument(string docType, IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions, IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> spans, IReadOnlyDictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties> fields, double confidence)
        {
            DocType = docType;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Fields = fields;
            Confidence = confidence;
        }

        /// <summary> Gets the doc type. </summary>
        public string DocType { get; }
        /// <summary> Gets the bounding regions. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsBoundingRegion> BoundingRegions { get; }
        /// <summary> Gets the spans. </summary>
        public IReadOnlyList<ModelsAnalyzeResultsDocumentElementsSpan> Spans { get; }
        /// <summary> Dictionary of &lt;components·1jq6pnz·schemas·models-analyzeresults-documentelements-document·properties·fields·additionalproperties&gt;. </summary>
        public IReadOnlyDictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties> Fields { get; }
        /// <summary> Gets the confidence. </summary>
        public double Confidence { get; }
    }
}