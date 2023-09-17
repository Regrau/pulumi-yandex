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
    public sealed class MonitoringDashboardWidgetChartQueryDownsampling
    {
        /// <summary>
        /// Disable downsampling.
        /// </summary>
        public readonly bool? Disabled;
        /// <summary>
        /// Parameters for filling gaps in data.
        /// </summary>
        public readonly string? GapFilling;
        /// <summary>
        /// Function that is used for downsampling.
        /// </summary>
        public readonly string? GridAggregation;
        /// <summary>
        /// Time interval (grid) for downsampling in milliseconds. Points in the specified range are aggregated into one time point
        /// </summary>
        public readonly int? GridInterval;
        /// <summary>
        /// Maximum number of points to be returned.
        /// </summary>
        public readonly int? MaxPoints;

        [OutputConstructor]
        private MonitoringDashboardWidgetChartQueryDownsampling(
            bool? disabled,

            string? gapFilling,

            string? gridAggregation,

            int? gridInterval,

            int? maxPoints)
        {
            Disabled = disabled;
            GapFilling = gapFilling;
            GridAggregation = gridAggregation;
            GridInterval = gridInterval;
            MaxPoints = maxPoints;
        }
    }
}
