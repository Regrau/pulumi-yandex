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
    public sealed class KubernetesClusterMasterMasterLogging
    {
        /// <summary>
        /// (Optional) Boolean flag that specifies if kube-apiserver audit logs should be sent to Yandex Cloud Logging.
        /// </summary>
        public readonly bool? AuditEnabled;
        /// <summary>
        /// (Optional) Boolean flag that specifies if cluster-autoscaler logs should be sent to Yandex Cloud Logging.
        /// </summary>
        public readonly bool? ClusterAutoscalerEnabled;
        /// <summary>
        /// (Optional) Boolean flag that specifies if master components logs should be sent to [Yandex Cloud Logging](https://cloud.yandex.com/docs/logging/). The exact components that will send their logs must be configured via the options described below.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// (Optional) Boolean flag that specifies if kubernetes cluster events should be sent to Yandex Cloud Logging.
        /// </summary>
        public readonly bool? EventsEnabled;
        /// <summary>
        /// The ID of the folder that the Kubernetes cluster belongs to.
        /// If it is not provided, the default provider folder is used.
        /// </summary>
        public readonly string? FolderId;
        /// <summary>
        /// (Optional) Boolean flag that specifies if kube-apiserver logs should be sent to Yandex Cloud Logging.
        /// </summary>
        public readonly bool? KubeApiserverEnabled;
        /// <summary>
        /// (Optional) ID of the Yandex Cloud Logging [Log group](https://cloud.yandex.com/docs/logging/concepts/log-group).
        /// </summary>
        public readonly string? LogGroupId;

        [OutputConstructor]
        private KubernetesClusterMasterMasterLogging(
            bool? auditEnabled,

            bool? clusterAutoscalerEnabled,

            bool? enabled,

            bool? eventsEnabled,

            string? folderId,

            bool? kubeApiserverEnabled,

            string? logGroupId)
        {
            AuditEnabled = auditEnabled;
            ClusterAutoscalerEnabled = clusterAutoscalerEnabled;
            Enabled = enabled;
            EventsEnabled = eventsEnabled;
            FolderId = folderId;
            KubeApiserverEnabled = kubeApiserverEnabled;
            LogGroupId = logGroupId;
        }
    }
}
