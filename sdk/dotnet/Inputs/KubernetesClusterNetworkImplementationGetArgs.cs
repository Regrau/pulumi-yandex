// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesClusterNetworkImplementationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cilium")]
        public Input<Inputs.KubernetesClusterNetworkImplementationCiliumGetArgs>? Cilium { get; set; }

        public KubernetesClusterNetworkImplementationGetArgs()
        {
        }
        public static new KubernetesClusterNetworkImplementationGetArgs Empty => new KubernetesClusterNetworkImplementationGetArgs();
    }
}
