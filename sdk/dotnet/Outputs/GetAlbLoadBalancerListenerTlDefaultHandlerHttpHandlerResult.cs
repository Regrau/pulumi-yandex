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
    public sealed class GetAlbLoadBalancerListenerTlDefaultHandlerHttpHandlerResult
    {
        public readonly bool? AllowHttp10;
        public readonly ImmutableArray<Outputs.GetAlbLoadBalancerListenerTlDefaultHandlerHttpHandlerHttp2OptionResult> Http2Options;
        public readonly string HttpRouterId;

        [OutputConstructor]
        private GetAlbLoadBalancerListenerTlDefaultHandlerHttpHandlerResult(
            bool? allowHttp10,

            ImmutableArray<Outputs.GetAlbLoadBalancerListenerTlDefaultHandlerHttpHandlerHttp2OptionResult> http2Options,

            string httpRouterId)
        {
            AllowHttp10 = allowHttp10;
            Http2Options = http2Options;
            HttpRouterId = httpRouterId;
        }
    }
}
