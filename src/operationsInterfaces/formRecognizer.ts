/*
 * Copyright (c) Microsoft Corporation.
 * Licensed under the MIT License.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is regenerated.
 */

import {
  FormRecognizerGetInfoOptionalParams,
  FormRecognizerGetInfoResponse,
  FormRecognizerGetCopyAuthorizationOptionalParams,
  FormRecognizerGetCopyAuthorizationResponse,
  FormRecognizerBuildModelOptionalParams,
  FormRecognizerBuildModelResponse,
  FormRecognizerComposeModelOptionalParams,
  FormRecognizerComposeModelResponse
} from "../models";

/** Interface representing a FormRecognizer. */
export interface FormRecognizer {
  /** @param options The options parameters. */
  getInfo(
    options?: FormRecognizerGetInfoOptionalParams
  ): Promise<FormRecognizerGetInfoResponse>;
  /** @param options The options parameters. */
  getCopyAuthorization(
    options?: FormRecognizerGetCopyAuthorizationOptionalParams
  ): Promise<FormRecognizerGetCopyAuthorizationResponse>;
  /** @param options The options parameters. */
  buildModel(
    options?: FormRecognizerBuildModelOptionalParams
  ): Promise<FormRecognizerBuildModelResponse>;
  /** @param options The options parameters. */
  composeModel(
    options?: FormRecognizerComposeModelOptionalParams
  ): Promise<FormRecognizerComposeModelResponse>;
}