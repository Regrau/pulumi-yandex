// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Outputs
{

    [OutputType]
    public sealed class GetDataprocClusterClusterConfigSubclusterSpecResult
    {
        /// <summary>
        /// The hosts of the subclusters have public IP addresses.
        /// </summary>
        public readonly bool AssignPublicIp;
        /// <summary>
        /// Optional autoscaling configuration for compute subclusters.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDataprocClusterClusterConfigSubclusterSpecAutoscalingConfigResult> AutoscalingConfigs;
        /// <summary>
        /// Number of hosts within Data Proc subcluster.
        /// </summary>
        public readonly int HostsCount;
        /// <summary>
        /// ID of the Data Proc subcluster.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the Data Proc cluster.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resources allocated to each host of the Data Proc subcluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDataprocClusterClusterConfigSubclusterSpecResourceResult> Resources;
        /// <summary>
        /// Role of the subcluster in the Data Proc cluster.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// The ID of the subnet, to which hosts of the subcluster belong.
        /// </summary>
        public readonly string SubnetId;

        [OutputConstructor]
        private GetDataprocClusterClusterConfigSubclusterSpecResult(
            bool assignPublicIp,

            ImmutableArray<Outputs.GetDataprocClusterClusterConfigSubclusterSpecAutoscalingConfigResult> autoscalingConfigs,

            int hostsCount,

            string id,

            string name,

            ImmutableArray<Outputs.GetDataprocClusterClusterConfigSubclusterSpecResourceResult> resources,

            string role,

            string subnetId)
        {
            AssignPublicIp = assignPublicIp;
            AutoscalingConfigs = autoscalingConfigs;
            HostsCount = hostsCount;
            Id = id;
            Name = name;
            Resources = resources;
            Role = role;
            SubnetId = subnetId;
        }
    }
}
