// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Method: Compression method. Two methods are available: LZ4 and zstd.
        /// </summary>
        [Input("method")]
        public Input<string>? Method { get; set; }

        /// <summary>
        /// Min part size: Minimum size (in bytes) of a data part in a table. ClickHouse only applies the rule to tables with data parts greater than or equal to the Min part size value.
        /// </summary>
        [Input("minPartSize")]
        public Input<int>? MinPartSize { get; set; }

        /// <summary>
        /// Min part size ratio: Minimum table part size to total table size ratio. ClickHouse only applies the rule to tables in which this ratio is greater than or equal to the Min part size ratio value.
        /// </summary>
        [Input("minPartSizeRatio")]
        public Input<double>? MinPartSizeRatio { get; set; }

        public GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs Empty => new GetMdbClickhouseClusterClickhouseConfigCompressionInputArgs();
    }
}
