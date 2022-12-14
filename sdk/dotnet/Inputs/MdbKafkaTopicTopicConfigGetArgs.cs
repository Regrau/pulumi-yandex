// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbKafkaTopicTopicConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cleanupPolicy")]
        public Input<string>? CleanupPolicy { get; set; }

        [Input("compressionType")]
        public Input<string>? CompressionType { get; set; }

        [Input("deleteRetentionMs")]
        public Input<string>? DeleteRetentionMs { get; set; }

        [Input("fileDeleteDelayMs")]
        public Input<string>? FileDeleteDelayMs { get; set; }

        [Input("flushMessages")]
        public Input<string>? FlushMessages { get; set; }

        [Input("flushMs")]
        public Input<string>? FlushMs { get; set; }

        [Input("maxMessageBytes")]
        public Input<string>? MaxMessageBytes { get; set; }

        [Input("minCompactionLagMs")]
        public Input<string>? MinCompactionLagMs { get; set; }

        [Input("minInsyncReplicas")]
        public Input<string>? MinInsyncReplicas { get; set; }

        [Input("preallocate")]
        public Input<bool>? Preallocate { get; set; }

        [Input("retentionBytes")]
        public Input<string>? RetentionBytes { get; set; }

        [Input("retentionMs")]
        public Input<string>? RetentionMs { get; set; }

        [Input("segmentBytes")]
        public Input<string>? SegmentBytes { get; set; }

        public MdbKafkaTopicTopicConfigGetArgs()
        {
        }
        public static new MdbKafkaTopicTopicConfigGetArgs Empty => new MdbKafkaTopicTopicConfigGetArgs();
    }
}
