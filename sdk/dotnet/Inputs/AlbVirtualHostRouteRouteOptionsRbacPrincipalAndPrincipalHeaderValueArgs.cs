// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValueArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Match exactly.
        /// </summary>
        [Input("exact")]
        public Input<string>? Exact { get; set; }

        /// <summary>
        /// Match prefix.
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        public AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValueArgs()
        {
        }
        public static new AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValueArgs Empty => new AlbVirtualHostRouteRouteOptionsRbacPrincipalAndPrincipalHeaderValueArgs();
    }
}
