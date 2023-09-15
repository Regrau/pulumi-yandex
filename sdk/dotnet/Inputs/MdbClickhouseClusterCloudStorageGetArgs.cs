// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterCloudStorageGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enables temporary storage in the cluster repository of data requested from the object repository.
        /// </summary>
        [Input("dataCacheEnabled")]
        public Input<bool>? DataCacheEnabled { get; set; }

        /// <summary>
        /// Defines the maximum amount of memory (in bytes) allocated in the cluster storage for temporary storage of data requested from the object storage.
        /// </summary>
        [Input("dataCacheMaxSize")]
        public Input<int>? DataCacheMaxSize { get; set; }

        /// <summary>
        /// Whether to use Yandex Object Storage for storing ClickHouse data. Can be either `true` or `false`.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Sets the minimum free space ratio in the cluster storage. If the free space is lower than this value, the data is transferred to Yandex Object Storage. Acceptable values are 0 to 1, inclusive.
        /// </summary>
        [Input("moveFactor")]
        public Input<double>? MoveFactor { get; set; }

        public MdbClickhouseClusterCloudStorageGetArgs()
        {
        }
        public static new MdbClickhouseClusterCloudStorageGetArgs Empty => new MdbClickhouseClusterCloudStorageGetArgs();
    }
}
