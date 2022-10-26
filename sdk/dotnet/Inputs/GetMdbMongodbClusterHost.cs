// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbMongodbClusterHostArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Has assigned public IP.
        /// </summary>
        [Input("assignPublicIp", required: true)]
        public bool AssignPublicIp { get; set; }

        /// <summary>
        /// The health of the host.
        /// </summary>
        [Input("health", required: true)]
        public string Health { get; set; } = null!;

        /// <summary>
        /// The name of the MongoDB cluster.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The role of the cluster (either PRIMARY or SECONDARY).
        /// </summary>
        [Input("role", required: true)]
        public string Role { get; set; } = null!;

        /// <summary>
        /// The name of the shard to which the host belongs.
        /// </summary>
        [Input("shardName", required: true)]
        public string ShardName { get; set; } = null!;

        /// <summary>
        /// The ID of the subnet, to which the host belongs. The subnet must
        /// be a part of the network to which the cluster belongs.
        /// </summary>
        [Input("subnetId")]
        public string? SubnetId { get; set; }

        /// <summary>
        /// Type of maintenance window. Can be either `ANYTIME` or `WEEKLY`. A day and hour of window need to be specified with weekly window.
        /// </summary>
        [Input("type", required: true)]
        public string Type { get; set; } = null!;

        /// <summary>
        /// The availability zone where the MongoDB host will be created.
        /// </summary>
        [Input("zoneId")]
        public string? ZoneId { get; set; }

        public GetMdbMongodbClusterHostArgs()
        {
        }
        public static new GetMdbMongodbClusterHostArgs Empty => new GetMdbMongodbClusterHostArgs();
    }
}
