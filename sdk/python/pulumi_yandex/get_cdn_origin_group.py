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
    'GetCdnOriginGroupResult',
    'AwaitableGetCdnOriginGroupResult',
    'get_cdn_origin_group',
    'get_cdn_origin_group_output',
]

@pulumi.output_type
class GetCdnOriginGroupResult:
    """
    A collection of values returned by getCdnOriginGroup.
    """
    def __init__(__self__, folder_id=None, id=None, name=None, origin_group_id=None, origins=None, use_next=None):
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if origin_group_id and not isinstance(origin_group_id, int):
            raise TypeError("Expected argument 'origin_group_id' to be a int")
        pulumi.set(__self__, "origin_group_id", origin_group_id)
        if origins and not isinstance(origins, list):
            raise TypeError("Expected argument 'origins' to be a list")
        pulumi.set(__self__, "origins", origins)
        if use_next and not isinstance(use_next, bool):
            raise TypeError("Expected argument 'use_next' to be a bool")
        pulumi.set(__self__, "use_next", use_next)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="originGroupId")
    def origin_group_id(self) -> int:
        return pulumi.get(self, "origin_group_id")

    @property
    @pulumi.getter
    def origins(self) -> Sequence['outputs.GetCdnOriginGroupOriginResult']:
        return pulumi.get(self, "origins")

    @property
    @pulumi.getter(name="useNext")
    def use_next(self) -> bool:
        return pulumi.get(self, "use_next")


class AwaitableGetCdnOriginGroupResult(GetCdnOriginGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCdnOriginGroupResult(
            folder_id=self.folder_id,
            id=self.id,
            name=self.name,
            origin_group_id=self.origin_group_id,
            origins=self.origins,
            use_next=self.use_next)


def get_cdn_origin_group(folder_id: Optional[str] = None,
                         name: Optional[str] = None,
                         origin_group_id: Optional[int] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetCdnOriginGroupResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['folderId'] = folder_id
    __args__['name'] = name
    __args__['originGroupId'] = origin_group_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getCdnOriginGroup:getCdnOriginGroup', __args__, opts=opts, typ=GetCdnOriginGroupResult).value

    return AwaitableGetCdnOriginGroupResult(
        folder_id=__ret__.folder_id,
        id=__ret__.id,
        name=__ret__.name,
        origin_group_id=__ret__.origin_group_id,
        origins=__ret__.origins,
        use_next=__ret__.use_next)


@_utilities.lift_output_func(get_cdn_origin_group)
def get_cdn_origin_group_output(folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                name: Optional[pulumi.Input[Optional[str]]] = None,
                                origin_group_id: Optional[pulumi.Input[Optional[int]]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetCdnOriginGroupResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
