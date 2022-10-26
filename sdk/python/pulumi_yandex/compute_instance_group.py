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

__all__ = ['ComputeInstanceGroupArgs', 'ComputeInstanceGroup']

@pulumi.input_type
class ComputeInstanceGroupArgs:
    def __init__(__self__, *,
                 allocation_policy: pulumi.Input['ComputeInstanceGroupAllocationPolicyArgs'],
                 deploy_policy: pulumi.Input['ComputeInstanceGroupDeployPolicyArgs'],
                 instance_template: pulumi.Input['ComputeInstanceGroupInstanceTemplateArgs'],
                 scale_policy: pulumi.Input['ComputeInstanceGroupScalePolicyArgs'],
                 service_account_id: pulumi.Input[str],
                 application_load_balancer: Optional[pulumi.Input['ComputeInstanceGroupApplicationLoadBalancerArgs']] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 health_checks: Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupHealthCheckArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 load_balancer: Optional[pulumi.Input['ComputeInstanceGroupLoadBalancerArgs']] = None,
                 max_checking_health_duration: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 variables: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a ComputeInstanceGroup resource.
        """
        pulumi.set(__self__, "allocation_policy", allocation_policy)
        pulumi.set(__self__, "deploy_policy", deploy_policy)
        pulumi.set(__self__, "instance_template", instance_template)
        pulumi.set(__self__, "scale_policy", scale_policy)
        pulumi.set(__self__, "service_account_id", service_account_id)
        if application_load_balancer is not None:
            pulumi.set(__self__, "application_load_balancer", application_load_balancer)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if health_checks is not None:
            pulumi.set(__self__, "health_checks", health_checks)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if load_balancer is not None:
            pulumi.set(__self__, "load_balancer", load_balancer)
        if max_checking_health_duration is not None:
            pulumi.set(__self__, "max_checking_health_duration", max_checking_health_duration)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if variables is not None:
            pulumi.set(__self__, "variables", variables)

    @property
    @pulumi.getter(name="allocationPolicy")
    def allocation_policy(self) -> pulumi.Input['ComputeInstanceGroupAllocationPolicyArgs']:
        return pulumi.get(self, "allocation_policy")

    @allocation_policy.setter
    def allocation_policy(self, value: pulumi.Input['ComputeInstanceGroupAllocationPolicyArgs']):
        pulumi.set(self, "allocation_policy", value)

    @property
    @pulumi.getter(name="deployPolicy")
    def deploy_policy(self) -> pulumi.Input['ComputeInstanceGroupDeployPolicyArgs']:
        return pulumi.get(self, "deploy_policy")

    @deploy_policy.setter
    def deploy_policy(self, value: pulumi.Input['ComputeInstanceGroupDeployPolicyArgs']):
        pulumi.set(self, "deploy_policy", value)

    @property
    @pulumi.getter(name="instanceTemplate")
    def instance_template(self) -> pulumi.Input['ComputeInstanceGroupInstanceTemplateArgs']:
        return pulumi.get(self, "instance_template")

    @instance_template.setter
    def instance_template(self, value: pulumi.Input['ComputeInstanceGroupInstanceTemplateArgs']):
        pulumi.set(self, "instance_template", value)

    @property
    @pulumi.getter(name="scalePolicy")
    def scale_policy(self) -> pulumi.Input['ComputeInstanceGroupScalePolicyArgs']:
        return pulumi.get(self, "scale_policy")

    @scale_policy.setter
    def scale_policy(self, value: pulumi.Input['ComputeInstanceGroupScalePolicyArgs']):
        pulumi.set(self, "scale_policy", value)

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "service_account_id")

    @service_account_id.setter
    def service_account_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "service_account_id", value)

    @property
    @pulumi.getter(name="applicationLoadBalancer")
    def application_load_balancer(self) -> Optional[pulumi.Input['ComputeInstanceGroupApplicationLoadBalancerArgs']]:
        return pulumi.get(self, "application_load_balancer")

    @application_load_balancer.setter
    def application_load_balancer(self, value: Optional[pulumi.Input['ComputeInstanceGroupApplicationLoadBalancerArgs']]):
        pulumi.set(self, "application_load_balancer", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter(name="healthChecks")
    def health_checks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupHealthCheckArgs']]]]:
        return pulumi.get(self, "health_checks")

    @health_checks.setter
    def health_checks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupHealthCheckArgs']]]]):
        pulumi.set(self, "health_checks", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="loadBalancer")
    def load_balancer(self) -> Optional[pulumi.Input['ComputeInstanceGroupLoadBalancerArgs']]:
        return pulumi.get(self, "load_balancer")

    @load_balancer.setter
    def load_balancer(self, value: Optional[pulumi.Input['ComputeInstanceGroupLoadBalancerArgs']]):
        pulumi.set(self, "load_balancer", value)

    @property
    @pulumi.getter(name="maxCheckingHealthDuration")
    def max_checking_health_duration(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "max_checking_health_duration")

    @max_checking_health_duration.setter
    def max_checking_health_duration(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_checking_health_duration", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def variables(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "variables")

    @variables.setter
    def variables(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "variables", value)


@pulumi.input_type
class _ComputeInstanceGroupState:
    def __init__(__self__, *,
                 allocation_policy: Optional[pulumi.Input['ComputeInstanceGroupAllocationPolicyArgs']] = None,
                 application_load_balancer: Optional[pulumi.Input['ComputeInstanceGroupApplicationLoadBalancerArgs']] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 deploy_policy: Optional[pulumi.Input['ComputeInstanceGroupDeployPolicyArgs']] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 health_checks: Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupHealthCheckArgs']]]] = None,
                 instance_template: Optional[pulumi.Input['ComputeInstanceGroupInstanceTemplateArgs']] = None,
                 instances: Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupInstanceArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 load_balancer: Optional[pulumi.Input['ComputeInstanceGroupLoadBalancerArgs']] = None,
                 max_checking_health_duration: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 scale_policy: Optional[pulumi.Input['ComputeInstanceGroupScalePolicyArgs']] = None,
                 service_account_id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 variables: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        Input properties used for looking up and filtering ComputeInstanceGroup resources.
        """
        if allocation_policy is not None:
            pulumi.set(__self__, "allocation_policy", allocation_policy)
        if application_load_balancer is not None:
            pulumi.set(__self__, "application_load_balancer", application_load_balancer)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if deploy_policy is not None:
            pulumi.set(__self__, "deploy_policy", deploy_policy)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if health_checks is not None:
            pulumi.set(__self__, "health_checks", health_checks)
        if instance_template is not None:
            pulumi.set(__self__, "instance_template", instance_template)
        if instances is not None:
            pulumi.set(__self__, "instances", instances)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if load_balancer is not None:
            pulumi.set(__self__, "load_balancer", load_balancer)
        if max_checking_health_duration is not None:
            pulumi.set(__self__, "max_checking_health_duration", max_checking_health_duration)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if scale_policy is not None:
            pulumi.set(__self__, "scale_policy", scale_policy)
        if service_account_id is not None:
            pulumi.set(__self__, "service_account_id", service_account_id)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if variables is not None:
            pulumi.set(__self__, "variables", variables)

    @property
    @pulumi.getter(name="allocationPolicy")
    def allocation_policy(self) -> Optional[pulumi.Input['ComputeInstanceGroupAllocationPolicyArgs']]:
        return pulumi.get(self, "allocation_policy")

    @allocation_policy.setter
    def allocation_policy(self, value: Optional[pulumi.Input['ComputeInstanceGroupAllocationPolicyArgs']]):
        pulumi.set(self, "allocation_policy", value)

    @property
    @pulumi.getter(name="applicationLoadBalancer")
    def application_load_balancer(self) -> Optional[pulumi.Input['ComputeInstanceGroupApplicationLoadBalancerArgs']]:
        return pulumi.get(self, "application_load_balancer")

    @application_load_balancer.setter
    def application_load_balancer(self, value: Optional[pulumi.Input['ComputeInstanceGroupApplicationLoadBalancerArgs']]):
        pulumi.set(self, "application_load_balancer", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter(name="deployPolicy")
    def deploy_policy(self) -> Optional[pulumi.Input['ComputeInstanceGroupDeployPolicyArgs']]:
        return pulumi.get(self, "deploy_policy")

    @deploy_policy.setter
    def deploy_policy(self, value: Optional[pulumi.Input['ComputeInstanceGroupDeployPolicyArgs']]):
        pulumi.set(self, "deploy_policy", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter(name="healthChecks")
    def health_checks(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupHealthCheckArgs']]]]:
        return pulumi.get(self, "health_checks")

    @health_checks.setter
    def health_checks(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupHealthCheckArgs']]]]):
        pulumi.set(self, "health_checks", value)

    @property
    @pulumi.getter(name="instanceTemplate")
    def instance_template(self) -> Optional[pulumi.Input['ComputeInstanceGroupInstanceTemplateArgs']]:
        return pulumi.get(self, "instance_template")

    @instance_template.setter
    def instance_template(self, value: Optional[pulumi.Input['ComputeInstanceGroupInstanceTemplateArgs']]):
        pulumi.set(self, "instance_template", value)

    @property
    @pulumi.getter
    def instances(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupInstanceArgs']]]]:
        return pulumi.get(self, "instances")

    @instances.setter
    def instances(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ComputeInstanceGroupInstanceArgs']]]]):
        pulumi.set(self, "instances", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="loadBalancer")
    def load_balancer(self) -> Optional[pulumi.Input['ComputeInstanceGroupLoadBalancerArgs']]:
        return pulumi.get(self, "load_balancer")

    @load_balancer.setter
    def load_balancer(self, value: Optional[pulumi.Input['ComputeInstanceGroupLoadBalancerArgs']]):
        pulumi.set(self, "load_balancer", value)

    @property
    @pulumi.getter(name="maxCheckingHealthDuration")
    def max_checking_health_duration(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "max_checking_health_duration")

    @max_checking_health_duration.setter
    def max_checking_health_duration(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_checking_health_duration", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="scalePolicy")
    def scale_policy(self) -> Optional[pulumi.Input['ComputeInstanceGroupScalePolicyArgs']]:
        return pulumi.get(self, "scale_policy")

    @scale_policy.setter
    def scale_policy(self, value: Optional[pulumi.Input['ComputeInstanceGroupScalePolicyArgs']]):
        pulumi.set(self, "scale_policy", value)

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "service_account_id")

    @service_account_id.setter
    def service_account_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "service_account_id", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def variables(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "variables")

    @variables.setter
    def variables(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "variables", value)


class ComputeInstanceGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allocation_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupAllocationPolicyArgs']]] = None,
                 application_load_balancer: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupApplicationLoadBalancerArgs']]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 deploy_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupDeployPolicyArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 health_checks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ComputeInstanceGroupHealthCheckArgs']]]]] = None,
                 instance_template: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupInstanceTemplateArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 load_balancer: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupLoadBalancerArgs']]] = None,
                 max_checking_health_duration: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 scale_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupScalePolicyArgs']]] = None,
                 service_account_id: Optional[pulumi.Input[str]] = None,
                 variables: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Create a ComputeInstanceGroup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ComputeInstanceGroupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ComputeInstanceGroup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ComputeInstanceGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ComputeInstanceGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allocation_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupAllocationPolicyArgs']]] = None,
                 application_load_balancer: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupApplicationLoadBalancerArgs']]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 deploy_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupDeployPolicyArgs']]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 health_checks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ComputeInstanceGroupHealthCheckArgs']]]]] = None,
                 instance_template: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupInstanceTemplateArgs']]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 load_balancer: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupLoadBalancerArgs']]] = None,
                 max_checking_health_duration: Optional[pulumi.Input[int]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 scale_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupScalePolicyArgs']]] = None,
                 service_account_id: Optional[pulumi.Input[str]] = None,
                 variables: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ComputeInstanceGroupArgs.__new__(ComputeInstanceGroupArgs)

            if allocation_policy is None and not opts.urn:
                raise TypeError("Missing required property 'allocation_policy'")
            __props__.__dict__["allocation_policy"] = allocation_policy
            __props__.__dict__["application_load_balancer"] = application_load_balancer
            __props__.__dict__["deletion_protection"] = deletion_protection
            if deploy_policy is None and not opts.urn:
                raise TypeError("Missing required property 'deploy_policy'")
            __props__.__dict__["deploy_policy"] = deploy_policy
            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["health_checks"] = health_checks
            if instance_template is None and not opts.urn:
                raise TypeError("Missing required property 'instance_template'")
            __props__.__dict__["instance_template"] = instance_template
            __props__.__dict__["labels"] = labels
            __props__.__dict__["load_balancer"] = load_balancer
            __props__.__dict__["max_checking_health_duration"] = max_checking_health_duration
            __props__.__dict__["name"] = name
            if scale_policy is None and not opts.urn:
                raise TypeError("Missing required property 'scale_policy'")
            __props__.__dict__["scale_policy"] = scale_policy
            if service_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'service_account_id'")
            __props__.__dict__["service_account_id"] = service_account_id
            __props__.__dict__["variables"] = variables
            __props__.__dict__["created_at"] = None
            __props__.__dict__["instances"] = None
            __props__.__dict__["status"] = None
        super(ComputeInstanceGroup, __self__).__init__(
            'yandex:index/computeInstanceGroup:ComputeInstanceGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            allocation_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupAllocationPolicyArgs']]] = None,
            application_load_balancer: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupApplicationLoadBalancerArgs']]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            deploy_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupDeployPolicyArgs']]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            health_checks: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ComputeInstanceGroupHealthCheckArgs']]]]] = None,
            instance_template: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupInstanceTemplateArgs']]] = None,
            instances: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ComputeInstanceGroupInstanceArgs']]]]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            load_balancer: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupLoadBalancerArgs']]] = None,
            max_checking_health_duration: Optional[pulumi.Input[int]] = None,
            name: Optional[pulumi.Input[str]] = None,
            scale_policy: Optional[pulumi.Input[pulumi.InputType['ComputeInstanceGroupScalePolicyArgs']]] = None,
            service_account_id: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None,
            variables: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'ComputeInstanceGroup':
        """
        Get an existing ComputeInstanceGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ComputeInstanceGroupState.__new__(_ComputeInstanceGroupState)

        __props__.__dict__["allocation_policy"] = allocation_policy
        __props__.__dict__["application_load_balancer"] = application_load_balancer
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["deploy_policy"] = deploy_policy
        __props__.__dict__["description"] = description
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["health_checks"] = health_checks
        __props__.__dict__["instance_template"] = instance_template
        __props__.__dict__["instances"] = instances
        __props__.__dict__["labels"] = labels
        __props__.__dict__["load_balancer"] = load_balancer
        __props__.__dict__["max_checking_health_duration"] = max_checking_health_duration
        __props__.__dict__["name"] = name
        __props__.__dict__["scale_policy"] = scale_policy
        __props__.__dict__["service_account_id"] = service_account_id
        __props__.__dict__["status"] = status
        __props__.__dict__["variables"] = variables
        return ComputeInstanceGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allocationPolicy")
    def allocation_policy(self) -> pulumi.Output['outputs.ComputeInstanceGroupAllocationPolicy']:
        return pulumi.get(self, "allocation_policy")

    @property
    @pulumi.getter(name="applicationLoadBalancer")
    def application_load_balancer(self) -> pulumi.Output[Optional['outputs.ComputeInstanceGroupApplicationLoadBalancer']]:
        return pulumi.get(self, "application_load_balancer")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter(name="deployPolicy")
    def deploy_policy(self) -> pulumi.Output['outputs.ComputeInstanceGroupDeployPolicy']:
        return pulumi.get(self, "deploy_policy")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="healthChecks")
    def health_checks(self) -> pulumi.Output[Optional[Sequence['outputs.ComputeInstanceGroupHealthCheck']]]:
        return pulumi.get(self, "health_checks")

    @property
    @pulumi.getter(name="instanceTemplate")
    def instance_template(self) -> pulumi.Output['outputs.ComputeInstanceGroupInstanceTemplate']:
        return pulumi.get(self, "instance_template")

    @property
    @pulumi.getter
    def instances(self) -> pulumi.Output[Sequence['outputs.ComputeInstanceGroupInstance']]:
        return pulumi.get(self, "instances")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="loadBalancer")
    def load_balancer(self) -> pulumi.Output[Optional['outputs.ComputeInstanceGroupLoadBalancer']]:
        return pulumi.get(self, "load_balancer")

    @property
    @pulumi.getter(name="maxCheckingHealthDuration")
    def max_checking_health_duration(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "max_checking_health_duration")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="scalePolicy")
    def scale_policy(self) -> pulumi.Output['outputs.ComputeInstanceGroupScalePolicy']:
        return pulumi.get(self, "scale_policy")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "service_account_id")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def variables(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        return pulumi.get(self, "variables")

