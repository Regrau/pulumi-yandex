// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Heatmap green value.
        /// </summary>
        [Input("greenValue")]
        public Input<string>? GreenValue { get; set; }

        /// <summary>
        /// Heatmap red value.
        /// </summary>
        [Input("redValue")]
        public Input<string>? RedValue { get; set; }

        /// <summary>
        /// Heatmap violet value.
        /// </summary>
        [Input("violetValue")]
        public Input<string>? VioletValue { get; set; }

        /// <summary>
        /// Heatmap yellow value.
        /// </summary>
        [Input("yellowValue")]
        public Input<string>? YellowValue { get; set; }

        public MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingArgs()
        {
        }
        public static new MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingArgs Empty => new MonitoringDashboardWidgetChartVisualizationSettingHeatmapSettingArgs();
    }
}
