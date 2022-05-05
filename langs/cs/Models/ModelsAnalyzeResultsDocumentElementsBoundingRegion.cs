// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace FormRecognizerClient.Models
{
    /// <summary> The ModelsAnalyzeResultsDocumentElementsBoundingRegion. </summary>
    public partial class ModelsAnalyzeResultsDocumentElementsBoundingRegion
    {
        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsBoundingRegion. </summary>
        /// <param name="pageNumber"></param>
        /// <param name="boundingBox"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="boundingBox"/> is null. </exception>
        internal ModelsAnalyzeResultsDocumentElementsBoundingRegion(int pageNumber, IEnumerable<double> boundingBox)
        {
            if (boundingBox == null)
            {
                throw new ArgumentNullException(nameof(boundingBox));
            }

            PageNumber = pageNumber;
            BoundingBox = boundingBox.ToList();
        }

        /// <summary> Initializes a new instance of ModelsAnalyzeResultsDocumentElementsBoundingRegion. </summary>
        /// <param name="pageNumber"></param>
        /// <param name="boundingBox"></param>
        internal ModelsAnalyzeResultsDocumentElementsBoundingRegion(int pageNumber, IReadOnlyList<double> boundingBox)
        {
            PageNumber = pageNumber;
            BoundingBox = boundingBox;
        }

        /// <summary> Gets the page number. </summary>
        public int PageNumber { get; }
        /// <summary> Gets the bounding box. </summary>
        public IReadOnlyList<double> BoundingBox { get; }
    }
}
