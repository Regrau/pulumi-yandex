// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetVpcRouteTable
    {
        /// <summary>
        /// Get information about a Yandex VPC route table. For more information, see
        /// [Yandex.Cloud VPC](https://cloud.yandex.com/docs/vpc/concepts/index).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Yandex.GetVpcRouteTable.Invoke(new()
        ///     {
        ///         RouteTableId = "my-rt-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [VPC Route Table] that can be used by other resources.
        /// </summary>
        public static Task<GetVpcRouteTableResult> InvokeAsync(GetVpcRouteTableArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpcRouteTableResult>("yandex:index/getVpcRouteTable:getVpcRouteTable", args ?? new GetVpcRouteTableArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex VPC route table. For more information, see
        /// [Yandex.Cloud VPC](https://cloud.yandex.com/docs/vpc/concepts/index).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var @this = Yandex.GetVpcRouteTable.Invoke(new()
        ///     {
        ///         RouteTableId = "my-rt-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [VPC Route Table] that can be used by other resources.
        /// </summary>
        public static Output<GetVpcRouteTableResult> Invoke(GetVpcRouteTableInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVpcRouteTableResult>("yandex:index/getVpcRouteTable:getVpcRouteTable", args ?? new GetVpcRouteTableInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVpcRouteTableArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// - Name of the route table.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Route table ID.
        /// </summary>
        [Input("routeTableId")]
        public string? RouteTableId { get; set; }

        public GetVpcRouteTableArgs()
        {
        }
        public static new GetVpcRouteTableArgs Empty => new GetVpcRouteTableArgs();
    }

    public sealed class GetVpcRouteTableInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// - Name of the route table.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Route table ID.
        /// </summary>
        [Input("routeTableId")]
        public Input<string>? RouteTableId { get; set; }

        public GetVpcRouteTableInvokeArgs()
        {
        }
        public static new GetVpcRouteTableInvokeArgs Empty => new GetVpcRouteTableInvokeArgs();
    }


    [OutputType]
    public sealed class GetVpcRouteTableResult
    {
        /// <summary>
        /// Creation timestamp of this route table.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Description of the route table.
        /// </summary>
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Labels to assign to this route table.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        /// <summary>
        /// ID of the network this route table belongs to.
        /// </summary>
        public readonly string NetworkId;
        public readonly string RouteTableId;
        /// <summary>
        /// List of static route records of the route table. Structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVpcRouteTableStaticRouteResult> StaticRoutes;

        [OutputConstructor]
        private GetVpcRouteTableResult(
            string createdAt,

            string description,

            string folderId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            string routeTableId,

            ImmutableArray<Outputs.GetVpcRouteTableStaticRouteResult> staticRoutes)
        {
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            Id = id;
            Labels = labels;
            Name = name;
            NetworkId = networkId;
            RouteTableId = routeTableId;
            StaticRoutes = staticRoutes;
        }
    }
}
