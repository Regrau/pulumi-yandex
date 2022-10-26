// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupScalePolicyArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoScale")]
        public Input<Inputs.KubernetesNodeGroupScalePolicyAutoScaleArgs>? AutoScale { get; set; }

        [Input("fixedScale")]
        public Input<Inputs.KubernetesNodeGroupScalePolicyFixedScaleArgs>? FixedScale { get; set; }

        public KubernetesNodeGroupScalePolicyArgs()
        {
        }
        public static new KubernetesNodeGroupScalePolicyArgs Empty => new KubernetesNodeGroupScalePolicyArgs();
    }
}