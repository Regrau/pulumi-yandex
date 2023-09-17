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
    public sealed class GetMonitoringDashboardWidgetResult
    {
        /// <summary>
        /// Chart widget settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartResult> Charts;
        /// <summary>
        /// Widget position.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetPositionResult> Positions;
        /// <summary>
        /// Title text.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetTextResult> Texts;
        /// <summary>
        /// Inside chart title.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMonitoringDashboardWidgetTitleResult> Titles;

        [OutputConstructor]
        private GetMonitoringDashboardWidgetResult(
            ImmutableArray<Outputs.GetMonitoringDashboardWidgetChartResult> charts,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetPositionResult> positions,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetTextResult> texts,

            ImmutableArray<Outputs.GetMonitoringDashboardWidgetTitleResult> titles)
        {
            Charts = charts;
            Positions = positions;
            Texts = texts;
            Titles = titles;
        }
    }
}
