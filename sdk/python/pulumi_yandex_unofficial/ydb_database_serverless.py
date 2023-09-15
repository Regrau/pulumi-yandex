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

__all__ = ['YdbDatabaseServerlessArgs', 'YdbDatabaseServerless']

@pulumi.input_type
class YdbDatabaseServerlessArgs:
    def __init__(__self__, *,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 serverless_databases: Optional[pulumi.Input[Sequence[pulumi.Input['YdbDatabaseServerlessServerlessDatabaseArgs']]]] = None):
        """
        The set of arguments for constructing a YdbDatabaseServerless resource.
        :param pulumi.Input[bool] deletion_protection: Inhibits deletion of the database. Can be either `true` or `false`
        :param pulumi.Input[str] description: A description for the Yandex Database serverless cluster.
        :param pulumi.Input[str] folder_id: ID of the folder that the Yandex Database serverless cluster belongs to.
               It will be deduced from provider configuration if not set explicitly.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        :param pulumi.Input[str] location_id: Location ID for the Yandex Database serverless cluster.
        :param pulumi.Input[str] name: Name for the Yandex Database serverless cluster.
        """
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if location_id is not None:
            pulumi.set(__self__, "location_id", location_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if serverless_databases is not None:
            pulumi.set(__self__, "serverless_databases", serverless_databases)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Inhibits deletion of the database. Can be either `true` or `false`
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        A description for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder that the Yandex Database serverless cluster belongs to.
        It will be deduced from provider configuration if not set explicitly.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="locationId")
    def location_id(self) -> Optional[pulumi.Input[str]]:
        """
        Location ID for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "location_id")

    @location_id.setter
    def location_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="serverlessDatabases")
    def serverless_databases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['YdbDatabaseServerlessServerlessDatabaseArgs']]]]:
        return pulumi.get(self, "serverless_databases")

    @serverless_databases.setter
    def serverless_databases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['YdbDatabaseServerlessServerlessDatabaseArgs']]]]):
        pulumi.set(self, "serverless_databases", value)


@pulumi.input_type
class _YdbDatabaseServerlessState:
    def __init__(__self__, *,
                 created_at: Optional[pulumi.Input[str]] = None,
                 database_path: Optional[pulumi.Input[str]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 document_api_endpoint: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 serverless_databases: Optional[pulumi.Input[Sequence[pulumi.Input['YdbDatabaseServerlessServerlessDatabaseArgs']]]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 tls_enabled: Optional[pulumi.Input[bool]] = None,
                 ydb_api_endpoint: Optional[pulumi.Input[str]] = None,
                 ydb_full_endpoint: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering YdbDatabaseServerless resources.
        :param pulumi.Input[str] created_at: The Yandex Database serverless cluster creation timestamp.
        :param pulumi.Input[str] database_path: Full database path of the Yandex Database serverless cluster.
               Useful for SDK configuration.
        :param pulumi.Input[bool] deletion_protection: Inhibits deletion of the database. Can be either `true` or `false`
        :param pulumi.Input[str] description: A description for the Yandex Database serverless cluster.
        :param pulumi.Input[str] document_api_endpoint: Document API endpoint of the Yandex Database serverless cluster.
        :param pulumi.Input[str] folder_id: ID of the folder that the Yandex Database serverless cluster belongs to.
               It will be deduced from provider configuration if not set explicitly.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        :param pulumi.Input[str] location_id: Location ID for the Yandex Database serverless cluster.
        :param pulumi.Input[str] name: Name for the Yandex Database serverless cluster.
        :param pulumi.Input[str] status: Status of the Yandex Database serverless cluster.
        :param pulumi.Input[bool] tls_enabled: Whether TLS is enabled for the Yandex Database serverless cluster.
               Useful for SDK configuration.
        :param pulumi.Input[str] ydb_api_endpoint: API endpoint of the Yandex Database serverless cluster.
               Useful for SDK configuration.
        :param pulumi.Input[str] ydb_full_endpoint: Full endpoint of the Yandex Database serverless cluster.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if database_path is not None:
            pulumi.set(__self__, "database_path", database_path)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if document_api_endpoint is not None:
            pulumi.set(__self__, "document_api_endpoint", document_api_endpoint)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if location_id is not None:
            pulumi.set(__self__, "location_id", location_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if serverless_databases is not None:
            pulumi.set(__self__, "serverless_databases", serverless_databases)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if tls_enabled is not None:
            pulumi.set(__self__, "tls_enabled", tls_enabled)
        if ydb_api_endpoint is not None:
            pulumi.set(__self__, "ydb_api_endpoint", ydb_api_endpoint)
        if ydb_full_endpoint is not None:
            pulumi.set(__self__, "ydb_full_endpoint", ydb_full_endpoint)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        The Yandex Database serverless cluster creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="databasePath")
    def database_path(self) -> Optional[pulumi.Input[str]]:
        """
        Full database path of the Yandex Database serverless cluster.
        Useful for SDK configuration.
        """
        return pulumi.get(self, "database_path")

    @database_path.setter
    def database_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "database_path", value)

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Inhibits deletion of the database. Can be either `true` or `false`
        """
        return pulumi.get(self, "deletion_protection")

    @deletion_protection.setter
    def deletion_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "deletion_protection", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        A description for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="documentApiEndpoint")
    def document_api_endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        Document API endpoint of the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "document_api_endpoint")

    @document_api_endpoint.setter
    def document_api_endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "document_api_endpoint", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the folder that the Yandex Database serverless cluster belongs to.
        It will be deduced from provider configuration if not set explicitly.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter(name="locationId")
    def location_id(self) -> Optional[pulumi.Input[str]]:
        """
        Location ID for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "location_id")

    @location_id.setter
    def location_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="serverlessDatabases")
    def serverless_databases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['YdbDatabaseServerlessServerlessDatabaseArgs']]]]:
        return pulumi.get(self, "serverless_databases")

    @serverless_databases.setter
    def serverless_databases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['YdbDatabaseServerlessServerlessDatabaseArgs']]]]):
        pulumi.set(self, "serverless_databases", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Status of the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter(name="tlsEnabled")
    def tls_enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether TLS is enabled for the Yandex Database serverless cluster.
        Useful for SDK configuration.
        """
        return pulumi.get(self, "tls_enabled")

    @tls_enabled.setter
    def tls_enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "tls_enabled", value)

    @property
    @pulumi.getter(name="ydbApiEndpoint")
    def ydb_api_endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        API endpoint of the Yandex Database serverless cluster.
        Useful for SDK configuration.
        """
        return pulumi.get(self, "ydb_api_endpoint")

    @ydb_api_endpoint.setter
    def ydb_api_endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ydb_api_endpoint", value)

    @property
    @pulumi.getter(name="ydbFullEndpoint")
    def ydb_full_endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        Full endpoint of the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "ydb_full_endpoint")

    @ydb_full_endpoint.setter
    def ydb_full_endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ydb_full_endpoint", value)


class YdbDatabaseServerless(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 serverless_databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['YdbDatabaseServerlessServerlessDatabaseArgs']]]]] = None,
                 __props__=None):
        """
        Yandex Database (serverless) resource. For more information, see
            [the official documentation](https://cloud.yandex.com/en/docs/ydb/concepts/serverless_and_dedicated).

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex_unofficial as yandex

        database1 = yandex.YdbDatabaseServerless("database1",
            deletion_protection=True,
            folder_id=data["yandex_resourcemanager_folder"]["test_folder"]["id"])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] deletion_protection: Inhibits deletion of the database. Can be either `true` or `false`
        :param pulumi.Input[str] description: A description for the Yandex Database serverless cluster.
        :param pulumi.Input[str] folder_id: ID of the folder that the Yandex Database serverless cluster belongs to.
               It will be deduced from provider configuration if not set explicitly.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        :param pulumi.Input[str] location_id: Location ID for the Yandex Database serverless cluster.
        :param pulumi.Input[str] name: Name for the Yandex Database serverless cluster.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[YdbDatabaseServerlessArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Yandex Database (serverless) resource. For more information, see
            [the official documentation](https://cloud.yandex.com/en/docs/ydb/concepts/serverless_and_dedicated).

        ## Example Usage

        ```python
        import pulumi
        import pulumi_yandex_unofficial as yandex

        database1 = yandex.YdbDatabaseServerless("database1",
            deletion_protection=True,
            folder_id=data["yandex_resourcemanager_folder"]["test_folder"]["id"])
        ```

        :param str resource_name: The name of the resource.
        :param YdbDatabaseServerlessArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(YdbDatabaseServerlessArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 location_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 serverless_databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['YdbDatabaseServerlessServerlessDatabaseArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = YdbDatabaseServerlessArgs.__new__(YdbDatabaseServerlessArgs)

            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["location_id"] = location_id
            __props__.__dict__["name"] = name
            __props__.__dict__["serverless_databases"] = serverless_databases
            __props__.__dict__["created_at"] = None
            __props__.__dict__["database_path"] = None
            __props__.__dict__["document_api_endpoint"] = None
            __props__.__dict__["status"] = None
            __props__.__dict__["tls_enabled"] = None
            __props__.__dict__["ydb_api_endpoint"] = None
            __props__.__dict__["ydb_full_endpoint"] = None
        super(YdbDatabaseServerless, __self__).__init__(
            'yandex:index/ydbDatabaseServerless:YdbDatabaseServerless',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            database_path: Optional[pulumi.Input[str]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            document_api_endpoint: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            location_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            serverless_databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['YdbDatabaseServerlessServerlessDatabaseArgs']]]]] = None,
            status: Optional[pulumi.Input[str]] = None,
            tls_enabled: Optional[pulumi.Input[bool]] = None,
            ydb_api_endpoint: Optional[pulumi.Input[str]] = None,
            ydb_full_endpoint: Optional[pulumi.Input[str]] = None) -> 'YdbDatabaseServerless':
        """
        Get an existing YdbDatabaseServerless resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_at: The Yandex Database serverless cluster creation timestamp.
        :param pulumi.Input[str] database_path: Full database path of the Yandex Database serverless cluster.
               Useful for SDK configuration.
        :param pulumi.Input[bool] deletion_protection: Inhibits deletion of the database. Can be either `true` or `false`
        :param pulumi.Input[str] description: A description for the Yandex Database serverless cluster.
        :param pulumi.Input[str] document_api_endpoint: Document API endpoint of the Yandex Database serverless cluster.
        :param pulumi.Input[str] folder_id: ID of the folder that the Yandex Database serverless cluster belongs to.
               It will be deduced from provider configuration if not set explicitly.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        :param pulumi.Input[str] location_id: Location ID for the Yandex Database serverless cluster.
        :param pulumi.Input[str] name: Name for the Yandex Database serverless cluster.
        :param pulumi.Input[str] status: Status of the Yandex Database serverless cluster.
        :param pulumi.Input[bool] tls_enabled: Whether TLS is enabled for the Yandex Database serverless cluster.
               Useful for SDK configuration.
        :param pulumi.Input[str] ydb_api_endpoint: API endpoint of the Yandex Database serverless cluster.
               Useful for SDK configuration.
        :param pulumi.Input[str] ydb_full_endpoint: Full endpoint of the Yandex Database serverless cluster.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _YdbDatabaseServerlessState.__new__(_YdbDatabaseServerlessState)

        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["database_path"] = database_path
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["description"] = description
        __props__.__dict__["document_api_endpoint"] = document_api_endpoint
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["location_id"] = location_id
        __props__.__dict__["name"] = name
        __props__.__dict__["serverless_databases"] = serverless_databases
        __props__.__dict__["status"] = status
        __props__.__dict__["tls_enabled"] = tls_enabled
        __props__.__dict__["ydb_api_endpoint"] = ydb_api_endpoint
        __props__.__dict__["ydb_full_endpoint"] = ydb_full_endpoint
        return YdbDatabaseServerless(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The Yandex Database serverless cluster creation timestamp.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="databasePath")
    def database_path(self) -> pulumi.Output[str]:
        """
        Full database path of the Yandex Database serverless cluster.
        Useful for SDK configuration.
        """
        return pulumi.get(self, "database_path")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[Optional[bool]]:
        """
        Inhibits deletion of the database. Can be either `true` or `false`
        """
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        A description for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="documentApiEndpoint")
    def document_api_endpoint(self) -> pulumi.Output[str]:
        """
        Document API endpoint of the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "document_api_endpoint")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        ID of the folder that the Yandex Database serverless cluster belongs to.
        It will be deduced from provider configuration if not set explicitly.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="locationId")
    def location_id(self) -> pulumi.Output[str]:
        """
        Location ID for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "location_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name for the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="serverlessDatabases")
    def serverless_databases(self) -> pulumi.Output[Sequence['outputs.YdbDatabaseServerlessServerlessDatabase']]:
        return pulumi.get(self, "serverless_databases")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        """
        Status of the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="tlsEnabled")
    def tls_enabled(self) -> pulumi.Output[bool]:
        """
        Whether TLS is enabled for the Yandex Database serverless cluster.
        Useful for SDK configuration.
        """
        return pulumi.get(self, "tls_enabled")

    @property
    @pulumi.getter(name="ydbApiEndpoint")
    def ydb_api_endpoint(self) -> pulumi.Output[str]:
        """
        API endpoint of the Yandex Database serverless cluster.
        Useful for SDK configuration.
        """
        return pulumi.get(self, "ydb_api_endpoint")

    @property
    @pulumi.getter(name="ydbFullEndpoint")
    def ydb_full_endpoint(self) -> pulumi.Output[str]:
        """
        Full endpoint of the Yandex Database serverless cluster.
        """
        return pulumi.get(self, "ydb_full_endpoint")

