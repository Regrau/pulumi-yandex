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
    public sealed class GetMdbClickhouseClusterShardResult
    {
        /// <summary>
        /// The name of the ClickHouse cluster.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resources allocated to hosts of the shard. The resources specified for the shard takes precedence over the resources specified for the cluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbClickhouseClusterShardResourcesResult Resources;
        /// <summary>
        /// The weight of the shard.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private GetMdbClickhouseClusterShardResult(
            string name,

            Outputs.GetMdbClickhouseClusterShardResourcesResult resources,

            int weight)
        {
            Name = name;
            Resources = resources;
            Weight = weight;
        }
    }
}
