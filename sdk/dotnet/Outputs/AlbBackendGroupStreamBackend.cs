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
    public sealed class AlbBackendGroupStreamBackend
    {
        public readonly bool? EnableProxyProtocol;
        /// <summary>
        /// Healthcheck specification that will be used by this backend. Structure is documented below.
        /// </summary>
        public readonly Outputs.AlbBackendGroupStreamBackendHealthcheck? Healthcheck;
        /// <summary>
        /// Load Balancing Config specification that will be used by this backend. Structure is documented below.
        /// </summary>
        public readonly Outputs.AlbBackendGroupStreamBackendLoadBalancingConfig? LoadBalancingConfig;
        /// <summary>
        /// Name of the backend.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Port for incoming traffic.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// References target groups for the backend.
        /// </summary>
        public readonly ImmutableArray<string> TargetGroupIds;
        /// <summary>
        /// Tls specification that will be used by this backend. Structure is documented below.
        /// </summary>
        public readonly Outputs.AlbBackendGroupStreamBackendTls? Tls;
        /// <summary>
        /// Weight of the backend. Traffic will be split between backends of the same BackendGroup according to their weights.
        /// </summary>
        public readonly int? Weight;

        [OutputConstructor]
        private AlbBackendGroupStreamBackend(
            bool? enableProxyProtocol,

            Outputs.AlbBackendGroupStreamBackendHealthcheck? healthcheck,

            Outputs.AlbBackendGroupStreamBackendLoadBalancingConfig? loadBalancingConfig,

            string name,

            int? port,

            ImmutableArray<string> targetGroupIds,

            Outputs.AlbBackendGroupStreamBackendTls? tls,

            int? weight)
        {
            EnableProxyProtocol = enableProxyProtocol;
            Healthcheck = healthcheck;
            LoadBalancingConfig = loadBalancingConfig;
            Name = name;
            Port = port;
            TargetGroupIds = targetGroupIds;
            Tls = tls;
            Weight = weight;
        }
    }
}
