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
    public sealed class MdbRedisClusterConfig
    {
        /// <summary>
        /// Normal clients output buffer limits.
        /// See [redis config file](https://github.com/redis/redis/blob/6.2/redis.conf#L1841).
        /// </summary>
        public readonly string? ClientOutputBufferLimitNormal;
        /// <summary>
        /// Pubsub clients output buffer limits.
        /// See [redis config file](https://github.com/redis/redis/blob/6.2/redis.conf#L1843).
        /// </summary>
        public readonly string? ClientOutputBufferLimitPubsub;
        /// <summary>
        /// Number of databases (changing requires redis-server restart).
        /// </summary>
        public readonly int? Databases;
        /// <summary>
        /// Redis maxmemory usage in percent
        /// </summary>
        public readonly int? MaxmemoryPercent;
        /// <summary>
        /// Redis key eviction policy for a dataset that reaches maximum memory.
        /// Can be any of the listed in [the official RedisDB documentation](https://docs.redislabs.com/latest/rs/administering/database-operations/eviction-policy/).
        /// </summary>
        public readonly string? MaxmemoryPolicy;
        /// <summary>
        /// Select the events that Redis will notify among a set of classes.
        /// </summary>
        public readonly string? NotifyKeyspaceEvents;
        /// <summary>
        /// Password for the Redis cluster.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// Log slow queries below this number in microseconds.
        /// </summary>
        public readonly int? SlowlogLogSlowerThan;
        /// <summary>
        /// Slow queries log length.
        /// </summary>
        public readonly int? SlowlogMaxLen;
        /// <summary>
        /// Close the connection after a client is idle for N seconds.
        /// </summary>
        public readonly int? Timeout;
        /// <summary>
        /// Version of Redis (6.2).
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private MdbRedisClusterConfig(
            string? clientOutputBufferLimitNormal,

            string? clientOutputBufferLimitPubsub,

            int? databases,

            int? maxmemoryPercent,

            string? maxmemoryPolicy,

            string? notifyKeyspaceEvents,

            string password,

            int? slowlogLogSlowerThan,

            int? slowlogMaxLen,

            int? timeout,

            string version)
        {
            ClientOutputBufferLimitNormal = clientOutputBufferLimitNormal;
            ClientOutputBufferLimitPubsub = clientOutputBufferLimitPubsub;
            Databases = databases;
            MaxmemoryPercent = maxmemoryPercent;
            MaxmemoryPolicy = maxmemoryPolicy;
            NotifyKeyspaceEvents = notifyKeyspaceEvents;
            Password = password;
            SlowlogLogSlowerThan = slowlogLogSlowerThan;
            SlowlogMaxLen = slowlogMaxLen;
            Timeout = timeout;
            Version = version;
        }
    }
}
