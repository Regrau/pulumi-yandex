// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceFilesystemArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the device representing the filesystem on the instance.
        /// </summary>
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        /// <summary>
        /// ID of the filesystem that should be attached.
        /// </summary>
        [Input("filesystemId", required: true)]
        public Input<string> FilesystemId { get; set; } = null!;

        /// <summary>
        /// Mode of access to the filesystem that should be attached. By default, filesystem is attached 
        /// in `READ_WRITE` mode.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        public ComputeInstanceFilesystemArgs()
        {
        }
        public static new ComputeInstanceFilesystemArgs Empty => new ComputeInstanceFilesystemArgs();
    }
}
