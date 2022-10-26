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
    public sealed class GetMdbClickhouseClusterCloudStorageResult
    {
        /// <summary>
        /// (Required) Whether to use Yandex Object Storage for storing ClickHouse data. Can be either `true` or `false`.
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private GetMdbClickhouseClusterCloudStorageResult(bool enabled)
        {
            Enabled = enabled;
        }
    }
}
