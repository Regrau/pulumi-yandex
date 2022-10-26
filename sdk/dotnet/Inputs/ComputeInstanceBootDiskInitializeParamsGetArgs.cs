// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceBootDiskInitializeParamsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Block size of the disk, specified in bytes.
        /// </summary>
        [Input("blockSize")]
        public Input<int>? BlockSize { get; set; }

        /// <summary>
        /// Description of the boot disk.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A disk image to initialize this disk from.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        /// <summary>
        /// Name of the boot disk.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Size of the disk in GB.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// A snapshot to initialize this disk from.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// Disk type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public ComputeInstanceBootDiskInitializeParamsGetArgs()
        {
        }
        public static new ComputeInstanceBootDiskInitializeParamsGetArgs Empty => new ComputeInstanceBootDiskInitializeParamsGetArgs();
    }
}
