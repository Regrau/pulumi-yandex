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

__all__ = [
    'GetMdbClickhouseClusterResult',
    'AwaitableGetMdbClickhouseClusterResult',
    'get_mdb_clickhouse_cluster',
    'get_mdb_clickhouse_cluster_output',
]

@pulumi.output_type
class GetMdbClickhouseClusterResult:
    """
    A collection of values returned by getMdbClickhouseCluster.
    """
    def __init__(__self__, access=None, admin_password=None, backup_window_start=None, clickhouse=None, cloud_storage=None, cluster_id=None, copy_schema_on_new_hosts=None, created_at=None, databases=None, deletion_protection=None, description=None, embedded_keeper=None, environment=None, folder_id=None, format_schemas=None, health=None, hosts=None, id=None, labels=None, maintenance_window=None, ml_models=None, name=None, network_id=None, security_group_ids=None, service_account_id=None, shard_groups=None, shards=None, sql_database_management=None, sql_user_management=None, status=None, users=None, version=None, zookeeper=None):
        if access and not isinstance(access, dict):
            raise TypeError("Expected argument 'access' to be a dict")
        pulumi.set(__self__, "access", access)
        if admin_password and not isinstance(admin_password, str):
            raise TypeError("Expected argument 'admin_password' to be a str")
        pulumi.set(__self__, "admin_password", admin_password)
        if backup_window_start and not isinstance(backup_window_start, dict):
            raise TypeError("Expected argument 'backup_window_start' to be a dict")
        pulumi.set(__self__, "backup_window_start", backup_window_start)
        if clickhouse and not isinstance(clickhouse, dict):
            raise TypeError("Expected argument 'clickhouse' to be a dict")
        pulumi.set(__self__, "clickhouse", clickhouse)
        if cloud_storage and not isinstance(cloud_storage, dict):
            raise TypeError("Expected argument 'cloud_storage' to be a dict")
        pulumi.set(__self__, "cloud_storage", cloud_storage)
        if cluster_id and not isinstance(cluster_id, str):
            raise TypeError("Expected argument 'cluster_id' to be a str")
        pulumi.set(__self__, "cluster_id", cluster_id)
        if copy_schema_on_new_hosts and not isinstance(copy_schema_on_new_hosts, bool):
            raise TypeError("Expected argument 'copy_schema_on_new_hosts' to be a bool")
        pulumi.set(__self__, "copy_schema_on_new_hosts", copy_schema_on_new_hosts)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if databases and not isinstance(databases, list):
            raise TypeError("Expected argument 'databases' to be a list")
        pulumi.set(__self__, "databases", databases)
        if deletion_protection and not isinstance(deletion_protection, bool):
            raise TypeError("Expected argument 'deletion_protection' to be a bool")
        pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if embedded_keeper and not isinstance(embedded_keeper, bool):
            raise TypeError("Expected argument 'embedded_keeper' to be a bool")
        pulumi.set(__self__, "embedded_keeper", embedded_keeper)
        if environment and not isinstance(environment, str):
            raise TypeError("Expected argument 'environment' to be a str")
        pulumi.set(__self__, "environment", environment)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if format_schemas and not isinstance(format_schemas, list):
            raise TypeError("Expected argument 'format_schemas' to be a list")
        pulumi.set(__self__, "format_schemas", format_schemas)
        if health and not isinstance(health, str):
            raise TypeError("Expected argument 'health' to be a str")
        pulumi.set(__self__, "health", health)
        if hosts and not isinstance(hosts, list):
            raise TypeError("Expected argument 'hosts' to be a list")
        pulumi.set(__self__, "hosts", hosts)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if maintenance_window and not isinstance(maintenance_window, dict):
            raise TypeError("Expected argument 'maintenance_window' to be a dict")
        pulumi.set(__self__, "maintenance_window", maintenance_window)
        if ml_models and not isinstance(ml_models, list):
            raise TypeError("Expected argument 'ml_models' to be a list")
        pulumi.set(__self__, "ml_models", ml_models)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if network_id and not isinstance(network_id, str):
            raise TypeError("Expected argument 'network_id' to be a str")
        pulumi.set(__self__, "network_id", network_id)
        if security_group_ids and not isinstance(security_group_ids, list):
            raise TypeError("Expected argument 'security_group_ids' to be a list")
        pulumi.set(__self__, "security_group_ids", security_group_ids)
        if service_account_id and not isinstance(service_account_id, str):
            raise TypeError("Expected argument 'service_account_id' to be a str")
        pulumi.set(__self__, "service_account_id", service_account_id)
        if shard_groups and not isinstance(shard_groups, list):
            raise TypeError("Expected argument 'shard_groups' to be a list")
        pulumi.set(__self__, "shard_groups", shard_groups)
        if shards and not isinstance(shards, list):
            raise TypeError("Expected argument 'shards' to be a list")
        pulumi.set(__self__, "shards", shards)
        if sql_database_management and not isinstance(sql_database_management, bool):
            raise TypeError("Expected argument 'sql_database_management' to be a bool")
        pulumi.set(__self__, "sql_database_management", sql_database_management)
        if sql_user_management and not isinstance(sql_user_management, bool):
            raise TypeError("Expected argument 'sql_user_management' to be a bool")
        pulumi.set(__self__, "sql_user_management", sql_user_management)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if users and not isinstance(users, list):
            raise TypeError("Expected argument 'users' to be a list")
        pulumi.set(__self__, "users", users)
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        pulumi.set(__self__, "version", version)
        if zookeeper and not isinstance(zookeeper, dict):
            raise TypeError("Expected argument 'zookeeper' to be a dict")
        pulumi.set(__self__, "zookeeper", zookeeper)

    @property
    @pulumi.getter
    def access(self) -> 'outputs.GetMdbClickhouseClusterAccessResult':
        """
        Access policy to the ClickHouse cluster. The structure is documented below.
        """
        return pulumi.get(self, "access")

    @property
    @pulumi.getter(name="adminPassword")
    def admin_password(self) -> Optional[str]:
        return pulumi.get(self, "admin_password")

    @property
    @pulumi.getter(name="backupWindowStart")
    def backup_window_start(self) -> 'outputs.GetMdbClickhouseClusterBackupWindowStartResult':
        """
        Time to start the daily backup, in the UTC timezone. The structure is documented below.
        """
        return pulumi.get(self, "backup_window_start")

    @property
    @pulumi.getter
    def clickhouse(self) -> 'outputs.GetMdbClickhouseClusterClickhouseResult':
        """
        Configuration of the ClickHouse subcluster. The structure is documented below.
        """
        return pulumi.get(self, "clickhouse")

    @property
    @pulumi.getter(name="cloudStorage")
    def cloud_storage(self) -> 'outputs.GetMdbClickhouseClusterCloudStorageResult':
        return pulumi.get(self, "cloud_storage")

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> str:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="copySchemaOnNewHosts")
    def copy_schema_on_new_hosts(self) -> Optional[bool]:
        return pulumi.get(self, "copy_schema_on_new_hosts")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        """
        Creation timestamp of the key.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter
    def databases(self) -> Optional[Sequence['outputs.GetMdbClickhouseClusterDatabaseResult']]:
        """
        A database of the ClickHouse cluster. The structure is documented below.
        """
        return pulumi.get(self, "databases")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> bool:
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        """
        Description of the shard group.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="embeddedKeeper")
    def embedded_keeper(self) -> bool:
        """
        Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
        """
        return pulumi.get(self, "embedded_keeper")

    @property
    @pulumi.getter
    def environment(self) -> Optional[str]:
        """
        Deployment environment of the ClickHouse cluster.
        """
        return pulumi.get(self, "environment")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="formatSchemas")
    def format_schemas(self) -> Optional[Sequence['outputs.GetMdbClickhouseClusterFormatSchemaResult']]:
        """
        A set of protobuf or cap'n proto format schemas. The structure is documented below.
        """
        return pulumi.get(self, "format_schemas")

    @property
    @pulumi.getter
    def health(self) -> str:
        """
        Aggregated health of the cluster.
        """
        return pulumi.get(self, "health")

    @property
    @pulumi.getter
    def hosts(self) -> Optional[Sequence['outputs.GetMdbClickhouseClusterHostResult']]:
        """
        A host of the ClickHouse cluster. The structure is documented below.
        """
        return pulumi.get(self, "hosts")

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
        """
        A set of key/value label pairs to assign to the ClickHouse cluster.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter(name="maintenanceWindow")
    def maintenance_window(self) -> 'outputs.GetMdbClickhouseClusterMaintenanceWindowResult':
        return pulumi.get(self, "maintenance_window")

    @property
    @pulumi.getter(name="mlModels")
    def ml_models(self) -> Optional[Sequence['outputs.GetMdbClickhouseClusterMlModelResult']]:
        """
        A group of machine learning models. The structure is documented below.
        """
        return pulumi.get(self, "ml_models")

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Graphite rollup configuration name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkId")
    def network_id(self) -> Optional[str]:
        """
        ID of the network, to which the ClickHouse cluster belongs.
        """
        return pulumi.get(self, "network_id")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Sequence[str]:
        """
        A set of ids of security groups assigned to hosts of the cluster.
        """
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> str:
        return pulumi.get(self, "service_account_id")

    @property
    @pulumi.getter(name="shardGroups")
    def shard_groups(self) -> Optional[Sequence['outputs.GetMdbClickhouseClusterShardGroupResult']]:
        """
        A group of clickhouse shards. The structure is documented below.
        """
        return pulumi.get(self, "shard_groups")

    @property
    @pulumi.getter
    def shards(self) -> Sequence['outputs.GetMdbClickhouseClusterShardResult']:
        """
        A shard of the ClickHouse cluster. The structure is documented below.
        """
        return pulumi.get(self, "shards")

    @property
    @pulumi.getter(name="sqlDatabaseManagement")
    def sql_database_management(self) -> bool:
        """
        Grants `admin` user database management permission.
        """
        return pulumi.get(self, "sql_database_management")

    @property
    @pulumi.getter(name="sqlUserManagement")
    def sql_user_management(self) -> bool:
        """
        Enables `admin` user with user management permission.
        """
        return pulumi.get(self, "sql_user_management")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        Status of the cluster.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def users(self) -> Optional[Sequence['outputs.GetMdbClickhouseClusterUserResult']]:
        """
        A user of the ClickHouse cluster. The structure is documented below.
        """
        return pulumi.get(self, "users")

    @property
    @pulumi.getter
    def version(self) -> str:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter
    def zookeeper(self) -> 'outputs.GetMdbClickhouseClusterZookeeperResult':
        """
        Configuration of the ZooKeeper subcluster. The structure is documented below.
        """
        return pulumi.get(self, "zookeeper")


class AwaitableGetMdbClickhouseClusterResult(GetMdbClickhouseClusterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetMdbClickhouseClusterResult(
            access=self.access,
            admin_password=self.admin_password,
            backup_window_start=self.backup_window_start,
            clickhouse=self.clickhouse,
            cloud_storage=self.cloud_storage,
            cluster_id=self.cluster_id,
            copy_schema_on_new_hosts=self.copy_schema_on_new_hosts,
            created_at=self.created_at,
            databases=self.databases,
            deletion_protection=self.deletion_protection,
            description=self.description,
            embedded_keeper=self.embedded_keeper,
            environment=self.environment,
            folder_id=self.folder_id,
            format_schemas=self.format_schemas,
            health=self.health,
            hosts=self.hosts,
            id=self.id,
            labels=self.labels,
            maintenance_window=self.maintenance_window,
            ml_models=self.ml_models,
            name=self.name,
            network_id=self.network_id,
            security_group_ids=self.security_group_ids,
            service_account_id=self.service_account_id,
            shard_groups=self.shard_groups,
            shards=self.shards,
            sql_database_management=self.sql_database_management,
            sql_user_management=self.sql_user_management,
            status=self.status,
            users=self.users,
            version=self.version,
            zookeeper=self.zookeeper)


def get_mdb_clickhouse_cluster(access: Optional[pulumi.InputType['GetMdbClickhouseClusterAccessArgs']] = None,
                               admin_password: Optional[str] = None,
                               backup_window_start: Optional[pulumi.InputType['GetMdbClickhouseClusterBackupWindowStartArgs']] = None,
                               clickhouse: Optional[pulumi.InputType['GetMdbClickhouseClusterClickhouseArgs']] = None,
                               cloud_storage: Optional[pulumi.InputType['GetMdbClickhouseClusterCloudStorageArgs']] = None,
                               cluster_id: Optional[str] = None,
                               copy_schema_on_new_hosts: Optional[bool] = None,
                               created_at: Optional[str] = None,
                               databases: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterDatabaseArgs']]] = None,
                               deletion_protection: Optional[bool] = None,
                               description: Optional[str] = None,
                               embedded_keeper: Optional[bool] = None,
                               environment: Optional[str] = None,
                               folder_id: Optional[str] = None,
                               format_schemas: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterFormatSchemaArgs']]] = None,
                               health: Optional[str] = None,
                               hosts: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterHostArgs']]] = None,
                               labels: Optional[Mapping[str, str]] = None,
                               maintenance_window: Optional[pulumi.InputType['GetMdbClickhouseClusterMaintenanceWindowArgs']] = None,
                               ml_models: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterMlModelArgs']]] = None,
                               name: Optional[str] = None,
                               network_id: Optional[str] = None,
                               security_group_ids: Optional[Sequence[str]] = None,
                               service_account_id: Optional[str] = None,
                               shard_groups: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterShardGroupArgs']]] = None,
                               shards: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterShardArgs']]] = None,
                               sql_database_management: Optional[bool] = None,
                               sql_user_management: Optional[bool] = None,
                               status: Optional[str] = None,
                               users: Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterUserArgs']]] = None,
                               version: Optional[str] = None,
                               zookeeper: Optional[pulumi.InputType['GetMdbClickhouseClusterZookeeperArgs']] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetMdbClickhouseClusterResult:
    """
    Get information about a Yandex Managed ClickHouse cluster. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    foo = yandex.get_mdb_clickhouse_cluster(name="test")
    pulumi.export("networkId", foo.network_id)
    ```


    :param pulumi.InputType['GetMdbClickhouseClusterAccessArgs'] access: Access policy to the ClickHouse cluster. The structure is documented below.
    :param pulumi.InputType['GetMdbClickhouseClusterBackupWindowStartArgs'] backup_window_start: Time to start the daily backup, in the UTC timezone. The structure is documented below.
    :param pulumi.InputType['GetMdbClickhouseClusterClickhouseArgs'] clickhouse: Configuration of the ClickHouse subcluster. The structure is documented below.
    :param str cluster_id: The ID of the ClickHouse cluster.
    :param str created_at: Creation timestamp of the key.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterDatabaseArgs']] databases: A database of the ClickHouse cluster. The structure is documented below.
    :param str description: Description of the shard group.
    :param bool embedded_keeper: Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
    :param str environment: Deployment environment of the ClickHouse cluster.
    :param str folder_id: The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterFormatSchemaArgs']] format_schemas: A set of protobuf or cap'n proto format schemas. The structure is documented below.
    :param str health: Aggregated health of the cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterHostArgs']] hosts: A host of the ClickHouse cluster. The structure is documented below.
    :param Mapping[str, str] labels: A set of key/value label pairs to assign to the ClickHouse cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterMlModelArgs']] ml_models: A group of machine learning models. The structure is documented below.
    :param str name: The name of the ClickHouse cluster.
    :param str network_id: ID of the network, to which the ClickHouse cluster belongs.
    :param Sequence[str] security_group_ids: A set of ids of security groups assigned to hosts of the cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterShardGroupArgs']] shard_groups: A group of clickhouse shards. The structure is documented below.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterShardArgs']] shards: A shard of the ClickHouse cluster. The structure is documented below.
    :param bool sql_database_management: Grants `admin` user database management permission.
    :param bool sql_user_management: Enables `admin` user with user management permission.
    :param str status: Status of the cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterUserArgs']] users: A user of the ClickHouse cluster. The structure is documented below.
    :param pulumi.InputType['GetMdbClickhouseClusterZookeeperArgs'] zookeeper: Configuration of the ZooKeeper subcluster. The structure is documented below.
    """
    __args__ = dict()
    __args__['access'] = access
    __args__['adminPassword'] = admin_password
    __args__['backupWindowStart'] = backup_window_start
    __args__['clickhouse'] = clickhouse
    __args__['cloudStorage'] = cloud_storage
    __args__['clusterId'] = cluster_id
    __args__['copySchemaOnNewHosts'] = copy_schema_on_new_hosts
    __args__['createdAt'] = created_at
    __args__['databases'] = databases
    __args__['deletionProtection'] = deletion_protection
    __args__['description'] = description
    __args__['embeddedKeeper'] = embedded_keeper
    __args__['environment'] = environment
    __args__['folderId'] = folder_id
    __args__['formatSchemas'] = format_schemas
    __args__['health'] = health
    __args__['hosts'] = hosts
    __args__['labels'] = labels
    __args__['maintenanceWindow'] = maintenance_window
    __args__['mlModels'] = ml_models
    __args__['name'] = name
    __args__['networkId'] = network_id
    __args__['securityGroupIds'] = security_group_ids
    __args__['serviceAccountId'] = service_account_id
    __args__['shardGroups'] = shard_groups
    __args__['shards'] = shards
    __args__['sqlDatabaseManagement'] = sql_database_management
    __args__['sqlUserManagement'] = sql_user_management
    __args__['status'] = status
    __args__['users'] = users
    __args__['version'] = version
    __args__['zookeeper'] = zookeeper
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getMdbClickhouseCluster:getMdbClickhouseCluster', __args__, opts=opts, typ=GetMdbClickhouseClusterResult).value

    return AwaitableGetMdbClickhouseClusterResult(
        access=__ret__.access,
        admin_password=__ret__.admin_password,
        backup_window_start=__ret__.backup_window_start,
        clickhouse=__ret__.clickhouse,
        cloud_storage=__ret__.cloud_storage,
        cluster_id=__ret__.cluster_id,
        copy_schema_on_new_hosts=__ret__.copy_schema_on_new_hosts,
        created_at=__ret__.created_at,
        databases=__ret__.databases,
        deletion_protection=__ret__.deletion_protection,
        description=__ret__.description,
        embedded_keeper=__ret__.embedded_keeper,
        environment=__ret__.environment,
        folder_id=__ret__.folder_id,
        format_schemas=__ret__.format_schemas,
        health=__ret__.health,
        hosts=__ret__.hosts,
        id=__ret__.id,
        labels=__ret__.labels,
        maintenance_window=__ret__.maintenance_window,
        ml_models=__ret__.ml_models,
        name=__ret__.name,
        network_id=__ret__.network_id,
        security_group_ids=__ret__.security_group_ids,
        service_account_id=__ret__.service_account_id,
        shard_groups=__ret__.shard_groups,
        shards=__ret__.shards,
        sql_database_management=__ret__.sql_database_management,
        sql_user_management=__ret__.sql_user_management,
        status=__ret__.status,
        users=__ret__.users,
        version=__ret__.version,
        zookeeper=__ret__.zookeeper)


@_utilities.lift_output_func(get_mdb_clickhouse_cluster)
def get_mdb_clickhouse_cluster_output(access: Optional[pulumi.Input[Optional[pulumi.InputType['GetMdbClickhouseClusterAccessArgs']]]] = None,
                                      admin_password: Optional[pulumi.Input[Optional[str]]] = None,
                                      backup_window_start: Optional[pulumi.Input[Optional[pulumi.InputType['GetMdbClickhouseClusterBackupWindowStartArgs']]]] = None,
                                      clickhouse: Optional[pulumi.Input[Optional[pulumi.InputType['GetMdbClickhouseClusterClickhouseArgs']]]] = None,
                                      cloud_storage: Optional[pulumi.Input[Optional[pulumi.InputType['GetMdbClickhouseClusterCloudStorageArgs']]]] = None,
                                      cluster_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      copy_schema_on_new_hosts: Optional[pulumi.Input[Optional[bool]]] = None,
                                      created_at: Optional[pulumi.Input[Optional[str]]] = None,
                                      databases: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterDatabaseArgs']]]]] = None,
                                      deletion_protection: Optional[pulumi.Input[Optional[bool]]] = None,
                                      description: Optional[pulumi.Input[Optional[str]]] = None,
                                      embedded_keeper: Optional[pulumi.Input[Optional[bool]]] = None,
                                      environment: Optional[pulumi.Input[Optional[str]]] = None,
                                      folder_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      format_schemas: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterFormatSchemaArgs']]]]] = None,
                                      health: Optional[pulumi.Input[Optional[str]]] = None,
                                      hosts: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterHostArgs']]]]] = None,
                                      labels: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                                      maintenance_window: Optional[pulumi.Input[Optional[pulumi.InputType['GetMdbClickhouseClusterMaintenanceWindowArgs']]]] = None,
                                      ml_models: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterMlModelArgs']]]]] = None,
                                      name: Optional[pulumi.Input[Optional[str]]] = None,
                                      network_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      security_group_ids: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                                      service_account_id: Optional[pulumi.Input[Optional[str]]] = None,
                                      shard_groups: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterShardGroupArgs']]]]] = None,
                                      shards: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterShardArgs']]]]] = None,
                                      sql_database_management: Optional[pulumi.Input[Optional[bool]]] = None,
                                      sql_user_management: Optional[pulumi.Input[Optional[bool]]] = None,
                                      status: Optional[pulumi.Input[Optional[str]]] = None,
                                      users: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetMdbClickhouseClusterUserArgs']]]]] = None,
                                      version: Optional[pulumi.Input[Optional[str]]] = None,
                                      zookeeper: Optional[pulumi.Input[Optional[pulumi.InputType['GetMdbClickhouseClusterZookeeperArgs']]]] = None,
                                      opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetMdbClickhouseClusterResult]:
    """
    Get information about a Yandex Managed ClickHouse cluster. For more information, see
    [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts).

    ## Example Usage

    ```python
    import pulumi
    import pulumi_yandex as yandex

    foo = yandex.get_mdb_clickhouse_cluster(name="test")
    pulumi.export("networkId", foo.network_id)
    ```


    :param pulumi.InputType['GetMdbClickhouseClusterAccessArgs'] access: Access policy to the ClickHouse cluster. The structure is documented below.
    :param pulumi.InputType['GetMdbClickhouseClusterBackupWindowStartArgs'] backup_window_start: Time to start the daily backup, in the UTC timezone. The structure is documented below.
    :param pulumi.InputType['GetMdbClickhouseClusterClickhouseArgs'] clickhouse: Configuration of the ClickHouse subcluster. The structure is documented below.
    :param str cluster_id: The ID of the ClickHouse cluster.
    :param str created_at: Creation timestamp of the key.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterDatabaseArgs']] databases: A database of the ClickHouse cluster. The structure is documented below.
    :param str description: Description of the shard group.
    :param bool embedded_keeper: Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
    :param str environment: Deployment environment of the ClickHouse cluster.
    :param str folder_id: The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterFormatSchemaArgs']] format_schemas: A set of protobuf or cap'n proto format schemas. The structure is documented below.
    :param str health: Aggregated health of the cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterHostArgs']] hosts: A host of the ClickHouse cluster. The structure is documented below.
    :param Mapping[str, str] labels: A set of key/value label pairs to assign to the ClickHouse cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterMlModelArgs']] ml_models: A group of machine learning models. The structure is documented below.
    :param str name: The name of the ClickHouse cluster.
    :param str network_id: ID of the network, to which the ClickHouse cluster belongs.
    :param Sequence[str] security_group_ids: A set of ids of security groups assigned to hosts of the cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterShardGroupArgs']] shard_groups: A group of clickhouse shards. The structure is documented below.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterShardArgs']] shards: A shard of the ClickHouse cluster. The structure is documented below.
    :param bool sql_database_management: Grants `admin` user database management permission.
    :param bool sql_user_management: Enables `admin` user with user management permission.
    :param str status: Status of the cluster.
    :param Sequence[pulumi.InputType['GetMdbClickhouseClusterUserArgs']] users: A user of the ClickHouse cluster. The structure is documented below.
    :param pulumi.InputType['GetMdbClickhouseClusterZookeeperArgs'] zookeeper: Configuration of the ZooKeeper subcluster. The structure is documented below.
    """
    ...
