// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// name of the route.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("value")]
        public Input<Inputs.AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValueGetArgs>? Value { get; set; }

        public AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderGetArgs()
        {
        }
        public static new AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderGetArgs Empty => new AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderGetArgs();
    }
}
