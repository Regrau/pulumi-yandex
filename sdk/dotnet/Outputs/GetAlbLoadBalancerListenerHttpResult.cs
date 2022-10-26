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
    public sealed class GetAlbLoadBalancerListenerHttpResult
    {
        public readonly ImmutableArray<Outputs.GetAlbLoadBalancerListenerHttpHandlerResult> Handlers;
        public readonly ImmutableArray<Outputs.GetAlbLoadBalancerListenerHttpRedirectResult> Redirects;

        [OutputConstructor]
        private GetAlbLoadBalancerListenerHttpResult(
            ImmutableArray<Outputs.GetAlbLoadBalancerListenerHttpHandlerResult> handlers,

            ImmutableArray<Outputs.GetAlbLoadBalancerListenerHttpRedirectResult> redirects)
        {
            Handlers = handlers;
            Redirects = redirects;
        }
    }
}
