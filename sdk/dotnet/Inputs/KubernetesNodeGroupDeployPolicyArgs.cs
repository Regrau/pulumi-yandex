// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupDeployPolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("maxExpansion", required: true)]
        public Input<int> MaxExpansion { get; set; } = null!;

        [Input("maxUnavailable", required: true)]
        public Input<int> MaxUnavailable { get; set; } = null!;

        public KubernetesNodeGroupDeployPolicyArgs()
        {
        }
        public static new KubernetesNodeGroupDeployPolicyArgs Empty => new KubernetesNodeGroupDeployPolicyArgs();
    }
}
