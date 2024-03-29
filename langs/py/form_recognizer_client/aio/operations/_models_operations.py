# pylint: disable=too-many-lines
# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# --------------------------------------------------------------------------
from typing import Any, Callable, Dict, Optional, TypeVar, Union

from azure.core.exceptions import ClientAuthenticationError, HttpResponseError, ResourceExistsError, ResourceNotFoundError, map_error
from azure.core.pipeline import PipelineResponse
from azure.core.pipeline.transport import AsyncHttpResponse
from azure.core.rest import HttpRequest
from azure.core.tracing.decorator_async import distributed_trace_async

from ... import models as _models
from ..._vendor import _convert_request
from ...operations._models_operations import build_analyze_request, build_copy_model_to_request, build_get_page_request
T = TypeVar('T')
ClsType = Optional[Callable[[PipelineResponse[HttpRequest, AsyncHttpResponse], T, Dict[str, Any]], Any]]

class ModelsOperations:
    """
    .. warning::
        **DO NOT** instantiate this class directly.

        Instead, you should access the following operations through
        :class:`~form_recognizer_client.aio.FormRecognizerClient`'s
        :attr:`models` attribute.
    """

    models = _models

    def __init__(self, *args, **kwargs) -> None:
        args = list(args)
        self._client = args.pop(0) if args else kwargs.pop("client")
        self._config = args.pop(0) if args else kwargs.pop("config")
        self._serialize = args.pop(0) if args else kwargs.pop("serializer")
        self._deserialize = args.pop(0) if args else kwargs.pop("deserializer")


    @distributed_trace_async
    async def get_page(
        self,
        **kwargs: Any
    ) -> "_models.PageModelsModelSummary":
        """get_page.

        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: PageModelsModelSummary, or the result of cls(response)
        :rtype: ~form_recognizer_client.models.PageModelsModelSummary
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType["_models.PageModelsModelSummary"]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))

        api_version = kwargs.pop('api_version', "2022-01-30-preview")  # type: str

        
        request = build_get_page_request(
            api_version=api_version,
            template_url=self.get_page.metadata['url'],
        )
        request = _convert_request(request)
        request.url = self._client.format_url(request.url)

        pipeline_response = await self._client._pipeline.run(  # pylint: disable=protected-access
            request,
            stream=False,
            **kwargs
        )
        response = pipeline_response.http_response

        if response.status_code not in [200]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            raise HttpResponseError(response=response)

        deserialized = self._deserialize('PageModelsModelSummary', pipeline_response)

        if cls:
            return cls(pipeline_response, deserialized, {})

        return deserialized

    get_page.metadata = {'url': "/formrecognizer/documentModels"}  # type: ignore


    @distributed_trace_async
    async def copy_model_to(  # pylint: disable=inconsistent-return-statements
        self,
        model_id: str,
        body: Optional["_models.CopyAuthorization"] = None,
        **kwargs: Any
    ) -> None:
        """copy_model_to.

        :param model_id:
        :type model_id: str
        :param body:  Default value is None.
        :type body: ~form_recognizer_client.models.CopyAuthorization
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: None, or the result of cls(response)
        :rtype: None
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[None]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))

        api_version = kwargs.pop('api_version', "2022-01-30-preview")  # type: str
        content_type = kwargs.pop('content_type', "application/json")  # type: Optional[str]

        if body is not None:
            _json = self._serialize.body(body, 'CopyAuthorization')
        else:
            _json = None

        request = build_copy_model_to_request(
            model_id=model_id,
            api_version=api_version,
            content_type=content_type,
            json=_json,
            template_url=self.copy_model_to.metadata['url'],
        )
        request = _convert_request(request)
        request.url = self._client.format_url(request.url)

        pipeline_response = await self._client._pipeline.run(  # pylint: disable=protected-access
            request,
            stream=False,
            **kwargs
        )
        response = pipeline_response.http_response

        if response.status_code not in [202]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            raise HttpResponseError(response=response)

        response_headers = {}
        response_headers['Operation-Location']=self._deserialize('str', response.headers.get('Operation-Location'))


        if cls:
            return cls(pipeline_response, None, response_headers)

    copy_model_to.metadata = {'url': "/formrecognizer/documentModels/{modelId}:copyTo"}  # type: ignore


    @distributed_trace_async
    async def analyze(  # pylint: disable=inconsistent-return-statements
        self,
        model_id: str,
        pages: Optional[str] = None,
        locale: Optional[str] = None,
        string_index_type: Optional[Union[str, "_models.Enum1"]] = None,
        body: Optional["_models.ModelsAnalyzeRequest"] = None,
        **kwargs: Any
    ) -> None:
        """analyze.

        :param model_id:
        :type model_id: str
        :param pages:  Default value is None.
        :type pages: str
        :param locale:  Default value is None.
        :type locale: str
        :param string_index_type:  Default value is None.
        :type string_index_type: str or ~form_recognizer_client.models.Enum1
        :param body:  Default value is None.
        :type body: ~form_recognizer_client.models.ModelsAnalyzeRequest
        :keyword callable cls: A custom type or function that will be passed the direct response
        :return: None, or the result of cls(response)
        :rtype: None
        :raises: ~azure.core.exceptions.HttpResponseError
        """
        cls = kwargs.pop('cls', None)  # type: ClsType[None]
        error_map = {
            401: ClientAuthenticationError, 404: ResourceNotFoundError, 409: ResourceExistsError
        }
        error_map.update(kwargs.pop('error_map', {}))

        api_version = kwargs.pop('api_version', "2022-01-30-preview")  # type: str
        content_type = kwargs.pop('content_type', "application/json")  # type: Optional[str]

        if body is not None:
            _json = self._serialize.body(body, 'ModelsAnalyzeRequest')
        else:
            _json = None

        request = build_analyze_request(
            model_id=model_id,
            api_version=api_version,
            content_type=content_type,
            json=_json,
            pages=pages,
            locale=locale,
            string_index_type=string_index_type,
            template_url=self.analyze.metadata['url'],
        )
        request = _convert_request(request)
        request.url = self._client.format_url(request.url)

        pipeline_response = await self._client._pipeline.run(  # pylint: disable=protected-access
            request,
            stream=False,
            **kwargs
        )
        response = pipeline_response.http_response

        if response.status_code not in [202]:
            map_error(status_code=response.status_code, response=response, error_map=error_map)
            raise HttpResponseError(response=response)

        response_headers = {}
        response_headers['Operation-Location']=self._deserialize('str', response.headers.get('Operation-Location'))


        if cls:
            return cls(pipeline_response, None, response_headers)

    analyze.metadata = {'url': "/formrecognizer/documentModels/{modelId}:analyze"}  # type: ignore

