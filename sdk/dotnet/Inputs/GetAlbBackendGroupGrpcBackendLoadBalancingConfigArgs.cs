// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupGrpcBackendLoadBalancingConfigInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("localityAwareRoutingPercent", required: true)]
        public Input<int> LocalityAwareRoutingPercent { get; set; } = null!;

        [Input("mode", required: true)]
        public Input<string> Mode { get; set; } = null!;

        [Input("panicThreshold", required: true)]
        public Input<int> PanicThreshold { get; set; } = null!;

        [Input("strictLocality", required: true)]
        public Input<bool> StrictLocality { get; set; } = null!;

        public GetAlbBackendGroupGrpcBackendLoadBalancingConfigInputArgs()
        {
        }
        public static new GetAlbBackendGroupGrpcBackendLoadBalancingConfigInputArgs Empty => new GetAlbBackendGroupGrpcBackendLoadBalancingConfigInputArgs();
    }
}
