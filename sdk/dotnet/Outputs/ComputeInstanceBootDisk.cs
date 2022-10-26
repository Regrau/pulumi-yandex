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
        /// <summary>
        /// Whether the disk is auto-deleted when the instance
        /// is deleted. The default value is false.
        /// </summary>
        public readonly bool? AutoDelete;
        /// <summary>
        /// Name that can be used to access an attached disk
        /// under `/dev/disk/by-id/`.
        /// </summary>
        public readonly string? DeviceName;
        /// <summary>
        /// ID of the disk that is attached to the instance.
        /// </summary>
        public readonly string? DiskId;
        /// <summary>
        /// Parameters for a new disk that will be created
        /// alongside the new instance. Either `initialize_params` or `disk_id` must be set. The structure is documented below.
        /// </summary>
        public readonly Outputs.ComputeInstanceBootDiskInitializeParams? InitializeParams;
        /// <summary>
        /// Type of access to the disk resource. By default, a disk is attached in `READ_WRITE` mode.
        /// </summary>
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
