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

__all__ = ['MdbSqlServerClusterArgs', 'MdbSqlServerCluster']

@pulumi.input_type
class MdbSqlServerClusterArgs:
    def __init__(__self__, *,
                 databases: pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterDatabaseArgs']]],
                 environment: pulumi.Input[str],
                 hosts: pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterHostArgs']]],
                 network_id: pulumi.Input[str],
                 resources: pulumi.Input['MdbSqlServerClusterResourcesArgs'],
                 users: pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterUserArgs']]],
                 version: pulumi.Input[str],
                 backup_window_start: Optional[pulumi.Input['MdbSqlServerClusterBackupWindowStartArgs']] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 host_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 sqlcollation: Optional[pulumi.Input[str]] = None,
                 sqlserver_config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a MdbSqlServerCluster resource.
        """
        pulumi.set(__self__, "databases", databases)
        pulumi.set(__self__, "environment", environment)
        pulumi.set(__self__, "hosts", hosts)
        pulumi.set(__self__, "network_id", network_id)
        pulumi.set(__self__, "resources", resources)
        pulumi.set(__self__, "users", users)
        pulumi.set(__self__, "version", version)
        if backup_window_start is not None:
            pulumi.set(__self__, "backup_window_start", backup_window_start)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if host_group_ids is not None:
            pulumi.set(__self__, "host_group_ids", host_group_ids)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if sqlcollation is not None:
            pulumi.set(__self__, "sqlcollation", sqlcollation)
        if sqlserver_config is not None:
            pulumi.set(__self__, "sqlserver_config", sqlserver_config)

    @property
    @pulumi.getter
    def databases(self) -> pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterDatabaseArgs']]]:
        return pulumi.get(self, "databases")

    @databases.setter
    def databases(self, value: pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterDatabaseArgs']]]):
        pulumi.set(self, "databases", value)

    @property
    @pulumi.getter
    def environment(self) -> pulumi.Input[str]:
        return pulumi.get(self, "environment")

    @environment.setter
    def environment(self, value: pulumi.Input[str]):
        pulumi.set(self, "environment", value)

    @property
    @pulumi.getter
    def hosts(self) -> pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterHostArgs']]]:
        return pulumi.get(self, "hosts")

    @hosts.setter
    def hosts(self, value: pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterHostArgs']]]):
        pulumi.set(self, "hosts", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter
    def resources(self) -> pulumi.Input['MdbSqlServerClusterResourcesArgs']:
        return pulumi.get(self, "resources")

    @resources.setter
    def resources(self, value: pulumi.Input['MdbSqlServerClusterResourcesArgs']):
        pulumi.set(self, "resources", value)

    @property
    @pulumi.getter
    def users(self) -> pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterUserArgs']]]:
        return pulumi.get(self, "users")

    @users.setter
    def users(self, value: pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterUserArgs']]]):
        pulumi.set(self, "users", value)

    @property
    @pulumi.getter
    def version(self) -> pulumi.Input[str]:
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: pulumi.Input[str]):
        pulumi.set(self, "version", value)

    @property
    @pulumi.getter(name="backupWindowStart")
    def backup_window_start(self) -> Optional[pulumi.Input['MdbSqlServerClusterBackupWindowStartArgs']]:
        return pulumi.get(self, "backup_window_start")

    @backup_window_start.setter
    def backup_window_start(self, value: Optional[pulumi.Input['MdbSqlServerClusterBackupWindowStartArgs']]):
        pulumi.set(self, "backup_window_start", value)

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
    @pulumi.getter(name="hostGroupIds")
    def host_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "host_group_ids")

    @host_group_ids.setter
    def host_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "host_group_ids", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)

    @property
    @pulumi.getter
    def sqlcollation(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "sqlcollation")

    @sqlcollation.setter
    def sqlcollation(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sqlcollation", value)

    @property
    @pulumi.getter(name="sqlserverConfig")
    def sqlserver_config(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "sqlserver_config")

    @sqlserver_config.setter
    def sqlserver_config(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "sqlserver_config", value)


@pulumi.input_type
class _MdbSqlServerClusterState:
    def __init__(__self__, *,
                 backup_window_start: Optional[pulumi.Input['MdbSqlServerClusterBackupWindowStartArgs']] = None,
                 created_at: Optional[pulumi.Input[str]] = None,
                 databases: Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterDatabaseArgs']]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 health: Optional[pulumi.Input[str]] = None,
                 host_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 hosts: Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterHostArgs']]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 resources: Optional[pulumi.Input['MdbSqlServerClusterResourcesArgs']] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 sqlcollation: Optional[pulumi.Input[str]] = None,
                 sqlserver_config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterUserArgs']]]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering MdbSqlServerCluster resources.
        """
        if backup_window_start is not None:
            pulumi.set(__self__, "backup_window_start", backup_window_start)
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if databases is not None:
            pulumi.set(__self__, "databases", databases)
        if deletion_protection is not None:
            pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if environment is not None:
            pulumi.set(__self__, "environment", environment)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if health is not None:
            pulumi.set(__self__, "health", health)
        if host_group_ids is not None:
            pulumi.set(__self__, "host_group_ids", host_group_ids)
        if hosts is not None:
            pulumi.set(__self__, "hosts", hosts)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if network_id is not None:
            pulumi.set(__self__, "network_id", network_id)
        if resources is not None:
            pulumi.set(__self__, "resources", resources)
        if security_group_ids is not None:
            pulumi.set(__self__, "security_group_ids", security_group_ids)
        if sqlcollation is not None:
            pulumi.set(__self__, "sqlcollation", sqlcollation)
        if sqlserver_config is not None:
            pulumi.set(__self__, "sqlserver_config", sqlserver_config)
        if status is not None:
            pulumi.set(__self__, "status", status)
        if users is not None:
            pulumi.set(__self__, "users", users)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="backupWindowStart")
    def backup_window_start(self) -> Optional[pulumi.Input['MdbSqlServerClusterBackupWindowStartArgs']]:
        return pulumi.get(self, "backup_window_start")

    @backup_window_start.setter
    def backup_window_start(self, value: Optional[pulumi.Input['MdbSqlServerClusterBackupWindowStartArgs']]):
        pulumi.set(self, "backup_window_start", value)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter
    def databases(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterDatabaseArgs']]]]:
        return pulumi.get(self, "databases")

    @databases.setter
    def databases(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterDatabaseArgs']]]]):
        pulumi.set(self, "databases", value)

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
    @pulumi.getter
    def environment(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "environment")

    @environment.setter
    def environment(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "environment", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def health(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "health")

    @health.setter
    def health(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "health", value)

    @property
    @pulumi.getter(name="hostGroupIds")
    def host_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "host_group_ids")

    @host_group_ids.setter
    def host_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "host_group_ids", value)

    @property
    @pulumi.getter
    def hosts(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterHostArgs']]]]:
        return pulumi.get(self, "hosts")

    @hosts.setter
    def hosts(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterHostArgs']]]]):
        pulumi.set(self, "hosts", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "network_id")

    @network_id.setter
    def network_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "network_id", value)

    @property
    @pulumi.getter
    def resources(self) -> Optional[pulumi.Input['MdbSqlServerClusterResourcesArgs']]:
        return pulumi.get(self, "resources")

    @resources.setter
    def resources(self, value: Optional[pulumi.Input['MdbSqlServerClusterResourcesArgs']]):
        pulumi.set(self, "resources", value)

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "security_group_ids")

    @security_group_ids.setter
    def security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "security_group_ids", value)

    @property
    @pulumi.getter
    def sqlcollation(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "sqlcollation")

    @sqlcollation.setter
    def sqlcollation(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sqlcollation", value)

    @property
    @pulumi.getter(name="sqlserverConfig")
    def sqlserver_config(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        return pulumi.get(self, "sqlserver_config")

    @sqlserver_config.setter
    def sqlserver_config(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "sqlserver_config", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)

    @property
    @pulumi.getter
    def users(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterUserArgs']]]]:
        return pulumi.get(self, "users")

    @users.setter
    def users(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MdbSqlServerClusterUserArgs']]]]):
        pulumi.set(self, "users", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


class MdbSqlServerCluster(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_window_start: Optional[pulumi.Input[pulumi.InputType['MdbSqlServerClusterBackupWindowStartArgs']]] = None,
                 databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterDatabaseArgs']]]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 host_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 hosts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterHostArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 resources: Optional[pulumi.Input[pulumi.InputType['MdbSqlServerClusterResourcesArgs']]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 sqlcollation: Optional[pulumi.Input[str]] = None,
                 sqlserver_config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterUserArgs']]]]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a MdbSqlServerCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: MdbSqlServerClusterArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a MdbSqlServerCluster resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param MdbSqlServerClusterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MdbSqlServerClusterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_window_start: Optional[pulumi.Input[pulumi.InputType['MdbSqlServerClusterBackupWindowStartArgs']]] = None,
                 databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterDatabaseArgs']]]]] = None,
                 deletion_protection: Optional[pulumi.Input[bool]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 environment: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 host_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 hosts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterHostArgs']]]]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 network_id: Optional[pulumi.Input[str]] = None,
                 resources: Optional[pulumi.Input[pulumi.InputType['MdbSqlServerClusterResourcesArgs']]] = None,
                 security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 sqlcollation: Optional[pulumi.Input[str]] = None,
                 sqlserver_config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 users: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterUserArgs']]]]] = None,
                 version: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MdbSqlServerClusterArgs.__new__(MdbSqlServerClusterArgs)

            __props__.__dict__["backup_window_start"] = backup_window_start
            if databases is None and not opts.urn:
                raise TypeError("Missing required property 'databases'")
            __props__.__dict__["databases"] = databases
            __props__.__dict__["deletion_protection"] = deletion_protection
            __props__.__dict__["description"] = description
            if environment is None and not opts.urn:
                raise TypeError("Missing required property 'environment'")
            __props__.__dict__["environment"] = environment
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["host_group_ids"] = host_group_ids
            if hosts is None and not opts.urn:
                raise TypeError("Missing required property 'hosts'")
            __props__.__dict__["hosts"] = hosts
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            if network_id is None and not opts.urn:
                raise TypeError("Missing required property 'network_id'")
            __props__.__dict__["network_id"] = network_id
            if resources is None and not opts.urn:
                raise TypeError("Missing required property 'resources'")
            __props__.__dict__["resources"] = resources
            __props__.__dict__["security_group_ids"] = security_group_ids
            __props__.__dict__["sqlcollation"] = sqlcollation
            __props__.__dict__["sqlserver_config"] = sqlserver_config
            if users is None and not opts.urn:
                raise TypeError("Missing required property 'users'")
            __props__.__dict__["users"] = users
            if version is None and not opts.urn:
                raise TypeError("Missing required property 'version'")
            __props__.__dict__["version"] = version
            __props__.__dict__["created_at"] = None
            __props__.__dict__["health"] = None
            __props__.__dict__["status"] = None
        super(MdbSqlServerCluster, __self__).__init__(
            'yandex:index/mdbSqlServerCluster:MdbSqlServerCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            backup_window_start: Optional[pulumi.Input[pulumi.InputType['MdbSqlServerClusterBackupWindowStartArgs']]] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            databases: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterDatabaseArgs']]]]] = None,
            deletion_protection: Optional[pulumi.Input[bool]] = None,
            description: Optional[pulumi.Input[str]] = None,
            environment: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            health: Optional[pulumi.Input[str]] = None,
            host_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            hosts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterHostArgs']]]]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            network_id: Optional[pulumi.Input[str]] = None,
            resources: Optional[pulumi.Input[pulumi.InputType['MdbSqlServerClusterResourcesArgs']]] = None,
            security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            sqlcollation: Optional[pulumi.Input[str]] = None,
            sqlserver_config: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            status: Optional[pulumi.Input[str]] = None,
            users: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MdbSqlServerClusterUserArgs']]]]] = None,
            version: Optional[pulumi.Input[str]] = None) -> 'MdbSqlServerCluster':
        """
        Get an existing MdbSqlServerCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _MdbSqlServerClusterState.__new__(_MdbSqlServerClusterState)

        __props__.__dict__["backup_window_start"] = backup_window_start
        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["databases"] = databases
        __props__.__dict__["deletion_protection"] = deletion_protection
        __props__.__dict__["description"] = description
        __props__.__dict__["environment"] = environment
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["health"] = health
        __props__.__dict__["host_group_ids"] = host_group_ids
        __props__.__dict__["hosts"] = hosts
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["network_id"] = network_id
        __props__.__dict__["resources"] = resources
        __props__.__dict__["security_group_ids"] = security_group_ids
        __props__.__dict__["sqlcollation"] = sqlcollation
        __props__.__dict__["sqlserver_config"] = sqlserver_config
        __props__.__dict__["status"] = status
        __props__.__dict__["users"] = users
        __props__.__dict__["version"] = version
        return MdbSqlServerCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backupWindowStart")
    def backup_window_start(self) -> pulumi.Output['outputs.MdbSqlServerClusterBackupWindowStart']:
        return pulumi.get(self, "backup_window_start")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def databases(self) -> pulumi.Output[Sequence['outputs.MdbSqlServerClusterDatabase']]:
        return pulumi.get(self, "databases")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> pulumi.Output[bool]:
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def environment(self) -> pulumi.Output[str]:
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def health(self) -> pulumi.Output[str]:
        return pulumi.get(self, "health")

    @property
    @pulumi.getter(name="hostGroupIds")
    def host_group_ids(self) -> pulumi.Output[Sequence[str]]:
        return pulumi.get(self, "host_group_ids")

    @property
    @pulumi.getter
    def hosts(self) -> pulumi.Output[Sequence['outputs.MdbSqlServerClusterHost']]:
        return pulumi.get(self, "hosts")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter
    def resources(self) -> pulumi.Output['outputs.MdbSqlServerClusterResources']:
        return pulumi.get(self, "resources")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter
    def sqlcollation(self) -> pulumi.Output[str]:
        return pulumi.get(self, "sqlcollation")

    @property
    @pulumi.getter(name="sqlserverConfig")
    def sqlserver_config(self) -> pulumi.Output[Mapping[str, str]]:
        return pulumi.get(self, "sqlserver_config")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[str]:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def users(self) -> pulumi.Output[Sequence['outputs.MdbSqlServerClusterUser']]:
        return pulumi.get(self, "users")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        return pulumi.get(self, "version")

