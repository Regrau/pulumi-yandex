// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class AlbLoadBalancerListenerTls
    {
        public readonly Outputs.AlbLoadBalancerListenerTlsDefaultHandler DefaultHandler;
        public readonly ImmutableArray<Outputs.AlbLoadBalancerListenerTlsSniHandler> SniHandlers;

        [OutputConstructor]
        private AlbLoadBalancerListenerTls(
            Outputs.AlbLoadBalancerListenerTlsDefaultHandler defaultHandler,

            ImmutableArray<Outputs.AlbLoadBalancerListenerTlsSniHandler> sniHandlers)
        {
            DefaultHandler = defaultHandler;
            SniHandlers = sniHandlers;
        }
    }
}