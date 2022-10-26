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
    'GetVpcSecurityGroupRuleResult',
    'AwaitableGetVpcSecurityGroupRuleResult',
    'get_vpc_security_group_rule',
    'get_vpc_security_group_rule_output',
]

@pulumi.output_type
class GetVpcSecurityGroupRuleResult:
    """
    A collection of values returned by getVpcSecurityGroupRule.
    """
    def __init__(__self__, description=None, direction=None, from_port=None, id=None, labels=None, port=None, predefined_target=None, protocol=None, rule_id=None, security_group_binding=None, security_group_id=None, to_port=None, v4_cidr_blocks=None, v6_cidr_blocks=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if direction and not isinstance(direction, str):
            raise TypeError("Expected argument 'direction' to be a str")
        pulumi.set(__self__, "direction", direction)
        if from_port and not isinstance(from_port, int):
            raise TypeError("Expected argument 'from_port' to be a int")
        pulumi.set(__self__, "from_port", from_port)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if port and not isinstance(port, int):
            raise TypeError("Expected argument 'port' to be a int")
        pulumi.set(__self__, "port", port)
        if predefined_target and not isinstance(predefined_target, str):
            raise TypeError("Expected argument 'predefined_target' to be a str")
        pulumi.set(__self__, "predefined_target", predefined_target)
        if protocol and not isinstance(protocol, str):
            raise TypeError("Expected argument 'protocol' to be a str")
        pulumi.set(__self__, "protocol", protocol)
        if rule_id and not isinstance(rule_id, str):
            raise TypeError("Expected argument 'rule_id' to be a str")
        pulumi.set(__self__, "rule_id", rule_id)
        if security_group_binding and not isinstance(security_group_binding, str):
            raise TypeError("Expected argument 'security_group_binding' to be a str")
        pulumi.set(__self__, "security_group_binding", security_group_binding)
        if security_group_id and not isinstance(security_group_id, str):
            raise TypeError("Expected argument 'security_group_id' to be a str")
        pulumi.set(__self__, "security_group_id", security_group_id)
        if to_port and not isinstance(to_port, int):
            raise TypeError("Expected argument 'to_port' to be a int")
        pulumi.set(__self__, "to_port", to_port)
        if v4_cidr_blocks and not isinstance(v4_cidr_blocks, list):
            raise TypeError("Expected argument 'v4_cidr_blocks' to be a list")
        pulumi.set(__self__, "v4_cidr_blocks", v4_cidr_blocks)
        if v6_cidr_blocks and not isinstance(v6_cidr_blocks, list):
            raise TypeError("Expected argument 'v6_cidr_blocks' to be a list")
        pulumi.set(__self__, "v6_cidr_blocks", v6_cidr_blocks)

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def direction(self) -> str:
        return pulumi.get(self, "direction")

    @property
    @pulumi.getter(name="fromPort")
    def from_port(self) -> int:
        return pulumi.get(self, "from_port")

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
    def port(self) -> int:
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="predefinedTarget")
    def predefined_target(self) -> str:
        return pulumi.get(self, "predefined_target")

    @property
    @pulumi.getter
    def protocol(self) -> str:
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter(name="ruleId")
    def rule_id(self) -> str:
        return pulumi.get(self, "rule_id")

    @property
    @pulumi.getter(name="securityGroupBinding")
    def security_group_binding(self) -> str:
        return pulumi.get(self, "security_group_binding")

    @property
    @pulumi.getter(name="securityGroupId")
    def security_group_id(self) -> str:
        return pulumi.get(self, "security_group_id")

    @property
    @pulumi.getter(name="toPort")
    def to_port(self) -> int:
        return pulumi.get(self, "to_port")

    @property
    @pulumi.getter(name="v4CidrBlocks")
    def v4_cidr_blocks(self) -> Sequence[str]:
        return pulumi.get(self, "v4_cidr_blocks")

    @property
    @pulumi.getter(name="v6CidrBlocks")
    def v6_cidr_blocks(self) -> Sequence[str]:
        return pulumi.get(self, "v6_cidr_blocks")


class AwaitableGetVpcSecurityGroupRuleResult(GetVpcSecurityGroupRuleResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVpcSecurityGroupRuleResult(
            description=self.description,
            direction=self.direction,
            from_port=self.from_port,
            id=self.id,
            labels=self.labels,
            port=self.port,
            predefined_target=self.predefined_target,
            protocol=self.protocol,
            rule_id=self.rule_id,
            security_group_binding=self.security_group_binding,
            security_group_id=self.security_group_id,
            to_port=self.to_port,
            v4_cidr_blocks=self.v4_cidr_blocks,
            v6_cidr_blocks=self.v6_cidr_blocks)


def get_vpc_security_group_rule(rule_id: Optional[str] = None,
                                security_group_binding: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetVpcSecurityGroupRuleResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['ruleId'] = rule_id
    __args__['securityGroupBinding'] = security_group_binding
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getVpcSecurityGroupRule:getVpcSecurityGroupRule', __args__, opts=opts, typ=GetVpcSecurityGroupRuleResult).value

    return AwaitableGetVpcSecurityGroupRuleResult(
        description=__ret__.description,
        direction=__ret__.direction,
        from_port=__ret__.from_port,
        id=__ret__.id,
        labels=__ret__.labels,
        port=__ret__.port,
        predefined_target=__ret__.predefined_target,
        protocol=__ret__.protocol,
        rule_id=__ret__.rule_id,
        security_group_binding=__ret__.security_group_binding,
        security_group_id=__ret__.security_group_id,
        to_port=__ret__.to_port,
        v4_cidr_blocks=__ret__.v4_cidr_blocks,
        v6_cidr_blocks=__ret__.v6_cidr_blocks)


@_utilities.lift_output_func(get_vpc_security_group_rule)
def get_vpc_security_group_rule_output(rule_id: Optional[pulumi.Input[str]] = None,
                                       security_group_binding: Optional[pulumi.Input[str]] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetVpcSecurityGroupRuleResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
