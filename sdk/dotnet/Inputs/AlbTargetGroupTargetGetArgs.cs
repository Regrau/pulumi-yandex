// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbTargetGroupTargetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipAddress", required: true)]
        public Input<string> IpAddress { get; set; } = null!;

        [Input("privateIpv4Address")]
        public Input<bool>? PrivateIpv4Address { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public AlbTargetGroupTargetGetArgs()
        {
        }
        public static new AlbTargetGroupTargetGetArgs Empty => new AlbTargetGroupTargetGetArgs();
    }
}
