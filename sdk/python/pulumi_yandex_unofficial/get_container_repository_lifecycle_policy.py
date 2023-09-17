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
    'GetContainerRepositoryLifecyclePolicyResult',
    'AwaitableGetContainerRepositoryLifecyclePolicyResult',
    'get_container_repository_lifecycle_policy',
    'get_container_repository_lifecycle_policy_output',
]

@pulumi.output_type
class GetContainerRepositoryLifecyclePolicyResult:
    """
    A collection of values returned by getContainerRepositoryLifecyclePolicy.
    """
    def __init__(__self__, created_at=None, description=None, id=None, lifecycle_policy_id=None, name=None, repository_id=None, rules=None, status=None):
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if lifecycle_policy_id and not isinstance(lifecycle_policy_id, str):
            raise TypeError("Expected argument 'lifecycle_policy_id' to be a str")
        pulumi.set(__self__, "lifecycle_policy_id", lifecycle_policy_id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if repository_id and not isinstance(repository_id, str):
            raise TypeError("Expected argument 'repository_id' to be a str")
        pulumi.set(__self__, "repository_id", repository_id)
        if rules and not isinstance(rules, list):
            raise TypeError("Expected argument 'rules' to be a list")
        pulumi.set(__self__, "rules", rules)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        """
        Description of the lifecycle policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="lifecyclePolicyId")
    def lifecycle_policy_id(self) -> str:
        return pulumi.get(self, "lifecycle_policy_id")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="repositoryId")
    def repository_id(self) -> str:
        return pulumi.get(self, "repository_id")

    @property
    @pulumi.getter
    def rules(self) -> Sequence['outputs.GetContainerRepositoryLifecyclePolicyRuleResult']:
        return pulumi.get(self, "rules")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The status of lifecycle policy.
        """
        return pulumi.get(self, "status")


class AwaitableGetContainerRepositoryLifecyclePolicyResult(GetContainerRepositoryLifecyclePolicyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetContainerRepositoryLifecyclePolicyResult(
            created_at=self.created_at,
            description=self.description,
            id=self.id,
            lifecycle_policy_id=self.lifecycle_policy_id,
            name=self.name,
            repository_id=self.repository_id,
            rules=self.rules,
            status=self.status)


def get_container_repository_lifecycle_policy(lifecycle_policy_id: Optional[str] = None,
                                              name: Optional[str] = None,
                                              repository_id: Optional[str] = None,
                                              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetContainerRepositoryLifecyclePolicyResult:
    """
    Get information about a Yandex Container Repository. For more information, see
    [the official documentation](https://cloud.yandex.com/en-ru/docs/container-registry/concepts/lifecycle-policy)

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_lifecycle_policy_by_id = yandex.get_container_repository_lifecycle_policy(lifecycle_policy_id=yandex_container_repository_lifecycle_policy["my_lifecycle_policy"]["id"])
    ```


    :param str lifecycle_policy_id: The ID of a specific Lifecycle Policy.
    :param str name: Name of Lifecycle Policy.
    :param str repository_id: The ID of a repository which Lifecycle Policy belongs to.
    """
    __args__ = dict()
    __args__['lifecyclePolicyId'] = lifecycle_policy_id
    __args__['name'] = name
    __args__['repositoryId'] = repository_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getContainerRepositoryLifecyclePolicy:getContainerRepositoryLifecyclePolicy', __args__, opts=opts, typ=GetContainerRepositoryLifecyclePolicyResult).value

    return AwaitableGetContainerRepositoryLifecyclePolicyResult(
        created_at=__ret__.created_at,
        description=__ret__.description,
        id=__ret__.id,
        lifecycle_policy_id=__ret__.lifecycle_policy_id,
        name=__ret__.name,
        repository_id=__ret__.repository_id,
        rules=__ret__.rules,
        status=__ret__.status)


@_utilities.lift_output_func(get_container_repository_lifecycle_policy)
def get_container_repository_lifecycle_policy_output(lifecycle_policy_id: Optional[pulumi.Input[Optional[str]]] = None,
                                                     name: Optional[pulumi.Input[Optional[str]]] = None,
                                                     repository_id: Optional[pulumi.Input[Optional[str]]] = None,
                                                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetContainerRepositoryLifecyclePolicyResult]:
    """
    Get information about a Yandex Container Repository. For more information, see
    [the official documentation](https://cloud.yandex.com/en-ru/docs/container-registry/concepts/lifecycle-policy)

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    my_lifecycle_policy_by_id = yandex.get_container_repository_lifecycle_policy(lifecycle_policy_id=yandex_container_repository_lifecycle_policy["my_lifecycle_policy"]["id"])
    ```


    :param str lifecycle_policy_id: The ID of a specific Lifecycle Policy.
    :param str name: Name of Lifecycle Policy.
    :param str repository_id: The ID of a repository which Lifecycle Policy belongs to.
    """
    ...
