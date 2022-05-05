/*
 * Copyright (c) Microsoft Corporation.
 * Licensed under the MIT License.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is regenerated.
 */

import {
  OperationParameter,
  OperationURLParameter,
  OperationQueryParameter
} from "@azure/core-client";
import {
  CopyAuthorizationRequest as CopyAuthorizationRequestMapper,
  BuildModelRequest as BuildModelRequestMapper,
  ComposeModelRequest as ComposeModelRequestMapper,
  CopyAuthorization as CopyAuthorizationMapper
} from "../models/mappers";

export const accept: OperationParameter = {
  parameterPath: "accept",
  mapper: {
    defaultValue: "application/json",
    isConstant: true,
    serializedName: "Accept",
    type: {
      name: "String"
    }
  }
};

export const $host: OperationURLParameter = {
  parameterPath: "$host",
  mapper: {
    serializedName: "$host",
    required: true,
    type: {
      name: "String"
    }
  },
  skipEncoding: true
};

export const apiVersion: OperationQueryParameter = {
  parameterPath: "apiVersion",
  mapper: {
    defaultValue: "2022-01-30-preview",
    isConstant: true,
    serializedName: "api-version",
    type: {
      name: "String"
    }
  }
};

export const contentType: OperationParameter = {
  parameterPath: ["options", "contentType"],
  mapper: {
    defaultValue: "application/json",
    isConstant: true,
    serializedName: "Content-Type",
    type: {
      name: "String"
    }
  }
};

export const body: OperationParameter = {
  parameterPath: ["options", "body"],
  mapper: CopyAuthorizationRequestMapper
};

export const body1: OperationParameter = {
  parameterPath: ["options", "body"],
  mapper: BuildModelRequestMapper
};

export const body2: OperationParameter = {
  parameterPath: ["options", "body"],
  mapper: ComposeModelRequestMapper
};

export const body3: OperationParameter = {
  parameterPath: ["options", "body"],
  mapper: CopyAuthorizationMapper
};

export const modelId: OperationURLParameter = {
  parameterPath: "modelId",
  mapper: {
    serializedName: "modelId",
    required: true,
    type: {
      name: "String"
    }
  }
};

export const contentType1: OperationParameter = {
  parameterPath: ["options", "contentType"],
  mapper: {
    defaultValue: "application/octet-stream",
    isConstant: true,
    serializedName: "Content-Type",
    type: {
      name: "String"
    }
  }
};

export const data: OperationParameter = {
  parameterPath: ["options", "data"],
  mapper: {
    serializedName: "data",
    type: {
      name: "Stream"
    }
  }
};

export const accept1: OperationParameter = {
  parameterPath: "accept",
  mapper: {
    defaultValue: "application/json",
    isConstant: true,
    serializedName: "Accept",
    type: {
      name: "String"
    }
  }
};

export const pages: OperationQueryParameter = {
  parameterPath: ["options", "pages"],
  mapper: {
    constraints: {
      Pattern: new RegExp("^(\\d+(-\\d+)?)(,\\s*(\\d+(-\\d+)?))*$")
    },
    serializedName: "pages",
    type: {
      name: "String"
    }
  }
};

export const locale: OperationQueryParameter = {
  parameterPath: ["options", "locale"],
  mapper: {
    serializedName: "locale",
    type: {
      name: "String"
    }
  }
};

export const stringIndexType: OperationQueryParameter = {
  parameterPath: ["options", "stringIndexType"],
  mapper: {
    serializedName: "stringIndexType",
    type: {
      name: "String"
    }
  }
};

export const resultId: OperationURLParameter = {
  parameterPath: "resultId",
  mapper: {
    serializedName: "resultId",
    required: true,
    type: {
      name: "String"
    }
  }
};

export const operationId: OperationURLParameter = {
  parameterPath: "operationId",
  mapper: {
    serializedName: "operationId",
    required: true,
    type: {
      name: "String"
    }
  }
};
