// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class LbNetworkLoadBalancerListenerExternalAddressSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Internal IP address for a listener. Must belong to the subnet that is referenced in subnet_id. IP address will be allocated if it wasn't been set.
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// IP version of the internal addresses that the load balancer works with. Must be one of ipv4 or ipv6. The default is ipv4.
        /// </summary>
        [Input("ipVersion")]
        public Input<string>? IpVersion { get; set; }

        public LbNetworkLoadBalancerListenerExternalAddressSpecArgs()
        {
        }
        public static new LbNetworkLoadBalancerListenerExternalAddressSpecArgs Empty => new LbNetworkLoadBalancerListenerExternalAddressSpecArgs();
    }
}
