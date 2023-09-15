// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketObjectLockConfigurationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable object locking in a bucket. Require versioning to be enabled.
        /// </summary>
        [Input("objectLockEnabled")]
        public Input<string>? ObjectLockEnabled { get; set; }

        /// <summary>
        /// Specifies a default locking configuration for added objects. Require object_lock_enabled to be enabled.
        /// </summary>
        [Input("rule")]
        public Input<Inputs.StorageBucketObjectLockConfigurationRuleArgs>? Rule { get; set; }

        public StorageBucketObjectLockConfigurationArgs()
        {
        }
        public static new StorageBucketObjectLockConfigurationArgs Empty => new StorageBucketObjectLockConfigurationArgs();
    }
}
