// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("patterns")]
        private InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternGetArgs>? _patterns;

        /// <summary>
        /// Set of thinning rules.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternGetArgs> Patterns
        {
            get => _patterns ?? (_patterns = new InputList<Inputs.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternGetArgs>());
            set => _patterns = value;
        }

        public MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs Empty => new MdbClickhouseClusterClickhouseConfigGraphiteRollupGetArgs();
    }
}
