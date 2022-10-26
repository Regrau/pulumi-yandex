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
    public sealed class GetAlbVirtualHostRouteResult
    {
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostRouteGrpcRouteResult> GrpcRoutes;
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostRouteHttpRouteResult> HttpRoutes;
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetAlbVirtualHostRouteRouteOptionResult> RouteOptions;

        [OutputConstructor]
        private GetAlbVirtualHostRouteResult(
            ImmutableArray<Outputs.GetAlbVirtualHostRouteGrpcRouteResult> grpcRoutes,

            ImmutableArray<Outputs.GetAlbVirtualHostRouteHttpRouteResult> httpRoutes,

            string name,

            ImmutableArray<Outputs.GetAlbVirtualHostRouteRouteOptionResult> routeOptions)
        {
            GrpcRoutes = grpcRoutes;
            HttpRoutes = httpRoutes;
            Name = name;
            RouteOptions = routeOptions;
        }
    }
}
