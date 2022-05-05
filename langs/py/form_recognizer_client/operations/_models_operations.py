# pylint: disable=too-many-lines
# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for license information.
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is regenerated.
# --------------------------------------------------------------------------
from typing import TYPE_CHECKING

from msrest import Serializer

from azure.core.exceptions import ClientAuthenticationError, HttpResponseError, ResourceExistsError, ResourceNotFoundError, map_error
from azure.core.pipeline import PipelineResponse
from azure.core.pipeline.transport import HttpResponse
from azure.core.rest import HttpRequest
from azure.core.tracing.decorator import distributed_trace

from .. import models as _models
from .._vendor import _convert_request, _format_url_section

if TYPE_CHECKING:
    # pylint: disable=unused-import,ungrouped-imports
    from typing import Any, Callable, Dict, Optional, TypeVar, Union
    T = TypeVar('T')
    ClsType = Optional[Callable[[PipelineResponse[HttpRequest, HttpResponse], T, Dict[str, Any]], Any]]

_SERIALIZER = Serializer()
_SERIALIZER.client_side_validation = False
# fmt: off

def build_get_page_request(
    **kwargs  # type: Any
):
    # type: (...) -> HttpRequest
    api_version = kwargs.pop('api_version', "2022-01-30-preview")  # type: str

    accept = "application/json"
    # Construct URL
    _url = kwargs.pop("template_url", "/formrecognizer/documentModels")

    # Construct parameters
    _query_parameters = kwargs.pop("params", {})  # type: Dict[str, Any]
    _query_parameters['api-version'] = _SERIALIZER.query("api_version", api_version, 'str')

    # Construct headers
    _header_parameters = kwargs.pop("headers", {})  # type: Dict[str, Any]
    _header_parameters['Accept'] = _SERIALIZER.header("accept", accept, 'str')

    return HttpRequest(
        method="GET",
        url=_url,
        params=_query_parameters,
        headers=_header_parameters,
        **kwargs
    )


def build_copy_model_to_request(
    model_id,  # type: str
    **kwargs  # type: Any
):
    # type: (...) -> HttpRequest
    api_version = kwargs.pop('api_version', "2022-01-30-preview")  # type: str
    content_type = kwargs.pop('content_type', None)  # type: Optional[str]

    # Construct URL
    _url = kwargs.pop("template_url", "/formrecognizer/documentModels/{modelId}:copyTo")
    path_format_arguments = {
        "modelId": _SERIALIZER.url("model_id", model_id, 'str'),
    }

    _url = _format_url_section(_url, **path_format_arguments)

    # Construct parameters
    _query_parameters = kwargs.pop("params", {})  # type: Dict[str, Any]
    _query_parameters['api-version'] = _SERIALIZER.query("api_version", api_version, 'str')

    # Construct headers
    _header_parameters = kwargs.pop("headers", {})  # type: Dict[str, Any]
    if content_type is not None:
        _header_parameters['Content-Type'] = _SERIALIZER.header("content_type", content_type, 'str')

    return HttpRequest(
        method="POST",
        url=_url,
        params=_query_parameters,
        headers=_header_parameters,
        **kwargs
    )


def build_analyze_request(
    model_id,  # type: str
    **kwargs  # type: Any
):
    # type: (...) -> HttpRequest
    api_version = kwargs.pop('api_version', "2022-01-30-preview")  # type: str
    content_type = kwargs.pop('content_type', None)  # type: Optional[str]
    pages = kwargs.pop('pages', None)  # type: Optional[str]
    locale = kwargs.pop('locale', None)  # type: Optional[str]
    string_index_type = kwargs.pop('string_index_type', None)  # type: Optional[Union[str, "_models.Enum1"]]

    # Construct URL
    _url = kwargs.pop("template_url", "/formrecognizer/documentModels/{modelId}:analyze")
    path_format_arguments = {
        "modelId": _SERIALIZER.url("model_id", model_id, 'str'),
    }

    _url = _format_url_section(_url, **path_format_arguments)

    # Construct parameters
    _query_parameters = kwargs.pop("params", {})  # type: Dict[str, Any]
    if pages is not None:
        _query_parameters['pages'] = _SERIALIZER.query("pages", pages, 'str')
    if locale is not None:
        _query_parameters['locale'] = _SERIALIZER.query("locale", locale, 'str')
    if string_index_type is not None:
        _query_parameters['stringIndexType'] = _SERIALIZER.query("string_index_type", string_index_type, 'str')
    _query_parameters['api-version'] = _SERIALIZER.query("api_version", api_version, 'str')

    # Construct headers
    _header_parameters = kwargs.pop("headers", {})  # type: Dict[str, Any]
    if content_type is not None:
        _header_parameters['Content-Type'] = _SERIALIZER.header("content_type", content_type, 'str')

    return HttpRequest(
        method="POST",
        url=_url,
        params=_query_parameters,
        headers=_header_parameters,
        **kwargs
    )

# fmt: on
class ModelsOperations(object):
    """
    .. warning::
        **DO NOT** instantiate this class directly.

        Instead, you should access the following operations through
        :class:`~form_recognizer_client.FormRecognizerClient`'s
        :attr:`models` attribute.
    """

    models = _models

    def __init__(self, *args, **kwargs):
        args = list(args)
        self._client = args.pop(0) if args else kwargs.pop("client")
        self._config = args.pop(0) if args else kwargs.pop("config")
        self._serialize = args.pop(0) if args else kwargs.pop("serializer")
        self._deserialize = args.pop(0) if args else kwargs.pop("deserializer")


    @distributed_trace
    def get_page(
        self,
        **kwargs  # type: Any
    ):
        # type: (...) -> "_models.PageModelsModelSummary"
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

        pipeline_response = self._client._pipeline.run(  # pylint: disable=protected-access
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


    @distributed_trace
    def copy_model_to(  # pylint: disable=inconsistent-return-statements
        self,
        model_id,  # type: str
        body=None,  # type: Optional["_models.CopyAuthorization"]
        **kwargs  # type: Any
    ):
        # type: (...) -> None
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

        pipeline_response = self._client._pipeline.run(  # pylint: disable=protected-access
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


    @distributed_trace
    def analyze(  # pylint: disable=inconsistent-return-statements
        self,
        model_id,  # type: str
        pages=None,  # type: Optional[str]
        locale=None,  # type: Optional[str]
        string_index_type=None,  # type: Optional[Union[str, "_models.Enum1"]]
        body=None,  # type: Optional["_models.ModelsAnalyzeRequest"]
        **kwargs  # type: Any
    ):
        # type: (...) -> None
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

        pipeline_response = self._client._pipeline.run(  # pylint: disable=protected-access
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

