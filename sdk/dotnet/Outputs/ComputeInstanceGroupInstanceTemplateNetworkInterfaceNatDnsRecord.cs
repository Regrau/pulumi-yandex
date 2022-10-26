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
    public sealed class ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord
    {
        /// <summary>
        /// DNS zone id (if not set, private zone used).
        /// </summary>
        public readonly string? DnsZoneId;
        /// <summary>
        /// DNS record fqdn (must have dot at the end).
        /// </summary>
        public readonly string Fqdn;
        /// <summary>
        /// When set to true, also create PTR DNS record.
        /// </summary>
        public readonly bool? Ptr;
        /// <summary>
        /// DNS record TTL.
        /// </summary>
        public readonly int? Ttl;

        [OutputConstructor]
        private ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord(
            string? dnsZoneId,

            string fqdn,

            bool? ptr,

            int? ttl)
        {
            DnsZoneId = dnsZoneId;
            Fqdn = fqdn;
            Ptr = ptr;
            Ttl = ttl;
        }
    }
}
