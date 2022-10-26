// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupStreamBackendHealthcheckInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("grpcHealthcheck", required: true)]
        public Input<Inputs.GetAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheckInputArgs> GrpcHealthcheck { get; set; } = null!;

        [Input("healthcheckPort", required: true)]
        public Input<int> HealthcheckPort { get; set; } = null!;

        [Input("healthyThreshold", required: true)]
        public Input<int> HealthyThreshold { get; set; } = null!;

        [Input("httpHealthcheck", required: true)]
        public Input<Inputs.GetAlbBackendGroupStreamBackendHealthcheckHttpHealthcheckInputArgs> HttpHealthcheck { get; set; } = null!;

        [Input("interval", required: true)]
        public Input<string> Interval { get; set; } = null!;

        [Input("intervalJitterPercent", required: true)]
        public Input<double> IntervalJitterPercent { get; set; } = null!;

        [Input("streamHealthcheck", required: true)]
        public Input<Inputs.GetAlbBackendGroupStreamBackendHealthcheckStreamHealthcheckInputArgs> StreamHealthcheck { get; set; } = null!;

        [Input("timeout", required: true)]
        public Input<string> Timeout { get; set; } = null!;

        [Input("unhealthyThreshold", required: true)]
        public Input<int> UnhealthyThreshold { get; set; } = null!;

        public GetAlbBackendGroupStreamBackendHealthcheckInputArgs()
        {
        }
        public static new GetAlbBackendGroupStreamBackendHealthcheckInputArgs Empty => new GetAlbBackendGroupStreamBackendHealthcheckInputArgs();
    }
}
