// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateNetworkSettingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Network acceleration type. By default a network is in `STANDARD` mode.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ComputeInstanceGroupInstanceTemplateNetworkSettingGetArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateNetworkSettingGetArgs Empty => new ComputeInstanceGroupInstanceTemplateNetworkSettingGetArgs();
    }
}
