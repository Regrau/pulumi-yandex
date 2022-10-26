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

__all__ = ['AlbHttpRouterArgs', 'AlbHttpRouter']

@pulumi.input_type
class AlbHttpRouterArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 route_options: Optional[pulumi.Input['AlbHttpRouterRouteOptionsArgs']] = None):
        """
        The set of arguments for constructing a AlbHttpRouter resource.
        :param pulumi.Input[str] description: An optional description of the HTTP Router. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this HTTP Router. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if route_options is not None:
            pulumi.set(__self__, "route_options", route_options)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of the HTTP Router. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder to which the resource belongs.
        If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this HTTP Router. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="routeOptions")
    def route_options(self) -> Optional[pulumi.Input['AlbHttpRouterRouteOptionsArgs']]:
        return pulumi.get(self, "route_options")

    @route_options.setter
    def route_options(self, value: Optional[pulumi.Input['AlbHttpRouterRouteOptionsArgs']]):
        pulumi.set(self, "route_options", value)


@pulumi.input_type
class _AlbHttpRouterState:
    def __init__(__self__, *,
                 created_at: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 route_options: Optional[pulumi.Input['AlbHttpRouterRouteOptionsArgs']] = None):
        """
        Input properties used for looking up and filtering AlbHttpRouter resources.
        :param pulumi.Input[str] created_at: The HTTP Router creation timestamp.
        :param pulumi.Input[str] description: An optional description of the HTTP Router. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this HTTP Router. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if route_options is not None:
            pulumi.set(__self__, "route_options", route_options)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        The HTTP Router creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        An optional description of the HTTP Router. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The ID of the folder to which the resource belongs.
        If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Labels to assign to this HTTP Router. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="routeOptions")
    def route_options(self) -> Optional[pulumi.Input['AlbHttpRouterRouteOptionsArgs']]:
        return pulumi.get(self, "route_options")

    @route_options.setter
    def route_options(self, value: Optional[pulumi.Input['AlbHttpRouterRouteOptionsArgs']]):
        pulumi.set(self, "route_options", value)


class AlbHttpRouter(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 route_options: Optional[pulumi.Input[pulumi.InputType['AlbHttpRouterRouteOptionsArgs']]] = None,
                 __props__=None):
        """
        Creates an HTTP Router in the specified folder.
        For more information, see [the official documentation](https://cloud.yandex.com/en/docs/application-load-balancer/concepts/http-router).

        ## Import

        An HTTP Router can be imported using the `id` of the resource, e.g.

        ```sh
         $ pulumi import yandex:index/albHttpRouter:AlbHttpRouter default http_router_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: An optional description of the HTTP Router. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this HTTP Router. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[AlbHttpRouterArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Creates an HTTP Router in the specified folder.
        For more information, see [the official documentation](https://cloud.yandex.com/en/docs/application-load-balancer/concepts/http-router).

        ## Import

        An HTTP Router can be imported using the `id` of the resource, e.g.

        ```sh
         $ pulumi import yandex:index/albHttpRouter:AlbHttpRouter default http_router_id
        ```

        :param str resource_name: The name of the resource.
        :param AlbHttpRouterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(AlbHttpRouterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 route_options: Optional[pulumi.Input[pulumi.InputType['AlbHttpRouterRouteOptionsArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = AlbHttpRouterArgs.__new__(AlbHttpRouterArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            __props__.__dict__["route_options"] = route_options
            __props__.__dict__["created_at"] = None
        super(AlbHttpRouter, __self__).__init__(
            'yandex:index/albHttpRouter:AlbHttpRouter',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            route_options: Optional[pulumi.Input[pulumi.InputType['AlbHttpRouterRouteOptionsArgs']]] = None) -> 'AlbHttpRouter':
        """
        Get an existing AlbHttpRouter resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_at: The HTTP Router creation timestamp.
        :param pulumi.Input[str] description: An optional description of the HTTP Router. Provide this property when
               you create the resource.
        :param pulumi.Input[str] folder_id: The ID of the folder to which the resource belongs.
               If omitted, the provider folder is used.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: Labels to assign to this HTTP Router. A list of key/value pairs.
        :param pulumi.Input[str] name: Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _AlbHttpRouterState.__new__(_AlbHttpRouterState)

        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["description"] = description
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["route_options"] = route_options
        return AlbHttpRouter(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The HTTP Router creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        An optional description of the HTTP Router. Provide this property when
        you create the resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        The ID of the folder to which the resource belongs.
        If omitted, the provider folder is used.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Labels to assign to this HTTP Router. A list of key/value pairs.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the HTTP Router. Provided by the client when the HTTP Router is created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="routeOptions")
    def route_options(self) -> pulumi.Output[Optional['outputs.AlbHttpRouterRouteOptions']]:
        return pulumi.get(self, "route_options")

