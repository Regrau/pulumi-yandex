// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigMergeTreeInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Optional) Minimum period to clean old queue logs, blocks hashes and parts.
        /// </summary>
        [Input("cleanupDelayPeriod", required: true)]
        public Input<int> CleanupDelayPeriod { get; set; } = null!;

        /// <summary>
        /// Max bytes to merge at min space in pool: Maximum total size of a data part to merge when the number of free threads in the background pool is minimum.
        /// </summary>
        [Input("maxBytesToMergeAtMinSpaceInPool", required: true)]
        public Input<int> MaxBytesToMergeAtMinSpaceInPool { get; set; } = null!;

        /// <summary>
        /// (Optional) When there is more than specified number of merges with TTL entries in pool, do not assign new merge with TTL.
        /// </summary>
        [Input("maxNumberOfMergesWithTtlInPool", required: true)]
        public Input<int> MaxNumberOfMergesWithTtlInPool { get; set; } = null!;

        /// <summary>
        /// (Optional) Maximum number of parts in all partitions.
        /// </summary>
        [Input("maxPartsInTotal", required: true)]
        public Input<int> MaxPartsInTotal { get; set; } = null!;

        /// <summary>
        /// Max replicated merges in queue: Maximum number of merge tasks that can be in the ReplicatedMergeTree queue at the same time.
        /// </summary>
        [Input("maxReplicatedMergesInQueue", required: true)]
        public Input<int> MaxReplicatedMergesInQueue { get; set; } = null!;

        /// <summary>
        /// (Optional) Minimum delay in seconds before repeating a merge with recompression TTL. Default value: 14400 seconds (4 hours).
        /// </summary>
        [Input("mergeWithRecompressionTtlTimeout", required: true)]
        public Input<int> MergeWithRecompressionTtlTimeout { get; set; } = null!;

        /// <summary>
        /// (Optional) Minimum delay in seconds before repeating a merge with delete TTL. Default value: 14400 seconds (4 hours).
        /// </summary>
        [Input("mergeWithTtlTimeout", required: true)]
        public Input<int> MergeWithTtlTimeout { get; set; } = null!;

        /// <summary>
        /// (Optional) Minimum number of bytes in a data part that can be stored in Wide format. You can set one, both or none of these settings.
        /// </summary>
        [Input("minBytesForWidePart", required: true)]
        public Input<int> MinBytesForWidePart { get; set; } = null!;

        /// <summary>
        /// (Optional) Minimum number of rows in a data part that can be stored in Wide format. You can set one, both or none of these settings.
        /// </summary>
        [Input("minRowsForWidePart", required: true)]
        public Input<int> MinRowsForWidePart { get; set; } = null!;

        /// <summary>
        /// Number of free entries in pool to lower max size of merge: Threshold value of free entries in the pool. If the number of entries in the pool falls below this value, ClickHouse reduces the maximum size of a data part to merge. This helps handle small merges faster, rather than filling the pool with lengthy merges.
        /// </summary>
        [Input("numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge", required: true)]
        public Input<int> NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge { get; set; } = null!;

        /// <summary>
        /// Parts to delay insert: Number of active data parts in a table, on exceeding which ClickHouse starts artificially reduce the rate of inserting data into the table.
        /// </summary>
        [Input("partsToDelayInsert", required: true)]
        public Input<int> PartsToDelayInsert { get; set; } = null!;

        /// <summary>
        /// Parts to throw insert: Threshold value of active data parts in a table, on exceeding which ClickHouse throws the 'Too many parts ...' exception.
        /// </summary>
        [Input("partsToThrowInsert", required: true)]
        public Input<int> PartsToThrowInsert { get; set; } = null!;

        /// <summary>
        /// Replicated deduplication window: Number of recent hash blocks that ZooKeeper will store (the old ones will be deleted).
        /// </summary>
        [Input("replicatedDeduplicationWindow", required: true)]
        public Input<int> ReplicatedDeduplicationWindow { get; set; } = null!;

        /// <summary>
        /// Replicated deduplication window seconds: Time during which ZooKeeper stores the hash blocks (the old ones wil be deleted).
        /// </summary>
        [Input("replicatedDeduplicationWindowSeconds", required: true)]
        public Input<int> ReplicatedDeduplicationWindowSeconds { get; set; } = null!;

        /// <summary>
        /// (Optional) Enables or disables complete dropping of data parts where all rows are expired in MergeTree tables.
        /// </summary>
        [Input("ttlOnlyDropParts", required: true)]
        public Input<bool> TtlOnlyDropParts { get; set; } = null!;

        public GetMdbClickhouseClusterClickhouseConfigMergeTreeInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigMergeTreeInputArgs Empty => new GetMdbClickhouseClusterClickhouseConfigMergeTreeInputArgs();
    }
}
