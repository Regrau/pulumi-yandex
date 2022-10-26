// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigMergeTreeArgs : global::Pulumi.ResourceArgs
    {
        [Input("maxBytesToMergeAtMinSpaceInPool")]
        public Input<int>? MaxBytesToMergeAtMinSpaceInPool { get; set; }

        [Input("maxReplicatedMergesInQueue")]
        public Input<int>? MaxReplicatedMergesInQueue { get; set; }

        [Input("numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge")]
        public Input<int>? NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge { get; set; }

        [Input("partsToDelayInsert")]
        public Input<int>? PartsToDelayInsert { get; set; }

        [Input("partsToThrowInsert")]
        public Input<int>? PartsToThrowInsert { get; set; }

        [Input("replicatedDeduplicationWindow")]
        public Input<int>? ReplicatedDeduplicationWindow { get; set; }

        [Input("replicatedDeduplicationWindowSeconds")]
        public Input<int>? ReplicatedDeduplicationWindowSeconds { get; set; }

        public MdbClickhouseClusterClickhouseConfigMergeTreeArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigMergeTreeArgs Empty => new MdbClickhouseClusterClickhouseConfigMergeTreeArgs();
    }
}
