// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace FormRecognizerClient.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class FormRecognizerModelFactory
    {
        /// <summary> Initializes a new instance of ResourceInfo. </summary>
        /// <param name="customDocumentModels"></param>
        /// <returns> A new <see cref="Models.ResourceInfo"/> instance for mocking. </returns>
        public static ResourceInfo ResourceInfo(CustomDocumentModelInfo customDocumentModels = null)
        {
            return new ResourceInfo(customDocumentModels);
        }

        /// <summary> Initializes a new instance of CustomDocumentModelInfo. </summary>
        /// <param name="count"></param>
        /// <param name="limit"></param>
        /// <returns> A new <see cref="Models.CustomDocumentModelInfo"/> instance for mocking. </returns>
        public static CustomDocumentModelInfo CustomDocumentModelInfo(int count = default, int limit = default)
        {
            return new CustomDocumentModelInfo(count, limit);
        }

        /// <summary> Initializes a new instance of PageModelsModelSummary. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <returns> A new <see cref="Models.PageModelsModelSummary"/> instance for mocking. </returns>
        public static PageModelsModelSummary PageModelsModelSummary(IEnumerable<ModelsModelSummary> value = null, string nextLink = null)
        {
            value ??= new List<ModelsModelSummary>();

            return new PageModelsModelSummary(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of ModelsModelSummary. </summary>
        /// <param name="modelId"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="apiVersion"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <returns> A new <see cref="Models.ModelsModelSummary"/> instance for mocking. </returns>
        public static ModelsModelSummary ModelsModelSummary(string modelId = null, DateTimeOffset createdDateTime = default, string apiVersion = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ModelsModelSummary(modelId, createdDateTime, apiVersion, tags);
        }

        /// <summary> Initializes a new instance of ModelsModelInfo. </summary>
        /// <param name="modelId"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="apiVersion"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="docTypes"> Dictionary of &lt;Models.DocTypeInfo&gt;. </param>
        /// <returns> A new <see cref="Models.ModelsModelInfo"/> instance for mocking. </returns>
        public static ModelsModelInfo ModelsModelInfo(string modelId = null, DateTimeOffset createdDateTime = default, string apiVersion = null, IReadOnlyDictionary<string, string> tags = null, IReadOnlyDictionary<string, ModelsDocTypeInfo> docTypes = null)
        {
            tags ??= new Dictionary<string, string>();
            docTypes ??= new Dictionary<string, ModelsDocTypeInfo>();

            return new ModelsModelInfo(modelId, createdDateTime, apiVersion, tags, docTypes);
        }

        /// <summary> Initializes a new instance of ModelsDocTypeInfo. </summary>
        /// <param name="description"></param>
        /// <param name="buildMode"></param>
        /// <param name="fieldSchema"> Dictionary of &lt;Models.DocumentFieldSchema&gt;. </param>
        /// <param name="fieldConfidence"> Any object. </param>
        /// <returns> A new <see cref="Models.ModelsDocTypeInfo"/> instance for mocking. </returns>
        public static ModelsDocTypeInfo ModelsDocTypeInfo(string description = null, ModelsBuildMode? buildMode = null, IReadOnlyDictionary<string, ModelsDocumentFieldSchema> fieldSchema = null, object fieldConfidence = null)
        {
            fieldSchema ??= new Dictionary<string, ModelsDocumentFieldSchema>();

            return new ModelsDocTypeInfo(description, buildMode, fieldSchema, fieldConfidence);
        }

        /// <summary> Initializes a new instance of ModelsDocumentFieldSchema. </summary>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="example"></param>
        /// <param name="items"></param>
        /// <param name="properties"> Dictionary of &lt;Models.DocumentFieldSchema&gt;. </param>
        /// <returns> A new <see cref="Models.ModelsDocumentFieldSchema"/> instance for mocking. </returns>
        public static ModelsDocumentFieldSchema ModelsDocumentFieldSchema(ModelsDocumentFieldType type = default, string description = null, string example = null, ModelsDocumentFieldSchema items = null, IReadOnlyDictionary<string, ModelsDocumentFieldSchema> properties = null)
        {
            properties ??= new Dictionary<string, ModelsDocumentFieldSchema>();

            return new ModelsDocumentFieldSchema(type, description, example, items, properties);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsAnalyzeOperation. </summary>
        /// <param name="status"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="error"></param>
        /// <param name="analyzeResult"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsAnalyzeOperation"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsAnalyzeOperation ModelsAnalyzeResultsAnalyzeOperation(ModelsAnalyzeResultsAnalyzeOperationStatus status = default, DateTimeOffset createdDateTime = default, DateTimeOffset lastUpdatedDateTime = default, Error error = null, ModelsAnalyzeResultsAnalyzeResult analyzeResult = null)
        {
            return new ModelsAnalyzeResultsAnalyzeOperation(status, createdDateTime, lastUpdatedDateTime, error, analyzeResult);
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="target"></param>
        /// <param name="details"></param>
        /// <param name="innererror"></param>
        /// <returns> A new <see cref="Models.Error"/> instance for mocking. </returns>
        public static Error Error(string code = null, string message = null, string target = null, IEnumerable<Error> details = null, Error innererror = null)
        {
            details ??= new List<Error>();

            return new Error(code, message, target, details?.ToList(), innererror);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsAnalyzeResult. </summary>
        /// <param name="apiVersion"></param>
        /// <param name="modelId"></param>
        /// <param name="stringIndexType"></param>
        /// <param name="content"></param>
        /// <param name="pages"></param>
        /// <param name="tables"></param>
        /// <param name="keyValuePairs"></param>
        /// <param name="entities"></param>
        /// <param name="styles"></param>
        /// <param name="languages"></param>
        /// <param name="documents"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsAnalyzeResult"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsAnalyzeResult ModelsAnalyzeResultsAnalyzeResult(string apiVersion = null, string modelId = null, ModelsStringIndexType stringIndexType = default, string content = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsPage> pages = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsTable> tables = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsKeyValuePair> keyValuePairs = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsEntity> entities = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsStyle> styles = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsLanguage> languages = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsDocument> documents = null)
        {
            pages ??= new List<ModelsAnalyzeResultsDocumentElementsPage>();
            tables ??= new List<ModelsAnalyzeResultsDocumentElementsTable>();
            keyValuePairs ??= new List<ModelsAnalyzeResultsDocumentElementsKeyValuePair>();
            entities ??= new List<ModelsAnalyzeResultsDocumentElementsEntity>();
            styles ??= new List<ModelsAnalyzeResultsDocumentElementsStyle>();
            languages ??= new List<ModelsAnalyzeResultsDocumentElementsLanguage>();
            documents ??= new List<ModelsAnalyzeResultsDocumentElementsDocument>();

            return new ModelsAnalyzeResultsAnalyzeResult(apiVersion, modelId, stringIndexType, content, pages?.ToList(), tables?.ToList(), keyValuePairs?.ToList(), entities?.ToList(), styles?.ToList(), languages?.ToList(), documents?.ToList());
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsPage. </summary>
        /// <param name="pageNumber"></param>
        /// <param name="angle"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="unit"></param>
        /// <param name="spans"></param>
        /// <param name="words"></param>
        /// <param name="selectionMarks"></param>
        /// <param name="lines"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsPage"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsPage ModelsAnalyzeResultsDocumentElementsPage(int pageNumber = default, double angle = default, double width = default, double height = default, ModelsAnalyzeResultsDocumentElementsPageUnit unit = default, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsWord> words = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSelectionMark> selectionMarks = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsLine> lines = null)
        {
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();
            words ??= new List<ModelsAnalyzeResultsDocumentElementsWord>();
            selectionMarks ??= new List<ModelsAnalyzeResultsDocumentElementsSelectionMark>();
            lines ??= new List<ModelsAnalyzeResultsDocumentElementsLine>();

            return new ModelsAnalyzeResultsDocumentElementsPage(pageNumber, angle, width, height, unit, spans?.ToList(), words?.ToList(), selectionMarks?.ToList(), lines?.ToList());
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsSpan. </summary>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsSpan"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsSpan ModelsAnalyzeResultsDocumentElementsSpan(int offset = default, int length = default)
        {
            return new ModelsAnalyzeResultsDocumentElementsSpan(offset, length);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsWord. </summary>
        /// <param name="content"></param>
        /// <param name="span"></param>
        /// <param name="boundingBox"></param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsWord"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsWord ModelsAnalyzeResultsDocumentElementsWord(string content = null, ModelsAnalyzeResultsDocumentElementsSpan span = null, IEnumerable<double> boundingBox = null, double confidence = default)
        {
            boundingBox ??= new List<double>();

            return new ModelsAnalyzeResultsDocumentElementsWord(content, span, boundingBox?.ToList(), confidence);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsSelectionMark. </summary>
        /// <param name="state"></param>
        /// <param name="span"></param>
        /// <param name="boundingBox"></param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsSelectionMark"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsSelectionMark ModelsAnalyzeResultsDocumentElementsSelectionMark(ModelsAnalyzeResultsDocumentElementsSelectionMarkState state = default, ModelsAnalyzeResultsDocumentElementsSpan span = null, IEnumerable<double> boundingBox = null, double confidence = default)
        {
            boundingBox ??= new List<double>();

            return new ModelsAnalyzeResultsDocumentElementsSelectionMark(state, span, boundingBox?.ToList(), confidence);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsLine. </summary>
        /// <param name="content"></param>
        /// <param name="boundingBox"></param>
        /// <param name="spans"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsLine"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsLine ModelsAnalyzeResultsDocumentElementsLine(string content = null, IEnumerable<double> boundingBox = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null)
        {
            boundingBox ??= new List<double>();
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsLine(content, boundingBox?.ToList(), spans?.ToList());
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsTable. </summary>
        /// <param name="rowCount"></param>
        /// <param name="columnCount"></param>
        /// <param name="cells"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsTable"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsTable ModelsAnalyzeResultsDocumentElementsTable(int rowCount = default, int columnCount = default, IEnumerable<ModelsAnalyzeResultsDocumentElementsTableCell> cells = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null)
        {
            cells ??= new List<ModelsAnalyzeResultsDocumentElementsTableCell>();
            boundingRegions ??= new List<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsTable(rowCount, columnCount, cells?.ToList(), boundingRegions?.ToList(), spans?.ToList());
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
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsTableCell"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsTableCell ModelsAnalyzeResultsDocumentElementsTableCell(ModelsAnalyzeResultsDocumentElementsTableCellKind? kind = null, int rowIndex = default, int columnIndex = default, int? rowSpan = null, int? columnSpan = null, string content = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null)
        {
            boundingRegions ??= new List<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsTableCell(kind, rowIndex, columnIndex, rowSpan, columnSpan, content, boundingRegions?.ToList(), spans?.ToList());
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsBoundingRegion. </summary>
        /// <param name="pageNumber"></param>
        /// <param name="boundingBox"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsBoundingRegion"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsBoundingRegion ModelsAnalyzeResultsDocumentElementsBoundingRegion(int pageNumber = default, IEnumerable<double> boundingBox = null)
        {
            boundingBox ??= new List<double>();

            return new ModelsAnalyzeResultsDocumentElementsBoundingRegion(pageNumber, boundingBox?.ToList());
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsKeyValuePair. </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsKeyValuePair"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsKeyValuePair ModelsAnalyzeResultsDocumentElementsKeyValuePair(ModelsAnalyzeResultsDocumentElementsKeyValueElement key = null, ModelsAnalyzeResultsDocumentElementsKeyValueElement value = null, double confidence = default)
        {
            return new ModelsAnalyzeResultsDocumentElementsKeyValuePair(key, value, confidence);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsKeyValueElement. </summary>
        /// <param name="content"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsKeyValueElement"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsKeyValueElement ModelsAnalyzeResultsDocumentElementsKeyValueElement(string content = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null)
        {
            boundingRegions ??= new List<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsKeyValueElement(content, boundingRegions?.ToList(), spans?.ToList());
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsEntity. </summary>
        /// <param name="category"></param>
        /// <param name="subCategory"></param>
        /// <param name="content"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsEntity"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsEntity ModelsAnalyzeResultsDocumentElementsEntity(string category = null, string subCategory = null, string content = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null, double confidence = default)
        {
            boundingRegions ??= new List<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsEntity(category, subCategory, content, boundingRegions?.ToList(), spans?.ToList(), confidence);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsStyle. </summary>
        /// <param name="isHandwritten"></param>
        /// <param name="spans"></param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsStyle"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsStyle ModelsAnalyzeResultsDocumentElementsStyle(bool? isHandwritten = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null, double confidence = default)
        {
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsStyle(isHandwritten, spans?.ToList(), confidence);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsLanguage. </summary>
        /// <param name="languageCode"></param>
        /// <param name="spans"></param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsLanguage"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsLanguage ModelsAnalyzeResultsDocumentElementsLanguage(string languageCode = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null, double confidence = default)
        {
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();

            return new ModelsAnalyzeResultsDocumentElementsLanguage(languageCode, spans?.ToList(), confidence);
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsDocument. </summary>
        /// <param name="docType"></param>
        /// <param name="boundingRegions"></param>
        /// <param name="spans"></param>
        /// <param name="fields"> Dictionary of &lt;components·1jq6pnz·schemas·models-analyzeresults-documentelements-document·properties·fields·additionalproperties&gt;. </param>
        /// <param name="confidence"></param>
        /// <returns> A new <see cref="Models.ModelsAnalyzeResultsDocumentElementsDocument"/> instance for mocking. </returns>
        public static ModelsAnalyzeResultsDocumentElementsDocument ModelsAnalyzeResultsDocumentElementsDocument(string docType = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsBoundingRegion> boundingRegions = null, IEnumerable<ModelsAnalyzeResultsDocumentElementsSpan> spans = null, IReadOnlyDictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties> fields = null, double confidence = default)
        {
            boundingRegions ??= new List<ModelsAnalyzeResultsDocumentElementsBoundingRegion>();
            spans ??= new List<ModelsAnalyzeResultsDocumentElementsSpan>();
            fields ??= new Dictionary<string, Components1Jq6PnzSchemasModelsAnalyzeresultsDocumentelementsDocumentPropertiesFieldsAdditionalproperties>();

            return new ModelsAnalyzeResultsDocumentElementsDocument(docType, boundingRegions?.ToList(), spans?.ToList(), fields, confidence);
        }

        /// <summary> Initializes a new instance of PageOperationsOperationInfo. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <returns> A new <see cref="Models.PageOperationsOperationInfo"/> instance for mocking. </returns>
        public static PageOperationsOperationInfo PageOperationsOperationInfo(IEnumerable<OperationsOperationInfo> value = null, string nextLink = null)
        {
            value ??= new List<OperationsOperationInfo>();

            return new PageOperationsOperationInfo(value?.ToList(), nextLink);
        }

        /// <summary> Initializes a new instance of OperationsOperationInfo. </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="percentCompleted"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="kind"></param>
        /// <param name="resourceLocation"></param>
        /// <param name="apiVersion"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <returns> A new <see cref="Models.OperationsOperationInfo"/> instance for mocking. </returns>
        public static OperationsOperationInfo OperationsOperationInfo(string operationId = null, OperationsOperationStatus status = default, int? percentCompleted = null, DateTimeOffset createdDateTime = default, DateTimeOffset lastUpdatedDateTime = default, OperationsOperationKind kind = default, string resourceLocation = null, string apiVersion = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new OperationsOperationInfo(operationId, status, percentCompleted, createdDateTime, lastUpdatedDateTime, kind, resourceLocation, apiVersion, tags);
        }

        /// <summary> Initializes a new instance of OperationsGetOperationResponse. </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="percentCompleted"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="lastUpdatedDateTime"></param>
        /// <param name="kind"></param>
        /// <param name="resourceLocation"></param>
        /// <param name="apiVersion"></param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="error"></param>
        /// <param name="result"></param>
        /// <returns> A new <see cref="Models.OperationsGetOperationResponse"/> instance for mocking. </returns>
        public static OperationsGetOperationResponse OperationsGetOperationResponse(string operationId = null, OperationsOperationStatus status = default, int? percentCompleted = null, DateTimeOffset createdDateTime = default, DateTimeOffset lastUpdatedDateTime = default, OperationsOperationKind kind = default, string resourceLocation = null, string apiVersion = null, IReadOnlyDictionary<string, string> tags = null, Error error = null, ModelsModelInfo result = null)
        {
            tags ??= new Dictionary<string, string>();

            return new OperationsGetOperationResponse(operationId, status, percentCompleted, createdDateTime, lastUpdatedDateTime, kind, resourceLocation, apiVersion, tags, error, result);
        }
    }
}