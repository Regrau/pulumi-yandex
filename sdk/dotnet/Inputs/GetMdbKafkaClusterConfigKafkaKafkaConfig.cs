// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbKafkaClusterConfigKafkaKafkaConfigArgs : global::Pulumi.InvokeArgs
    {
        [Input("autoCreateTopicsEnable")]
        public bool? AutoCreateTopicsEnable { get; set; }

        [Input("compressionType")]
        public string? CompressionType { get; set; }

        [Input("defaultReplicationFactor")]
        public string? DefaultReplicationFactor { get; set; }

        [Input("logFlushIntervalMessages")]
        public string? LogFlushIntervalMessages { get; set; }

        [Input("logFlushIntervalMs")]
        public string? LogFlushIntervalMs { get; set; }

        [Input("logFlushSchedulerIntervalMs")]
        public string? LogFlushSchedulerIntervalMs { get; set; }

        [Input("logPreallocate")]
        public bool? LogPreallocate { get; set; }

        [Input("logRetentionBytes")]
        public string? LogRetentionBytes { get; set; }

        [Input("logRetentionHours")]
        public string? LogRetentionHours { get; set; }

        [Input("logRetentionMinutes")]
        public string? LogRetentionMinutes { get; set; }

        [Input("logRetentionMs")]
        public string? LogRetentionMs { get; set; }

        [Input("logSegmentBytes")]
        public string? LogSegmentBytes { get; set; }

        [Input("messageMaxBytes")]
        public string? MessageMaxBytes { get; set; }

        [Input("numPartitions")]
        public string? NumPartitions { get; set; }

        [Input("offsetsRetentionMinutes")]
        public string? OffsetsRetentionMinutes { get; set; }

        [Input("replicaFetchMaxBytes")]
        public string? ReplicaFetchMaxBytes { get; set; }

        [Input("saslEnabledMechanisms")]
        private List<string>? _saslEnabledMechanisms;
        public List<string> SaslEnabledMechanisms
        {
            get => _saslEnabledMechanisms ?? (_saslEnabledMechanisms = new List<string>());
            set => _saslEnabledMechanisms = value;
        }

        [Input("socketReceiveBufferBytes")]
        public string? SocketReceiveBufferBytes { get; set; }

        [Input("socketSendBufferBytes")]
        public string? SocketSendBufferBytes { get; set; }

        [Input("sslCipherSuites")]
        private List<string>? _sslCipherSuites;
        public List<string> SslCipherSuites
        {
            get => _sslCipherSuites ?? (_sslCipherSuites = new List<string>());
            set => _sslCipherSuites = value;
        }

        public GetMdbKafkaClusterConfigKafkaKafkaConfigArgs()
        {
        }
        public static new GetMdbKafkaClusterConfigKafkaKafkaConfigArgs Empty => new GetMdbKafkaClusterConfigKafkaKafkaConfigArgs();
    }
}
