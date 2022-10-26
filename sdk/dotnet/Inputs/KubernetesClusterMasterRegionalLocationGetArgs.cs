// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesClusterMasterRegionalLocationGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// (Optional) ID of the subnet.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// (Optional) ID of the availability zone.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public KubernetesClusterMasterRegionalLocationGetArgs()
        {
        }
        public static new KubernetesClusterMasterRegionalLocationGetArgs Empty => new KubernetesClusterMasterRegionalLocationGetArgs();
    }
}
