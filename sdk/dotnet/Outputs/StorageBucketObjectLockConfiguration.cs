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
    public sealed class StorageBucketObjectLockConfiguration
    {
        /// <summary>
        /// Enable object locking in a bucket. Require versioning to be enabled.
        /// </summary>
        public readonly string? ObjectLockEnabled;
        /// <summary>
        /// Specifies a default locking configuration for added objects. Require object_lock_enabled to be enabled.
        /// </summary>
        public readonly Outputs.StorageBucketObjectLockConfigurationRule? Rule;

        [OutputConstructor]
        private StorageBucketObjectLockConfiguration(
            string? objectLockEnabled,

            Outputs.StorageBucketObjectLockConfigurationRule? rule)
        {
            ObjectLockEnabled = objectLockEnabled;
            Rule = rule;
        }
    }
}
