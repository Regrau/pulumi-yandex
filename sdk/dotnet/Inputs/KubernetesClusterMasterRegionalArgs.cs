// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesClusterMasterRegionalArgs : global::Pulumi.ResourceArgs
    {
        [Input("locations")]
        private InputList<Inputs.KubernetesClusterMasterRegionalLocationArgs>? _locations;
        public InputList<Inputs.KubernetesClusterMasterRegionalLocationArgs> Locations
        {
            get => _locations ?? (_locations = new InputList<Inputs.KubernetesClusterMasterRegionalLocationArgs>());
            set => _locations = value;
        }

        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        public KubernetesClusterMasterRegionalArgs()
        {
        }
        public static new KubernetesClusterMasterRegionalArgs Empty => new KubernetesClusterMasterRegionalArgs();
    }
}
