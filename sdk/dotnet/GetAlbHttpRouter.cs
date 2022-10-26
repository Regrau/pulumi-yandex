// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetAlbHttpRouter
    {
        /// <summary>
        /// Get information about a Yandex Application Load Balancer HTTP Router. For more information, see
        /// [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var tf_router = Yandex.GetAlbHttpRouter.Invoke(new()
        ///     {
        ///         HttpRouterId = "my-http-router-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [Application Load Balancer HTTP Router] that can be used by other resources.
        /// </summary>
        public static Task<GetAlbHttpRouterResult> InvokeAsync(GetAlbHttpRouterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAlbHttpRouterResult>("yandex:index/getAlbHttpRouter:getAlbHttpRouter", args ?? new GetAlbHttpRouterArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Application Load Balancer HTTP Router. For more information, see
        /// [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var tf_router = Yandex.GetAlbHttpRouter.Invoke(new()
        ///     {
        ///         HttpRouterId = "my-http-router-id",
        ///     });
        /// 
        /// });
        /// ```
        /// 
        /// This data source is used to define [Application Load Balancer HTTP Router] that can be used by other resources.
        /// </summary>
        public static Output<GetAlbHttpRouterResult> Invoke(GetAlbHttpRouterInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAlbHttpRouterResult>("yandex:index/getAlbHttpRouter:getAlbHttpRouter", args ?? new GetAlbHttpRouterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAlbHttpRouterArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Description of the HTTP Router.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// HTTP Router ID.
        /// </summary>
        [Input("httpRouterId")]
        public string? HttpRouterId { get; set; }

        /// <summary>
        /// - Name of the HTTP Router.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        public GetAlbHttpRouterArgs()
        {
        }
        public static new GetAlbHttpRouterArgs Empty => new GetAlbHttpRouterArgs();
    }

    public sealed class GetAlbHttpRouterInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Description of the HTTP Router.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// HTTP Router ID.
        /// </summary>
        [Input("httpRouterId")]
        public Input<string>? HttpRouterId { get; set; }

        /// <summary>
        /// - Name of the HTTP Router.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetAlbHttpRouterInvokeArgs()
        {
        }
        public static new GetAlbHttpRouterInvokeArgs Empty => new GetAlbHttpRouterInvokeArgs();
    }


    [OutputType]
    public sealed class GetAlbHttpRouterResult
    {
        /// <summary>
        /// Creation timestamp of this HTTP Router.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Description of the HTTP Router.
        /// </summary>
        public readonly string Description;
        public readonly string FolderId;
        public readonly string HttpRouterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Labels to assign to this HTTP Router.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetAlbHttpRouterRouteOptionResult> RouteOptions;

        [OutputConstructor]
        private GetAlbHttpRouterResult(
            string createdAt,

            string description,

            string folderId,

            string httpRouterId,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            ImmutableArray<Outputs.GetAlbHttpRouterRouteOptionResult> routeOptions)
        {
            CreatedAt = createdAt;
            Description = description;
            FolderId = folderId;
            HttpRouterId = httpRouterId;
            Id = id;
            Labels = labels;
            Name = name;
            RouteOptions = routeOptions;
        }
    }
}
