// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MdbGreenplumClusterMasterHostGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("assignPublicIp")]
        public Input<bool>? AssignPublicIp { get; set; }

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        public MdbGreenplumClusterMasterHostGetArgs()
        {
        }
        public static new MdbGreenplumClusterMasterHostGetArgs Empty => new MdbGreenplumClusterMasterHostGetArgs();
    }
}