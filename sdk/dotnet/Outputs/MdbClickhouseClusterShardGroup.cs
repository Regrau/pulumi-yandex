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
    public sealed class MdbClickhouseClusterShardGroup
    {
        /// <summary>
        /// Description of the shard group.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of shards names that belong to the shard group.
        /// </summary>
        public readonly ImmutableArray<string> ShardNames;

        [OutputConstructor]
        private MdbClickhouseClusterShardGroup(
            string? description,

            string name,

            ImmutableArray<string> shardNames)
        {
            Description = description;
            Name = name;
            ShardNames = shardNames;
        }
    }
}
