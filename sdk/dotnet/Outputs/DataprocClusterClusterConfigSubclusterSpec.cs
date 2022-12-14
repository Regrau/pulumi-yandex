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
    public sealed class DataprocClusterClusterConfigSubclusterSpec
    {
        /// <summary>
        /// If true then assign public IP addresses to the hosts of the subclusters.
        /// </summary>
        public readonly bool? AssignPublicIp;
        /// <summary>
        /// Autoscaling configuration for compute subclusters.
        /// </summary>
        public readonly Outputs.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig? AutoscalingConfig;
        /// <summary>
        /// Number of hosts within Data Proc subcluster.
        /// </summary>
        public readonly int HostsCount;
        /// <summary>
        /// (Computed) ID of a new Data Proc cluster.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the Data Proc subcluster.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resources allocated to each host of the Data Proc subcluster. The structure is documented below.
        /// </summary>
        public readonly Outputs.DataprocClusterClusterConfigSubclusterSpecResources Resources;
        /// <summary>
        /// Role of the subcluster in the Data Proc cluster.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// The ID of the subnet, to which hosts of the subcluster belong. Subnets of all the subclusters must belong to the same VPC network.
        /// </summary>
        public readonly string SubnetId;

        [OutputConstructor]
        private DataprocClusterClusterConfigSubclusterSpec(
            bool? assignPublicIp,

            Outputs.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig? autoscalingConfig,

            int hostsCount,

            string? id,

            string name,

            Outputs.DataprocClusterClusterConfigSubclusterSpecResources resources,

            string role,

            string subnetId)
        {
            AssignPublicIp = assignPublicIp;
            AutoscalingConfig = autoscalingConfig;
            HostsCount = hostsCount;
            Id = id;
            Name = name;
            Resources = resources;
            Role = role;
            SubnetId = subnetId;
        }
    }
}
