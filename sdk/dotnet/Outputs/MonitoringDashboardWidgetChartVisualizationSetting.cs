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
    public sealed class MonitoringDashboardWidgetChartVisualizationSetting
    {
        /// <summary>
        /// Aggregation. Values:
        /// - SERIES_AGGREGATION_UNSPECIFIED: Not specified (avg by default).
        /// - SERIES_AGGREGATION_AVG: Average.
        /// - SERIES_AGGREGATION_MIN: Minimum.
        /// - SERIES_AGGREGATION_MAX: Maximum.
        /// - SERIES_AGGREGATION_LAST: Last non-NaN value.
        /// - SERIES_AGGREGATION_SUM: Sum.
        /// </summary>
        public readonly string? Aggregation;
        /// <summary>
        /// Color settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.MonitoringDashboardWidgetChartVisualizationSettingColorSchemeSetting> ColorSchemeSettings;
        /// <summary>
        /// Heatmap settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.MonitoringDashboardWidgetChartVisualizationSettingHeatmapSetting> HeatmapSettings;
        /// <summary>
        /// Interpolate values. Values:
        /// - INTERPOLATE_UNSPECIFIED: Not specified (linear by default).
        /// - INTERPOLATE_LINEAR: Linear.
        /// - INTERPOLATE_LEFT: Left.
        /// - INTERPOLATE_RIGHT: Right.
        /// </summary>
        public readonly string? Interpolate;
        /// <summary>
        /// Normalize values.
        /// </summary>
        public readonly bool? Normalize;
        /// <summary>
        /// Show chart labels.
        /// </summary>
        public readonly bool? ShowLabels;
        /// <summary>
        /// -Title or empty.
        /// </summary>
        public readonly string? Title;
        /// <summary>
        /// Type.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Y axis settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.MonitoringDashboardWidgetChartVisualizationSettingYaxisSetting> YaxisSettings;

        [OutputConstructor]
        private MonitoringDashboardWidgetChartVisualizationSetting(
            string? aggregation,

            ImmutableArray<Outputs.MonitoringDashboardWidgetChartVisualizationSettingColorSchemeSetting> colorSchemeSettings,

            ImmutableArray<Outputs.MonitoringDashboardWidgetChartVisualizationSettingHeatmapSetting> heatmapSettings,

            string? interpolate,

            bool? normalize,

            bool? showLabels,

            string? title,

            string? type,

            ImmutableArray<Outputs.MonitoringDashboardWidgetChartVisualizationSettingYaxisSetting> yaxisSettings)
        {
            Aggregation = aggregation;
            ColorSchemeSettings = colorSchemeSettings;
            HeatmapSettings = heatmapSettings;
            Interpolate = interpolate;
            Normalize = normalize;
            ShowLabels = showLabels;
            Title = title;
            Type = type;
            YaxisSettings = yaxisSettings;
        }
    }
}
