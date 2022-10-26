// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbBackendGroupGrpcBackendLoadBalancingConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("localityAwareRoutingPercent")]
        public Input<int>? LocalityAwareRoutingPercent { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("panicThreshold")]
        public Input<int>? PanicThreshold { get; set; }

        [Input("strictLocality")]
        public Input<bool>? StrictLocality { get; set; }

        public AlbBackendGroupGrpcBackendLoadBalancingConfigArgs()
        {
        }
        public static new AlbBackendGroupGrpcBackendLoadBalancingConfigArgs Empty => new AlbBackendGroupGrpcBackendLoadBalancingConfigArgs();
    }
}
