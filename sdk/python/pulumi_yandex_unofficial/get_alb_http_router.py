# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs

__all__ = [
    'GetAlbHttpRouterResult',
    'AwaitableGetAlbHttpRouterResult',
    'get_alb_http_router',
    'get_alb_http_router_output',
]

@pulumi.output_type
class GetAlbHttpRouterResult:
    """
    A collection of values returned by getAlbHttpRouter.
    """
    def __init__(__self__, created_at=None, description=None, folder_id=None, http_router_id=None, id=None, labels=None, name=None, route_options=None):
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if http_router_id and not isinstance(http_router_id, str):
            raise TypeError("Expected argument 'http_router_id' to be a str")
        pulumi.set(__self__, "http_router_id", http_router_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if route_options and not isinstance(route_options, list):
            raise TypeError("Expected argument 'route_options' to be a list")
        pulumi.set(__self__, "route_options", route_options)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        Creation timestamp of this HTTP Router.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the HTTP Router.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="httpRouterId")
    def http_router_id(self) -> str:
        return pulumi.get(self, "http_router_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        Labels to assign to this HTTP Router.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="routeOptions")
    def route_options(self) -> Sequence['outputs.GetAlbHttpRouterRouteOptionResult']:
        return pulumi.get(self, "route_options")


class AwaitableGetAlbHttpRouterResult(GetAlbHttpRouterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAlbHttpRouterResult(
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            http_router_id=self.http_router_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            route_options=self.route_options)


def get_alb_http_router(description: Optional[str] = None,
                        folder_id: Optional[str] = None,
                        http_router_id: Optional[str] = None,
                        name: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAlbHttpRouterResult:
    """
    Get information about a Yandex Application Load Balancer HTTP Router. For more information, see
    [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).

    ```python
    import pulumi
    import pulumi_yandex as yandex

    tf_router = yandex.get_alb_http_router(http_router_id="my-http-router-id")
    ```

    This data source is used to define [Application Load Balancer HTTP Router] that can be used by other resources.


    :param str description: Description of the HTTP Router.
    :param str folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
    :param str http_router_id: HTTP Router ID.
    :param str name: - Name of the HTTP Router.
    """
    __args__ = dict()
    __args__['description'] = description
    __args__['folderId'] = folder_id
    __args__['httpRouterId'] = http_router_id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getAlbHttpRouter:getAlbHttpRouter', __args__, opts=opts, typ=GetAlbHttpRouterResult).value

    return AwaitableGetAlbHttpRouterResult(
        created_at=__ret__.created_at,
        description=__ret__.description,
        folder_id=__ret__.folder_id,
        http_router_id=__ret__.http_router_id,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        route_options=__ret__.route_options)


@_utilities.lift_output_func(get_alb_http_router)
def get_alb_http_router_output(description: Optional[pulumi.Input[Optional[str]]] = None,
                               folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                               http_router_id: Optional[pulumi.Input[Optional[str]]] = None,
                               name: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAlbHttpRouterResult]:
    """
    Get information about a Yandex Application Load Balancer HTTP Router. For more information, see
    [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).

    ```python
    import pulumi
    import pulumi_yandex as yandex

    tf_router = yandex.get_alb_http_router(http_router_id="my-http-router-id")
    ```

    This data source is used to define [Application Load Balancer HTTP Router] that can be used by other resources.


    :param str description: Description of the HTTP Router.
    :param str folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
    :param str http_router_id: HTTP Router ID.
    :param str name: - Name of the HTTP Router.
    """
    ...
