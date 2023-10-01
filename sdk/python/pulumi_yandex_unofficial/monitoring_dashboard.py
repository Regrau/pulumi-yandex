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

__all__ = ['MonitoringDashboardArgs', 'MonitoringDashboard']

@pulumi.input_type
class MonitoringDashboardArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parametrizations: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 widgets: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]]] = None):
        """
        The set of arguments for constructing a MonitoringDashboard resource.
        :param pulumi.Input[str] description: Chart description in dashboard (not enabled in UI).
        :param pulumi.Input[str] folder_id: Labels folder ID.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Dashboard.
        :param pulumi.Input[str] name: Series name or empty.
        :param pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]] parametrizations: Dashboard parametrization
        :param pulumi.Input[str] title: -Title or empty.
        :param pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]] widgets: Widgets
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if parametrizations is not None:
            pulumi.set(__self__, "parametrizations", parametrizations)
        if title is not None:
            pulumi.set(__self__, "title", title)
        if widgets is not None:
            pulumi.set(__self__, "widgets", widgets)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Chart description in dashboard (not enabled in UI).
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        Labels folder ID.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of key/value label pairs to assign to the Dashboard.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Series name or empty.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def parametrizations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]]]:
        """
        Dashboard parametrization
        """
        return pulumi.get(self, "parametrizations")

    @parametrizations.setter
    def parametrizations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]]]):
        pulumi.set(self, "parametrizations", value)

    @property
    @pulumi.getter
    def title(self) -> Optional[pulumi.Input[str]]:
        """
        -Title or empty.
        """
        return pulumi.get(self, "title")

    @title.setter
    def title(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "title", value)

    @property
    @pulumi.getter
    def widgets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]]]:
        """
        Widgets
        """
        return pulumi.get(self, "widgets")

    @widgets.setter
    def widgets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]]]):
        pulumi.set(self, "widgets", value)


@pulumi.input_type
class _MonitoringDashboardState:
    def __init__(__self__, *,
                 dashboard_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parametrizations: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 widgets: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]]] = None):
        """
        Input properties used for looking up and filtering MonitoringDashboard resources.
        :param pulumi.Input[str] dashboard_id: Dashboard ID
        :param pulumi.Input[str] description: Chart description in dashboard (not enabled in UI).
        :param pulumi.Input[str] folder_id: Labels folder ID.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Dashboard.
        :param pulumi.Input[str] name: Series name or empty.
        :param pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]] parametrizations: Dashboard parametrization
        :param pulumi.Input[str] title: -Title or empty.
        :param pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]] widgets: Widgets
        """
        if dashboard_id is not None:
            pulumi.set(__self__, "dashboard_id", dashboard_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if folder_id is not None:
            pulumi.set(__self__, "folder_id", folder_id)
        if labels is not None:
            pulumi.set(__self__, "labels", labels)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if parametrizations is not None:
            pulumi.set(__self__, "parametrizations", parametrizations)
        if title is not None:
            pulumi.set(__self__, "title", title)
        if widgets is not None:
            pulumi.set(__self__, "widgets", widgets)

    @property
    @pulumi.getter(name="dashboardId")
    def dashboard_id(self) -> Optional[pulumi.Input[str]]:
        """
        Dashboard ID
        """
        return pulumi.get(self, "dashboard_id")

    @dashboard_id.setter
    def dashboard_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "dashboard_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Chart description in dashboard (not enabled in UI).
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> Optional[pulumi.Input[str]]:
        """
        Labels folder ID.
        """
        return pulumi.get(self, "folder_id")

    @folder_id.setter
    def folder_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "folder_id", value)

    @property
    @pulumi.getter
    def labels(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        A set of key/value label pairs to assign to the Dashboard.
        """
        return pulumi.get(self, "labels")

    @labels.setter
    def labels(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "labels", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Series name or empty.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def parametrizations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]]]:
        """
        Dashboard parametrization
        """
        return pulumi.get(self, "parametrizations")

    @parametrizations.setter
    def parametrizations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardParametrizationArgs']]]]):
        pulumi.set(self, "parametrizations", value)

    @property
    @pulumi.getter
    def title(self) -> Optional[pulumi.Input[str]]:
        """
        -Title or empty.
        """
        return pulumi.get(self, "title")

    @title.setter
    def title(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "title", value)

    @property
    @pulumi.getter
    def widgets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]]]:
        """
        Widgets
        """
        return pulumi.get(self, "widgets")

    @widgets.setter
    def widgets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MonitoringDashboardWidgetArgs']]]]):
        pulumi.set(self, "widgets", value)


