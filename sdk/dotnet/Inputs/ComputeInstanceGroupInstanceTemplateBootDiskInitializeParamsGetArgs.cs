// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        [Input("size")]
        public Input<int>? Size { get; set; }

        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsGetArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsGetArgs Empty => new ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsGetArgs();
    }
}
