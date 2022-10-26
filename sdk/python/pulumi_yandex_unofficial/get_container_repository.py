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
    'GetContainerRepositoryResult',
    'AwaitableGetContainerRepositoryResult',
    'get_container_repository',
    'get_container_repository_output',
]

@pulumi.output_type
class GetContainerRepositoryResult:
    """
    A collection of values returned by getContainerRepository.
    """
    def __init__(__self__, id=None, name=None, repository_id=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if repository_id and not isinstance(repository_id, str):
            raise TypeError("Expected argument 'repository_id' to be a str")
        pulumi.set(__self__, "repository_id", repository_id)

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
    @pulumi.getter(name="repositoryId")
    def repository_id(self) -> str:
        return pulumi.get(self, "repository_id")


class AwaitableGetContainerRepositoryResult(GetContainerRepositoryResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetContainerRepositoryResult(
            id=self.id,
            name=self.name,
            repository_id=self.repository_id)


def get_container_repository(name: Optional[str] = None,
                             repository_id: Optional[str] = None,
                             opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetContainerRepositoryResult:
    """
    Get information about a Yandex Container Repository. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/container-registry/concepts/repository)

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    repo_1 = yandex.get_container_repository(name="some_repository_name")
    repo_2 = yandex.get_container_repository(repository_id="some_repository_id")
    ```


    :param str name: Name of the repository. The name of the repository should start with id of a container registry and match the name of the images in the repository.
    :param str repository_id: The ID of a specific repository.
    """
    __args__ = dict()
    __args__['name'] = name
    __args__['repositoryId'] = repository_id
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getContainerRepository:getContainerRepository', __args__, opts=opts, typ=GetContainerRepositoryResult).value

    return AwaitableGetContainerRepositoryResult(
        id=__ret__.id,
        name=__ret__.name,
        repository_id=__ret__.repository_id)


@_utilities.lift_output_func(get_container_repository)
def get_container_repository_output(name: Optional[pulumi.Input[Optional[str]]] = None,
                                    repository_id: Optional[pulumi.Input[Optional[str]]] = None,
                                    opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetContainerRepositoryResult]:
    """
    Get information about a Yandex Container Repository. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/container-registry/concepts/repository)

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    repo_1 = yandex.get_container_repository(name="some_repository_name")
    repo_2 = yandex.get_container_repository(repository_id="some_repository_id")
    ```


    :param str name: Name of the repository. The name of the repository should start with id of a container registry and match the name of the images in the repository.
    :param str repository_id: The ID of a specific repository.
    """
    ...
