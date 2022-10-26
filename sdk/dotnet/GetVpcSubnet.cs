// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetVpcSubnet
    {
        public static Task<GetVpcSubnetResult> InvokeAsync(GetVpcSubnetArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpcSubnetResult>("yandex:index/getVpcSubnet:getVpcSubnet", args ?? new GetVpcSubnetArgs(), options.WithDefaults());

        public static Output<GetVpcSubnetResult> Invoke(GetVpcSubnetInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVpcSubnetResult>("yandex:index/getVpcSubnet:getVpcSubnet", args ?? new GetVpcSubnetInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVpcSubnetArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("subnetId")]
        public string? SubnetId { get; set; }

        public GetVpcSubnetArgs()
        {
        }
        public static new GetVpcSubnetArgs Empty => new GetVpcSubnetArgs();
    }

    public sealed class GetVpcSubnetInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public GetVpcSubnetInvokeArgs()
        {
        }
        public static new GetVpcSubnetInvokeArgs Empty => new GetVpcSubnetInvokeArgs();
    }


    [OutputType]
    public sealed class GetVpcSubnetResult
    {
        public readonly string CreatedAt;
        public readonly string Description;
        public readonly ImmutableArray<Outputs.GetVpcSubnetDhcpOptionResult> DhcpOptions;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly string RouteTableId;
        public readonly string SubnetId;
        public readonly ImmutableArray<string> V4CidrBlocks;
        public readonly ImmutableArray<string> V6CidrBlocks;
        public readonly string Zone;

        [OutputConstructor]
        private GetVpcSubnetResult(
            string createdAt,

            string description,

            ImmutableArray<Outputs.GetVpcSubnetDhcpOptionResult> dhcpOptions,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            string routeTableId,

            string subnetId,

            ImmutableArray<string> v4CidrBlocks,

            ImmutableArray<string> v6CidrBlocks,

            string zone)
        {
            CreatedAt = createdAt;
            Description = description;
            DhcpOptions = dhcpOptions;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            NetworkId = networkId;
            RouteTableId = routeTableId;
            SubnetId = subnetId;
            V4CidrBlocks = v4CidrBlocks;
            V6CidrBlocks = v6CidrBlocks;
            Zone = zone;
        }
    }
}
