// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseTargetShardingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Shard data by the hash value of the specified column. The structure is documented below.
        /// </summary>
        [Input("columnValueHash")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHashArgs>? ColumnValueHash { get; set; }

        /// <summary>
        /// Shard data by ID of the transfer.
        /// </summary>
        [Input("transferId")]
        public Input<Inputs.DatatransferEndpointSettingsClickhouseTargetShardingTransferIdArgs>? TransferId { get; set; }

        public DatatransferEndpointSettingsClickhouseTargetShardingArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseTargetShardingArgs Empty => new DatatransferEndpointSettingsClickhouseTargetShardingArgs();
    }
}
