// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupAllocationPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locations")]
        private InputList<Inputs.KubernetesNodeGroupAllocationPolicyLocationGetArgs>? _locations;

        /// <summary>
        /// Repeated field, that specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
        /// </summary>
        public InputList<Inputs.KubernetesNodeGroupAllocationPolicyLocationGetArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.KubernetesNodeGroupAllocationPolicyLocationGetArgs>());
            set => _locations = value;
        }

        public KubernetesNodeGroupAllocationPolicyGetArgs()
        {
        }
        public static new KubernetesNodeGroupAllocationPolicyGetArgs Empty => new KubernetesNodeGroupAllocationPolicyGetArgs();
    }
}
