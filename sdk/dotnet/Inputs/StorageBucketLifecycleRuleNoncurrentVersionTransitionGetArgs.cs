// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("days")]
        public Input<int>? Days { get; set; }

        [Input("storageClass", required: true)]
        public Input<string> StorageClass { get; set; } = null!;

        public StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs()
        {
        }
        public static new StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs Empty => new StorageBucketLifecycleRuleNoncurrentVersionTransitionGetArgs();
    }
}
