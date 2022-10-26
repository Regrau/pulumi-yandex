// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class GetAlbBackendGroupHttpBackendInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Healthcheck specification that will be used by this backend. Structure is documented below.
        /// </summary>
        [Input("healthcheck", required: true)]
        public Input<Inputs.GetAlbBackendGroupHttpBackendHealthcheckInputArgs> Healthcheck { get; set; } = null!;

        /// <summary>
        /// If set, health checks will use HTTP2.
        /// </summary>
        [Input("http2", required: true)]
        public Input<bool> Http2 { get; set; } = null!;

        /// <summary>
        /// Load Balancing Config specification that will be used by this backend. Structure is documented below.
        /// </summary>
        [Input("loadBalancingConfig", required: true)]
        public Input<Inputs.GetAlbBackendGroupHttpBackendLoadBalancingConfigInputArgs> LoadBalancingConfig { get; set; } = null!;

        /// <summary>
        /// - Name of the Backend Group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Port for incoming traffic.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        [Input("storageBucket", required: true)]
        public Input<string> StorageBucket { get; set; } = null!;

        [Input("targetGroupIds", required: true)]
        private InputList<string>? _targetGroupIds;

        /// <summary>
        /// References target groups for the backend.
        /// </summary>
        public InputList<string> TargetGroupIds
        {
            get => _targetGroupIds ?? (_targetGroupIds = new InputList<string>());
            set => _targetGroupIds = value;
        }

        /// <summary>
        /// Tls specification that will be used by this backend. Structure is documented below.
        /// </summary>
        [Input("tls", required: true)]
        public Input<Inputs.GetAlbBackendGroupHttpBackendTlsInputArgs> Tls { get; set; } = null!;

        /// <summary>
        /// Weight of the backend. Traffic will be split between backends of the same BackendGroup according to their weights.
        /// </summary>
        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public GetAlbBackendGroupHttpBackendInputArgs()
        {
        }
        public static new GetAlbBackendGroupHttpBackendInputArgs Empty => new GetAlbBackendGroupHttpBackendInputArgs();
    }
}
