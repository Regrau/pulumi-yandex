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
from ._inputs import *

__all__ = [
    'GetComputeInstanceResult',
    'AwaitableGetComputeInstanceResult',
    'get_compute_instance',
    'get_compute_instance_output',
]

@pulumi.output_type
class GetComputeInstanceResult:
    """
    A collection of values returned by getComputeInstance.
    """
    def __init__(__self__, boot_disks=None, created_at=None, description=None, filesystems=None, folder_id=None, fqdn=None, id=None, instance_id=None, labels=None, local_disks=None, metadata=None, metadata_options=None, name=None, network_acceleration_type=None, network_interfaces=None, placement_policy=None, platform_id=None, resources=None, scheduling_policies=None, secondary_disks=None, service_account_id=None, status=None, zone=None):
        if boot_disks and not isinstance(boot_disks, list):
            raise TypeError("Expected argument 'boot_disks' to be a list")
        pulumi.set(__self__, "boot_disks", boot_disks)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if filesystems and not isinstance(filesystems, list):
            raise TypeError("Expected argument 'filesystems' to be a list")
        pulumi.set(__self__, "filesystems", filesystems)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if fqdn and not isinstance(fqdn, str):
            raise TypeError("Expected argument 'fqdn' to be a str")
        pulumi.set(__self__, "fqdn", fqdn)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if local_disks and not isinstance(local_disks, list):
            raise TypeError("Expected argument 'local_disks' to be a list")
        pulumi.set(__self__, "local_disks", local_disks)
        if metadata and not isinstance(metadata, dict):
            raise TypeError("Expected argument 'metadata' to be a dict")
        pulumi.set(__self__, "metadata", metadata)
        if metadata_options and not isinstance(metadata_options, dict):
            raise TypeError("Expected argument 'metadata_options' to be a dict")
        pulumi.set(__self__, "metadata_options", metadata_options)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_acceleration_type and not isinstance(network_acceleration_type, str):
            raise TypeError("Expected argument 'network_acceleration_type' to be a str")
        pulumi.set(__self__, "network_acceleration_type", network_acceleration_type)
        if network_interfaces and not isinstance(network_interfaces, list):
            raise TypeError("Expected argument 'network_interfaces' to be a list")
        pulumi.set(__self__, "network_interfaces", network_interfaces)
        if placement_policy and not isinstance(placement_policy, dict):
            raise TypeError("Expected argument 'placement_policy' to be a dict")
        pulumi.set(__self__, "placement_policy", placement_policy)
        if platform_id and not isinstance(platform_id, str):
            raise TypeError("Expected argument 'platform_id' to be a str")
        pulumi.set(__self__, "platform_id", platform_id)
        if resources and not isinstance(resources, list):
            raise TypeError("Expected argument 'resources' to be a list")
        pulumi.set(__self__, "resources", resources)
        if scheduling_policies and not isinstance(scheduling_policies, list):
            raise TypeError("Expected argument 'scheduling_policies' to be a list")
        pulumi.set(__self__, "scheduling_policies", scheduling_policies)
        if secondary_disks and not isinstance(secondary_disks, list):
            raise TypeError("Expected argument 'secondary_disks' to be a list")
        pulumi.set(__self__, "secondary_disks", secondary_disks)
        if service_account_id and not isinstance(service_account_id, str):
            raise TypeError("Expected argument 'service_account_id' to be a str")
        pulumi.set(__self__, "service_account_id", service_account_id)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if zone and not isinstance(zone, str):
            raise TypeError("Expected argument 'zone' to be a str")
        pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="bootDisks")
    def boot_disks(self) -> Sequence['outputs.GetComputeInstanceBootDiskResult']:
        """
        The boot disk for the instance. Structure is documented below.
        """
        return pulumi.get(self, "boot_disks")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        Instance creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the boot disk.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def filesystems(self) -> Optional[Sequence['outputs.GetComputeInstanceFilesystemResult']]:
        return pulumi.get(self, "filesystems")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def fqdn(self) -> str:
        """
        DNS record FQDN.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        A set of key/value label pairs assigned to the instance.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="localDisks")
    def local_disks(self) -> Optional[Sequence['outputs.GetComputeInstanceLocalDiskResult']]:
        """
        List of local disks that are attached to the instance. Structure is documented below.
        """
        return pulumi.get(self, "local_disks")

    @property
    @pulumi.getter
    def metadata(self) -> Mapping[str, str]:
        """
        Metadata key/value pairs to make available from
        within the instance.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter(name="metadataOptions")
    def metadata_options(self) -> 'outputs.GetComputeInstanceMetadataOptionsResult':
        """
        Options allow user to configure access to instance's metadata
        """
        return pulumi.get(self, "metadata_options")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the boot disk.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkAccelerationType")
    def network_acceleration_type(self) -> str:
        """
        Type of network acceleration. The default is `standard`. Values: `standard`, `software_accelerated`
        """
        return pulumi.get(self, "network_acceleration_type")

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> Sequence['outputs.GetComputeInstanceNetworkInterfaceResult']:
        """
        The networks attached to the instance. Structure is documented below.
        * `network_interface.0.ip_address` - An internal IP address of the instance, either manually or dynamically assigned.
        * `network_interface.0.nat_ip_address` - An assigned external IP address if the instance has NAT enabled.
        """
        return pulumi.get(self, "network_interfaces")

    @property
    @pulumi.getter(name="placementPolicy")
    def placement_policy(self) -> Optional['outputs.GetComputeInstancePlacementPolicyResult']:
        """
        The placement policy configuration. The structure is documented below.
        """
        return pulumi.get(self, "placement_policy")

    @property
    @pulumi.getter(name="platformId")
    def platform_id(self) -> str:
        """
        Type of virtual machine to create. Default is 'standard-v1'.
        """
        return pulumi.get(self, "platform_id")

    @property
    @pulumi.getter
    def resources(self) -> Sequence['outputs.GetComputeInstanceResourceResult']:
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="schedulingPolicies")
    def scheduling_policies(self) -> Sequence['outputs.GetComputeInstanceSchedulingPolicyResult']:
        """
        Scheduling policy configuration. The structure is documented below.
        """
        return pulumi.get(self, "scheduling_policies")

    @property
    @pulumi.getter(name="secondaryDisks")
    def secondary_disks(self) -> Sequence['outputs.GetComputeInstanceSecondaryDiskResult']:
        """
        List of secondary disks attached to the instance. Structure is documented below.
        """
        return pulumi.get(self, "secondary_disks")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> str:
        """
        ID of the service account authorized for this instance.
        """
        return pulumi.get(self, "service_account_id")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the instance.
        * `resources.0.memory` - Memory size allocated for the instance.
        * `resources.0.cores` - Number of CPU cores allocated for the instance.
        * `resources.0.core_fraction` - Baseline performance for a core, set as a percent.
        * `resources.0.gpus` - Number of GPU cores allocated for the instance.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def zone(self) -> str:
        """
        Availability zone where the instance resides.
        """
        return pulumi.get(self, "zone")


