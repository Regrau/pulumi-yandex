// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class ComputeInstanceGroupDeployPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("maxCreating")]
        public Input<int>? MaxCreating { get; set; }

        [Input("maxDeleting")]
        public Input<int>? MaxDeleting { get; set; }

        [Input("maxExpansion", required: true)]
        public Input<int> MaxExpansion { get; set; } = null!;

        [Input("maxUnavailable", required: true)]
        public Input<int> MaxUnavailable { get; set; } = null!;

        [Input("startupDuration")]
        public Input<int>? StartupDuration { get; set; }

        [Input("strategy")]
        public Input<string>? Strategy { get; set; }

        public ComputeInstanceGroupDeployPolicyGetArgs()
        {
        }
        public static new ComputeInstanceGroupDeployPolicyGetArgs Empty => new ComputeInstanceGroupDeployPolicyGetArgs();
    }
}
