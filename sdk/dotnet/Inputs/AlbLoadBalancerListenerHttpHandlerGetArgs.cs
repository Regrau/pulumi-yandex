// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerListenerHttpHandlerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowHttp10")]
        public Input<bool>? AllowHttp10 { get; set; }

        [Input("http2Options")]
        public Input<Inputs.AlbLoadBalancerListenerHttpHandlerHttp2OptionsGetArgs>? Http2Options { get; set; }

        [Input("httpRouterId")]
        public Input<string>? HttpRouterId { get; set; }

        public AlbLoadBalancerListenerHttpHandlerGetArgs()
        {
        }
        public static new AlbLoadBalancerListenerHttpHandlerGetArgs Empty => new AlbLoadBalancerListenerHttpHandlerGetArgs();
    }
}