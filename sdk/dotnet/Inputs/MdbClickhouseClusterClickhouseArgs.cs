// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbClickhouseClusterClickhouseArgs : global::Pulumi.ResourceArgs
    {
        [Input("config")]
        public Input<Inputs.MdbClickhouseClusterClickhouseConfigArgs>? Config { get; set; }

        [Input("resources", required: true)]
        public Input<Inputs.MdbClickhouseClusterClickhouseResourcesArgs> Resources { get; set; } = null!;

        public MdbClickhouseClusterClickhouseArgs()
        {
        }
        public static new MdbClickhouseClusterClickhouseArgs Empty => new MdbClickhouseClusterClickhouseArgs();
    }
}
