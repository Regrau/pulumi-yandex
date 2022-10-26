// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of successful health checks required in order to set the `HEALTHY` status for the target.
        /// </summary>
        [Input("healthyThreshold")]
        public Input<int>? HealthyThreshold { get; set; }

        /// <summary>
        /// Options for HTTP health check. The structure is documented below.
        /// </summary>
        [Input("httpOptions")]
        public Input<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsArgs>? HttpOptions { get; set; }

        /// <summary>
        /// The interval between health checks. The default is 2 seconds.
        /// </summary>
        [Input("interval")]
        public Input<int>? Interval { get; set; }

        /// <summary>
        /// Name of the listener. The name must be unique for each listener on a single load balancer.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Options for TCP health check. The structure is documented below.
        /// </summary>
        [Input("tcpOptions")]
        public Input<Inputs.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsArgs>? TcpOptions { get; set; }

        /// <summary>
        /// Timeout for a target to return a response for the health check. The default is 1 second.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        /// <summary>
        /// Number of failed health checks before changing the status to `UNHEALTHY`. The default is 2.
        /// </summary>
        [Input("unhealthyThreshold")]
        public Input<int>? UnhealthyThreshold { get; set; }

        public LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs()
        {
        }
        public static new LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs Empty => new LbNetworkLoadBalancerAttachedTargetGroupHealthcheckArgs();
    }
}
