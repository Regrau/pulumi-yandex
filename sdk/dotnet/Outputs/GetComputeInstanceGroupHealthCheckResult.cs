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
    public sealed class GetComputeInstanceGroupHealthCheckResult
    {
        /// <summary>
        /// The number of successful health checks before the managed instance is declared healthy.
        /// </summary>
        public readonly int HealthyThreshold;
        /// <summary>
        /// HTTP check options. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupHealthCheckHttpOptionResult> HttpOptions;
        /// <summary>
        /// The interval between health checks in seconds.
        /// </summary>
        public readonly int Interval;
        /// <summary>
        /// TCP check options. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupHealthCheckTcpOptionResult> TcpOptions;
        /// <summary>
        /// Timeout for the managed instance to return a response for the health check in seconds.
        /// </summary>
        public readonly int Timeout;
        /// <summary>
        /// The number of failed health checks before the managed instance is declared unhealthy.
        /// </summary>
        public readonly int UnhealthyThreshold;

        [OutputConstructor]
        private GetComputeInstanceGroupHealthCheckResult(
            int healthyThreshold,

            ImmutableArray<Outputs.GetComputeInstanceGroupHealthCheckHttpOptionResult> httpOptions,

            int interval,

            ImmutableArray<Outputs.GetComputeInstanceGroupHealthCheckTcpOptionResult> tcpOptions,

            int timeout,

            int unhealthyThreshold)
        {
            HealthyThreshold = healthyThreshold;
            HttpOptions = httpOptions;
            Interval = interval;
            TcpOptions = tcpOptions;
            Timeout = timeout;
            UnhealthyThreshold = unhealthyThreshold;
        }
    }
}
