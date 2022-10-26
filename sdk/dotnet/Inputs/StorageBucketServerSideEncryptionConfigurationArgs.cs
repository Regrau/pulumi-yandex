// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class StorageBucketServerSideEncryptionConfigurationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A single object for server-side encryption by default configuration. (documented below)
        /// </summary>
        [Input("rule", required: true)]
        public Input<Inputs.StorageBucketServerSideEncryptionConfigurationRuleArgs> Rule { get; set; } = null!;

        public StorageBucketServerSideEncryptionConfigurationArgs()
        {
        }
        public static new StorageBucketServerSideEncryptionConfigurationArgs Empty => new StorageBucketServerSideEncryptionConfigurationArgs();
    }
}
