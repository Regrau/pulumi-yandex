// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupAllocationPolicyLocationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the subnet, that will be used by one compute instance in node group.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// ID of the availability zone where for one compute instance in node group.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public KubernetesNodeGroupAllocationPolicyLocationArgs()
        {
        }
        public static new KubernetesNodeGroupAllocationPolicyLocationArgs Empty => new KubernetesNodeGroupAllocationPolicyLocationArgs();
    }
}
