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
    public sealed class ComputeInstanceGroupInstanceTemplateBootDisk
    {
        public readonly string? DeviceName;
        public readonly string? DiskId;
        public readonly Outputs.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? InitializeParams;
        public readonly string? Mode;

        [OutputConstructor]
        private ComputeInstanceGroupInstanceTemplateBootDisk(
            string? deviceName,

            string? diskId,

            Outputs.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? initializeParams,

            string? mode)
        {
            DeviceName = deviceName;
            DiskId = diskId;
            InitializeParams = initializeParams;
            Mode = mode;
        }
    }
}
