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
    public sealed class AlbVirtualHostRouteOptionsRbacPrincipalAndPrincipal
    {
        public readonly bool? Any;
        public readonly Outputs.AlbVirtualHostRouteOptionsRbacPrincipalAndPrincipalHeader? Header;
        public readonly string? RemoteIp;

        [OutputConstructor]
        private AlbVirtualHostRouteOptionsRbacPrincipalAndPrincipal(
            bool? any,

            Outputs.AlbVirtualHostRouteOptionsRbacPrincipalAndPrincipalHeader? header,

            string? remoteIp)
        {
            Any = any;
            Header = header;
            RemoteIp = remoteIp;
        }
    }
}