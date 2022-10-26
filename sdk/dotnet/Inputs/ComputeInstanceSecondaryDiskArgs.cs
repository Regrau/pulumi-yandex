// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceSecondaryDiskArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoDelete")]
        public Input<bool>? AutoDelete { get; set; }

        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        [Input("diskId", required: true)]
        public Input<string> DiskId { get; set; } = null!;

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public ComputeInstanceSecondaryDiskArgs()
        {
        }
        public static new ComputeInstanceSecondaryDiskArgs Empty => new ComputeInstanceSecondaryDiskArgs();
    }
}
