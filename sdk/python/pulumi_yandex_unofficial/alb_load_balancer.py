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

__all__ = ['AlbLoadBalancerArgs', 'AlbLoadBalancer']

@pulumi.input_type
class AlbLoadBalancerArgs:
    def __init__(__self__, *,
                 allocation_policy: pulumi.Input['AlbLoadBalancerAllocationPolicyArgs'],
                 network_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a AlbLoadBalancer resource.
        :param pulumi.Input['AlbLoadBalancerAllocationPolicyArgs'] allocation_policy: Allocation zones for the Load Balancer instance. The structure is documented below.
        :param pulumi.Input[str] network_id: ID of the network that the Load Balancer is located at.
        :param pulumi.Input[str] description: An optional description of the Load Balancer.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this Load Balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]] listeners: List of listeners for the Load Balancer. The structure is documented below.
        :param pulumi.Input[str] name: name of SNI match.
        :param pulumi.Input[str] region_id: ID of the region that the Load Balancer is located at.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: A list of ID's of security groups attached to the Load Balancer.
        """
        pulumi.set(__self__, "allocation_policy", allocation_policy)
        pulumi.set(__self__, "network_id", network_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if listeners is not None:
            pulumi.set(__self__, "listeners", listeners)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if region_id is not None:
            pulumi.set(__self__, "region_id", region_id)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)

    @property
    @pulumi.getter(name="allocationPolicy")
    def allocation_policy(self) -> pulumi.Input['AlbLoadBalancerAllocationPolicyArgs']:
        """
        Allocation zones for the Load Balancer instance. The structure is documented below.
        """
        return pulumi.get(self, "allocation_policy")

    @allocation_policy.setter
    def allocation_policy(self, value: pulumi.Input['AlbLoadBalancerAllocationPolicyArgs']):
        pulumi.set(self, "allocation_policy", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Input[str]:
        """
        ID of the network that the Load Balancer is located at.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of the Load Balancer.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this Load Balancer. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def listeners(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]]]:
        """
        List of listeners for the Load Balancer. The structure is documented below.
        """
        return pulumi.get(self, "listeners")

    @listeners.setter
    def listeners(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]]]):
        pulumi.set(self, "listeners", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        name of SNI match.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the region that the Load Balancer is located at.
        """
        return pulumi.get(self, "region_id")

    @region_id.setter
    def region_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region_id", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of ID's of security groups attached to the Load Balancer.
        """
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)


