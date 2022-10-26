// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerListenerTlsSniHandlerHandlerArgs : global::Pulumi.ResourceArgs
    {
        [Input("certificateIds", required: true)]
        private InputList<string>? _certificateIds;
        public InputList<string> CertificateIds
        {
            get => _certificateIds ?? (_certificateIds = new InputList<string>());
            set => _certificateIds = value;
        }

        [Input("httpHandler")]
        public Input<Inputs.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerArgs>? HttpHandler { get; set; }

        [Input("streamHandler")]
        public Input<Inputs.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandlerArgs>? StreamHandler { get; set; }

        public AlbLoadBalancerListenerTlsSniHandlerHandlerArgs()
        {
        }
        public static new AlbLoadBalancerListenerTlsSniHandlerHandlerArgs Empty => new AlbLoadBalancerListenerTlsSniHandlerHandlerArgs();
    }
}