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
    public sealed class MdbClickhouseClusterClickhouseConfig
    {
        public readonly int? BackgroundPoolSize;
        public readonly int? BackgroundSchedulePoolSize;
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigCompression> Compressions;
        public readonly string? GeobaseUri;
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigGraphiteRollup> GraphiteRollups;
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigKafka? Kafka;
        public readonly ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigKafkaTopic> KafkaTopics;
        public readonly int? KeepAliveTimeout;
        public readonly string? LogLevel;
        public readonly int? MarkCacheSize;
        public readonly int? MaxConcurrentQueries;
        public readonly int? MaxConnections;
        public readonly int? MaxPartitionSizeToDrop;
        public readonly int? MaxTableSizeToDrop;
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigMergeTree? MergeTree;
        public readonly bool? MetricLogEnabled;
        public readonly int? MetricLogRetentionSize;
        public readonly int? MetricLogRetentionTime;
        public readonly int? PartLogRetentionSize;
        public readonly int? PartLogRetentionTime;
        public readonly int? QueryLogRetentionSize;
        public readonly int? QueryLogRetentionTime;
        public readonly bool? QueryThreadLogEnabled;
        public readonly int? QueryThreadLogRetentionSize;
        public readonly int? QueryThreadLogRetentionTime;
        public readonly Outputs.MdbClickhouseClusterClickhouseConfigRabbitmq? Rabbitmq;
        public readonly bool? TextLogEnabled;
        public readonly string? TextLogLevel;
        public readonly int? TextLogRetentionSize;
        public readonly int? TextLogRetentionTime;
        public readonly string? Timezone;
        public readonly bool? TraceLogEnabled;
        public readonly int? TraceLogRetentionSize;
        public readonly int? TraceLogRetentionTime;
        public readonly int? UncompressedCacheSize;

        [OutputConstructor]
        private MdbClickhouseClusterClickhouseConfig(
            int? backgroundPoolSize,

            int? backgroundSchedulePoolSize,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigCompression> compressions,

            string? geobaseUri,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigGraphiteRollup> graphiteRollups,

            Outputs.MdbClickhouseClusterClickhouseConfigKafka? kafka,

            ImmutableArray<Outputs.MdbClickhouseClusterClickhouseConfigKafkaTopic> kafkaTopics,

            int? keepAliveTimeout,

            string? logLevel,

            int? markCacheSize,

            int? maxConcurrentQueries,

            int? maxConnections,

            int? maxPartitionSizeToDrop,

            int? maxTableSizeToDrop,

            Outputs.MdbClickhouseClusterClickhouseConfigMergeTree? mergeTree,

            bool? metricLogEnabled,

            int? metricLogRetentionSize,

            int? metricLogRetentionTime,

            int? partLogRetentionSize,

            int? partLogRetentionTime,

            int? queryLogRetentionSize,

            int? queryLogRetentionTime,

            bool? queryThreadLogEnabled,

            int? queryThreadLogRetentionSize,

            int? queryThreadLogRetentionTime,

            Outputs.MdbClickhouseClusterClickhouseConfigRabbitmq? rabbitmq,

            bool? textLogEnabled,

            string? textLogLevel,

            int? textLogRetentionSize,

            int? textLogRetentionTime,

            string? timezone,

            bool? traceLogEnabled,

            int? traceLogRetentionSize,

            int? traceLogRetentionTime,

            int? uncompressedCacheSize)
        {
            BackgroundPoolSize = backgroundPoolSize;
            BackgroundSchedulePoolSize = backgroundSchedulePoolSize;
            Compressions = compressions;
            GeobaseUri = geobaseUri;
            GraphiteRollups = graphiteRollups;
            Kafka = kafka;
            KafkaTopics = kafkaTopics;
            KeepAliveTimeout = keepAliveTimeout;
            LogLevel = logLevel;
            MarkCacheSize = markCacheSize;
            MaxConcurrentQueries = maxConcurrentQueries;
            MaxConnections = maxConnections;
            MaxPartitionSizeToDrop = maxPartitionSizeToDrop;
            MaxTableSizeToDrop = maxTableSizeToDrop;
            MergeTree = mergeTree;
            MetricLogEnabled = metricLogEnabled;
            MetricLogRetentionSize = metricLogRetentionSize;
            MetricLogRetentionTime = metricLogRetentionTime;
            PartLogRetentionSize = partLogRetentionSize;
            PartLogRetentionTime = partLogRetentionTime;
            QueryLogRetentionSize = queryLogRetentionSize;
            QueryLogRetentionTime = queryLogRetentionTime;
            QueryThreadLogEnabled = queryThreadLogEnabled;
            QueryThreadLogRetentionSize = queryThreadLogRetentionSize;
            QueryThreadLogRetentionTime = queryThreadLogRetentionTime;
            Rabbitmq = rabbitmq;
            TextLogEnabled = textLogEnabled;
            TextLogLevel = textLogLevel;
            TextLogRetentionSize = textLogRetentionSize;
            TextLogRetentionTime = textLogRetentionTime;
            Timezone = timezone;
            TraceLogEnabled = traceLogEnabled;
            TraceLogRetentionSize = traceLogRetentionSize;
            TraceLogRetentionTime = traceLogRetentionTime;
            UncompressedCacheSize = uncompressedCacheSize;
        }
    }
}
