// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbGreenplumClusterSegmentHostGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        public MdbGreenplumClusterSegmentHostGetArgs()
        {
        }
        public static new MdbGreenplumClusterSegmentHostGetArgs Empty => new MdbGreenplumClusterSegmentHostGetArgs();
    }
}