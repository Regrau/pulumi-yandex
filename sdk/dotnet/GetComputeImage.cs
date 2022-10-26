// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetComputeImage
    {
        public static Task<GetComputeImageResult> InvokeAsync(GetComputeImageArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComputeImageResult>("yandex:index/getComputeImage:getComputeImage", args ?? new GetComputeImageArgs(), options.WithDefaults());

        public static Output<GetComputeImageResult> Invoke(GetComputeImageInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComputeImageResult>("yandex:index/getComputeImage:getComputeImage", args ?? new GetComputeImageInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComputeImageArgs : global::Pulumi.InvokeArgs
    {
        [Input("family")]
        public string? Family { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("imageId")]
        public string? ImageId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetComputeImageArgs()
        {
        }
        public static new GetComputeImageArgs Empty => new GetComputeImageArgs();
    }

    public sealed class GetComputeImageInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("family")]
        public Input<string>? Family { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetComputeImageInvokeArgs()
        {
        }
        public static new GetComputeImageInvokeArgs Empty => new GetComputeImageInvokeArgs();
    }


    [OutputType]
    public sealed class GetComputeImageResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly string Family;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string ImageId;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly int MinDiskSize;
        public readonly string Name;
        public readonly string OsType;
        public readonly bool Pooled;
        public readonly ImmutableArray<string> ProductIds;
        public readonly int Size;
        public readonly string Status;

        [OutputConstructor]
        private GetComputeImageResult(
            string createdAt,

            string description,

            string family,

            string folderId,

            string id,

            string imageId,

            ImmutableDictionary<string, string> labels,

            int minDiskSize,

            string name,

            string osType,

            bool pooled,

            ImmutableArray<string> productIds,

            int size,

            string status)
        {
            CreatedAt = createdAt;
            Description = description;
            Family = family;
            FolderId = folderId;
            Id = id;
            ImageId = imageId;
            Labels = labels;
            MinDiskSize = minDiskSize;
            Name = name;
            OsType = osType;
            Pooled = pooled;
            ProductIds = productIds;
            Size = size;
            Status = status;
        }
    }
}
