// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupAllocationPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("locations")]
        private InputList<Inputs.KubernetesNodeGroupAllocationPolicyLocationArgs>? _locations;
        public InputList<Inputs.KubernetesNodeGroupAllocationPolicyLocationArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.KubernetesNodeGroupAllocationPolicyLocationArgs>());
            set => _locations = value;
        }

        public KubernetesNodeGroupAllocationPolicyArgs()
        {
        }
        public static new KubernetesNodeGroupAllocationPolicyArgs Empty => new KubernetesNodeGroupAllocationPolicyArgs();
    }
}
