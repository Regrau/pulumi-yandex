# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetComputeFilesystemResult',
    'AwaitableGetComputeFilesystemResult',
    'get_compute_filesystem',
    'get_compute_filesystem_output',
]

@pulumi.output_type
class GetComputeFilesystemResult:
    """
    A collection of values returned by getComputeFilesystem.
    """
    def __init__(__self__, block_size=None, created_at=None, description=None, filesystem_id=None, folder_id=None, id=None, labels=None, name=None, size=None, status=None, type=None, zone=None):
        if block_size and not isinstance(block_size, int):
            raise TypeError("Expected argument 'block_size' to be a int")
        pulumi.set(__self__, "block_size", block_size)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if filesystem_id and not isinstance(filesystem_id, str):
            raise TypeError("Expected argument 'filesystem_id' to be a str")
        pulumi.set(__self__, "filesystem_id", filesystem_id)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if size and not isinstance(size, int):
            raise TypeError("Expected argument 'size' to be a int")
        pulumi.set(__self__, "size", size)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if zone and not isinstance(zone, str):
            raise TypeError("Expected argument 'zone' to be a str")
        pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="blockSize")
    def block_size(self) -> int:
        return pulumi.get(self, "block_size")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="filesystemId")
    def filesystem_id(self) -> str:
        return pulumi.get(self, "filesystem_id")

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
    def labels(self) -> Mapping[str, str]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def size(self) -> int:
        return pulumi.get(self, "size")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def zone(self) -> str:
        return pulumi.get(self, "zone")


class AwaitableGetComputeFilesystemResult(GetComputeFilesystemResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetComputeFilesystemResult(
            block_size=self.block_size,
            created_at=self.created_at,
            description=self.description,
            filesystem_id=self.filesystem_id,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            size=self.size,
            status=self.status,
            type=self.type,
            zone=self.zone)


def get_compute_filesystem(filesystem_id: Optional[str] = None,
                           folder_id: Optional[str] = None,
                           name: Optional[str] = None,
                           opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetComputeFilesystemResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['filesystemId'] = filesystem_id
    __args__['folderId'] = folder_id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getComputeFilesystem:getComputeFilesystem', __args__, opts=opts, typ=GetComputeFilesystemResult).value

    return AwaitableGetComputeFilesystemResult(
        block_size=__ret__.block_size,
        created_at=__ret__.created_at,
        description=__ret__.description,
        filesystem_id=__ret__.filesystem_id,
        folder_id=__ret__.folder_id,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        size=__ret__.size,
        status=__ret__.status,
        type=__ret__.type,
        zone=__ret__.zone)


@_utilities.lift_output_func(get_compute_filesystem)
def get_compute_filesystem_output(filesystem_id: Optional[pulumi.Input[Optional[str]]] = None,
                                  folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                  name: Optional[pulumi.Input[Optional[str]]] = None,
                                  opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetComputeFilesystemResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
