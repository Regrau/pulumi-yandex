# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ResourcemanagerFolderIamMemberArgs', 'ResourcemanagerFolderIamMember']

@pulumi.input_type
class ResourcemanagerFolderIamMemberArgs:
    def __init__(__self__, *,
                 folder_id: pulumi.Input[str],
                 member: pulumi.Input[str],
                 role: pulumi.Input[str],
                 sleep_after: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a ResourcemanagerFolderIamMember resource.
        """
        pulumi.set(__self__, "folder_id", folder_id)
        pulumi.set(__self__, "member", member)
        pulumi.set(__self__, "role", role)
        if sleep_after is not None:
            pulumi.set(__self__, "sleep_after", sleep_after)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def member(self) -> pulumi.Input[str]:
        return pulumi.get(self, "member")

    @member.setter
    def member(self, value: pulumi.Input[str]):
        pulumi.set(self, "member", value)

    @property
    @pulumi.getter
    def role(self) -> pulumi.Input[str]:
        return pulumi.get(self, "role")

    @role.setter
    def role(self, value: pulumi.Input[str]):
        pulumi.set(self, "role", value)

    @property
    @pulumi.getter(name="sleepAfter")
    def sleep_after(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "sleep_after")

    @sleep_after.setter
    def sleep_after(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "sleep_after", value)


@pulumi.input_type
class _ResourcemanagerFolderIamMemberState:
    def __init__(__self__, *,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 member: Optional[pulumi.Input[str]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 sleep_after: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering ResourcemanagerFolderIamMember resources.
        """
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if member is not None:
            pulumi.set(__self__, "member", member)
        if role is not None:
            pulumi.set(__self__, "role", role)
        if sleep_after is not None:
            pulumi.set(__self__, "sleep_after", sleep_after)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def member(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "member")

    @member.setter
    def member(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "member", value)

    @property
    @pulumi.getter
    def role(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "role")

    @role.setter
    def role(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "role", value)

    @property
    @pulumi.getter(name="sleepAfter")
    def sleep_after(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "sleep_after")

    @sleep_after.setter
    def sleep_after(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "sleep_after", value)


class ResourcemanagerFolderIamMember(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 member: Optional[pulumi.Input[str]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 sleep_after: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Create a ResourcemanagerFolderIamMember resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ResourcemanagerFolderIamMemberArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ResourcemanagerFolderIamMember resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ResourcemanagerFolderIamMemberArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ResourcemanagerFolderIamMemberArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 member: Optional[pulumi.Input[str]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 sleep_after: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ResourcemanagerFolderIamMemberArgs.__new__(ResourcemanagerFolderIamMemberArgs)

            if folder_id is None and not opts.urn:
                raise TypeError("Missing required property 'folder_id'")
            __props__.__dict__["folder_id"] = folder_id
            if member is None and not opts.urn:
                raise TypeError("Missing required property 'member'")
            __props__.__dict__["member"] = member
            if role is None and not opts.urn:
                raise TypeError("Missing required property 'role'")
            __props__.__dict__["role"] = role
            __props__.__dict__["sleep_after"] = sleep_after
        super(ResourcemanagerFolderIamMember, __self__).__init__(
            'yandex:index/resourcemanagerFolderIamMember:ResourcemanagerFolderIamMember',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            member: Optional[pulumi.Input[str]] = None,
            role: Optional[pulumi.Input[str]] = None,
            sleep_after: Optional[pulumi.Input[int]] = None) -> 'ResourcemanagerFolderIamMember':
        """
        Get an existing ResourcemanagerFolderIamMember resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ResourcemanagerFolderIamMemberState.__new__(_ResourcemanagerFolderIamMemberState)

        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["member"] = member
        __props__.__dict__["role"] = role
        __props__.__dict__["sleep_after"] = sleep_after
        return ResourcemanagerFolderIamMember(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def member(self) -> pulumi.Output[str]:
        return pulumi.get(self, "member")

    @property
    @pulumi.getter
    def role(self) -> pulumi.Output[str]:
        return pulumi.get(self, "role")

    @property
    @pulumi.getter(name="sleepAfter")
    def sleep_after(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "sleep_after")

