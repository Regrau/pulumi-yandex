// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeDisk
    {
        /// <summary>
        /// Get information about a Yandex Compute disk. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/compute/concepts/disk).
        /// </summary>
        public static Task<GetComputeDiskResult> InvokeAsync(GetComputeDiskArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeDiskResult>("yandex:index/getComputeDisk:getComputeDisk", args ?? new GetComputeDiskArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Compute disk. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/compute/concepts/disk).
        /// </summary>
        public static Output<GetComputeDiskResult> Invoke(GetComputeDiskInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComputeDiskResult>("yandex:index/getComputeDisk:getComputeDisk", args ?? new GetComputeDiskInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComputeDiskArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of a specific disk.
        /// </summary>
        [Input("diskId")]
        public string? DiskId { get; set; }

        [Input("diskPlacementPolicy")]
        public Inputs.GetComputeDiskDiskPlacementPolicyArgs? DiskPlacementPolicy { get; set; }

        /// <summary>
        /// ID of the folder that the disk belongs to.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Name of the disk.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetComputeDiskArgs()
        {
        }
        public static new GetComputeDiskArgs Empty => new GetComputeDiskArgs();
    }

    public sealed class GetComputeDiskInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of a specific disk.
        /// </summary>
        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        [Input("diskPlacementPolicy")]
        public Input<Inputs.GetComputeDiskDiskPlacementPolicyInputArgs>? DiskPlacementPolicy { get; set; }

        /// <summary>
        /// ID of the folder that the disk belongs to.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Name of the disk.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetComputeDiskInvokeArgs()
        {
        }
        public static new GetComputeDiskInvokeArgs Empty => new GetComputeDiskInvokeArgs();
    }


    [OutputType]
    public sealed class GetComputeDiskResult
    {
        /// <summary>
        /// The block size of the disk in bytes.
        /// </summary>
        public readonly int BlockSize;
        /// <summary>
        /// Disk creation timestamp.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Optional description of this disk.
        /// </summary>
        public readonly string Description;
        public readonly string DiskId;
        public readonly Outputs.GetComputeDiskDiskPlacementPolicyResult? DiskPlacementPolicy;
        /// <summary>
        /// ID of the folder that the disk belongs to.
        /// </summary>
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// ID of the source image that was used to create this disk.
        /// </summary>
        public readonly string ImageId;
        /// <summary>
        /// IDs of instances to which this disk is attached.
        /// </summary>
        public readonly ImmutableArray<string> InstanceIds;
        /// <summary>
        /// Map of labels applied to this disk.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        /// <summary>
        /// License IDs that indicate which licenses are attached to this disk.
        /// </summary>
        public readonly ImmutableArray<string> ProductIds;
        /// <summary>
        /// Size of the disk, specified in Gb.
        /// </summary>
        public readonly int Size;
        /// <summary>
        /// Source snapshot that was used to create this disk.
        /// </summary>
        public readonly string SnapshotId;
        /// <summary>
        /// Status of the disk.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type of the disk.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// ID of the zone where the disk resides.
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private GetComputeDiskResult(
            int blockSize,

            string createdAt,

            string description,

            string diskId,

            Outputs.GetComputeDiskDiskPlacementPolicyResult? diskPlacementPolicy,

            string folderId,

            string id,

            string imageId,

            ImmutableArray<string> instanceIds,

            ImmutableDictionary<string, string> labels,

            string name,

            ImmutableArray<string> productIds,

            int size,

            string snapshotId,

            string status,

            string type,

            string zone)
        {
            BlockSize = blockSize;
            CreatedAt = createdAt;
            Description = description;
            DiskId = diskId;
            DiskPlacementPolicy = diskPlacementPolicy;
            FolderId = folderId;
            Id = id;
            ImageId = imageId;
            InstanceIds = instanceIds;
            Labels = labels;
            Name = name;
            ProductIds = productIds;
            Size = size;
            SnapshotId = snapshotId;
            Status = status;
            Type = type;
            Zone = zone;
        }
    }
}
