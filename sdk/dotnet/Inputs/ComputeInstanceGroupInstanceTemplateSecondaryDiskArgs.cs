// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs : global::Pulumi.ResourceArgs
    {
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        [Input("initializeParams")]
        public Input<Inputs.ComputeInstanceGroupInstanceTemplateSecondaryDiskInitializeParamsArgs>? InitializeParams { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs Empty => new ComputeInstanceGroupInstanceTemplateSecondaryDiskArgs();
    }
}
