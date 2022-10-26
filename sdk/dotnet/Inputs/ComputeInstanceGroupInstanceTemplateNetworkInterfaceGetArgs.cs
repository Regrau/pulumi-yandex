// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateNetworkInterfaceGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dnsRecords")]
        private InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordGetArgs>? _dnsRecords;
        public InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordGetArgs> DnsRecords
        {
            get => _dnsRecords ?? (_dnsRecords = new InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordGetArgs>());
            set => _dnsRecords = value;
        }

        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("ipv4")]
        public Input<bool>? Ipv4 { get; set; }

        [Input("ipv6")]
        public Input<bool>? Ipv6 { get; set; }

        [Input("ipv6Address")]
        public Input<string>? Ipv6Address { get; set; }

        [Input("ipv6DnsRecords")]
        private InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs>? _ipv6DnsRecords;
        public InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs> Ipv6DnsRecords
        {
            get => _ipv6DnsRecords ?? (_ipv6DnsRecords = new InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs>());
            set => _ipv6DnsRecords = value;
        }

        [Input("nat")]
        public Input<bool>? Nat { get; set; }

        [Input("natDnsRecords")]
        private InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordGetArgs>? _natDnsRecords;
        public InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordGetArgs> NatDnsRecords
        {
            get => _natDnsRecords ?? (_natDnsRecords = new InputList<Inputs.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordGetArgs>());
            set => _natDnsRecords = value;
        }

        [Input("natIpAddress")]
        public Input<string>? NatIpAddress { get; set; }

        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("subnetIds")]
        private InputList<string>? _subnetIds;
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        public ComputeInstanceGroupInstanceTemplateNetworkInterfaceGetArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateNetworkInterfaceGetArgs Empty => new ComputeInstanceGroupInstanceTemplateNetworkInterfaceGetArgs();
    }
}
