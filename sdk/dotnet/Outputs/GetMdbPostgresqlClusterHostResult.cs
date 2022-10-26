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
    public sealed class GetMdbPostgresqlClusterHostResult
    {
        public readonly bool AssignPublicIp;
        public readonly string Fqdn;
        public readonly int Priority;
        public readonly string ReplicationSource;
        public readonly string Role;
        public readonly string SubnetId;
        public readonly string Zone;

        [OutputConstructor]
        private GetMdbPostgresqlClusterHostResult(
            bool assignPublicIp,

            string fqdn,

            int priority,

            string replicationSource,

            string role,

            string subnetId,

            string zone)
        {
            AssignPublicIp = assignPublicIp;
            Fqdn = fqdn;
            Priority = priority;
            ReplicationSource = replicationSource;
            Role = role;
            SubnetId = subnetId;
            Zone = zone;
        }
    }
}
