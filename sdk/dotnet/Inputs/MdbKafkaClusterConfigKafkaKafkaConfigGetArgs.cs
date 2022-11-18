// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaClusterConfigKafkaKafkaConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoCreateTopicsEnable")]
        public Input<bool>? AutoCreateTopicsEnable { get; set; }

        [Input("compressionType")]
        public Input<string>? CompressionType { get; set; }

        [Input("defaultReplicationFactor")]
        public Input<string>? DefaultReplicationFactor { get; set; }

        [Input("logFlushIntervalMessages")]
        public Input<string>? LogFlushIntervalMessages { get; set; }

        [Input("logFlushIntervalMs")]
        public Input<string>? LogFlushIntervalMs { get; set; }

        [Input("logFlushSchedulerIntervalMs")]
        public Input<string>? LogFlushSchedulerIntervalMs { get; set; }

        [Input("logPreallocate")]
        public Input<bool>? LogPreallocate { get; set; }

        [Input("logRetentionBytes")]
        public Input<string>? LogRetentionBytes { get; set; }

        [Input("logRetentionHours")]
        public Input<string>? LogRetentionHours { get; set; }

        [Input("logRetentionMinutes")]
        public Input<string>? LogRetentionMinutes { get; set; }

        [Input("logRetentionMs")]
        public Input<string>? LogRetentionMs { get; set; }

        [Input("logSegmentBytes")]
        public Input<string>? LogSegmentBytes { get; set; }

        [Input("messageMaxBytes")]
        public Input<string>? MessageMaxBytes { get; set; }

        [Input("numPartitions")]
        public Input<string>? NumPartitions { get; set; }

        [Input("offsetsRetentionMinutes")]
        public Input<string>? OffsetsRetentionMinutes { get; set; }

        [Input("replicaFetchMaxBytes")]
        public Input<string>? ReplicaFetchMaxBytes { get; set; }

        [Input("saslEnabledMechanisms")]
        private InputList<string>? _saslEnabledMechanisms;
        public InputList<string> SaslEnabledMechanisms
        {
            get => _saslEnabledMechanisms ?? (_saslEnabledMechanisms = new InputList<string>());
            set => _saslEnabledMechanisms = value;
        }

        [Input("socketReceiveBufferBytes")]
        public Input<string>? SocketReceiveBufferBytes { get; set; }

        [Input("socketSendBufferBytes")]
        public Input<string>? SocketSendBufferBytes { get; set; }

        [Input("sslCipherSuites")]
        private InputList<string>? _sslCipherSuites;
        public InputList<string> SslCipherSuites
        {
            get => _sslCipherSuites ?? (_sslCipherSuites = new InputList<string>());
            set => _sslCipherSuites = value;
        }

        public MdbKafkaClusterConfigKafkaKafkaConfigGetArgs()
        {
        }
        public static new MdbKafkaClusterConfigKafkaKafkaConfigGetArgs Empty => new MdbKafkaClusterConfigKafkaKafkaConfigGetArgs();
    }
}
