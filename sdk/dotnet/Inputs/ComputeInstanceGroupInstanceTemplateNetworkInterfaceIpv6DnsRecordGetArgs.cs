// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dnsZoneId")]
        public Input<string>? DnsZoneId { get; set; }

        [Input("fqdn", required: true)]
        public Input<string> Fqdn { get; set; } = null!;

        [Input("ptr")]
        public Input<bool>? Ptr { get; set; }

        [Input("ttl")]
        public Input<int>? Ttl { get; set; }

        public ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs Empty => new ComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordGetArgs();
    }
}
