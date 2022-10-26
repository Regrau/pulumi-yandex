// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("backgroundPoolSize")]
        public Input<int>? BackgroundPoolSize { get; set; }

        [Input("backgroundSchedulePoolSize")]
        public Input<int>? BackgroundSchedulePoolSize { get; set; }

        [Input("compressions")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigCompressionGetArgs>? _compressions;

        /// <summary>
        /// Data compression configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigCompressionGetArgs> Compressions
        {
            get => _compressions ?? (_compressions = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigCompressionGetArgs>());
            set => _compressions = value;
        }

        [Input("geobaseUri")]
        public Input<string>? GeobaseUri { get; set; }

        [Input("graphiteRollups")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs>? _graphiteRollups;

        /// <summary>
        /// Graphite rollup configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs> GraphiteRollups
        {
            get => _graphiteRollups ?? (_graphiteRollups = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs>());
            set => _graphiteRollups = value;
        }

        /// <summary>
        /// Kafka connection configuration. The structure is documented below.
        /// </summary>
        [Input("kafka")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigKafkaGetArgs>? Kafka { get; set; }

        [Input("kafkaTopics")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicGetArgs>? _kafkaTopics;

        /// <summary>
        /// Kafka topic connection configuration. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicGetArgs> KafkaTopics
        {
            get => _kafkaTopics ?? (_kafkaTopics = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigKafkaTopicGetArgs>());
            set => _kafkaTopics = value;
        }

        [Input("keepAliveTimeout")]
        public Input<int>? KeepAliveTimeout { get; set; }

        [Input("logLevel")]
        public Input<string>? LogLevel { get; set; }

        [Input("markCacheSize")]
        public Input<int>? MarkCacheSize { get; set; }

        [Input("maxConcurrentQueries")]
        public Input<int>? MaxConcurrentQueries { get; set; }

        [Input("maxConnections")]
        public Input<int>? MaxConnections { get; set; }

        [Input("maxPartitionSizeToDrop")]
        public Input<int>? MaxPartitionSizeToDrop { get; set; }

        [Input("maxTableSizeToDrop")]
        public Input<int>? MaxTableSizeToDrop { get; set; }

        /// <summary>
        /// MergeTree engine configuration. The structure is documented below.
        /// </summary>
        [Input("mergeTree")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigMergeTreeGetArgs>? MergeTree { get; set; }

        [Input("metricLogEnabled")]
        public Input<bool>? MetricLogEnabled { get; set; }

        [Input("metricLogRetentionSize")]
        public Input<int>? MetricLogRetentionSize { get; set; }

        [Input("metricLogRetentionTime")]
        public Input<int>? MetricLogRetentionTime { get; set; }

        [Input("partLogRetentionSize")]
        public Input<int>? PartLogRetentionSize { get; set; }

        [Input("partLogRetentionTime")]
        public Input<int>? PartLogRetentionTime { get; set; }

        [Input("queryLogRetentionSize")]
        public Input<int>? QueryLogRetentionSize { get; set; }

        [Input("queryLogRetentionTime")]
        public Input<int>? QueryLogRetentionTime { get; set; }

        [Input("queryThreadLogEnabled")]
        public Input<bool>? QueryThreadLogEnabled { get; set; }

        [Input("queryThreadLogRetentionSize")]
        public Input<int>? QueryThreadLogRetentionSize { get; set; }

        [Input("queryThreadLogRetentionTime")]
        public Input<int>? QueryThreadLogRetentionTime { get; set; }

        /// <summary>
        /// RabbitMQ connection configuration. The structure is documented below.
        /// </summary>
        [Input("rabbitmq")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigRabbitmqGetArgs>? Rabbitmq { get; set; }

        [Input("textLogEnabled")]
        public Input<bool>? TextLogEnabled { get; set; }

        [Input("textLogLevel")]
        public Input<string>? TextLogLevel { get; set; }

        [Input("textLogRetentionSize")]
        public Input<int>? TextLogRetentionSize { get; set; }

        [Input("textLogRetentionTime")]
        public Input<int>? TextLogRetentionTime { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("traceLogEnabled")]
        public Input<bool>? TraceLogEnabled { get; set; }

        [Input("traceLogRetentionSize")]
        public Input<int>? TraceLogRetentionSize { get; set; }

        [Input("traceLogRetentionTime")]
        public Input<int>? TraceLogRetentionTime { get; set; }

        [Input("uncompressedCacheSize")]
        public Input<int>? UncompressedCacheSize { get; set; }

        public MdbClickhouseClusterClickhouseConfigGetArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigGetArgs Empty => new MdbClickhouseClusterClickhouseConfigGetArgs();
    }
}
