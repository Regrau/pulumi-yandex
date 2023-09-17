# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ResourcemanagerFolderIamBindingArgs', 'ResourcemanagerFolderIamBinding']

@pulumi.input_type
class ResourcemanagerFolderIamBindingArgs:
    def __init__(__self__, *,
                 folder_id: pulumi.Input[str],
                 members: pulumi.Input[Sequence[pulumi.Input[str]]],
                 role: pulumi.Input[str],
                 sleep_after: Optional[pulumi.Input[int]] = None):
        """
        The set of arguments for constructing a ResourcemanagerFolderIamBinding resource.
        :param pulumi.Input[str] folder_id: ID of the folder to attach a policy to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] members: An array of identities that will be granted the privilege that is specified in the `role` field.
               Each entry can have one of the following values:
               * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
               * **serviceAccount:{service_account_id}**: A unique service account ID.
               * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
               * **group:{group_id}**: A unique group ID.
               * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        :param pulumi.Input[str] role: The role that should be assigned. Only one
               `ResourcemanagerFolderIamBinding` can be used per role.
        """
        pulumi.set(__self__, "folder_id", folder_id)
        pulumi.set(__self__, "members", members)
        pulumi.set(__self__, "role", role)
        if sleep_after is not None:
            pulumi.set(__self__, "sleep_after", sleep_after)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Input[str]:
        """
        ID of the folder to attach a policy to.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def members(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        An array of identities that will be granted the privilege that is specified in the `role` field.
        Each entry can have one of the following values:
        * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
        * **serviceAccount:{service_account_id}**: A unique service account ID.
        * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        * **group:{group_id}**: A unique group ID.
        * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        """
        return pulumi.get(self, "members")

    @members.setter
    def members(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "members", value)

    @property
    @pulumi.getter
    def role(self) -> pulumi.Input[str]:
        """
        The role that should be assigned. Only one
        `ResourcemanagerFolderIamBinding` can be used per role.
        """
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
class _ResourcemanagerFolderIamBindingState:
    def __init__(__self__, *,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 members: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 sleep_after: Optional[pulumi.Input[int]] = None):
        """
        Input properties used for looking up and filtering ResourcemanagerFolderIamBinding resources.
        :param pulumi.Input[str] folder_id: ID of the folder to attach a policy to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] members: An array of identities that will be granted the privilege that is specified in the `role` field.
               Each entry can have one of the following values:
               * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
               * **serviceAccount:{service_account_id}**: A unique service account ID.
               * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
               * **group:{group_id}**: A unique group ID.
               * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        :param pulumi.Input[str] role: The role that should be assigned. Only one
               `ResourcemanagerFolderIamBinding` can be used per role.
        """
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if members is not None:
            pulumi.set(__self__, "members", members)
        if role is not None:
            pulumi.set(__self__, "role", role)
        if sleep_after is not None:
            pulumi.set(__self__, "sleep_after", sleep_after)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder to attach a policy to.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def members(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        An array of identities that will be granted the privilege that is specified in the `role` field.
        Each entry can have one of the following values:
        * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
        * **serviceAccount:{service_account_id}**: A unique service account ID.
        * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        * **group:{group_id}**: A unique group ID.
        * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        """
        return pulumi.get(self, "members")

    @members.setter
    def members(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "members", value)

    @property
    @pulumi.getter
    def role(self) -> Optional[pulumi.Input[str]]:
        """
        The role that should be assigned. Only one
        `ResourcemanagerFolderIamBinding` can be used per role.
        """
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


class ResourcemanagerFolderIamBinding(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 members: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 sleep_after: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        """
        Allows creation and management of a single binding within IAM policy for
        an existing Yandex Resource Manager folder.

        > **Note:** This resource _must not_ be used in conjunction with
           `ResourcemanagerFolderIamPolicy` or they will conflict over what your policy
           should be.

        > **Note:** When you delete `ResourcemanagerFolderIamBinding` resource,
           the roles can be deleted from other users within the folder as well. Be careful!

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex as yandex
        import pulumi_yandex_unofficial as yandex

        project1 = yandex.get_resourcemanager_folder(folder_id="some_folder_id")
        admin = yandex.ResourcemanagerFolderIamBinding("admin",
            folder_id=project1.id,
            members=["userAccount:some_user_id"],
            role="editor")
        ```

        ## Import

        IAM binding imports use space-delimited identifiers; first the resource in question and then the role. These bindings can be imported using the `folder_id` and role, e.g.

        ```sh
         $ pulumi import yandex:index/resourcemanagerFolderIamBinding:ResourcemanagerFolderIamBinding viewer "folder_id viewer"
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] folder_id: ID of the folder to attach a policy to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] members: An array of identities that will be granted the privilege that is specified in the `role` field.
               Each entry can have one of the following values:
               * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
               * **serviceAccount:{service_account_id}**: A unique service account ID.
               * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
               * **group:{group_id}**: A unique group ID.
               * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        :param pulumi.Input[str] role: The role that should be assigned. Only one
               `ResourcemanagerFolderIamBinding` can be used per role.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ResourcemanagerFolderIamBindingArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Allows creation and management of a single binding within IAM policy for
        an existing Yandex Resource Manager folder.

        > **Note:** This resource _must not_ be used in conjunction with
           `ResourcemanagerFolderIamPolicy` or they will conflict over what your policy
           should be.

        > **Note:** When you delete `ResourcemanagerFolderIamBinding` resource,
           the roles can be deleted from other users within the folder as well. Be careful!

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex as yandex
        import pulumi_yandex_unofficial as yandex

        project1 = yandex.get_resourcemanager_folder(folder_id="some_folder_id")
        admin = yandex.ResourcemanagerFolderIamBinding("admin",
            folder_id=project1.id,
            members=["userAccount:some_user_id"],
            role="editor")
        ```

        ## Import

        IAM binding imports use space-delimited identifiers; first the resource in question and then the role. These bindings can be imported using the `folder_id` and role, e.g.

        ```sh
         $ pulumi import yandex:index/resourcemanagerFolderIamBinding:ResourcemanagerFolderIamBinding viewer "folder_id viewer"
        ```

        :param str resource_name: The name of the resource.
        :param ResourcemanagerFolderIamBindingArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ResourcemanagerFolderIamBindingArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 members: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 sleep_after: Optional[pulumi.Input[int]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ResourcemanagerFolderIamBindingArgs.__new__(ResourcemanagerFolderIamBindingArgs)

            if folder_id is None and not opts.urn:
                raise TypeError("Missing required property 'folder_id'")
            __props__.__dict__["folder_id"] = folder_id
            if members is None and not opts.urn:
                raise TypeError("Missing required property 'members'")
            __props__.__dict__["members"] = members
            if role is None and not opts.urn:
                raise TypeError("Missing required property 'role'")
            __props__.__dict__["role"] = role
            __props__.__dict__["sleep_after"] = sleep_after
        super(ResourcemanagerFolderIamBinding, __self__).__init__(
            'yandex:index/resourcemanagerFolderIamBinding:ResourcemanagerFolderIamBinding',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            members: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            role: Optional[pulumi.Input[str]] = None,
            sleep_after: Optional[pulumi.Input[int]] = None) -> 'ResourcemanagerFolderIamBinding':
        """
        Get an existing ResourcemanagerFolderIamBinding resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] folder_id: ID of the folder to attach a policy to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] members: An array of identities that will be granted the privilege that is specified in the `role` field.
               Each entry can have one of the following values:
               * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
               * **serviceAccount:{service_account_id}**: A unique service account ID.
               * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
               * **group:{group_id}**: A unique group ID.
               * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        :param pulumi.Input[str] role: The role that should be assigned. Only one
               `ResourcemanagerFolderIamBinding` can be used per role.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ResourcemanagerFolderIamBindingState.__new__(_ResourcemanagerFolderIamBindingState)

        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["members"] = members
        __props__.__dict__["role"] = role
        __props__.__dict__["sleep_after"] = sleep_after
        return ResourcemanagerFolderIamBinding(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        ID of the folder to attach a policy to.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def members(self) -> pulumi.Output[Sequence[str]]:
        """
        An array of identities that will be granted the privilege that is specified in the `role` field.
        Each entry can have one of the following values:
        * **userAccount:{user_id}**: An email address that represents a specific Yandex account. For example, ivan@yandex.ru or joe@example.com.
        * **serviceAccount:{service_account_id}**: A unique service account ID.
        * **federatedUser:{federated_user_id}:**: A unique saml federation user account ID.
        * **group:{group_id}**: A unique group ID.
        * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
        """
        return pulumi.get(self, "members")

    @property
    @pulumi.getter
    def role(self) -> pulumi.Output[str]:
        """
        The role that should be assigned. Only one
        `ResourcemanagerFolderIamBinding` can be used per role.
        """
        return pulumi.get(self, "role")

    @property
    @pulumi.getter(name="sleepAfter")
    def sleep_after(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "sleep_after")

