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
    'GetAlbLoadBalancerResult',
    'AwaitableGetAlbLoadBalancerResult',
    'get_alb_load_balancer',
    'get_alb_load_balancer_output',
]

@pulumi.output_type
class GetAlbLoadBalancerResult:
    """
    A collection of values returned by getAlbLoadBalancer.
    """
    def __init__(__self__, allocation_policies=None, created_at=None, description=None, folder_id=None, id=None, labels=None, listeners=None, load_balancer_id=None, log_group_id=None, log_options=None, name=None, network_id=None, region_id=None, security_group_ids=None, status=None):
        if allocation_policies and not isinstance(allocation_policies, list):
            raise TypeError("Expected argument 'allocation_policies' to be a list")
        pulumi.set(__self__, "allocation_policies", allocation_policies)
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
        if listeners and not isinstance(listeners, list):
            raise TypeError("Expected argument 'listeners' to be a list")
        pulumi.set(__self__, "listeners", listeners)
        if load_balancer_id and not isinstance(load_balancer_id, str):
            raise TypeError("Expected argument 'load_balancer_id' to be a str")
        pulumi.set(__self__, "load_balancer_id", load_balancer_id)
        if log_group_id and not isinstance(log_group_id, str):
            raise TypeError("Expected argument 'log_group_id' to be a str")
        pulumi.set(__self__, "log_group_id", log_group_id)
        if log_options and not isinstance(log_options, list):
            raise TypeError("Expected argument 'log_options' to be a list")
        pulumi.set(__self__, "log_options", log_options)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_id and not isinstance(network_id, str):
            raise TypeError("Expected argument 'network_id' to be a str")
        pulumi.set(__self__, "network_id", network_id)
        if region_id and not isinstance(region_id, str):
            raise TypeError("Expected argument 'region_id' to be a str")
        pulumi.set(__self__, "region_id", region_id)
        if security_group_ids and not isinstance(security_group_ids, list):
            raise TypeError("Expected argument 'security_group_ids' to be a list")
        pulumi.set(__self__, "security_group_ids", security_group_ids)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="allocationPolicies")
    def allocation_policies(self) -> Sequence['outputs.GetAlbLoadBalancerAllocationPolicyResult']:
        return pulumi.get(self, "allocation_policies")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

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
    def listeners(self) -> Sequence['outputs.GetAlbLoadBalancerListenerResult']:
        return pulumi.get(self, "listeners")

    @property
    @pulumi.getter(name="loadBalancerId")
    def load_balancer_id(self) -> str:
        return pulumi.get(self, "load_balancer_id")

    @property
    @pulumi.getter(name="logGroupId")
    def log_group_id(self) -> str:
        return pulumi.get(self, "log_group_id")

    @property
    @pulumi.getter(name="logOptions")
    def log_options(self) -> Sequence['outputs.GetAlbLoadBalancerLogOptionResult']:
        return pulumi.get(self, "log_options")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> str:
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> str:
        return pulumi.get(self, "region_id")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Sequence[str]:
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")


class AwaitableGetAlbLoadBalancerResult(GetAlbLoadBalancerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAlbLoadBalancerResult(
            allocation_policies=self.allocation_policies,
            created_at=self.created_at,
            description=self.description,
            folder_id=self.folder_id,
            id=self.id,
            labels=self.labels,
            listeners=self.listeners,
            load_balancer_id=self.load_balancer_id,
            log_group_id=self.log_group_id,
            log_options=self.log_options,
            name=self.name,
            network_id=self.network_id,
            region_id=self.region_id,
            security_group_ids=self.security_group_ids,
            status=self.status)


def get_alb_load_balancer(load_balancer_id: Optional[str] = None,
                          name: Optional[str] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAlbLoadBalancerResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['loadBalancerId'] = load_balancer_id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getAlbLoadBalancer:getAlbLoadBalancer', __args__, opts=opts, typ=GetAlbLoadBalancerResult).value

    return AwaitableGetAlbLoadBalancerResult(
        allocation_policies=__ret__.allocation_policies,
        created_at=__ret__.created_at,
        description=__ret__.description,
        folder_id=__ret__.folder_id,
        id=__ret__.id,
        labels=__ret__.labels,
        listeners=__ret__.listeners,
        load_balancer_id=__ret__.load_balancer_id,
        log_group_id=__ret__.log_group_id,
        log_options=__ret__.log_options,
        name=__ret__.name,
        network_id=__ret__.network_id,
        region_id=__ret__.region_id,
        security_group_ids=__ret__.security_group_ids,
        status=__ret__.status)


@_utilities.lift_output_func(get_alb_load_balancer)
def get_alb_load_balancer_output(load_balancer_id: Optional[pulumi.Input[Optional[str]]] = None,
                                 name: Optional[pulumi.Input[Optional[str]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAlbLoadBalancerResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
