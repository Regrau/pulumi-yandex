// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class AlbLoadBalancerAllocationPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("locations", required: true)]
        private InputList<Inputs.AlbLoadBalancerAllocationPolicyLocationArgs>? _locations;
        public InputList<Inputs.AlbLoadBalancerAllocationPolicyLocationArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.AlbLoadBalancerAllocationPolicyLocationArgs>());
            set => _locations = value;
        }

        public AlbLoadBalancerAllocationPolicyArgs()
        {
        }
        public static new AlbLoadBalancerAllocationPolicyArgs Empty => new AlbLoadBalancerAllocationPolicyArgs();
    }
}
