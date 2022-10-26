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
    public sealed class ComputeInstanceNetworkInterface
    {
        public readonly ImmutableArray<Outputs.ComputeInstanceNetworkInterfaceDnsRecord> DnsRecords;
        public readonly int? Index;
        public readonly string? IpAddress;
        public readonly bool? Ipv4;
        public readonly bool? Ipv6;
        public readonly string? Ipv6Address;
        public readonly ImmutableArray<Outputs.ComputeInstanceNetworkInterfaceIpv6DnsRecord> Ipv6DnsRecords;
        public readonly string? MacAddress;
        public readonly bool? Nat;
        public readonly ImmutableArray<Outputs.ComputeInstanceNetworkInterfaceNatDnsRecord> NatDnsRecords;
        public readonly string? NatIpAddress;
        public readonly string? NatIpVersion;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly string SubnetId;

        [OutputConstructor]
        private ComputeInstanceNetworkInterface(
            ImmutableArray<Outputs.ComputeInstanceNetworkInterfaceDnsRecord> dnsRecords,

            int? index,

            string? ipAddress,

            bool? ipv4,

            bool? ipv6,

            string? ipv6Address,

            ImmutableArray<Outputs.ComputeInstanceNetworkInterfaceIpv6DnsRecord> ipv6DnsRecords,

            string? macAddress,

            bool? nat,

            ImmutableArray<Outputs.ComputeInstanceNetworkInterfaceNatDnsRecord> natDnsRecords,

            string? natIpAddress,

            string? natIpVersion,

            ImmutableArray<string> securityGroupIds,

            string subnetId)
        {
            DnsRecords = dnsRecords;
            Index = index;
            IpAddress = ipAddress;
            Ipv4 = ipv4;
            Ipv6 = ipv6;
            Ipv6Address = ipv6Address;
            Ipv6DnsRecords = ipv6DnsRecords;
            MacAddress = macAddress;
            Nat = nat;
            NatDnsRecords = natDnsRecords;
            NatIpAddress = natIpAddress;
            NatIpVersion = natIpVersion;
            SecurityGroupIds = securityGroupIds;
            SubnetId = subnetId;
        }
    }
}
