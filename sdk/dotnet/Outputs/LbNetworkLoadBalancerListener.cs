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
    public sealed class LbNetworkLoadBalancerListener
    {
        public readonly Outputs.LbNetworkLoadBalancerListenerExternalAddressSpec? ExternalAddressSpec;
        public readonly Outputs.LbNetworkLoadBalancerListenerInternalAddressSpec? InternalAddressSpec;
        public readonly string Name;
        public readonly int Port;
        public readonly string? Protocol;
        public readonly int? TargetPort;

        [OutputConstructor]
        private LbNetworkLoadBalancerListener(
            Outputs.LbNetworkLoadBalancerListenerExternalAddressSpec? externalAddressSpec,

            Outputs.LbNetworkLoadBalancerListenerInternalAddressSpec? internalAddressSpec,

            string name,

            int port,

            string? protocol,

            int? targetPort)
        {
            ExternalAddressSpec = externalAddressSpec;
            InternalAddressSpec = internalAddressSpec;
            Name = name;
            Port = port;
            Protocol = protocol;
            TargetPort = targetPort;
        }
    }
}
