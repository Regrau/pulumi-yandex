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
    public sealed class MdbElasticSearchClusterHost
    {
        public readonly bool? AssignPublicIp;
        public readonly string? Fqdn;
        public readonly string Name;
        public readonly string? SubnetId;
        public readonly string Type;
        public readonly string Zone;

        [OutputConstructor]
        private MdbElasticSearchClusterHost(
            bool? assignPublicIp,

            string? fqdn,

            string name,

            string? subnetId,

            string type,

            string zone)
        {
            AssignPublicIp = assignPublicIp;
            Fqdn = fqdn;
            Name = name;
            SubnetId = subnetId;
            Type = type;
            Zone = zone;
        }
    }
}