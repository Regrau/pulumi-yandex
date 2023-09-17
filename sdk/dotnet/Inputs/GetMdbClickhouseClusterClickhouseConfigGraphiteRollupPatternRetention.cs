// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Minimum data age in seconds.
        /// </summary>
        [Input("age")]
        public int? Age { get; set; }

        /// <summary>
        /// Accuracy of determining the age of the data in seconds.
        /// </summary>
        [Input("precision")]
        public int? Precision { get; set; }

        public GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionArgs Empty => new GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetentionArgs();
    }
}
