// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerListenerEndpointAddressGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("externalIpv4Address")]
        public Input<Inputs.AlbLoadBalancerListenerEndpointAddressExternalIpv4AddressGetArgs>? ExternalIpv4Address { get; set; }

        [Input("externalIpv6Address")]
        public Input<Inputs.AlbLoadBalancerListenerEndpointAddressExternalIpv6AddressGetArgs>? ExternalIpv6Address { get; set; }

        [Input("internalIpv4Address")]
        public Input<Inputs.AlbLoadBalancerListenerEndpointAddressInternalIpv4AddressGetArgs>? InternalIpv4Address { get; set; }

        public AlbLoadBalancerListenerEndpointAddressGetArgs()
        {
        }
        public static new AlbLoadBalancerListenerEndpointAddressGetArgs Empty => new AlbLoadBalancerListenerEndpointAddressGetArgs();
    }
}
