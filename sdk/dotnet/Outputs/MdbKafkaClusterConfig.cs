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
    public sealed class MdbKafkaClusterConfig
    {
        /// <summary>
        /// Access policy to the Kafka cluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbKafkaClusterConfigAccess? Access;
        /// <summary>
        /// Determines whether each broker will be assigned a public IP address. The default is `false`.
        /// </summary>
        public readonly bool? AssignPublicIp;
        /// <summary>
        /// Count of brokers per availability zone. The default is `1`.
        /// </summary>
        public readonly int? BrokersCount;
        /// <summary>
        /// Configuration of the Kafka subcluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbKafkaClusterConfigKafka Kafka;
        /// <summary>
        /// Enables managed schema registry on cluster. The default is `false`.
        /// </summary>
        public readonly bool? SchemaRegistry;
        /// <summary>
        /// Allows to use Kafka AdminAPI to manage topics. The default is `false`.
        /// </summary>
        public readonly bool? UnmanagedTopics;
        /// <summary>
        /// Version of the Kafka server software.
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// List of availability zones.
        /// </summary>
        public readonly ImmutableArray<string> Zones;
        /// <summary>
        /// Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.MdbKafkaClusterConfigZookeeper? Zookeeper;

        [OutputConstructor]
        private MdbKafkaClusterConfig(
            Outputs.MdbKafkaClusterConfigAccess? access,

            bool? assignPublicIp,

            int? brokersCount,

            Outputs.MdbKafkaClusterConfigKafka kafka,

            bool? schemaRegistry,

            bool? unmanagedTopics,

            string version,

            ImmutableArray<string> zones,

            Outputs.MdbKafkaClusterConfigZookeeper? zookeeper)
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
