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
    'GetComputeDiskPlacementGroupResult',
    'AwaitableGetComputeDiskPlacementGroupResult',
    'get_compute_disk_placement_group',
    'get_compute_disk_placement_group_output',
]

@pulumi.output_type
class GetComputeDiskPlacementGroupResult:
    """
    A collection of values returned by getComputeDiskPlacementGroup.
    """
    def __init__(__self__, created_at=None, description=None, folder_id=None, group_id=None, id=None, labels=None, name=None, status=None, zone=None):
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if group_id and not isinstance(group_id, str):
            raise TypeError("Expected argument 'group_id' to be a str")
        pulumi.set(__self__, "group_id", group_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if zone and not isinstance(zone, str):
            raise TypeError("Expected argument 'zone' to be a str")
        pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        The creation timestamp of the Disk Placement Group.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Description of the Disk Placement Group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> str:
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def labels(self) -> Optional[Mapping[str, str]]:
        """
        A set of key/value label pairs assigned to the Disk Placement Group.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the Disk Placement Group.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def zone(self) -> Optional[str]:
        """
        ID of the zone where the Disk Placement Group resides.
        """
        return pulumi.get(self, "zone")


class AwaitableGetComputeDiskPlacementGroupResult(GetComputeDiskPlacementGroupResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetComputeDiskPlacementGroupResult(
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            group_id=self.group_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            status=self.status,
            zone=self.zone)


def get_compute_disk_placement_group(description: Optional[str] = None,
                                     folder_id: Optional[str] = None,
                                     group_id: Optional[str] = None,
                                     labels: Optional[Mapping[str, str]] = None,
                                     name: Optional[str] = None,
                                     zone: Optional[str] = None,
                                     opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetComputeDiskPlacementGroupResult:
    """
    Get information about a Yandex Compute Disk Placement group. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/compute/concepts/disk#nr-disks).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_group = yandex.get_compute_disk_placement_group(group_id="some_group_id")
    pulumi.export("placementGroupName", my_group.name)
    ```


    :param str description: Description of the Disk Placement Group.
    :param str folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
    :param str group_id: The ID of a specific group.
    :param Mapping[str, str] labels: A set of key/value label pairs assigned to the Disk Placement Group.
    :param str name: Name of the group.
    :param str zone: ID of the zone where the Disk Placement Group resides.
    """
    __args__ = dict()
    __args__['description'] = description
    __args__['folderId'] = folder_id
    __args__['groupId'] = group_id
    __args__['labels'] = labels
    __args__['name'] = name
    __args__['zone'] = zone
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getComputeDiskPlacementGroup:getComputeDiskPlacementGroup', __args__, opts=opts, typ=GetComputeDiskPlacementGroupResult).value

    return AwaitableGetComputeDiskPlacementGroupResult(
        created_at=__ret__.created_at,
        description=__ret__.description,
        folder_id=__ret__.folder_id,
        group_id=__ret__.group_id,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        status=__ret__.status,
        zone=__ret__.zone)


@_utilities.lift_output_func(get_compute_disk_placement_group)
def get_compute_disk_placement_group_output(description: Optional[pulumi.Input[Optional[str]]] = None,
                                            folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                            group_id: Optional[pulumi.Input[Optional[str]]] = None,
                                            labels: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                                            name: Optional[pulumi.Input[Optional[str]]] = None,
                                            zone: Optional[pulumi.Input[Optional[str]]] = None,
                                            opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetComputeDiskPlacementGroupResult]:
    """
    Get information about a Yandex Compute Disk Placement group. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/compute/concepts/disk#nr-disks).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_group = yandex.get_compute_disk_placement_group(group_id="some_group_id")
    pulumi.export("placementGroupName", my_group.name)
    ```


    :param str description: Description of the Disk Placement Group.
    :param str folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
    :param str group_id: The ID of a specific group.
    :param Mapping[str, str] labels: A set of key/value label pairs assigned to the Disk Placement Group.
    :param str name: Name of the group.
    :param str zone: ID of the zone where the Disk Placement Group resides.
    """
    ...
