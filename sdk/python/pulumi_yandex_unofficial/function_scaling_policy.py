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

__all__ = ['FunctionScalingPolicyArgs', 'FunctionScalingPolicy']

@pulumi.input_type
class FunctionScalingPolicyArgs:
    def __init__(__self__, *,
                 function_id: pulumi.Input[str],
                 policies: Optional[pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]]] = None):
        """
        The set of arguments for constructing a FunctionScalingPolicy resource.
        :param pulumi.Input[str] function_id: Yandex Cloud Function id used to define function
        :param pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]] policies: list definition for Yandex Cloud Function scaling policies
               * `policy.#` - number of Yandex Cloud Function scaling policies
               * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
               * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
               * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        pulumi.set(__self__, "function_id", function_id)
        if policies is not None:
            pulumi.set(__self__, "policies", policies)

    @property
    @pulumi.getter(name="functionId")
    def function_id(self) -> pulumi.Input[str]:
        """
        Yandex Cloud Function id used to define function
        """
        return pulumi.get(self, "function_id")

    @function_id.setter
    def function_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "function_id", value)

    @property
    @pulumi.getter
    def policies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]]]:
        """
        list definition for Yandex Cloud Function scaling policies
        * `policy.#` - number of Yandex Cloud Function scaling policies
        * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
        * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
        * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        return pulumi.get(self, "policies")

    @policies.setter
    def policies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]]]):
        pulumi.set(self, "policies", value)


@pulumi.input_type
class _FunctionScalingPolicyState:
    def __init__(__self__, *,
                 function_id: Optional[pulumi.Input[str]] = None,
                 policies: Optional[pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]]] = None):
        """
        Input properties used for looking up and filtering FunctionScalingPolicy resources.
        :param pulumi.Input[str] function_id: Yandex Cloud Function id used to define function
        :param pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]] policies: list definition for Yandex Cloud Function scaling policies
               * `policy.#` - number of Yandex Cloud Function scaling policies
               * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
               * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
               * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        if function_id is not None:
            pulumi.set(__self__, "function_id", function_id)
        if policies is not None:
            pulumi.set(__self__, "policies", policies)

    @property
    @pulumi.getter(name="functionId")
    def function_id(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex Cloud Function id used to define function
        """
        return pulumi.get(self, "function_id")

    @function_id.setter
    def function_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "function_id", value)

    @property
    @pulumi.getter
    def policies(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]]]:
        """
        list definition for Yandex Cloud Function scaling policies
        * `policy.#` - number of Yandex Cloud Function scaling policies
        * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
        * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
        * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        return pulumi.get(self, "policies")

    @policies.setter
    def policies(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FunctionScalingPolicyPolicyArgs']]]]):
        pulumi.set(self, "policies", value)


class FunctionScalingPolicy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 function_id: Optional[pulumi.Input[str]] = None,
                 policies: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FunctionScalingPolicyPolicyArgs']]]]] = None,
                 __props__=None):
        """
        Allows management of [Yandex Cloud Function Scaling Policies](https://cloud.yandex.com/docs/functions/)

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex_unofficial as yandex

        my_scaling_policy = yandex.FunctionScalingPolicy("myScalingPolicy",
            function_id="are1samplefunction11",
            policies=[
                yandex.FunctionScalingPolicyPolicyArgs(
                    tag="$latest",
                    zone_instances_limit=3,
                    zone_requests_limit=100,
                ),
                yandex.FunctionScalingPolicyPolicyArgs(
                    tag="my_tag",
                    zone_instances_limit=4,
                    zone_requests_limit=150,
                ),
            ])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] function_id: Yandex Cloud Function id used to define function
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FunctionScalingPolicyPolicyArgs']]]] policies: list definition for Yandex Cloud Function scaling policies
               * `policy.#` - number of Yandex Cloud Function scaling policies
               * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
               * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
               * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FunctionScalingPolicyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Allows management of [Yandex Cloud Function Scaling Policies](https://cloud.yandex.com/docs/functions/)

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex_unofficial as yandex

        my_scaling_policy = yandex.FunctionScalingPolicy("myScalingPolicy",
            function_id="are1samplefunction11",
            policies=[
                yandex.FunctionScalingPolicyPolicyArgs(
                    tag="$latest",
                    zone_instances_limit=3,
                    zone_requests_limit=100,
                ),
                yandex.FunctionScalingPolicyPolicyArgs(
                    tag="my_tag",
                    zone_instances_limit=4,
                    zone_requests_limit=150,
                ),
            ])
        ```

        :param str resource_name: The name of the resource.
        :param FunctionScalingPolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FunctionScalingPolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 function_id: Optional[pulumi.Input[str]] = None,
                 policies: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FunctionScalingPolicyPolicyArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FunctionScalingPolicyArgs.__new__(FunctionScalingPolicyArgs)

            if function_id is None and not opts.urn:
                raise TypeError("Missing required property 'function_id'")
            __props__.__dict__["function_id"] = function_id
            __props__.__dict__["policies"] = policies
        super(FunctionScalingPolicy, __self__).__init__(
            'yandex:index/functionScalingPolicy:FunctionScalingPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            function_id: Optional[pulumi.Input[str]] = None,
            policies: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FunctionScalingPolicyPolicyArgs']]]]] = None) -> 'FunctionScalingPolicy':
        """
        Get an existing FunctionScalingPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] function_id: Yandex Cloud Function id used to define function
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FunctionScalingPolicyPolicyArgs']]]] policies: list definition for Yandex Cloud Function scaling policies
               * `policy.#` - number of Yandex Cloud Function scaling policies
               * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
               * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
               * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FunctionScalingPolicyState.__new__(_FunctionScalingPolicyState)

        __props__.__dict__["function_id"] = function_id
        __props__.__dict__["policies"] = policies
        return FunctionScalingPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="functionId")
    def function_id(self) -> pulumi.Output[str]:
        """
        Yandex Cloud Function id used to define function
        """
        return pulumi.get(self, "function_id")

    @property
    @pulumi.getter
    def policies(self) -> pulumi.Output[Optional[Sequence['outputs.FunctionScalingPolicyPolicy']]]:
        """
        list definition for Yandex Cloud Function scaling policies
        * `policy.#` - number of Yandex Cloud Function scaling policies
        * `policy.{num}.tag` - Yandex.Cloud Function version tag for Yandex Cloud Function scaling policy
        * `policy.{num}.zone_instances_limit` - max number of instances in one zone for Yandex.Cloud Function with tag
        * `policy.{num}.zone_requests_limit` - max number of requests in one zone for Yandex.Cloud Function with tag
        """
        return pulumi.get(self, "policies")

