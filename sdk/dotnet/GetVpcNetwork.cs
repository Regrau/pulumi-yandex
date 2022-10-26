// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetVpcNetwork
    {
        /// <summary>
        /// Get information about a Yandex VPC network. For more information, see
        /// [Yandex.Cloud VPC](https://cloud.yandex.com/docs/vpc/concepts/index).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var admin = Yandex.GetVpcNetwork.Invoke(new()
        ///     {
        ///         NetworkId = "my-network-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [VPC Networks] that can be used by other resources.
        /// </summary>
        public static Task<GetVpcNetworkResult> InvokeAsync(GetVpcNetworkArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpcNetworkResult>("yandex:index/getVpcNetwork:getVpcNetwork", args ?? new GetVpcNetworkArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex VPC network. For more information, see
        /// [Yandex.Cloud VPC](https://cloud.yandex.com/docs/vpc/concepts/index).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var admin = Yandex.GetVpcNetwork.Invoke(new()
        ///     {
        ///         NetworkId = "my-network-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [VPC Networks] that can be used by other resources.
        /// </summary>
        public static Output<GetVpcNetworkResult> Invoke(GetVpcNetworkInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVpcNetworkResult>("yandex:index/getVpcNetwork:getVpcNetwork", args ?? new GetVpcNetworkInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVpcNetworkArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Name of the network.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the network.
        /// </summary>
        [Input("networkId")]
        public string? NetworkId { get; set; }

        public GetVpcNetworkArgs()
        {
        }
        public static new GetVpcNetworkArgs Empty => new GetVpcNetworkArgs();
    }

    public sealed class GetVpcNetworkInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Name of the network.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network.
        /// </summary>
        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        public GetVpcNetworkInvokeArgs()
        {
        }
        public static new GetVpcNetworkInvokeArgs Empty => new GetVpcNetworkInvokeArgs();
    }


    [OutputType]
    public sealed class GetVpcNetworkResult
    {
        /// <summary>
        /// Creation timestamp of this network.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// ID of default Security Group of this network.
        /// </summary>
        public readonly string DefaultSecurityGroupId;
        /// <summary>
        /// Description of the network.
        /// </summary>
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Labels assigned to this network.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        /// <summary>
        /// List of subnet ids.
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;

        [OutputConstructor]
        private GetVpcNetworkResult(
            string createdAt,

            string defaultSecurityGroupId,

            string description,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            ImmutableArray<string> subnetIds)
        {
            CreatedAt = createdAt;
            DefaultSecurityGroupId = defaultSecurityGroupId;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            NetworkId = networkId;
            SubnetIds = subnetIds;
        }
    }
}
