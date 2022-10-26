// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetAlbVirtualHost
    {
        public static Task<GetAlbVirtualHostResult> InvokeAsync(GetAlbVirtualHostArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAlbVirtualHostResult>("yandex:index/getAlbVirtualHost:getAlbVirtualHost", args ?? new GetAlbVirtualHostArgs(), options.WithDefaults());

        public static Output<GetAlbVirtualHostResult> Invoke(GetAlbVirtualHostInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAlbVirtualHostResult>("yandex:index/getAlbVirtualHost:getAlbVirtualHost", args ?? new GetAlbVirtualHostInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAlbVirtualHostArgs : global::Pulumi.InvokeArgs
    {
        [Input("httpRouterId")]
        public string? HttpRouterId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("virtualHostId")]
        public string? VirtualHostId { get; set; }

        public GetAlbVirtualHostArgs()
        {
        }
        public static new GetAlbVirtualHostArgs Empty => new GetAlbVirtualHostArgs();
    }

    public sealed class GetAlbVirtualHostInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("httpRouterId")]
        public Input<string>? HttpRouterId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("virtualHostId")]
        public Input<string>? VirtualHostId { get; set; }

        public GetAlbVirtualHostInvokeArgs()
        {
        }
        public static new GetAlbVirtualHostInvokeArgs Empty => new GetAlbVirtualHostInvokeArgs();
    }


    [OutputType]
    public sealed class GetAlbVirtualHostResult
    {
        public readonly ImmutableArray<string> Authorities;
        public readonly string HttpRouterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostModifyRequestHeaderResult> ModifyRequestHeaders;
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostModifyResponseHeaderResult> ModifyResponseHeaders;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostRouteOptionResult> RouteOptions;
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostRouteResult> Routes;
        public readonly string VirtualHostId;

        [OutputConstructor]
        private GetAlbVirtualHostResult(
            ImmutableArray<string> authorities,

            string httpRouterId,

            string id,

            ImmutableArray<Outputs.GetAlbVirtualHostModifyRequestHeaderResult> modifyRequestHeaders,

            ImmutableArray<Outputs.GetAlbVirtualHostModifyResponseHeaderResult> modifyResponseHeaders,

            string name,

            ImmutableArray<Outputs.GetAlbVirtualHostRouteOptionResult> routeOptions,

            ImmutableArray<Outputs.GetAlbVirtualHostRouteResult> routes,

            string virtualHostId)
        {
            Authorities = authorities;
            HttpRouterId = httpRouterId;
            Id = id;
            ModifyRequestHeaders = modifyRequestHeaders;
            ModifyResponseHeaders = modifyResponseHeaders;
            Name = name;
            RouteOptions = routeOptions;
            Routes = routes;
            VirtualHostId = virtualHostId;
        }
    }
}
