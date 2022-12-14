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
    public sealed class GetMdbKafkaClusterConfigResult
    {
        /// <summary>
        /// (Optional) Access policy to the Kafka cluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbKafkaClusterConfigAccessResult Access;
        /// <summary>
        /// The flag that defines whether a public IP address is assigned to the node.
        /// </summary>
        public readonly bool? AssignPublicIp;
        /// <summary>
        /// (Optional) Count of brokers per availability zone.
        /// </summary>
        public readonly int? BrokersCount;
        /// <summary>
        /// (Optional) Configuration of the Kafka subcluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbKafkaClusterConfigKafkaResult Kafka;
        /// <summary>
        /// (Optional) Enables managed schema registry on cluster. Can be either `true` or `false`.
        /// </summary>
        public readonly bool? SchemaRegistry;
        /// <summary>
        /// (Optional) Allows to use Kafka AdminAPI to manage topics. Can be either `true` or `false`.
        /// </summary>
        public readonly bool? UnmanagedTopics;
        /// <summary>
        /// (Required) Version of the Kafka server software.
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// (Optional) List of availability zones.
        /// </summary>
        public readonly ImmutableArray<string> Zones;
        /// <summary>
        /// (Optional) Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.GetMdbKafkaClusterConfigZookeeperResult Zookeeper;

        [OutputConstructor]
        private GetMdbKafkaClusterConfigResult(
            Outputs.GetMdbKafkaClusterConfigAccessResult access,

            bool? assignPublicIp,

            int? brokersCount,

            Outputs.GetMdbKafkaClusterConfigKafkaResult kafka,

            bool? schemaRegistry,

            bool? unmanagedTopics,

            string version,

            ImmutableArray<string> zones,

            Outputs.GetMdbKafkaClusterConfigZookeeperResult zookeeper)
        {
            Access = access;
            AssignPublicIp = assignPublicIp;
            BrokersCount = brokersCount;
            Kafka = kafka;
            SchemaRegistry = schemaRegistry;
            UnmanagedTopics = unmanagedTopics;
            Version = version;
            Zones = zones;
            Zookeeper = zookeeper;
        }
    }
}