class MonitoringDashboard(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 folder_id: Optional[pulumi.Input[str]] = None,
                 labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parametrizations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardParametrizationArgs']]]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 widgets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardWidgetArgs']]]]] = None,
                 __props__=None):
        """
        Get information about a Yandex Monitoring dashboard.

        ## Import

        A Monitoring dashboard can be imported using the `id` of the resource, e.g.

        ```sh
         $ pulumi import yandex:index/monitoringDashboard:monitoringDashboard default dashboard_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Chart description in dashboard (not enabled in UI).
        :param pulumi.Input[str] folder_id: Labels folder ID.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Dashboard.
        :param pulumi.Input[str] name: Series name or empty.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardParametrizationArgs']]]] parametrizations: Dashboard parametrization
        :param pulumi.Input[str] title: -Title or empty.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardWidgetArgs']]]] widgets: Widgets
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[MonitoringDashboardArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Get information about a Yandex Monitoring dashboard.

        ## Import

        A Monitoring dashboard can be imported using the `id` of the resource, e.g.

        ```sh
         $ pulumi import yandex:index/monitoringDashboard:monitoringDashboard default dashboard_id
        ```

        :param str resource_name: The name of the resource.
        :param MonitoringDashboardArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(MonitoringDashboardArgs, pulumi.ResourceOptions, *args, **kwargs)
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
                 parametrizations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardParametrizationArgs']]]]] = None,
                 title: Optional[pulumi.Input[str]] = None,
                 widgets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardWidgetArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = MonitoringDashboardArgs.__new__(MonitoringDashboardArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["folder_id"] = folder_id
            __props__.__dict__["labels"] = labels
            __props__.__dict__["name"] = name
            __props__.__dict__["parametrizations"] = parametrizations
            __props__.__dict__["title"] = title
            __props__.__dict__["widgets"] = widgets
            __props__.__dict__["dashboard_id"] = None
        super(MonitoringDashboard, __self__).__init__(
            'yandex:index/monitoringDashboard:monitoringDashboard',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            dashboard_id: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            folder_id: Optional[pulumi.Input[str]] = None,
            labels: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            parametrizations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardParametrizationArgs']]]]] = None,
            title: Optional[pulumi.Input[str]] = None,
            widgets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardWidgetArgs']]]]] = None) -> 'MonitoringDashboard':
        """
        Get an existing MonitoringDashboard resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] dashboard_id: Dashboard ID
        :param pulumi.Input[str] description: Chart description in dashboard (not enabled in UI).
        :param pulumi.Input[str] folder_id: Labels folder ID.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] labels: A set of key/value label pairs to assign to the Dashboard.
        :param pulumi.Input[str] name: Series name or empty.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardParametrizationArgs']]]] parametrizations: Dashboard parametrization
        :param pulumi.Input[str] title: -Title or empty.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MonitoringDashboardWidgetArgs']]]] widgets: Widgets
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _MonitoringDashboardState.__new__(_MonitoringDashboardState)

        __props__.__dict__["dashboard_id"] = dashboard_id
        __props__.__dict__["description"] = description
        __props__.__dict__["folder_id"] = folder_id
        __props__.__dict__["labels"] = labels
        __props__.__dict__["name"] = name
        __props__.__dict__["parametrizations"] = parametrizations
        __props__.__dict__["title"] = title
        __props__.__dict__["widgets"] = widgets
        return MonitoringDashboard(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dashboardId")
    def dashboard_id(self) -> pulumi.Output[str]:
        """
        Dashboard ID
        """
        return pulumi.get(self, "dashboard_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Chart description in dashboard (not enabled in UI).
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="folderId")
    def folder_id(self) -> pulumi.Output[str]:
        """
        Labels folder ID.
        """
        return pulumi.get(self, "folder_id")

    @property
    @pulumi.getter
    def labels(self) -> pulumi.Output[Mapping[str, str]]:
        """
        A set of key/value label pairs to assign to the Dashboard.
        """
        return pulumi.get(self, "labels")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Series name or empty.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parametrizations(self) -> pulumi.Output[Sequence['outputs.MonitoringDashboardParametrization']]:
        """
        Dashboard parametrization
        """
        return pulumi.get(self, "parametrizations")

    @property
    @pulumi.getter
    def title(self) -> pulumi.Output[Optional[str]]:
        """
        -Title or empty.
        """
        return pulumi.get(self, "title")

    @property
    @pulumi.getter
    def widgets(self) -> pulumi.Output[Optional[Sequence['outputs.MonitoringDashboardWidget']]]:
        """
        Widgets
        """
        return pulumi.get(self, "widgets")
