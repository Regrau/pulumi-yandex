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
    public sealed class GetMdbMysqlClusterResourceResult
    {
        /// <summary>
        /// Volume of the storage available to a MySQL host, in gigabytes.
        /// </summary>
        public readonly int DiskSize;
        /// <summary>
        /// Type of the storage for MySQL hosts.
        /// </summary>
        public readonly string DiskTypeId;
        public readonly string ResourcePresetId;

        [OutputConstructor]
        private GetMdbMysqlClusterResourceResult(
            int diskSize,

            string diskTypeId,

            string resourcePresetId)
        {
            DiskSize = diskSize;
            DiskTypeId = diskTypeId;
            ResourcePresetId = resourcePresetId;
        }
    }
}
