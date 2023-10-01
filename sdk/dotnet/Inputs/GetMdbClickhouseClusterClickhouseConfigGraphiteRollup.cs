// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetMdbClickhouseClusterClickhouseConfigGraphiteRollupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the ClickHouse cluster.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("patterns")]
        private List<Inputs.GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternArgs>? _patterns;

        /// <summary>
        /// Set of thinning rules.
        /// </summary>
        public List<Inputs.GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternArgs> Patterns
        {
            get => _patterns ?? (_patterns = new List<Inputs.GetMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternArgs>());
            set => _patterns = value;
        }

        public GetMdbClickhouseClusterClickhouseConfigGraphiteRollupArgs()
        {
        }
        public static new GetMdbClickhouseClusterClickhouseConfigGraphiteRollupArgs Empty => new GetMdbClickhouseClusterClickhouseConfigGraphiteRollupArgs();
    }
}