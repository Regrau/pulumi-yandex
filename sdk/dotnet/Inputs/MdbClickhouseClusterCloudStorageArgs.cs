// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterCloudStorageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to use Yandex Object Storage for storing ClickHouse data. Can be either `true` or `false`.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public MdbClickhouseClusterCloudStorageArgs()
        {
        }
        public static new MdbClickhouseClusterCloudStorageArgs Empty => new MdbClickhouseClusterCloudStorageArgs();
    }
}
