# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ProviderArgs', 'Provider']

@pulumi.input_type
class ProviderArgs:
    def __init__(__self__, *,
                 cloud_id: Optional[pulumi.Input[str]] = None,
                 endpoint: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 insecure: Optional[pulumi.Input[bool]] = None,
                 max_retries: Optional[pulumi.Input[int]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 plaintext: Optional[pulumi.Input[bool]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 service_account_key_file: Optional[pulumi.Input[str]] = None,
                 storage_access_key: Optional[pulumi.Input[str]] = None,
                 storage_endpoint: Optional[pulumi.Input[str]] = None,
                 storage_secret_key: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 ymq_access_key: Optional[pulumi.Input[str]] = None,
                 ymq_endpoint: Optional[pulumi.Input[str]] = None,
                 ymq_secret_key: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Provider resource.
        :param pulumi.Input[str] cloud_id: ID of Yandex.Cloud tenant.
        :param pulumi.Input[str] endpoint: The API endpoint for Yandex.Cloud SDK client.
        :param pulumi.Input[str] folder_id: The default folder ID where resources will be placed.
        :param pulumi.Input[bool] insecure: Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
        :param pulumi.Input[int] max_retries: The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
        :param pulumi.Input[bool] plaintext: Disable use of TLS. Default value is `false`.
        :param pulumi.Input[str] service_account_key_file: Either the path to or the contents of a Service Account key file in JSON format.
        :param pulumi.Input[str] storage_access_key: Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
               specified.
        :param pulumi.Input[str] storage_endpoint: Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
        :param pulumi.Input[str] storage_secret_key: Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
               specified.
        :param pulumi.Input[str] token: The access token for API operations.
        :param pulumi.Input[str] ymq_access_key: Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
               specified.
        :param pulumi.Input[str] ymq_endpoint: Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
        :param pulumi.Input[str] ymq_secret_key: Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
               specified.
        :param pulumi.Input[str] zone: The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
        """
        if cloud_id is not None:
            pulumi.set(__self__, "cloud_id", cloud_id)
        if endpoint is not None:
            pulumi.set(__self__, "endpoint", endpoint)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if insecure is not None:
            pulumi.set(__self__, "insecure", insecure)
        if max_retries is not None:
            pulumi.set(__self__, "max_retries", max_retries)
        if organization_id is not None:
            pulumi.set(__self__, "organization_id", organization_id)
        if plaintext is not None:
            pulumi.set(__self__, "plaintext", plaintext)
        if region_id is not None:
            pulumi.set(__self__, "region_id", region_id)
        if service_account_key_file is not None:
            pulumi.set(__self__, "service_account_key_file", service_account_key_file)
        if storage_access_key is not None:
            pulumi.set(__self__, "storage_access_key", storage_access_key)
        if storage_endpoint is not None:
            pulumi.set(__self__, "storage_endpoint", storage_endpoint)
        if storage_secret_key is not None:
            pulumi.set(__self__, "storage_secret_key", storage_secret_key)
        if token is not None:
            pulumi.set(__self__, "token", token)
        if ymq_access_key is not None:
            pulumi.set(__self__, "ymq_access_key", ymq_access_key)
        if ymq_endpoint is not None:
            pulumi.set(__self__, "ymq_endpoint", ymq_endpoint)
        if ymq_secret_key is not None:
            pulumi.set(__self__, "ymq_secret_key", ymq_secret_key)
        if zone is not None:
            pulumi.set(__self__, "zone", zone)

    @property
    @pulumi.getter(name="cloudId")
    def cloud_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of Yandex.Cloud tenant.
        """
        return pulumi.get(self, "cloud_id")

    @cloud_id.setter
    def cloud_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cloud_id", value)

    @property
    @pulumi.getter
    def endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        The API endpoint for Yandex.Cloud SDK client.
        """
        return pulumi.get(self, "endpoint")

    @endpoint.setter
    def endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "endpoint", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        The default folder ID where resources will be placed.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def insecure(self) -> Optional[pulumi.Input[bool]]:
        """
        Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
        """
        return pulumi.get(self, "insecure")

    @insecure.setter
    def insecure(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "insecure", value)

    @property
    @pulumi.getter(name="maxRetries")
    def max_retries(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
        """
        return pulumi.get(self, "max_retries")

    @max_retries.setter
    def max_retries(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_retries", value)

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "organization_id")

    @organization_id.setter
    def organization_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "organization_id", value)

    @property
    @pulumi.getter
    def plaintext(self) -> Optional[pulumi.Input[bool]]:
        """
        Disable use of TLS. Default value is `false`.
        """
        return pulumi.get(self, "plaintext")

    @plaintext.setter
    def plaintext(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "plaintext", value)

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "region_id")

    @region_id.setter
    def region_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "region_id", value)

    @property
    @pulumi.getter(name="serviceAccountKeyFile")
    def service_account_key_file(self) -> Optional[pulumi.Input[str]]:
        """
        Either the path to or the contents of a Service Account key file in JSON format.
        """
        return pulumi.get(self, "service_account_key_file")

    @service_account_key_file.setter
    def service_account_key_file(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "service_account_key_file", value)

    @property
    @pulumi.getter(name="storageAccessKey")
    def storage_access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
        specified.
        """
        return pulumi.get(self, "storage_access_key")

    @storage_access_key.setter
    def storage_access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_access_key", value)

    @property
    @pulumi.getter(name="storageEndpoint")
    def storage_endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
        """
        return pulumi.get(self, "storage_endpoint")

    @storage_endpoint.setter
    def storage_endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_endpoint", value)

    @property
    @pulumi.getter(name="storageSecretKey")
    def storage_secret_key(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
        specified.
        """
        return pulumi.get(self, "storage_secret_key")

    @storage_secret_key.setter
    def storage_secret_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_secret_key", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[str]]:
        """
        The access token for API operations.
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "token", value)

    @property
    @pulumi.getter(name="ymqAccessKey")
    def ymq_access_key(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
        specified.
        """
        return pulumi.get(self, "ymq_access_key")

    @ymq_access_key.setter
    def ymq_access_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ymq_access_key", value)

    @property
    @pulumi.getter(name="ymqEndpoint")
    def ymq_endpoint(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
        """
        return pulumi.get(self, "ymq_endpoint")

    @ymq_endpoint.setter
    def ymq_endpoint(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ymq_endpoint", value)

    @property
    @pulumi.getter(name="ymqSecretKey")
    def ymq_secret_key(self) -> Optional[pulumi.Input[str]]:
        """
        Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
        specified.
        """
        return pulumi.get(self, "ymq_secret_key")

    @ymq_secret_key.setter
    def ymq_secret_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ymq_secret_key", value)

    @property
    @pulumi.getter
    def zone(self) -> Optional[pulumi.Input[str]]:
        """
        The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
        """
        return pulumi.get(self, "zone")

    @zone.setter
    def zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zone", value)


class Provider(pulumi.ProviderResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cloud_id: Optional[pulumi.Input[str]] = None,
                 endpoint: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 insecure: Optional[pulumi.Input[bool]] = None,
                 max_retries: Optional[pulumi.Input[int]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 plaintext: Optional[pulumi.Input[bool]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 service_account_key_file: Optional[pulumi.Input[str]] = None,
                 storage_access_key: Optional[pulumi.Input[str]] = None,
                 storage_endpoint: Optional[pulumi.Input[str]] = None,
                 storage_secret_key: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 ymq_access_key: Optional[pulumi.Input[str]] = None,
                 ymq_endpoint: Optional[pulumi.Input[str]] = None,
                 ymq_secret_key: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        The provider type for the yandex package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cloud_id: ID of Yandex.Cloud tenant.
        :param pulumi.Input[str] endpoint: The API endpoint for Yandex.Cloud SDK client.
        :param pulumi.Input[str] folder_id: The default folder ID where resources will be placed.
        :param pulumi.Input[bool] insecure: Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.
        :param pulumi.Input[int] max_retries: The maximum number of times an API request is being executed. If the API request still fails, an error is thrown.
        :param pulumi.Input[bool] plaintext: Disable use of TLS. Default value is `false`.
        :param pulumi.Input[str] service_account_key_file: Either the path to or the contents of a Service Account key file in JSON format.
        :param pulumi.Input[str] storage_access_key: Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
               specified.
        :param pulumi.Input[str] storage_endpoint: Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
        :param pulumi.Input[str] storage_secret_key: Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
               specified.
        :param pulumi.Input[str] token: The access token for API operations.
        :param pulumi.Input[str] ymq_access_key: Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
               specified.
        :param pulumi.Input[str] ymq_endpoint: Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
        :param pulumi.Input[str] ymq_secret_key: Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
               specified.
        :param pulumi.Input[str] zone: The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ProviderArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The provider type for the yandex package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param ProviderArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProviderArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cloud_id: Optional[pulumi.Input[str]] = None,
                 endpoint: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 insecure: Optional[pulumi.Input[bool]] = None,
                 max_retries: Optional[pulumi.Input[int]] = None,
                 organization_id: Optional[pulumi.Input[str]] = None,
                 plaintext: Optional[pulumi.Input[bool]] = None,
                 region_id: Optional[pulumi.Input[str]] = None,
                 service_account_key_file: Optional[pulumi.Input[str]] = None,
                 storage_access_key: Optional[pulumi.Input[str]] = None,
                 storage_endpoint: Optional[pulumi.Input[str]] = None,
                 storage_secret_key: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 ymq_access_key: Optional[pulumi.Input[str]] = None,
                 ymq_endpoint: Optional[pulumi.Input[str]] = None,
                 ymq_secret_key: Optional[pulumi.Input[str]] = None,
                 zone: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProviderArgs.__new__(ProviderArgs)

            __props__.__dict__["cloud_id"] = cloud_id
            __props__.__dict__["endpoint"] = endpoint
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["insecure"] = pulumi.Output.from_input(insecure).apply(pulumi.runtime.to_json) if insecure is not None else None
            __props__.__dict__["max_retries"] = pulumi.Output.from_input(max_retries).apply(pulumi.runtime.to_json) if max_retries is not None else None
            __props__.__dict__["organization_id"] = organization_id
            __props__.__dict__["plaintext"] = pulumi.Output.from_input(plaintext).apply(pulumi.runtime.to_json) if plaintext is not None else None
            __props__.__dict__["region_id"] = region_id
            __props__.__dict__["service_account_key_file"] = service_account_key_file
            __props__.__dict__["storage_access_key"] = storage_access_key
            __props__.__dict__["storage_endpoint"] = storage_endpoint
            __props__.__dict__["storage_secret_key"] = None if storage_secret_key is None else pulumi.Output.secret(storage_secret_key)
            __props__.__dict__["token"] = None if token is None else pulumi.Output.secret(token)
            __props__.__dict__["ymq_access_key"] = ymq_access_key
            __props__.__dict__["ymq_endpoint"] = ymq_endpoint
            __props__.__dict__["ymq_secret_key"] = None if ymq_secret_key is None else pulumi.Output.secret(ymq_secret_key)
            __props__.__dict__["zone"] = zone
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["storageSecretKey", "token", "ymqSecretKey"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(Provider, __self__).__init__(
            'yandex',
            resource_name,
            __props__,
            opts)

    @property
    @pulumi.getter(name="cloudId")
    def cloud_id(self) -> pulumi.Output[Optional[str]]:
        """
        ID of Yandex.Cloud tenant.
        """
        return pulumi.get(self, "cloud_id")

    @property
    @pulumi.getter
    def endpoint(self) -> pulumi.Output[Optional[str]]:
        """
        The API endpoint for Yandex.Cloud SDK client.
        """
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[Optional[str]]:
        """
        The default folder ID where resources will be placed.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter(name="organizationId")
    def organization_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "organization_id")

    @property
    @pulumi.getter(name="regionId")
    def region_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "region_id")

    @property
    @pulumi.getter(name="serviceAccountKeyFile")
    def service_account_key_file(self) -> pulumi.Output[Optional[str]]:
        """
        Either the path to or the contents of a Service Account key file in JSON format.
        """
        return pulumi.get(self, "service_account_key_file")

    @property
    @pulumi.getter(name="storageAccessKey")
    def storage_access_key(self) -> pulumi.Output[Optional[str]]:
        """
        Yandex.Cloud storage service access key. Used when a storage data/resource doesn't have an access key explicitly
        specified.
        """
        return pulumi.get(self, "storage_access_key")

    @property
    @pulumi.getter(name="storageEndpoint")
    def storage_endpoint(self) -> pulumi.Output[Optional[str]]:
        """
        Yandex.Cloud storage service endpoint. Default is storage.yandexcloud.net
        """
        return pulumi.get(self, "storage_endpoint")

    @property
    @pulumi.getter(name="storageSecretKey")
    def storage_secret_key(self) -> pulumi.Output[Optional[str]]:
        """
        Yandex.Cloud storage service secret key. Used when a storage data/resource doesn't have a secret key explicitly
        specified.
        """
        return pulumi.get(self, "storage_secret_key")

    @property
    @pulumi.getter
    def token(self) -> pulumi.Output[Optional[str]]:
        """
        The access token for API operations.
        """
        return pulumi.get(self, "token")

    @property
    @pulumi.getter(name="ymqAccessKey")
    def ymq_access_key(self) -> pulumi.Output[Optional[str]]:
        """
        Yandex.Cloud Message Queue service access key. Used when a message queue resource doesn't have an access key explicitly
        specified.
        """
        return pulumi.get(self, "ymq_access_key")

    @property
    @pulumi.getter(name="ymqEndpoint")
    def ymq_endpoint(self) -> pulumi.Output[Optional[str]]:
        """
        Yandex.Cloud Message Queue service endpoint. Default is message-queue.api.cloud.yandex.net
        """
        return pulumi.get(self, "ymq_endpoint")

    @property
    @pulumi.getter(name="ymqSecretKey")
    def ymq_secret_key(self) -> pulumi.Output[Optional[str]]:
        """
        Yandex.Cloud Message Queue service secret key. Used when a message queue resource doesn't have a secret key explicitly
        specified.
        """
        return pulumi.get(self, "ymq_secret_key")

    @property
    @pulumi.getter
    def zone(self) -> pulumi.Output[Optional[str]]:
        """
        The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.
        """
        return pulumi.get(self, "zone")

