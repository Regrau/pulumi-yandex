// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketLoggingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("targetBucket", required: true)]
        public Input<string> TargetBucket { get; set; } = null!;

        [Input("targetPrefix")]
        public Input<string>? TargetPrefix { get; set; }

        public StorageBucketLoggingGetArgs()
        {
        }
        public static new StorageBucketLoggingGetArgs Empty => new StorageBucketLoggingGetArgs();
    }
}
