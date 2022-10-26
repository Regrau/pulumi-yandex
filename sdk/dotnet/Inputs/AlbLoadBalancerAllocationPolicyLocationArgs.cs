// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerAllocationPolicyLocationArgs : global::Pulumi.ResourceArgs
    {
        [Input("disableTraffic")]
        public Input<bool>? DisableTraffic { get; set; }

        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public AlbLoadBalancerAllocationPolicyLocationArgs()
        {
        }
        public static new AlbLoadBalancerAllocationPolicyLocationArgs Empty => new AlbLoadBalancerAllocationPolicyLocationArgs();
    }
}
