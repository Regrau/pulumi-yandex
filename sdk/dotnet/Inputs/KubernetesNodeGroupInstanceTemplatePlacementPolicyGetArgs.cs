// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupInstanceTemplatePlacementPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the id of the Placement Group to assign to the instances.
        /// </summary>
        [Input("placementGroupId", required: true)]
        public Input<string> PlacementGroupId { get; set; } = null!;

        public KubernetesNodeGroupInstanceTemplatePlacementPolicyGetArgs()
        {
        }
        public static new KubernetesNodeGroupInstanceTemplatePlacementPolicyGetArgs Empty => new KubernetesNodeGroupInstanceTemplatePlacementPolicyGetArgs();
    }
}
