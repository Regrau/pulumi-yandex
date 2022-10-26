// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesClusterMasterVersionInfoArgs : global::Pulumi.ResourceArgs
    {
        [Input("currentVersion")]
        public Input<string>? CurrentVersion { get; set; }

        [Input("newRevisionAvailable")]
        public Input<bool>? NewRevisionAvailable { get; set; }

        [Input("newRevisionSummary")]
        public Input<string>? NewRevisionSummary { get; set; }

        [Input("versionDeprecated")]
        public Input<bool>? VersionDeprecated { get; set; }

        public KubernetesClusterMasterVersionInfoArgs()
        {
        }
        public static new KubernetesClusterMasterVersionInfoArgs Empty => new KubernetesClusterMasterVersionInfoArgs();
    }
}
