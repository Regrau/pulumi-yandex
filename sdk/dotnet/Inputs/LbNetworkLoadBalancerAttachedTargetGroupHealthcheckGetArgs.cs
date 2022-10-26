// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LbNetworkLoadBalancerAttachedTargetGroupHealthcheckGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("healthyThreshold")]
        public Input<int>? HealthyThreshold { get; set; }

        [Input("httpOptions")]
        public Input<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsGetArgs>? HttpOptions { get; set; }

        [Input("interval")]
        public Input<int>? Interval { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("tcpOptions")]
        public Input<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsGetArgs>? TcpOptions { get; set; }

        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        [Input("unhealthyThreshold")]
        public Input<int>? UnhealthyThreshold { get; set; }

        public LbNetworkLoadBalancerAttachedTargetGroupHealthcheckGetArgs()
        {
        }
        public static new LbNetworkLoadBalancerAttachedTargetGroupHealthcheckGetArgs Empty => new LbNetworkLoadBalancerAttachedTargetGroupHealthcheckGetArgs();
    }
}