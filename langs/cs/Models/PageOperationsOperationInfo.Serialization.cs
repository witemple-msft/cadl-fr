// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    public partial class PageOperationsOperationInfo
    {
        internal static PageOperationsOperationInfo DeserializePageOperationsOperationInfo(JsonElement element)
        {
            IReadOnlyList<OperationsOperationInfo> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<OperationsOperationInfo> array = new List<OperationsOperationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationsOperationInfo.DeserializeOperationsOperationInfo(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PageOperationsOperationInfo(value, nextLink.Value);
        }
    }
}