@pulumi.input_type
class _AlbLoadBalancerState:
    def __init__(__self__, *,
                 allocation_policy: Optional[pulumi.Input['AlbLoadBalancerAllocationPolicyArgs']] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]]] = None,
                 log_group_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering AlbLoadBalancer resources.
        :param pulumi.Input['AlbLoadBalancerAllocationPolicyArgs'] allocation_policy: Allocation zones for the Load Balancer instance. The structure is documented below.
        :param pulumi.Input[str] created_at: The Load Balancer creation timestamp.
        :param pulumi.Input[str] description: An optional description of the Load Balancer.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this Load Balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]] listeners: List of listeners for the Load Balancer. The structure is documented below.
        :param pulumi.Input[str] log_group_id: Cloud log group used by the Load Balancer to store access logs.
        :param pulumi.Input[str] name: name of SNI match.
        :param pulumi.Input[str] network_id: ID of the network that the Load Balancer is located at.
        :param pulumi.Input[str] region_id: ID of the region that the Load Balancer is located at.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: A list of ID's of security groups attached to the Load Balancer.
        :param pulumi.Input[str] status: Status of the Load Balancer.
        """
        if allocation_policy is not None:
            pulumi.set(__self__, "allocation_policy", allocation_policy)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if listeners is not None:
            pulumi.set(__self__, "listeners", listeners)
        if log_group_id is not None:
            pulumi.set(__self__, "log_group_id", log_group_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)
        if region_id is not None:
            pulumi.set(__self__, "region_id", region_id)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="allocationPolicy")
    def allocation_policy(self) -> Optional[pulumi.Input['AlbLoadBalancerAllocationPolicyArgs']]:
        """
        Allocation zones for the Load Balancer instance. The structure is documented below.
        """
        return pulumi.get(self, "allocation_policy")

    @allocation_policy.setter
    def allocation_policy(self, value: Optional[pulumi.Input['AlbLoadBalancerAllocationPolicyArgs']]):
        pulumi.set(self, "allocation_policy", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        The Load Balancer creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of the Load Balancer.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this Load Balancer. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def listeners(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]]]:
        """
        List of listeners for the Load Balancer. The structure is documented below.
        """
        return pulumi.get(self, "listeners")

    @listeners.setter
    def listeners(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AlbLoadBalancerListenerArgs']]]]):
        pulumi.set(self, "listeners", value)

    @property
    @pulumi.getter(name="logGroupId")
    def log_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        Cloud log group used by the Load Balancer to store access logs.
        """
        return pulumi.get(self, "log_group_id")

    @log_group_id.setter
    def log_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_group_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        name of SNI match.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the network that the Load Balancer is located at.
        """
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the region that the Load Balancer is located at.
        """
        return pulumi.get(self, "region_id")

    @region_id.setter
    def region_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region_id", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of ID's of security groups attached to the Load Balancer.
        """
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status of the Load Balancer.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


class AlbLoadBalancer(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allocation_policy: Optional[pulumi.Input[pulumi.InputType['AlbLoadBalancerAllocationPolicyArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlbLoadBalancerListenerArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Creates an Application Load Balancer in the specified folder. For more information, see
        [the official documentation](https://cloud.yandex.com/en/docs/application-load-balancer/concepts/application-load-balancer)
        .

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex_unofficial as yandex

        test_balancer = yandex.AlbLoadBalancer("test-balancer",
            network_id=yandex_vpc_network["test-network"]["id"],
            allocation_policy=yandex.AlbLoadBalancerAllocationPolicyArgs(
                locations=[yandex.AlbLoadBalancerAllocationPolicyLocationArgs(
                    zone_id="ru-central1-a",
                    subnet_id=yandex_vpc_subnet["test-subnet"]["id"],
                )],
            ),
            listeners=[yandex.AlbLoadBalancerListenerArgs(
                name="my-listener",
                endpoints=[yandex.AlbLoadBalancerListenerEndpointArgs(
                    addresses=[yandex.AlbLoadBalancerListenerEndpointAddressArgs(
                        external_ipv4_address=yandex.AlbLoadBalancerListenerEndpointAddressExternalIpv4AddressArgs(),
                    )],
                    ports=[8080],
                )],
                http=yandex.AlbLoadBalancerListenerHttpArgs(
                    handler=yandex.AlbLoadBalancerListenerHttpHandlerArgs(
                        http_router_id=yandex_alb_http_router["test-router"]["id"],
                    ),
                ),
            )])
        ```

        ## Import

        An Application Load Balancer can be imported using the `id` of the resource, e.g.

        ```sh
         $ pulumi import yandex:index/albLoadBalancer:AlbLoadBalancer default load_balancer_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['AlbLoadBalancerAllocationPolicyArgs']] allocation_policy: Allocation zones for the Load Balancer instance. The structure is documented below.
        :param pulumi.Input[str] description: An optional description of the Load Balancer.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this Load Balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlbLoadBalancerListenerArgs']]]] listeners: List of listeners for the Load Balancer. The structure is documented below.
        :param pulumi.Input[str] name: name of SNI match.
        :param pulumi.Input[str] network_id: ID of the network that the Load Balancer is located at.
        :param pulumi.Input[str] region_id: ID of the region that the Load Balancer is located at.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: A list of ID's of security groups attached to the Load Balancer.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: AlbLoadBalancerArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates an Application Load Balancer in the specified folder. For more information, see
        [the official documentation](https://cloud.yandex.com/en/docs/application-load-balancer/concepts/application-load-balancer)
        .

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex_unofficial as yandex

        test_balancer = yandex.AlbLoadBalancer("test-balancer",
            network_id=yandex_vpc_network["test-network"]["id"],
            allocation_policy=yandex.AlbLoadBalancerAllocationPolicyArgs(
                locations=[yandex.AlbLoadBalancerAllocationPolicyLocationArgs(
                    zone_id="ru-central1-a",
                    subnet_id=yandex_vpc_subnet["test-subnet"]["id"],
                )],
            ),
            listeners=[yandex.AlbLoadBalancerListenerArgs(
                name="my-listener",
                endpoints=[yandex.AlbLoadBalancerListenerEndpointArgs(
                    addresses=[yandex.AlbLoadBalancerListenerEndpointAddressArgs(
                        external_ipv4_address=yandex.AlbLoadBalancerListenerEndpointAddressExternalIpv4AddressArgs(),
                    )],
                    ports=[8080],
                )],
                http=yandex.AlbLoadBalancerListenerHttpArgs(
                    handler=yandex.AlbLoadBalancerListenerHttpHandlerArgs(
                        http_router_id=yandex_alb_http_router["test-router"]["id"],
                    ),
                ),
            )])
        ```

        ## Import

        An Application Load Balancer can be imported using the `id` of the resource, e.g.

        ```sh
         $ pulumi import yandex:index/albLoadBalancer:AlbLoadBalancer default load_balancer_id
        ```

        :param str resource_name: The name of the resource.
        :param AlbLoadBalancerArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AlbLoadBalancerArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allocation_policy: Optional[pulumi.Input[pulumi.InputType['AlbLoadBalancerAllocationPolicyArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 listeners: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlbLoadBalancerListenerArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AlbLoadBalancerArgs.__new__(AlbLoadBalancerArgs)

            if allocation_policy is None and not opts.urn:
                raise TypeError("Missing required property 'allocation_policy'")
            __props__.__dict__["allocation_policy"] = allocation_policy
            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["listeners"] = listeners
            __props__.__dict__["name"] = name
            if network_id is None and not opts.urn:
                raise TypeError("Missing required property 'network_id'")
            __props__.__dict__["network_id"] = network_id
            __props__.__dict__["region_id"] = region_id
            __props__.__dict__["security_group_ids"] = security_group_ids
            __props__.__dict__["created_at"] = None
            __props__.__dict__["log_group_id"] = None
            __props__.__dict__["status"] = None
        super(AlbLoadBalancer, __self__).__init__(
            'yandex:index/albLoadBalancer:AlbLoadBalancer',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            allocation_policy: Optional[pulumi.Input[pulumi.InputType['AlbLoadBalancerAllocationPolicyArgs']]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            listeners: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlbLoadBalancerListenerArgs']]]]] = None,
            log_group_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            network_id: Optional[pulumi.Input[str]] = None,
            region_id: Optional[pulumi.Input[str]] = None,
            security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'AlbLoadBalancer':
        """
        Get an existing AlbLoadBalancer resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['AlbLoadBalancerAllocationPolicyArgs']] allocation_policy: Allocation zones for the Load Balancer instance. The structure is documented below.
        :param pulumi.Input[str] created_at: The Load Balancer creation timestamp.
        :param pulumi.Input[str] description: An optional description of the Load Balancer.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this Load Balancer. A list of key/value pairs.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AlbLoadBalancerListenerArgs']]]] listeners: List of listeners for the Load Balancer. The structure is documented below.
        :param pulumi.Input[str] log_group_id: Cloud log group used by the Load Balancer to store access logs.
        :param pulumi.Input[str] name: name of SNI match.
        :param pulumi.Input[str] network_id: ID of the network that the Load Balancer is located at.
        :param pulumi.Input[str] region_id: ID of the region that the Load Balancer is located at.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] security_group_ids: A list of ID's of security groups attached to the Load Balancer.
        :param pulumi.Input[str] status: Status of the Load Balancer.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AlbLoadBalancerState.__new__(_AlbLoadBalancerState)

        __props__.__dict__["allocation_policy"] = allocation_policy
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["description"] = description
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["listeners"] = listeners
        __props__.__dict__["log_group_id"] = log_group_id
        __props__.__dict__["name"] = name
        __props__.__dict__["network_id"] = network_id
        __props__.__dict__["region_id"] = region_id
        __props__.__dict__["security_group_ids"] = security_group_ids
        __props__.__dict__["status"] = status
        return AlbLoadBalancer(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allocationPolicy")
    def allocation_policy(self) -> pulumi.Output['outputs.AlbLoadBalancerAllocationPolicy']:
        """
        Allocation zones for the Load Balancer instance. The structure is documented below.
        """
        return pulumi.get(self, "allocation_policy")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The Load Balancer creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        An optional description of the Load Balancer.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        The ID of the folder to which the resource belongs. If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Labels to assign to this Load Balancer. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def listeners(self) -> pulumi.Output[Optional[Sequence['outputs.AlbLoadBalancerListener']]]:
        """
        List of listeners for the Load Balancer. The structure is documented below.
        """
        return pulumi.get(self, "listeners")

    @property
    @pulumi.getter(name="logGroupId")
    def log_group_id(self) -> pulumi.Output[str]:
        """
        Cloud log group used by the Load Balancer to store access logs.
        """
        return pulumi.get(self, "log_group_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        name of SNI match.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Output[str]:
        """
        ID of the network that the Load Balancer is located at.
        """
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> pulumi.Output[Optional[str]]:
        """
        ID of the region that the Load Balancer is located at.
        """
        return pulumi.get(self, "region_id")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        A list of ID's of security groups attached to the Load Balancer.
        """
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Status of the Load Balancer.
        """
        return pulumi.get(self, "status")

