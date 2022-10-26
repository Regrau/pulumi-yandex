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
    public sealed class GetComputeInstanceGroupScalePolicyAutoScaleResult
    {
        /// <summary>
        /// Target CPU load level.
        /// </summary>
        public readonly double CpuUtilizationTarget;
        /// <summary>
        /// A list of custom rules. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetComputeInstanceGroupScalePolicyAutoScaleCustomRuleResult> CustomRules;
        /// <summary>
        /// The initial number of instances in the instance group.
        /// </summary>
        public readonly int InitialSize;
        /// <summary>
        /// The maximum number of virtual machines in the group.
        /// </summary>
        public readonly int MaxSize;
        /// <summary>
        /// The amount of time, in seconds, that metrics are averaged for.
        /// If the average value at the end of the interval is higher than the `cpu_utilization_target`,
        /// the instance group will increase the number of virtual machines in the group.
        /// </summary>
        public readonly int MeasurementDuration;
        /// <summary>
        /// The minimum number of virtual machines in a single availability zone.
        /// </summary>
        public readonly int MinZoneSize;
        /// <summary>
        /// The minimum time interval, in seconds, to monitor the load before
        /// an instance group can reduce the number of virtual machines in the group. During this time, the group
        /// will not decrease even if the average load falls below the value of `cpu_utilization_target`.
        /// </summary>
        public readonly int StabilizationDuration;
        /// <summary>
        /// The warm-up time of the virtual machine, in seconds. During this time,
        /// traffic is fed to the virtual machine, but load metrics are not taken into account.
        /// </summary>
        public readonly int WarmupDuration;

        [OutputConstructor]
        private GetComputeInstanceGroupScalePolicyAutoScaleResult(
            double cpuUtilizationTarget,

            ImmutableArray<Outputs.GetComputeInstanceGroupScalePolicyAutoScaleCustomRuleResult> customRules,

            int initialSize,

            int maxSize,

            int measurementDuration,

            int minZoneSize,

            int stabilizationDuration,

            int warmupDuration)
        {
            CpuUtilizationTarget = cpuUtilizationTarget;
            CustomRules = customRules;
            InitialSize = initialSize;
            MaxSize = maxSize;
            MeasurementDuration = measurementDuration;
            MinZoneSize = minZoneSize;
            StabilizationDuration = stabilizationDuration;
            WarmupDuration = warmupDuration;
        }
    }
}
