// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHashArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the column to calculate hash from.
        /// </summary>
        [Input("columnName")]
        public Input<string>? ColumnName { get; set; }

        public DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHashArgs()
        {
        }
        public static new DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHashArgs Empty => new DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHashArgs();
    }
}
