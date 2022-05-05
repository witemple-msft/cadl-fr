// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace FormRecognizerClient.Models
{
    /// <summary> The Error. </summary>
    public partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal Error(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<Error>();
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="target"></param>
        /// <param name="details"></param>
        /// <param name="innererror"></param>
        internal Error(string code, string message, string target, IReadOnlyList<Error> details, Error innererror)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
        }

        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the target. </summary>
        public string Target { get; }
        /// <summary> Gets the details. </summary>
        public IReadOnlyList<Error> Details { get; }
        /// <summary> Gets the innererror. </summary>
        public Error Innererror { get; }
    }
}
