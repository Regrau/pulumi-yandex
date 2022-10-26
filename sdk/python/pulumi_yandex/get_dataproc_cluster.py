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

__all__ = [
    'GetDataprocClusterResult',
    'AwaitableGetDataprocClusterResult',
    'get_dataproc_cluster',
    'get_dataproc_cluster_output',
]

@pulumi.output_type
class GetDataprocClusterResult:
    """
    A collection of values returned by getDataprocCluster.
    """
    def __init__(__self__, bucket=None, cluster_configs=None, cluster_id=None, created_at=None, deletion_protection=None, description=None, folder_id=None, host_group_ids=None, id=None, labels=None, name=None, security_group_ids=None, service_account_id=None, ui_proxy=None, zone_id=None):
        if bucket and not isinstance(bucket, str):
            raise TypeError("Expected argument 'bucket' to be a str")
        pulumi.set(__self__, "bucket", bucket)
        if cluster_configs and not isinstance(cluster_configs, list):
            raise TypeError("Expected argument 'cluster_configs' to be a list")
        pulumi.set(__self__, "cluster_configs", cluster_configs)
        if cluster_id and not isinstance(cluster_id, str):
            raise TypeError("Expected argument 'cluster_id' to be a str")
        pulumi.set(__self__, "cluster_id", cluster_id)
        if created_at and not isinstance(created_at, str):
            raise TypeError("Expected argument 'created_at' to be a str")
        pulumi.set(__self__, "created_at", created_at)
        if deletion_protection and not isinstance(deletion_protection, bool):
            raise TypeError("Expected argument 'deletion_protection' to be a bool")
        pulumi.set(__self__, "deletion_protection", deletion_protection)
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        pulumi.set(__self__, "description", description)
        if folder_id and not isinstance(folder_id, str):
            raise TypeError("Expected argument 'folder_id' to be a str")
        pulumi.set(__self__, "folder_id", folder_id)
        if host_group_ids and not isinstance(host_group_ids, list):
            raise TypeError("Expected argument 'host_group_ids' to be a list")
        pulumi.set(__self__, "host_group_ids", host_group_ids)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if labels and not isinstance(labels, dict):
            raise TypeError("Expected argument 'labels' to be a dict")
        pulumi.set(__self__, "labels", labels)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if security_group_ids and not isinstance(security_group_ids, list):
            raise TypeError("Expected argument 'security_group_ids' to be a list")
        pulumi.set(__self__, "security_group_ids", security_group_ids)
        if service_account_id and not isinstance(service_account_id, str):
            raise TypeError("Expected argument 'service_account_id' to be a str")
        pulumi.set(__self__, "service_account_id", service_account_id)
        if ui_proxy and not isinstance(ui_proxy, bool):
            raise TypeError("Expected argument 'ui_proxy' to be a bool")
        pulumi.set(__self__, "ui_proxy", ui_proxy)
        if zone_id and not isinstance(zone_id, str):
            raise TypeError("Expected argument 'zone_id' to be a str")
        pulumi.set(__self__, "zone_id", zone_id)

    @property
    @pulumi.getter
    def bucket(self) -> str:
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter(name="clusterConfigs")
    def cluster_configs(self) -> Sequence['outputs.GetDataprocClusterClusterConfigResult']:
        return pulumi.get(self, "cluster_configs")

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> str:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> str:
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="deletionProtection")
    def deletion_protection(self) -> bool:
        return pulumi.get(self, "deletion_protection")

    @property
    @pulumi.getter
    def description(self) -> str:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> str:
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="hostGroupIds")
    def host_group_ids(self) -> Sequence[str]:
        return pulumi.get(self, "host_group_ids")

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
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="securityGroupIds")
    def security_group_ids(self) -> Sequence[str]:
        return pulumi.get(self, "security_group_ids")

    @property
    @pulumi.getter(name="serviceAccountId")
    def service_account_id(self) -> str:
        return pulumi.get(self, "service_account_id")

    @property
    @pulumi.getter(name="uiProxy")
    def ui_proxy(self) -> bool:
        return pulumi.get(self, "ui_proxy")

    @property
    @pulumi.getter(name="zoneId")
    def zone_id(self) -> str:
        return pulumi.get(self, "zone_id")


class AwaitableGetDataprocClusterResult(GetDataprocClusterResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDataprocClusterResult(
            bucket=self.bucket,
            cluster_configs=self.cluster_configs,
            cluster_id=self.cluster_id,
            created_at=self.created_at,
            deletion_protection=self.deletion_protection,
            description=self.description,
            folder_id=self.folder_id,
            host_group_ids=self.host_group_ids,
            id=self.id,
            labels=self.labels,
            name=self.name,
            security_group_ids=self.security_group_ids,
            service_account_id=self.service_account_id,
            ui_proxy=self.ui_proxy,
            zone_id=self.zone_id)


def get_dataproc_cluster(cluster_id: Optional[str] = None,
                         name: Optional[str] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDataprocClusterResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['clusterId'] = cluster_id
    __args__['name'] = name
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('yandex:index/getDataprocCluster:getDataprocCluster', __args__, opts=opts, typ=GetDataprocClusterResult).value

    return AwaitableGetDataprocClusterResult(
        bucket=__ret__.bucket,
        cluster_configs=__ret__.cluster_configs,
        cluster_id=__ret__.cluster_id,
        created_at=__ret__.created_at,
        deletion_protection=__ret__.deletion_protection,
        description=__ret__.description,
        folder_id=__ret__.folder_id,
        host_group_ids=__ret__.host_group_ids,
        id=__ret__.id,
        labels=__ret__.labels,
        name=__ret__.name,
        security_group_ids=__ret__.security_group_ids,
        service_account_id=__ret__.service_account_id,
        ui_proxy=__ret__.ui_proxy,
        zone_id=__ret__.zone_id)


@_utilities.lift_output_func(get_dataproc_cluster)
def get_dataproc_cluster_output(cluster_id: Optional[pulumi.Input[Optional[str]]] = None,
                                name: Optional[pulumi.Input[Optional[str]]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDataprocClusterResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
