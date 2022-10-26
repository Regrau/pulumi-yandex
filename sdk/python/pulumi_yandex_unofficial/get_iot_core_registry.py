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
    'GetIotCoreRegistryResult',
    'AwaitableGetIotCoreRegistryResult',
    'get_iot_core_registry',
    'get_iot_core_registry_output',
]

@pulumi.output_type
class GetIotCoreRegistryResult:
    """
    A collection of values returned by getIotCoreRegistry.
    """
    def __init__(__self__, certificates=None, created_at=None, description=None, folder_id=None, id=None, labels=None, name=None, passwords=None, registry_id=None):
        if certificates and not isinstance(certificates, list):
            raise TypeError("Expected argument 'certificates' to be a list")
        pulumi.set(__self__, "certificates", certificates)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
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
        if passwords and not isinstance(passwords, list):
            raise TypeError("Expected argument 'passwords' to be a list")
        pulumi.set(__self__, "passwords", passwords)
        if registry_id and not isinstance(registry_id, str):
            raise TypeError("Expected argument 'registry_id' to be a str")
        pulumi.set(__self__, "registry_id", registry_id)

    @property
    @pulumi.getter
    def certificates(self) -> Sequence[str]:
        """
        A set of certificate's fingerprints for the IoT Core Registry
        """
        return pulumi.get(self, "certificates")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        Creation timestamp of the IoT Core Registry
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the IoT Core Registry
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[str]:
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
        """
        A set of key/value label pairs to assign to the IoT Core Registry.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def passwords(self) -> Sequence[str]:
        """
        A set of passwords's id for the IoT Core Registry
        """
        return pulumi.get(self, "passwords")

    @property
    @pulumi.getter(name="registryId")
    def registry_id(self) -> Optional[str]:
        return pulumi.get(self, "registry_id")


class AwaitableGetIotCoreRegistryResult(GetIotCoreRegistryResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetIotCoreRegistryResult(
            certificates=self.certificates,
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            name=self.name,
            passwords=self.passwords,
            registry_id=self.registry_id)


def get_iot_core_registry(folder_id: Optional[str] = None,
                          name: Optional[str] = None,
                          registry_id: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetIotCoreRegistryResult:
    """
    Get information about a Yandex IoT Core Registry. For more information IoT Core, see
    [Yandex.Cloud IoT Registry](https://cloud.yandex.com/docs/iot-core/quickstart).

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_registry = yandex.get_iot_core_registry(registry_id="are1sampleregistry11")
    ```

    This data source is used to define [Yandex.Cloud IoT Registry](https://cloud.yandex.com/docs/iot-core/quickstart) that can be used by other resources.


    :param str folder_id: Folder ID for the IoT Core Registry
    :param str name: IoT Core Registry name used to define registry
    :param str registry_id: IoT Core Registry id used to define registry
    """
    __args__ = dict()
    __args__['folderId'] = folder_id
    __args__['name'] = name
    __args__['registryId'] = registry_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getIotCoreRegistry:getIotCoreRegistry', __args__, opts=opts, typ=GetIotCoreRegistryResult).value

    return AwaitableGetIotCoreRegistryResult(
        certificates=__ret__.certificates,
        created_at=__ret__.created_at,
        description=__ret__.description,
        folder_id=__ret__.folder_id,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        passwords=__ret__.passwords,
        registry_id=__ret__.registry_id)


@_utilities.lift_output_func(get_iot_core_registry)
def get_iot_core_registry_output(folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                 name: Optional[pulumi.Input[Optional[str]]] = None,
                                 registry_id: Optional[pulumi.Input[Optional[str]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetIotCoreRegistryResult]:
    """
    Get information about a Yandex IoT Core Registry. For more information IoT Core, see
    [Yandex.Cloud IoT Registry](https://cloud.yandex.com/docs/iot-core/quickstart).

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_registry = yandex.get_iot_core_registry(registry_id="are1sampleregistry11")
    ```

    This data source is used to define [Yandex.Cloud IoT Registry](https://cloud.yandex.com/docs/iot-core/quickstart) that can be used by other resources.


    :param str folder_id: Folder ID for the IoT Core Registry
    :param str name: IoT Core Registry name used to define registry
    :param str registry_id: IoT Core Registry id used to define registry
    """
    ...
