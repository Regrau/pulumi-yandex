// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupInstanceTemplateResourcesArgs : global::Pulumi.ResourceArgs
    {
        [Input("coreFraction")]
        public Input<int>? CoreFraction { get; set; }

        [Input("cores")]
        public Input<int>? Cores { get; set; }

        [Input("gpus")]
        public Input<int>? Gpus { get; set; }

        [Input("memory")]
        public Input<double>? Memory { get; set; }

        public KubernetesNodeGroupInstanceTemplateResourcesArgs()
        {
        }
        public static new KubernetesNodeGroupInstanceTemplateResourcesArgs Empty => new KubernetesNodeGroupInstanceTemplateResourcesArgs();
    }
}
