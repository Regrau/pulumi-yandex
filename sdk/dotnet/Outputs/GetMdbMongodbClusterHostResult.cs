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
    public sealed class GetMdbMongodbClusterHostResult
    {
        public readonly bool AssignPublicIp;
        public readonly string Health;
        public readonly string Name;
        public readonly string Role;
        public readonly string ShardName;
        public readonly string? SubnetId;
        public readonly string Type;
        public readonly string? ZoneId;

        [OutputConstructor]
        private GetMdbMongodbClusterHostResult(
            bool assignPublicIp,

            string health,

            string name,

            string role,

            string shardName,

            string? subnetId,

            string type,

            string? zoneId)
        {
            AssignPublicIp = assignPublicIp;
            Health = health;
            Name = name;
            Role = role;
            ShardName = shardName;
            SubnetId = subnetId;
            Type = type;
            ZoneId = zoneId;
        }
    }
}
