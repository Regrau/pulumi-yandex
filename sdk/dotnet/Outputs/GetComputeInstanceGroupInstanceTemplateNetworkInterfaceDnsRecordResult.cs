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
    public sealed class GetComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordResult
    {
        /// <summary>
        /// DNS zone id (if not set, private zone is used).
        /// </summary>
        public readonly string DnsZoneId;
        /// <summary>
        /// The Fully Qualified Domain Name.
        /// </summary>
        public readonly string Fqdn;
        /// <summary>
        /// When set to true, also create PTR DNS record.
        /// </summary>
        public readonly bool Ptr;
        /// <summary>
        /// DNS record TTL.
        /// </summary>
        public readonly int Ttl;

        [OutputConstructor]
        private GetComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordResult(
            string dnsZoneId,

            string fqdn,

            bool ptr,

            int ttl)
        {
            DnsZoneId = dnsZoneId;
            Fqdn = fqdn;
            Ptr = ptr;
            Ttl = ttl;
        }
    }
}
