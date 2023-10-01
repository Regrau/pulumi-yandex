// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    /// <summary>
    /// Get information about a Yandex Monitoring dashboard.
    /// 
    /// ## Import
    /// 
    /// A Monitoring dashboard can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/monitoringDashboard:monitoringDashboard default dashboard_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/monitoringDashboard:monitoringDashboard")]
    public partial class MonitoringDashboard : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Dashboard ID
        /// </summary>
        [Output("dashboardId")]
        public Output<string> DashboardId { get; private set; } = null!;

        /// <summary>
        /// Chart description in dashboard (not enabled in UI).
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Labels folder ID.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the Dashboard.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// Series name or empty.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Dashboard parametrization
        /// </summary>
        [Output("parametrizations")]
        public Output<ImmutableArray<Outputs.MonitoringDashboardParametrization>> Parametrizations { get; private set; } = null!;

        /// <summary>
        /// -Title or empty.
        /// </summary>
        [Output("title")]
        public Output<string?> Title { get; private set; } = null!;

        /// <summary>
        /// Widgets
        /// </summary>
        [Output("widgets")]
        public Output<ImmutableArray<Outputs.MonitoringDashboardWidget>> Widgets { get; private set; } = null!;


        /// <summary>
        /// Create a MonitoringDashboard resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MonitoringDashboard(string name, MonitoringDashboardArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/monitoringDashboard:monitoringDashboard", name, args ?? new MonitoringDashboardArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MonitoringDashboard(string name, Input<string> id, MonitoringDashboardState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/monitoringDashboard:monitoringDashboard", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/regrau/pulumi-yandex/releases",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MonitoringDashboard resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MonitoringDashboard Get(string name, Input<string> id, MonitoringDashboardState? state = null, CustomResourceOptions? options = null)
        {
            return new MonitoringDashboard(name, id, state, options);
        }
    }

    public sealed class MonitoringDashboardArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Chart description in dashboard (not enabled in UI).
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Labels folder ID.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Dashboard.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Series name or empty.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parametrizations")]
        private InputList<Inputs.MonitoringDashboardParametrizationArgs>? _parametrizations;

        /// <summary>
        /// Dashboard parametrization
        /// </summary>
        public InputList<Inputs.MonitoringDashboardParametrizationArgs> Parametrizations
        {
            get => _parametrizations ?? (_parametrizations = new InputList<Inputs.MonitoringDashboardParametrizationArgs>());
            set => _parametrizations = value;
        }

        /// <summary>
        /// -Title or empty.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("widgets")]
        private InputList<Inputs.MonitoringDashboardWidgetArgs>? _widgets;

        /// <summary>
        /// Widgets
        /// </summary>
        public InputList<Inputs.MonitoringDashboardWidgetArgs> Widgets
        {
            get => _widgets ?? (_widgets = new InputList<Inputs.MonitoringDashboardWidgetArgs>());
            set => _widgets = value;
        }

        public MonitoringDashboardArgs()
        {
        }
        public static new MonitoringDashboardArgs Empty => new MonitoringDashboardArgs();
    }

    public sealed class MonitoringDashboardState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Dashboard ID
        /// </summary>
        [Input("dashboardId")]
        public Input<string>? DashboardId { get; set; }

        /// <summary>
        /// Chart description in dashboard (not enabled in UI).
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Labels folder ID.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Dashboard.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Series name or empty.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parametrizations")]
        private InputList<Inputs.MonitoringDashboardParametrizationGetArgs>? _parametrizations;

        /// <summary>
        /// Dashboard parametrization
        /// </summary>
        public InputList<Inputs.MonitoringDashboardParametrizationGetArgs> Parametrizations
        {
            get => _parametrizations ?? (_parametrizations = new InputList<Inputs.MonitoringDashboardParametrizationGetArgs>());
            set => _parametrizations = value;
        }

        /// <summary>
        /// -Title or empty.
        /// </summary>
        [Input("title")]
        public Input<string>? Title { get; set; }

        [Input("widgets")]
        private InputList<Inputs.MonitoringDashboardWidgetGetArgs>? _widgets;

        /// <summary>
        /// Widgets
        /// </summary>
        public InputList<Inputs.MonitoringDashboardWidgetGetArgs> Widgets
        {
            get => _widgets ?? (_widgets = new InputList<Inputs.MonitoringDashboardWidgetGetArgs>());
            set => _widgets = value;
        }

        public MonitoringDashboardState()
        {
        }
        public static new MonitoringDashboardState Empty => new MonitoringDashboardState();
    }
}