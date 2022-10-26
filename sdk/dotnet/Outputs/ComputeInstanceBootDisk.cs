// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class ComputeInstanceBootDisk
    {
        public readonly bool? AutoDelete;
        public readonly string? DeviceName;
        public readonly string? DiskId;
        public readonly Outputs.ComputeInstanceBootDiskInitializeParams? InitializeParams;
        public readonly string? Mode;

        [OutputConstructor]
        private ComputeInstanceBootDisk(
            bool? autoDelete,

            string? deviceName,

            string? diskId,

            Outputs.ComputeInstanceBootDiskInitializeParams? initializeParams,

            string? mode)
        {
            AutoDelete = autoDelete;
            DeviceName = deviceName;
            DiskId = diskId;
            InitializeParams = initializeParams;
            Mode = mode;
        }
    }
}
