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
    public sealed class GetMdbClickhouseClusterClickhouseConfigResult
    {
        public readonly int? BackgroundPoolSize;
        public readonly int? BackgroundSchedulePoolSize;
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigCompressionResult> Compressions;
        public readonly string? GeobaseUri;
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigGraphiteRollupResult> GraphiteRollups;
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigKafkaTopicResult> KafkaTopics;
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigKafkaResult> Kafkas;
        public readonly int? KeepAliveTimeout;
        public readonly string? LogLevel;
        public readonly int? MarkCacheSize;
        public readonly int? MaxConcurrentQueries;
        public readonly int? MaxConnections;
        public readonly int? MaxPartitionSizeToDrop;
        public readonly int? MaxTableSizeToDrop;
        public readonly Outputs.GetMdbClickhouseClusterClickhouseConfigMergeTreeResult MergeTree;
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
        public readonly Outputs.GetMdbClickhouseClusterClickhouseConfigRabbitmqResult Rabbitmq;
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
        private GetMdbClickhouseClusterClickhouseConfigResult(
            int? backgroundPoolSize,

            int? backgroundSchedulePoolSize,

            ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigCompressionResult> compressions,

            string? geobaseUri,

            ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigGraphiteRollupResult> graphiteRollups,

            ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigKafkaTopicResult> kafkaTopics,

            ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseConfigKafkaResult> kafkas,

            int? keepAliveTimeout,

            string? logLevel,

            int? markCacheSize,

            int? maxConcurrentQueries,

            int? maxConnections,

            int? maxPartitionSizeToDrop,

            int? maxTableSizeToDrop,

            Outputs.GetMdbClickhouseClusterClickhouseConfigMergeTreeResult mergeTree,

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

            Outputs.GetMdbClickhouseClusterClickhouseConfigRabbitmqResult rabbitmq,

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
            KafkaTopics = kafkaTopics;
            Kafkas = kafkas;
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
