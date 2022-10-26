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
    public sealed class ComputeInstanceGroupInstanceTemplateNetworkInterface
    {
        public readonly ImmutableArray<Outputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecord> DnsRecords;
        public readonly string? IpAddress;
        public readonly bool? Ipv4;
        public readonly bool? Ipv6;
        public readonly string? Ipv6Address;
        public readonly ImmutableArray<Outputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecord> Ipv6DnsRecords;
        public readonly bool? Nat;
        public readonly ImmutableArray<Outputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord> NatDnsRecords;
        public readonly string? NatIpAddress;
        public readonly string? NetworkId;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly ImmutableArray<string> SubnetIds;

        [OutputConstructor]
        private ComputeInstanceGroupInstanceTemplateNetworkInterface(
            ImmutableArray<Outputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecord> dnsRecords,

            string? ipAddress,

            bool? ipv4,

            bool? ipv6,

            string? ipv6Address,

            ImmutableArray<Outputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecord> ipv6DnsRecords,

            bool? nat,

            ImmutableArray<Outputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord> natDnsRecords,

            string? natIpAddress,

            string? networkId,

            ImmutableArray<string> securityGroupIds,

            ImmutableArray<string> subnetIds)
        {
            DnsRecords = dnsRecords;
            IpAddress = ipAddress;
            Ipv4 = ipv4;
            Ipv6 = ipv6;
            Ipv6Address = ipv6Address;
            Ipv6DnsRecords = ipv6DnsRecords;
            Nat = nat;
            NatDnsRecords = natDnsRecords;
            NatIpAddress = natIpAddress;
            NetworkId = networkId;
            SecurityGroupIds = securityGroupIds;
            SubnetIds = subnetIds;
        }
    }
}
