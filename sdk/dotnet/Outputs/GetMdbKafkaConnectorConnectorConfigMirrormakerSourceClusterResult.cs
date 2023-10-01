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
    public sealed class GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterResult
    {
        /// <summary>
        /// Name of the cluster. Used also as a topic prefix
        /// </summary>
        public readonly string Alias;
        /// <summary>
        /// Connection params for external cluster
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterResult> ExternalClusters;
        /// <summary>
        /// Using this section in the cluster definition (source or target) means it's this cluster
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisClusterResult> ThisClusters;

        [OutputConstructor]
        private GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterResult(
            string alias,

            ImmutableArray<Outputs.GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterResult> externalClusters,

            ImmutableArray<Outputs.GetMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisClusterResult> thisClusters)
        {
            Alias = alias;
            ExternalClusters = externalClusters;
            ThisClusters = thisClusters;
        }
    }
}