# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['VpcSecurityGroupRuleArgs', 'VpcSecurityGroupRule']

@pulumi.input_type
class VpcSecurityGroupRuleArgs:
    def __init__(__self__, *,
                 direction: pulumi.Input[str],
                 security_group_binding: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 from_port: Optional[pulumi.Input[int]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 predefined_target: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 security_group_id: Optional[pulumi.Input[str]] = None,
                 to_port: Optional[pulumi.Input[int]] = None,
                 v4_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 v6_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a VpcSecurityGroupRule resource.
        """
        pulumi.set(__self__, "direction", direction)
        pulumi.set(__self__, "security_group_binding", security_group_binding)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if from_port is not None:
            pulumi.set(__self__, "from_port", from_port)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if predefined_target is not None:
            pulumi.set(__self__, "predefined_target", predefined_target)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if security_group_id is not None:
            pulumi.set(__self__, "security_group_id", security_group_id)
        if to_port is not None:
            pulumi.set(__self__, "to_port", to_port)
        if v4_cidr_blocks is not None:
            pulumi.set(__self__, "v4_cidr_blocks", v4_cidr_blocks)
        if v6_cidr_blocks is not None:
            pulumi.set(__self__, "v6_cidr_blocks", v6_cidr_blocks)

    @property
    @pulumi.getter
    def direction(self) -> pulumi.Input[str]:
        return pulumi.get(self, "direction")

    @direction.setter
    def direction(self, value: pulumi.Input[str]):
        pulumi.set(self, "direction", value)

    @property
    @pulumi.getter(name="securityGroupBinding")
    def security_group_binding(self) -> pulumi.Input[str]:
        return pulumi.get(self, "security_group_binding")

    @security_group_binding.setter
    def security_group_binding(self, value: pulumi.Input[str]):
        pulumi.set(self, "security_group_binding", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="fromPort")
    def from_port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "from_port")

    @from_port.setter
    def from_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "from_port", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="predefinedTarget")
    def predefined_target(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "predefined_target")

    @predefined_target.setter
    def predefined_target(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "predefined_target", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="securityGroupId")
    def security_group_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "security_group_id")

    @security_group_id.setter
    def security_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "security_group_id", value)

    @property
    @pulumi.getter(name="toPort")
    def to_port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "to_port")

    @to_port.setter
    def to_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "to_port", value)

    @property
    @pulumi.getter(name="v4CidrBlocks")
    def v4_cidr_blocks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "v4_cidr_blocks")

    @v4_cidr_blocks.setter
    def v4_cidr_blocks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "v4_cidr_blocks", value)

    @property
    @pulumi.getter(name="v6CidrBlocks")
    def v6_cidr_blocks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "v6_cidr_blocks")

    @v6_cidr_blocks.setter
    def v6_cidr_blocks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "v6_cidr_blocks", value)


@pulumi.input_type
class _VpcSecurityGroupRuleState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 direction: Optional[pulumi.Input[str]] = None,
                 from_port: Optional[pulumi.Input[int]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 predefined_target: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 security_group_binding: Optional[pulumi.Input[str]] = None,
                 security_group_id: Optional[pulumi.Input[str]] = None,
                 to_port: Optional[pulumi.Input[int]] = None,
                 v4_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 v6_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering VpcSecurityGroupRule resources.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if direction is not None:
            pulumi.set(__self__, "direction", direction)
        if from_port is not None:
            pulumi.set(__self__, "from_port", from_port)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if predefined_target is not None:
            pulumi.set(__self__, "predefined_target", predefined_target)
        if protocol is not None:
            pulumi.set(__self__, "protocol", protocol)
        if security_group_binding is not None:
            pulumi.set(__self__, "security_group_binding", security_group_binding)
        if security_group_id is not None:
            pulumi.set(__self__, "security_group_id", security_group_id)
        if to_port is not None:
            pulumi.set(__self__, "to_port", to_port)
        if v4_cidr_blocks is not None:
            pulumi.set(__self__, "v4_cidr_blocks", v4_cidr_blocks)
        if v6_cidr_blocks is not None:
            pulumi.set(__self__, "v6_cidr_blocks", v6_cidr_blocks)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def direction(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "direction")

    @direction.setter
    def direction(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "direction", value)

    @property
    @pulumi.getter(name="fromPort")
    def from_port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "from_port")

    @from_port.setter
    def from_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "from_port", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="predefinedTarget")
    def predefined_target(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "predefined_target")

    @predefined_target.setter
    def predefined_target(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "predefined_target", value)

    @property
    @pulumi.getter
    def protocol(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="securityGroupBinding")
    def security_group_binding(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "security_group_binding")

    @security_group_binding.setter
    def security_group_binding(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "security_group_binding", value)

    @property
    @pulumi.getter(name="securityGroupId")
    def security_group_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "security_group_id")

    @security_group_id.setter
    def security_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "security_group_id", value)

    @property
    @pulumi.getter(name="toPort")
    def to_port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "to_port")

    @to_port.setter
    def to_port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "to_port", value)

    @property
    @pulumi.getter(name="v4CidrBlocks")
    def v4_cidr_blocks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "v4_cidr_blocks")

    @v4_cidr_blocks.setter
    def v4_cidr_blocks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "v4_cidr_blocks", value)

    @property
    @pulumi.getter(name="v6CidrBlocks")
    def v6_cidr_blocks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "v6_cidr_blocks")

    @v6_cidr_blocks.setter
    def v6_cidr_blocks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "v6_cidr_blocks", value)


class VpcSecurityGroupRule(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 direction: Optional[pulumi.Input[str]] = None,
                 from_port: Optional[pulumi.Input[int]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 predefined_target: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 security_group_binding: Optional[pulumi.Input[str]] = None,
                 security_group_id: Optional[pulumi.Input[str]] = None,
                 to_port: Optional[pulumi.Input[int]] = None,
                 v4_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 v6_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Create a VpcSecurityGroupRule resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: VpcSecurityGroupRuleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a VpcSecurityGroupRule resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param VpcSecurityGroupRuleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(VpcSecurityGroupRuleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 direction: Optional[pulumi.Input[str]] = None,
                 from_port: Optional[pulumi.Input[int]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 predefined_target: Optional[pulumi.Input[str]] = None,
                 protocol: Optional[pulumi.Input[str]] = None,
                 security_group_binding: Optional[pulumi.Input[str]] = None,
                 security_group_id: Optional[pulumi.Input[str]] = None,
                 to_port: Optional[pulumi.Input[int]] = None,
                 v4_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 v6_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = VpcSecurityGroupRuleArgs.__new__(VpcSecurityGroupRuleArgs)

            __props__.__dict__["description"] = description
            if direction is None and not opts.urn:
                raise TypeError("Missing required property 'direction'")
            __props__.__dict__["direction"] = direction
            __props__.__dict__["from_port"] = from_port
            __props__.__dict__["labels"] = labels
            __props__.__dict__["port"] = port
            __props__.__dict__["predefined_target"] = predefined_target
            __props__.__dict__["protocol"] = protocol
            if security_group_binding is None and not opts.urn:
                raise TypeError("Missing required property 'security_group_binding'")
            __props__.__dict__["security_group_binding"] = security_group_binding
            __props__.__dict__["security_group_id"] = security_group_id
            __props__.__dict__["to_port"] = to_port
            __props__.__dict__["v4_cidr_blocks"] = v4_cidr_blocks
            __props__.__dict__["v6_cidr_blocks"] = v6_cidr_blocks
        super(VpcSecurityGroupRule, __self__).__init__(
            'yandex:index/vpcSecurityGroupRule:VpcSecurityGroupRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            direction: Optional[pulumi.Input[str]] = None,
            from_port: Optional[pulumi.Input[int]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            port: Optional[pulumi.Input[int]] = None,
            predefined_target: Optional[pulumi.Input[str]] = None,
            protocol: Optional[pulumi.Input[str]] = None,
            security_group_binding: Optional[pulumi.Input[str]] = None,
            security_group_id: Optional[pulumi.Input[str]] = None,
            to_port: Optional[pulumi.Input[int]] = None,
            v4_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            v6_cidr_blocks: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None) -> 'VpcSecurityGroupRule':
        """
        Get an existing VpcSecurityGroupRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _VpcSecurityGroupRuleState.__new__(_VpcSecurityGroupRuleState)

        __props__.__dict__["description"] = description
        __props__.__dict__["direction"] = direction
        __props__.__dict__["from_port"] = from_port
        __props__.__dict__["labels"] = labels
        __props__.__dict__["port"] = port
        __props__.__dict__["predefined_target"] = predefined_target
        __props__.__dict__["protocol"] = protocol
        __props__.__dict__["security_group_binding"] = security_group_binding
        __props__.__dict__["security_group_id"] = security_group_id
        __props__.__dict__["to_port"] = to_port
        __props__.__dict__["v4_cidr_blocks"] = v4_cidr_blocks
        __props__.__dict__["v6_cidr_blocks"] = v6_cidr_blocks
        return VpcSecurityGroupRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def direction(self) -> pulumi.Output[str]:
        return pulumi.get(self, "direction")

    @property
    @pulumi.getter(name="fromPort")
    def from_port(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "from_port")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="predefinedTarget")
    def predefined_target(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "predefined_target")

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "protocol")

    @property
    @pulumi.getter(name="securityGroupBinding")
    def security_group_binding(self) -> pulumi.Output[str]:
        return pulumi.get(self, "security_group_binding")

    @property
    @pulumi.getter(name="securityGroupId")
    def security_group_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "security_group_id")

    @property
    @pulumi.getter(name="toPort")
    def to_port(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "to_port")

    @property
    @pulumi.getter(name="v4CidrBlocks")
    def v4_cidr_blocks(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "v4_cidr_blocks")

    @property
    @pulumi.getter(name="v6CidrBlocks")
    def v6_cidr_blocks(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "v6_cidr_blocks")

