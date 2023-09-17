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
    public sealed class MdbMongodbClusterClusterConfigMongodOperationProfiling
    {
        /// <summary>
        /// Specifies which operations should be profiled. The following profiler levels are available: off, slow_op, all.
        /// For more information, see the [operationProfiling.mode](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-operationProfiling.mode)
        /// description in the official documentation.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The slow operation time threshold, in milliseconds. Operations that run for longer than this threshold are considered slow.
        /// For more information, see the [operationProfiling.slowOpThresholdMs](https://www.mongodb.com/docs/manual/reference/configuration-options/#mongodb-setting-operationProfiling.slowOpThresholdMs)
        /// description in the official documentation.
        /// </summary>
        public readonly int? SlowOpThreshold;

        [OutputConstructor]
        private MdbMongodbClusterClusterConfigMongodOperationProfiling(
            string? mode,

            int? slowOpThreshold)
        {
            Mode = mode;
            SlowOpThreshold = slowOpThreshold;
        }
    }
}