class AwaitableGetComputeInstanceResult(GetComputeInstanceResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetComputeInstanceResult(
            boot_disks=self.boot_disks,
            created_at=self.created_at,
            description=self.description,
            filesystems=self.filesystems,
            folder_id=self.folder_id,
            fqdn=self.fqdn,
            id=self.id,
            instance_id=self.instance_id,
            labels=self.labels,
            local_disks=self.local_disks,
            metadata=self.metadata,
            metadata_options=self.metadata_options,
            name=self.name,
            network_acceleration_type=self.network_acceleration_type,
            network_interfaces=self.network_interfaces,
            placement_policy=self.placement_policy,
            platform_id=self.platform_id,
            resources=self.resources,
            scheduling_policies=self.scheduling_policies,
            secondary_disks=self.secondary_disks,
            service_account_id=self.service_account_id,
            status=self.status,
            zone=self.zone)


def get_compute_instance(filesystems: Optional[Sequence[pulumi.InputType['GetComputeInstanceFilesystemArgs']]] = None,
                         folder_id: Optional[str] = None,
                         instance_id: Optional[str] = None,
                         local_disks: Optional[Sequence[pulumi.InputType['GetComputeInstanceLocalDiskArgs']]] = None,
                         metadata_options: Optional[pulumi.InputType['GetComputeInstanceMetadataOptionsArgs']] = None,
                         name: Optional[str] = None,
                         placement_policy: Optional[pulumi.InputType['GetComputeInstancePlacementPolicyArgs']] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetComputeInstanceResult:
    """
    Get information about a Yandex Compute instance. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/compute/concepts/vm).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_instance = yandex.get_compute_instance(instance_id="some_instance_id")
    pulumi.export("instanceExternalIp", my_instance.network_interfaces[0].nat_ip_address)
    ```


    :param str folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
    :param str instance_id: The ID of a specific instance.
    :param Sequence[pulumi.InputType['GetComputeInstanceLocalDiskArgs']] local_disks: List of local disks that are attached to the instance. Structure is documented below.
    :param pulumi.InputType['GetComputeInstanceMetadataOptionsArgs'] metadata_options: Options allow user to configure access to instance's metadata
    :param str name: Name of the instance.
    :param pulumi.InputType['GetComputeInstancePlacementPolicyArgs'] placement_policy: The placement policy configuration. The structure is documented below.
    """
    __args__ = dict()
    __args__['filesystems'] = filesystems
    __args__['folderId'] = folder_id
    __args__['instanceId'] = instance_id
    __args__['localDisks'] = local_disks
    __args__['metadataOptions'] = metadata_options
    __args__['name'] = name
    __args__['placementPolicy'] = placement_policy
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getComputeInstance:getComputeInstance', __args__, opts=opts, typ=GetComputeInstanceResult).value

    return AwaitableGetComputeInstanceResult(
        boot_disks=__ret__.boot_disks,
        created_at=__ret__.created_at,
        description=__ret__.description,
        filesystems=__ret__.filesystems,
        folder_id=__ret__.folder_id,
        fqdn=__ret__.fqdn,
        id=__ret__.id,
        instance_id=__ret__.instance_id,
        labels=__ret__.labels,
        local_disks=__ret__.local_disks,
        metadata=__ret__.metadata,
        metadata_options=__ret__.metadata_options,
        name=__ret__.name,
        network_acceleration_type=__ret__.network_acceleration_type,
        network_interfaces=__ret__.network_interfaces,
        placement_policy=__ret__.placement_policy,
        platform_id=__ret__.platform_id,
        resources=__ret__.resources,
        scheduling_policies=__ret__.scheduling_policies,
        secondary_disks=__ret__.secondary_disks,
        service_account_id=__ret__.service_account_id,
        status=__ret__.status,
        zone=__ret__.zone)


@_utilities.lift_output_func(get_compute_instance)
def get_compute_instance_output(filesystems: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetComputeInstanceFilesystemArgs']]]]] = None,
                                folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                instance_id: Optional[pulumi.Input[Optional[str]]] = None,
                                local_disks: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetComputeInstanceLocalDiskArgs']]]]] = None,
                                metadata_options: Optional[pulumi.Input[Optional[pulumi.InputType['GetComputeInstanceMetadataOptionsArgs']]]] = None,
                                name: Optional[pulumi.Input[Optional[str]]] = None,
                                placement_policy: Optional[pulumi.Input[Optional[pulumi.InputType['GetComputeInstancePlacementPolicyArgs']]]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetComputeInstanceResult]:
    """
    Get information about a Yandex Compute instance. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/compute/concepts/vm).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_instance = yandex.get_compute_instance(instance_id="some_instance_id")
    pulumi.export("instanceExternalIp", my_instance.network_interfaces[0].nat_ip_address)
    ```


    :param str folder_id: Folder that the resource belongs to. If value is omitted, the default provider folder is used.
    :param str instance_id: The ID of a specific instance.
    :param Sequence[pulumi.InputType['GetComputeInstanceLocalDiskArgs']] local_disks: List of local disks that are attached to the instance. Structure is documented below.
    :param pulumi.InputType['GetComputeInstanceMetadataOptionsArgs'] metadata_options: Options allow user to configure access to instance's metadata
    :param str name: Name of the instance.
    :param pulumi.InputType['GetComputeInstancePlacementPolicyArgs'] placement_policy: The placement policy configuration. The structure is documented below.
    """
    ...
