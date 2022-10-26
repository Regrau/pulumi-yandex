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
    public sealed class AlbLoadBalancerListenerHttpHandler
    {
        public readonly bool? AllowHttp10;
        public readonly Outputs.AlbLoadBalancerListenerHttpHandlerHttp2Options? Http2Options;
        public readonly string? HttpRouterId;

        [OutputConstructor]
        private AlbLoadBalancerListenerHttpHandler(
            bool? allowHttp10,

            Outputs.AlbLoadBalancerListenerHttpHandlerHttp2Options? http2Options,

            string? httpRouterId)
        {
            AllowHttp10 = allowHttp10;
            Http2Options = http2Options;
            HttpRouterId = httpRouterId;
        }
    }
}
