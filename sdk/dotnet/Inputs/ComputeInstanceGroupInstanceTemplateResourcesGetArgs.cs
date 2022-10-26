// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupInstanceTemplateResourcesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If provided, specifies baseline core performance as a percent.
        /// </summary>
        [Input("coreFraction")]
        public Input<int>? CoreFraction { get; set; }

        /// <summary>
        /// The number of CPU cores for the instance.
        /// </summary>
        [Input("cores", required: true)]
        public Input<int> Cores { get; set; } = null!;

        [Input("gpus")]
        public Input<int>? Gpus { get; set; }

        /// <summary>
        /// The memory size in GB.
        /// </summary>
        [Input("memory", required: true)]
        public Input<double> Memory { get; set; } = null!;

        public ComputeInstanceGroupInstanceTemplateResourcesGetArgs()
        {
        }
        public static new ComputeInstanceGroupInstanceTemplateResourcesGetArgs Empty => new ComputeInstanceGroupInstanceTemplateResourcesGetArgs();
    }
}
