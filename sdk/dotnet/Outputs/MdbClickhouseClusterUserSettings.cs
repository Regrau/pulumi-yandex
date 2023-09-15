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
    public sealed class MdbClickhouseClusterUserSettings
    {
        /// <summary>
        /// Include CORS headers in HTTP responces.
        /// </summary>
        public readonly bool? AddHttpCorsHeader;
        /// <summary>
        /// Allows or denies DDL queries.
        /// </summary>
        public readonly bool? AllowDdl;
        /// <summary>
        /// Enables introspections functions for query profiling.
        /// </summary>
        public readonly bool? AllowIntrospectionFunctions;
        /// <summary>
        /// Allows specifying LowCardinality modifier for types of small fixed size (8 or less) in CREATE TABLE statements. Enabling this may increase merge times and memory consumption.
        /// </summary>
        public readonly bool? AllowSuspiciousLowCardinalityTypes;
        /// <summary>
        /// Enables asynchronous inserts. Disabled by default.
        /// </summary>
        public readonly bool? AsyncInsert;
        /// <summary>
        /// The maximum timeout in milliseconds since the first INSERT query before inserting collected data. If the parameter is set to 0, the timeout is disabled. Default value: 200.
        /// </summary>
        public readonly int? AsyncInsertBusyTimeout;
        /// <summary>
        /// The maximum size of the unparsed data in bytes collected per query before being inserted. If the parameter is set to 0, asynchronous insertions are disabled. Default value: 100000.
        /// </summary>
        public readonly int? AsyncInsertMaxDataSize;
        /// <summary>
        /// The maximum timeout in milliseconds since the last INSERT query before dumping collected data. If enabled, the settings prolongs the async_insert_busy_timeout with every INSERT query as long as async_insert_max_data_size is not exceeded.
        /// </summary>
        public readonly int? AsyncInsertStaleTimeout;
        /// <summary>
        /// The maximum number of threads for background data parsing and insertion. If the parameter is set to 0, asynchronous insertions are disabled. Default value: 16.
        /// </summary>
        public readonly int? AsyncInsertThreads;
        /// <summary>
        /// Cancels HTTP read-only queries (e.g. SELECT) when a client closes the connection without waiting for the response.
        /// Default value: false.
        /// </summary>
        public readonly bool? CancelHttpReadonlyQueriesOnClientClose;
        /// <summary>
        /// Enable compilation of queries.
        /// </summary>
        public readonly bool? Compile;
        /// <summary>
        /// Turn on expression compilation.
        /// </summary>
        public readonly bool? CompileExpressions;
        /// <summary>
        /// Connect timeout in milliseconds on the socket used for communicating with the client.
        /// </summary>
        public readonly int? ConnectTimeout;
        /// <summary>
        /// The timeout in milliseconds for connecting to a remote server for a Distributed table engine, if the ‘shard’ and ‘replica’ sections are used in the cluster definition. If unsuccessful, several attempts are made to connect to various replicas. Default value: 50.
        /// </summary>
        public readonly int? ConnectTimeoutWithFailover;
        /// <summary>
        /// Specifies which of the uniq* functions should be used to perform the COUNT(DISTINCT …) construction.
        /// </summary>
        public readonly string? CountDistinctImplementation;
        /// <summary>
        /// Sets behaviour on overflow when using DISTINCT. Possible values:
        /// </summary>
        public readonly string? DistinctOverflowMode;
        /// <summary>
        /// Determine the behavior of distributed subqueries.
        /// </summary>
        public readonly bool? DistributedAggregationMemoryEfficient;
        /// <summary>
        /// Timeout for DDL queries, in milliseconds.
        /// </summary>
        public readonly int? DistributedDdlTaskTimeout;
        /// <summary>
        /// Changes the behaviour of distributed subqueries.
        /// </summary>
        public readonly string? DistributedProductMode;
        /// <summary>
        /// Allows to retunr empty result.
        /// </summary>
        public readonly bool? EmptyResultForAggregationByEmptySet;
        /// <summary>
        /// Enables or disables data compression in the response to an HTTP request.
        /// </summary>
        public readonly bool? EnableHttpCompression;
        /// <summary>
        /// Forces a query to an out-of-date replica if updated data is not available.
        /// </summary>
        public readonly bool? FallbackToStaleReplicasForDistributedQueries;
        /// <summary>
        /// Sets the data format of a nested columns.
        /// </summary>
        public readonly bool? FlattenNested;
        /// <summary>
        /// Disables query execution if the index can’t be used by date.
        /// </summary>
        public readonly bool? ForceIndexByDate;
        /// <summary>
        /// Disables query execution if indexing by the primary key is not possible.
        /// </summary>
        public readonly bool? ForcePrimaryKey;
        /// <summary>
        /// Sets behaviour on overflow while GROUP BY operation. Possible values:
        /// </summary>
        public readonly string? GroupByOverflowMode;
        /// <summary>
        /// Sets the threshold of the number of keys, after that the two-level aggregation should be used.
        /// </summary>
        public readonly int? GroupByTwoLevelThreshold;
        /// <summary>
        /// Sets the threshold of the number of bytes, after that the two-level aggregation should be used.
        /// </summary>
        public readonly int? GroupByTwoLevelThresholdBytes;
        /// <summary>
        /// Timeout for HTTP connection in milliseconds.
        /// </summary>
        public readonly int? HttpConnectionTimeout;
        /// <summary>
        /// Sets minimal interval between notifications about request process in HTTP header X-ClickHouse-Progress.
        /// </summary>
        public readonly int? HttpHeadersProgressInterval;
        /// <summary>
        /// Timeout for HTTP connection in milliseconds.
        /// </summary>
        public readonly int? HttpReceiveTimeout;
        /// <summary>
        /// Timeout for HTTP connection in milliseconds.
        /// </summary>
        public readonly int? HttpSendTimeout;
        /// <summary>
        /// When performing INSERT queries, replace omitted input column values with default values of the respective columns.
        /// </summary>
        public readonly bool? InputFormatDefaultsForOmittedFields;
        /// <summary>
        /// Enables or disables the full SQL parser if the fast stream parser can’t parse the data.
        /// </summary>
        public readonly bool? InputFormatValuesInterpretExpressions;
        /// <summary>
        /// Enables the insertion of default values instead of NULL into columns with not nullable data type. Default value: true.
        /// </summary>
        public readonly bool? InsertNullAsDefault;
        /// <summary>
        /// Enables the quorum writes.
        /// </summary>
        public readonly int? InsertQuorum;
        /// <summary>
        /// Write to a quorum timeout in milliseconds.
        /// </summary>
        public readonly int? InsertQuorumTimeout;
        /// <summary>
        /// Sets behaviour on overflow in JOIN. Possible values:
        /// </summary>
        public readonly string? JoinOverflowMode;
        /// <summary>
        /// Sets the type of JOIN behaviour. When merging tables, empty cells may appear. ClickHouse fills them differently based on this setting.
        /// </summary>
        public readonly bool? JoinUseNulls;
        /// <summary>
        /// Require aliases for subselects and table functions in FROM that more than one table is present.
        /// </summary>
        public readonly bool? JoinedSubqueryRequiresAlias;
        /// <summary>
        /// Allows or restricts using the LowCardinality data type with the Native format.
        /// </summary>
        public readonly bool? LowCardinalityAllowInNativeFormat;
        /// <summary>
        /// Maximum abstract syntax tree depth.
        /// </summary>
        public readonly int? MaxAstDepth;
        /// <summary>
        /// Maximum abstract syntax tree elements.
        /// </summary>
        public readonly int? MaxAstElements;
        /// <summary>
        /// A recommendation for what size of the block (in a count of rows) to load from tables.
        /// </summary>
        public readonly int? MaxBlockSize;
        /// <summary>
        /// Limit in bytes for using memoru for GROUP BY before using swap on disk.
        /// </summary>
        public readonly int? MaxBytesBeforeExternalGroupBy;
        /// <summary>
        /// This setting is equivalent of the max_bytes_before_external_group_by setting, except for it is for sort operation (ORDER BY), not aggregation.
        /// </summary>
        public readonly int? MaxBytesBeforeExternalSort;
        /// <summary>
        /// Limits the maximum size of a hash table in bytes (uncompressed data) when using DISTINCT.
        /// </summary>
        public readonly int? MaxBytesInDistinct;
        /// <summary>
        /// Limit on maximum size of the hash table for JOIN, in bytes.
        /// </summary>
        public readonly int? MaxBytesInJoin;
        /// <summary>
        /// Limit on the number of bytes in the set resulting from the execution of the IN section.
        /// </summary>
        public readonly int? MaxBytesInSet;
        /// <summary>
        /// Limits the maximum number of bytes (uncompressed data) that can be read from a table when running a query.
        /// </summary>
        public readonly int? MaxBytesToRead;
        /// <summary>
        /// Limits the maximum number of bytes (uncompressed data) that can be read from a table for sorting.
        /// </summary>
        public readonly int? MaxBytesToSort;
        /// <summary>
        /// Limits the maximum number of bytes (uncompressed data) that can be passed to a remote server or saved in a temporary table when using GLOBAL IN.
        /// </summary>
        public readonly int? MaxBytesToTransfer;
        /// <summary>
        /// Limits the maximum number of columns that can be read from a table in a single query.
        /// </summary>
        public readonly int? MaxColumnsToRead;
        /// <summary>
        /// The maximum number of concurrent requests per user. Default value: 0 (no limit).
        /// </summary>
        public readonly int? MaxConcurrentQueriesForUser;
        /// <summary>
        /// Limits the maximum query execution time in milliseconds.
        /// </summary>
        public readonly int? MaxExecutionTime;
        /// <summary>
        /// Maximum abstract syntax tree depth after after expansion of aliases.
        /// </summary>
        public readonly int? MaxExpandedAstElements;
        /// <summary>
        /// Limits the maximum number of HTTP GET redirect hops for URL-engine tables.
        /// If the parameter is set to 0 (default), no hops is allowed.
        /// </summary>
        public readonly int? MaxHttpGetRedirects;
        /// <summary>
        /// The size of blocks (in a count of rows) to form for insertion into a table.
        /// </summary>
        public readonly int? MaxInsertBlockSize;
        /// <summary>
        /// Limits the maximum memory usage (in bytes) for processing queries on a single server.
        /// </summary>
        public readonly int? MaxMemoryUsage;
        /// <summary>
        /// Limits the maximum memory usage (in bytes) for processing of user's queries on a single server.
        /// </summary>
        public readonly int? MaxMemoryUsageForUser;
        /// <summary>
        /// Limits the speed of the data exchange over the network in bytes per second.
        /// </summary>
        public readonly int? MaxNetworkBandwidth;
        /// <summary>
        /// Limits the speed of the data exchange over the network in bytes per second.
        /// </summary>
        public readonly int? MaxNetworkBandwidthForUser;
        /// <summary>
        /// The maximum part of a query that can be taken to RAM for parsing with the SQL parser.
        /// </summary>
        public readonly int? MaxQuerySize;
        /// <summary>
        /// Disables lagging replicas for distributed queries.
        /// </summary>
        public readonly int? MaxReplicaDelayForDistributedQueries;
        /// <summary>
        /// Limits the number of bytes in the result.
        /// </summary>
        public readonly int? MaxResultBytes;
        /// <summary>
        /// Limits the number of rows in the result.
        /// </summary>
        public readonly int? MaxResultRows;
        /// <summary>
        /// Limits the maximum number of different rows when using DISTINCT.
        /// </summary>
        public readonly int? MaxRowsInDistinct;
        /// <summary>
        /// Limit on maximum size of the hash table for JOIN, in rows.
        /// </summary>
        public readonly int? MaxRowsInJoin;
        /// <summary>
        /// Limit on the number of rows in the set resulting from the execution of the IN section.
        /// </summary>
        public readonly int? MaxRowsInSet;
        /// <summary>
        /// Limits the maximum number of unique keys received from aggregation function.
        /// </summary>
        public readonly int? MaxRowsToGroupBy;
        /// <summary>
        /// Limits the maximum number of rows that can be read from a table when running a query.
        /// </summary>
        public readonly int? MaxRowsToRead;
        /// <summary>
        /// Limits the maximum number of rows that can be read from a table for sorting.
        /// </summary>
        public readonly int? MaxRowsToSort;
        /// <summary>
        /// Limits the maximum number of rows that can be passed to a remote server or saved in a temporary table when using GLOBAL IN.
        /// </summary>
        public readonly int? MaxRowsToTransfer;
        /// <summary>
        /// Limits the maximum number of temporary columns that must be kept in RAM at the same time when running a query, including constant columns.
        /// </summary>
        public readonly int? MaxTemporaryColumns;
        /// <summary>
        /// Limits the maximum number of temporary columns that must be kept in RAM at the same time when running a query, excluding constant columns.
        /// </summary>
        public readonly int? MaxTemporaryNonConstColumns;
        /// <summary>
        /// The maximum number of query processing threads, excluding threads for retrieving data from remote servers.
        /// </summary>
        public readonly int? MaxThreads;
        /// <summary>
        /// Collect random allocations and deallocations and write them into system.trace_log with 'MemorySample' trace_type. The probability is for every alloc/free regardless to the size of the allocation. Possible values: from 0 to 1. Default: 0.
        /// </summary>
        public readonly double? MemoryProfilerSampleProbability;
        /// <summary>
        /// Memory profiler step (in bytes).  If the next query step requires more memory than this parameter specifies, the memory profiler collects the allocating stack trace. Values lower than a few megabytes slow down query processing. Default value: 4194304 (4 MB). Zero means disabled memory profiler.
        /// </summary>
        public readonly int? MemoryProfilerStep;
        /// <summary>
        /// If ClickHouse should read more than merge_tree_max_bytes_to_use_cache bytes in one query, it doesn’t use the cache of uncompressed blocks.
        /// </summary>
        public readonly int? MergeTreeMaxBytesToUseCache;
        /// <summary>
        /// If ClickHouse should read more than merge_tree_max_rows_to_use_cache rows in one query, it doesn’t use the cache of uncompressed blocks.
        /// </summary>
        public readonly int? MergeTreeMaxRowsToUseCache;
        /// <summary>
        /// If the number of bytes to read from one file of a MergeTree-engine table exceeds merge_tree_min_bytes_for_concurrent_read, then ClickHouse tries to concurrently read from this file in several threads.
        /// </summary>
        public readonly int? MergeTreeMinBytesForConcurrentRead;
        /// <summary>
        /// If the number of rows to be read from a file of a MergeTree table exceeds merge_tree_min_rows_for_concurrent_read then ClickHouse tries to perform a concurrent reading from this file on several threads.
        /// </summary>
        public readonly int? MergeTreeMinRowsForConcurrentRead;
        /// <summary>
        /// The minimum data volume required for using direct I/O access to the storage disk.
        /// </summary>
        public readonly int? MinBytesToUseDirectIo;
        /// <summary>
        /// How many times to potentially use a compiled chunk of code before running compilation.
        /// </summary>
        public readonly int? MinCountToCompile;
        /// <summary>
        /// A query waits for expression compilation process to complete prior to continuing execution.
        /// </summary>
        public readonly int? MinCountToCompileExpression;
        /// <summary>
        /// Minimal execution speed in rows per second.
        /// </summary>
        public readonly int? MinExecutionSpeed;
        /// <summary>
        /// Minimal execution speed in bytes per second.
        /// </summary>
        public readonly int? MinExecutionSpeedBytes;
        /// <summary>
        /// Sets the minimum number of bytes in the block which can be inserted into a table by an INSERT query.
        /// </summary>
        public readonly int? MinInsertBlockSizeBytes;
        /// <summary>
        /// Sets the minimum number of rows in the block which can be inserted into a table by an INSERT query.
        /// </summary>
        public readonly int? MinInsertBlockSizeRows;
        /// <summary>
        /// If the value is true, integers appear in quotes when using JSON* Int64 and UInt64 formats (for compatibility with most JavaScript implementations); otherwise, integers are output without the quotes.
        /// </summary>
        public readonly bool? OutputFormatJsonQuote64bitIntegers;
        /// <summary>
        /// Enables +nan, -nan, +inf, -inf outputs in JSON output format.
        /// </summary>
        public readonly bool? OutputFormatJsonQuoteDenormals;
        /// <summary>
        /// Query priority.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// Quota accounting mode.
        /// </summary>
        public readonly string? QuotaMode;
        /// <summary>
        /// Sets behaviour on overflow while read. Possible values:
        /// </summary>
        public readonly string? ReadOverflowMode;
        /// <summary>
        /// Restricts permissions for reading data, write data and change settings queries.
        /// </summary>
        public readonly int? Readonly;
        /// <summary>
        /// Receive timeout in milliseconds on the socket used for communicating with the client.
        /// </summary>
        public readonly int? ReceiveTimeout;
        /// <summary>
        /// For ALTER ... ATTACH|DETACH|DROP queries, you can use the replication_alter_partitions_sync setting to set up waiting.
        /// </summary>
        public readonly int? ReplicationAlterPartitionsSync;
        /// <summary>
        /// Sets behaviour on overflow in result. Possible values:
        /// </summary>
        public readonly string? ResultOverflowMode;
        /// <summary>
        /// Enables or disables sequential consistency for SELECT queries.
        /// </summary>
        public readonly bool? SelectSequentialConsistency;
        /// <summary>
        /// Enables or disables X-ClickHouse-Progress HTTP response headers in clickhouse-server responses.
        /// </summary>
        public readonly bool? SendProgressInHttpHeaders;
        /// <summary>
        /// Send timeout in milliseconds on the socket used for communicating with the client.
        /// </summary>
        public readonly int? SendTimeout;
        /// <summary>
        /// Sets behaviour on overflow in the set resulting. Possible values:
        /// </summary>
        public readonly string? SetOverflowMode;
        /// <summary>
        /// Enables or disables silently skipping of unavailable shards.
        /// </summary>
        public readonly bool? SkipUnavailableShards;
        /// <summary>
        /// Sets behaviour on overflow while sort. Possible values:
        /// </summary>
        public readonly string? SortOverflowMode;
        /// <summary>
        /// Timeout (in seconds) between checks of execution speed. It is checked that execution speed is not less that specified in min_execution_speed parameter.
        /// Must be at least 1000.
        /// </summary>
        public readonly int? TimeoutBeforeCheckingExecutionSpeed;
        /// <summary>
        /// Sets behaviour on overflow. Possible values:
        /// </summary>
        public readonly string? TimeoutOverflowMode;
        /// <summary>
        /// Sets behaviour on overflow. Possible values:
        /// </summary>
        public readonly string? TransferOverflowMode;
        /// <summary>
        /// Enables equality of NULL values for IN operator.
        /// </summary>
        public readonly bool? TransformNullIn;
        /// <summary>
        /// Whether to use a cache of uncompressed blocks.
        /// </summary>
        public readonly bool? UseUncompressedCache;
        /// <summary>
        /// Enables waiting for processing of asynchronous insertion. If enabled, server returns OK only after the data is inserted.
        /// </summary>
        public readonly bool? WaitForAsyncInsert;
        /// <summary>
        /// The timeout (in seconds) for waiting for processing of asynchronous insertion. Value must be at least 1000 (1 second).
        /// </summary>
        public readonly int? WaitForAsyncInsertTimeout;

        [OutputConstructor]
        private MdbClickhouseClusterUserSettings(
            bool? addHttpCorsHeader,

            bool? allowDdl,

            bool? allowIntrospectionFunctions,

            bool? allowSuspiciousLowCardinalityTypes,

            bool? asyncInsert,

            int? asyncInsertBusyTimeout,

            int? asyncInsertMaxDataSize,

            int? asyncInsertStaleTimeout,

            int? asyncInsertThreads,

            bool? cancelHttpReadonlyQueriesOnClientClose,

            bool? compile,

            bool? compileExpressions,

            int? connectTimeout,

            int? connectTimeoutWithFailover,

            string? countDistinctImplementation,

            string? distinctOverflowMode,

            bool? distributedAggregationMemoryEfficient,

            int? distributedDdlTaskTimeout,

            string? distributedProductMode,

            bool? emptyResultForAggregationByEmptySet,

            bool? enableHttpCompression,

            bool? fallbackToStaleReplicasForDistributedQueries,

            bool? flattenNested,

            bool? forceIndexByDate,

            bool? forcePrimaryKey,

            string? groupByOverflowMode,

            int? groupByTwoLevelThreshold,

            int? groupByTwoLevelThresholdBytes,

            int? httpConnectionTimeout,

            int? httpHeadersProgressInterval,

            int? httpReceiveTimeout,

            int? httpSendTimeout,

            bool? inputFormatDefaultsForOmittedFields,

            bool? inputFormatValuesInterpretExpressions,

            bool? insertNullAsDefault,

            int? insertQuorum,

            int? insertQuorumTimeout,

            string? joinOverflowMode,

            bool? joinUseNulls,

            bool? joinedSubqueryRequiresAlias,

            bool? lowCardinalityAllowInNativeFormat,

            int? maxAstDepth,

            int? maxAstElements,

            int? maxBlockSize,

            int? maxBytesBeforeExternalGroupBy,

            int? maxBytesBeforeExternalSort,

            int? maxBytesInDistinct,

            int? maxBytesInJoin,

            int? maxBytesInSet,

            int? maxBytesToRead,

            int? maxBytesToSort,

            int? maxBytesToTransfer,

            int? maxColumnsToRead,

            int? maxConcurrentQueriesForUser,

            int? maxExecutionTime,

            int? maxExpandedAstElements,

            int? maxHttpGetRedirects,

            int? maxInsertBlockSize,

            int? maxMemoryUsage,

            int? maxMemoryUsageForUser,

            int? maxNetworkBandwidth,

            int? maxNetworkBandwidthForUser,

            int? maxQuerySize,

            int? maxReplicaDelayForDistributedQueries,

            int? maxResultBytes,

            int? maxResultRows,

            int? maxRowsInDistinct,

            int? maxRowsInJoin,

            int? maxRowsInSet,

            int? maxRowsToGroupBy,

            int? maxRowsToRead,

            int? maxRowsToSort,

            int? maxRowsToTransfer,

            int? maxTemporaryColumns,

            int? maxTemporaryNonConstColumns,

            int? maxThreads,

            double? memoryProfilerSampleProbability,

            int? memoryProfilerStep,

            int? mergeTreeMaxBytesToUseCache,

            int? mergeTreeMaxRowsToUseCache,

            int? mergeTreeMinBytesForConcurrentRead,

            int? mergeTreeMinRowsForConcurrentRead,

            int? minBytesToUseDirectIo,

            int? minCountToCompile,

            int? minCountToCompileExpression,

            int? minExecutionSpeed,

            int? minExecutionSpeedBytes,

            int? minInsertBlockSizeBytes,

            int? minInsertBlockSizeRows,

            bool? outputFormatJsonQuote64bitIntegers,

            bool? outputFormatJsonQuoteDenormals,

            int? priority,

            string? quotaMode,

            string? readOverflowMode,

            int? @readonly,

            int? receiveTimeout,

            int? replicationAlterPartitionsSync,

            string? resultOverflowMode,

            bool? selectSequentialConsistency,

            bool? sendProgressInHttpHeaders,

            int? sendTimeout,

            string? setOverflowMode,

            bool? skipUnavailableShards,

            string? sortOverflowMode,

            int? timeoutBeforeCheckingExecutionSpeed,

            string? timeoutOverflowMode,

            string? transferOverflowMode,

            bool? transformNullIn,

            bool? useUncompressedCache,

            bool? waitForAsyncInsert,

            int? waitForAsyncInsertTimeout)
        {
            AddHttpCorsHeader = addHttpCorsHeader;
            AllowDdl = allowDdl;
            AllowIntrospectionFunctions = allowIntrospectionFunctions;
            AllowSuspiciousLowCardinalityTypes = allowSuspiciousLowCardinalityTypes;
            AsyncInsert = asyncInsert;
            AsyncInsertBusyTimeout = asyncInsertBusyTimeout;
            AsyncInsertMaxDataSize = asyncInsertMaxDataSize;
            AsyncInsertStaleTimeout = asyncInsertStaleTimeout;
            AsyncInsertThreads = asyncInsertThreads;
            CancelHttpReadonlyQueriesOnClientClose = cancelHttpReadonlyQueriesOnClientClose;
            Compile = compile;
            CompileExpressions = compileExpressions;
            ConnectTimeout = connectTimeout;
            ConnectTimeoutWithFailover = connectTimeoutWithFailover;
            CountDistinctImplementation = countDistinctImplementation;
            DistinctOverflowMode = distinctOverflowMode;
            DistributedAggregationMemoryEfficient = distributedAggregationMemoryEfficient;
            DistributedDdlTaskTimeout = distributedDdlTaskTimeout;
            DistributedProductMode = distributedProductMode;
            EmptyResultForAggregationByEmptySet = emptyResultForAggregationByEmptySet;
            EnableHttpCompression = enableHttpCompression;
            FallbackToStaleReplicasForDistributedQueries = fallbackToStaleReplicasForDistributedQueries;
            FlattenNested = flattenNested;
            ForceIndexByDate = forceIndexByDate;
            ForcePrimaryKey = forcePrimaryKey;
            GroupByOverflowMode = groupByOverflowMode;
            GroupByTwoLevelThreshold = groupByTwoLevelThreshold;
            GroupByTwoLevelThresholdBytes = groupByTwoLevelThresholdBytes;
            HttpConnectionTimeout = httpConnectionTimeout;
            HttpHeadersProgressInterval = httpHeadersProgressInterval;
            HttpReceiveTimeout = httpReceiveTimeout;
            HttpSendTimeout = httpSendTimeout;
            InputFormatDefaultsForOmittedFields = inputFormatDefaultsForOmittedFields;
            InputFormatValuesInterpretExpressions = inputFormatValuesInterpretExpressions;
            InsertNullAsDefault = insertNullAsDefault;
            InsertQuorum = insertQuorum;
            InsertQuorumTimeout = insertQuorumTimeout;
            JoinOverflowMode = joinOverflowMode;
            JoinUseNulls = joinUseNulls;
            JoinedSubqueryRequiresAlias = joinedSubqueryRequiresAlias;
            LowCardinalityAllowInNativeFormat = lowCardinalityAllowInNativeFormat;
            MaxAstDepth = maxAstDepth;
            MaxAstElements = maxAstElements;
            MaxBlockSize = maxBlockSize;
            MaxBytesBeforeExternalGroupBy = maxBytesBeforeExternalGroupBy;
            MaxBytesBeforeExternalSort = maxBytesBeforeExternalSort;
            MaxBytesInDistinct = maxBytesInDistinct;
            MaxBytesInJoin = maxBytesInJoin;
            MaxBytesInSet = maxBytesInSet;
            MaxBytesToRead = maxBytesToRead;
            MaxBytesToSort = maxBytesToSort;
            MaxBytesToTransfer = maxBytesToTransfer;
            MaxColumnsToRead = maxColumnsToRead;
            MaxConcurrentQueriesForUser = maxConcurrentQueriesForUser;
            MaxExecutionTime = maxExecutionTime;
            MaxExpandedAstElements = maxExpandedAstElements;
            MaxHttpGetRedirects = maxHttpGetRedirects;
            MaxInsertBlockSize = maxInsertBlockSize;
            MaxMemoryUsage = maxMemoryUsage;
            MaxMemoryUsageForUser = maxMemoryUsageForUser;
            MaxNetworkBandwidth = maxNetworkBandwidth;
            MaxNetworkBandwidthForUser = maxNetworkBandwidthForUser;
            MaxQuerySize = maxQuerySize;
            MaxReplicaDelayForDistributedQueries = maxReplicaDelayForDistributedQueries;
            MaxResultBytes = maxResultBytes;
            MaxResultRows = maxResultRows;
            MaxRowsInDistinct = maxRowsInDistinct;
            MaxRowsInJoin = maxRowsInJoin;
            MaxRowsInSet = maxRowsInSet;
            MaxRowsToGroupBy = maxRowsToGroupBy;
            MaxRowsToRead = maxRowsToRead;
            MaxRowsToSort = maxRowsToSort;
            MaxRowsToTransfer = maxRowsToTransfer;
            MaxTemporaryColumns = maxTemporaryColumns;
            MaxTemporaryNonConstColumns = maxTemporaryNonConstColumns;
            MaxThreads = maxThreads;
            MemoryProfilerSampleProbability = memoryProfilerSampleProbability;
            MemoryProfilerStep = memoryProfilerStep;
            MergeTreeMaxBytesToUseCache = mergeTreeMaxBytesToUseCache;
            MergeTreeMaxRowsToUseCache = mergeTreeMaxRowsToUseCache;
            MergeTreeMinBytesForConcurrentRead = mergeTreeMinBytesForConcurrentRead;
            MergeTreeMinRowsForConcurrentRead = mergeTreeMinRowsForConcurrentRead;
            MinBytesToUseDirectIo = minBytesToUseDirectIo;
            MinCountToCompile = minCountToCompile;
            MinCountToCompileExpression = minCountToCompileExpression;
            MinExecutionSpeed = minExecutionSpeed;
            MinExecutionSpeedBytes = minExecutionSpeedBytes;
            MinInsertBlockSizeBytes = minInsertBlockSizeBytes;
            MinInsertBlockSizeRows = minInsertBlockSizeRows;
            OutputFormatJsonQuote64bitIntegers = outputFormatJsonQuote64bitIntegers;
            OutputFormatJsonQuoteDenormals = outputFormatJsonQuoteDenormals;
            Priority = priority;
            QuotaMode = quotaMode;
            ReadOverflowMode = readOverflowMode;
            Readonly = @readonly;
            ReceiveTimeout = receiveTimeout;
            ReplicationAlterPartitionsSync = replicationAlterPartitionsSync;
            ResultOverflowMode = resultOverflowMode;
            SelectSequentialConsistency = selectSequentialConsistency;
            SendProgressInHttpHeaders = sendProgressInHttpHeaders;
            SendTimeout = sendTimeout;
            SetOverflowMode = setOverflowMode;
            SkipUnavailableShards = skipUnavailableShards;
            SortOverflowMode = sortOverflowMode;
            TimeoutBeforeCheckingExecutionSpeed = timeoutBeforeCheckingExecutionSpeed;
            TimeoutOverflowMode = timeoutOverflowMode;
            TransferOverflowMode = transferOverflowMode;
            TransformNullIn = transformNullIn;
            UseUncompressedCache = useUncompressedCache;
            WaitForAsyncInsert = waitForAsyncInsert;
            WaitForAsyncInsertTimeout = waitForAsyncInsertTimeout;
        }
    }
}
