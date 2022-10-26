// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetComputeInstanceLocalDiskArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the device.
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// Size of the disk, specified in bytes.
        /// </summary>
        [Input("sizeBytes", required: true)]
        public int SizeBytes { get; set; }

        public GetComputeInstanceLocalDiskArgs()
        {
        }
        public static new GetComputeInstanceLocalDiskArgs Empty => new GetComputeInstanceLocalDiskArgs();
    }
}
