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
    public sealed class AlbVirtualHostRoute
    {
        /// <summary>
        /// GRPC route resource. The structure is documented below.
        /// </summary>
        public readonly Outputs.AlbVirtualHostRouteGrpcRoute? GrpcRoute;
        /// <summary>
        /// HTTP route resource. The structure is documented below.
        /// </summary>
        public readonly Outputs.AlbVirtualHostRouteHttpRoute? HttpRoute;
        /// <summary>
        /// name of the route.
        /// </summary>
        public readonly string? Name;
        public readonly Outputs.AlbVirtualHostRouteRouteOptions? RouteOptions;

        [OutputConstructor]
        private AlbVirtualHostRoute(
            Outputs.AlbVirtualHostRouteGrpcRoute? grpcRoute,

            Outputs.AlbVirtualHostRouteHttpRoute? httpRoute,

            string? name,

            Outputs.AlbVirtualHostRouteRouteOptions? routeOptions)
        {
            GrpcRoute = grpcRoute;
            HttpRoute = httpRoute;
            Name = name;
            RouteOptions = routeOptions;
        }
    }
}
