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
    'GetLockBoxSecretResult',
    'AwaitableGetLockBoxSecretResult',
    'get_lock_box_secret',
    'get_lock_box_secret_output',
]

@pulumi.output_type
class GetLockBoxSecretResult:
    """
    A collection of values returned by getLockBoxSecret.
    """
    def __init__(__self__, created_at=None, current_versions=None, deletion_protection=None, description=None, folder_id=None, id=None, kms_key_id=None, labels=None, name=None, secret_id=None, status=None):
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if current_versions and not isinstance(current_versions, list):
            raise TypeError("Expected argument 'current_versions' to be a list")
        pulumi.set(__self__, "current_versions", current_versions)
        if deletion_protection and not isinstance(deletion_protection, bool):
            raise TypeError("Expected argument 'deletion_protection' to be a bool")
        pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if kms_key_id and not isinstance(kms_key_id, str):
            raise TypeError("Expected argument 'kms_key_id' to be a str")
        pulumi.set(__self__, "kms_key_id", kms_key_id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if secret_id and not isinstance(secret_id, str):
            raise TypeError("Expected argument 'secret_id' to be a str")
        pulumi.set(__self__, "secret_id", secret_id)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        The version creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="currentVersions")
    def current_versions(self) -> Sequence['outputs.GetLockBoxSecretCurrentVersionResult']:
        """
        Information about the current version of the Yandex Cloud Lockbox secret.
        """
        return pulumi.get(self, "current_versions")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> bool:
        """
        Whether the Yandex Cloud Lockbox secret is protected from deletion.
        """
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        The version description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        """
        ID of the folder that the Yandex Cloud Lockbox secret belongs to.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="kmsKeyId")
    def kms_key_id(self) -> str:
        """
        The KMS key used to encrypt the Yandex Cloud Lockbox secret (if an explicit key was used).
        """
        return pulumi.get(self, "kms_key_id")

    @property
    @pulumi.getter
    def labels(self) -> Mapping[str, str]:
        """
        A set of key/value label pairs assigned to the Yandex Cloud Lockbox secret.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        The Yandex Cloud Lockbox secret name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> Optional[str]:
        """
        The secret ID the version belongs to (it's the same as the `secret_id` argument indicated above)
        """
        return pulumi.get(self, "secret_id")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The version status.
        """
        return pulumi.get(self, "status")


class AwaitableGetLockBoxSecretResult(GetLockBoxSecretResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetLockBoxSecretResult(
            created_at=self.created_at,
            current_versions=self.current_versions,
            deletion_protection=self.deletion_protection,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            kms_key_id=self.kms_key_id,
            labels=self.labels,
            name=self.name,
            secret_id=self.secret_id,
            status=self.status)


def get_lock_box_secret(folder_id: Optional[str] = None,
                        name: Optional[str] = None,
                        secret_id: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetLockBoxSecretResult:
    """
    Get information about Yandex Cloud Lockbox secret. For more information,
    see [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_secret = yandex.get_lock_box_secret(secret_id="some ID")
    pulumi.export("mySecretCreatedAt", my_secret.created_at)
    ```


    :param str folder_id: Folder that the secret belongs to. If value is omitted, the default provider folder is used.
    :param str name: Name of the Lockbox secret.
    :param str secret_id: The Yandex Cloud Lockbox secret ID.
    """
    __args__ = dict()
    __args__['folderId'] = folder_id
    __args__['name'] = name
    __args__['secretId'] = secret_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getLockBoxSecret:getLockBoxSecret', __args__, opts=opts, typ=GetLockBoxSecretResult).value

    return AwaitableGetLockBoxSecretResult(
        created_at=__ret__.created_at,
        current_versions=__ret__.current_versions,
        deletion_protection=__ret__.deletion_protection,
        description=__ret__.description,
        folder_id=__ret__.folder_id,
        id=__ret__.id,
        kms_key_id=__ret__.kms_key_id,
        labels=__ret__.labels,
        name=__ret__.name,
        secret_id=__ret__.secret_id,
        status=__ret__.status)


@_utilities.lift_output_func(get_lock_box_secret)
def get_lock_box_secret_output(folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                               name: Optional[pulumi.Input[Optional[str]]] = None,
                               secret_id: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetLockBoxSecretResult]:
    """
    Get information about Yandex Cloud Lockbox secret. For more information,
    see [the official documentation](https://cloud.yandex.com/en/docs/lockbox/).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_secret = yandex.get_lock_box_secret(secret_id="some ID")
    pulumi.export("mySecretCreatedAt", my_secret.created_at)
    ```


    :param str folder_id: Folder that the secret belongs to. If value is omitted, the default provider folder is used.
    :param str name: Name of the Lockbox secret.
    :param str secret_id: The Yandex Cloud Lockbox secret ID.
    """
    ...
