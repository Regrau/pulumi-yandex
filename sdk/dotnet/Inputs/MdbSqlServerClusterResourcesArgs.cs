// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbSqlServerClusterResourcesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Volume of the storage available to a SQLServer host, in gigabytes.
        /// </summary>
        [Input("diskSize", required: true)]
        public Input<int> DiskSize { get; set; } = null!;

        /// <summary>
        /// Type of the storage of SQLServer hosts.
        /// </summary>
        [Input("diskTypeId", required: true)]
        public Input<string> DiskTypeId { get; set; } = null!;

        [Input("resourcePresetId", required: true)]
        public Input<string> ResourcePresetId { get; set; } = null!;

        public MdbSqlServerClusterResourcesArgs()
        {
        }
        public static new MdbSqlServerClusterResourcesArgs Empty => new MdbSqlServerClusterResourcesArgs();
    }
}
