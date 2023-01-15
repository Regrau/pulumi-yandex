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
    /// Creates a new snapshot schedule. For more information, see
    /// [the official documentation](https://cloud.yandex.ru/docs/compute/concepts/snapshot-schedule).
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var @default = new Yandex.ComputeSnapshotSchedule("default", new()
    ///     {
    ///         DiskIds = new[]
    ///         {
    ///             "test_disk_id",
    ///             "another_test_disk_id",
    ///         },
    ///         Labels = 
    ///         {
    ///             { "my-label", "my-label-value" },
    ///         },
    ///         SchedulePolicy = new Yandex.Inputs.ComputeSnapshotScheduleSchedulePolicyArgs
    ///         {
    ///             Expression = "0 0 * * *",
    ///         },
    ///         SnapshotCount = 1,
    ///         SnapshotSpec = new Yandex.Inputs.ComputeSnapshotScheduleSnapshotSpecArgs
    ///         {
    ///             Description = "snapshot-description",
    ///             Labels = 
    ///             {
    ///                 { "snapshot-label", "my-snapshot-label-value" },
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// A snapshot schedule can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/computeSnapshotSchedule:computeSnapshotSchedule my-schedule snapshot_schedule_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/computeSnapshotSchedule:computeSnapshotSchedule")]
    public partial class ComputeSnapshotSchedule : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation timestamp of the snapshot schedule.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Description of the resource.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// IDs of the disk for snapshot schedule.
        /// </summary>
        [Output("diskIds")]
        public Output<ImmutableArray<string>> DiskIds { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the snapshot schedule.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// A name for the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Retention period applied to snapshots created by this snapshot schedule.
        /// </summary>
        [Output("retentionPeriod")]
        public Output<string?> RetentionPeriod { get; private set; } = null!;

        /// <summary>
        /// Schedule policy of the snapshot schedule.
        /// </summary>
        [Output("schedulePolicy")]
        public Output<Outputs.ComputeSnapshotScheduleSchedulePolicy> SchedulePolicy { get; private set; } = null!;

        /// <summary>
        /// Maximum number of snapshots for every disk of the snapshot schedule.
        /// </summary>
        [Output("snapshotCount")]
        public Output<int?> SnapshotCount { get; private set; } = null!;

        /// <summary>
        /// Additional attributes for snapshots created by this snapshot schedule.
        /// </summary>
        [Output("snapshotSpec")]
        public Output<Outputs.ComputeSnapshotScheduleSnapshotSpec> SnapshotSpec { get; private set; } = null!;

        /// <summary>
        /// The status of the snapshot schedule.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a ComputeSnapshotSchedule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ComputeSnapshotSchedule(string name, ComputeSnapshotScheduleArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/computeSnapshotSchedule:computeSnapshotSchedule", name, args ?? new ComputeSnapshotScheduleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ComputeSnapshotSchedule(string name, Input<string> id, ComputeSnapshotScheduleState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/computeSnapshotSchedule:computeSnapshotSchedule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ComputeSnapshotSchedule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ComputeSnapshotSchedule Get(string name, Input<string> id, ComputeSnapshotScheduleState? state = null, CustomResourceOptions? options = null)
        {
            return new ComputeSnapshotSchedule(name, id, state, options);
        }
    }

    public sealed class ComputeSnapshotScheduleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskIds")]
        private InputList<string>? _diskIds;

        /// <summary>
        /// IDs of the disk for snapshot schedule.
        /// </summary>
        public InputList<string> DiskIds
        {
            get => _diskIds ?? (_diskIds = new InputList<string>());
            set => _diskIds = value;
        }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the snapshot schedule.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// A name for the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Retention period applied to snapshots created by this snapshot schedule.
        /// </summary>
        [Input("retentionPeriod")]
        public Input<string>? RetentionPeriod { get; set; }

        /// <summary>
        /// Schedule policy of the snapshot schedule.
        /// </summary>
        [Input("schedulePolicy")]
        public Input<Inputs.ComputeSnapshotScheduleSchedulePolicyArgs>? SchedulePolicy { get; set; }

        /// <summary>
        /// Maximum number of snapshots for every disk of the snapshot schedule.
        /// </summary>
        [Input("snapshotCount")]
        public Input<int>? SnapshotCount { get; set; }

        /// <summary>
        /// Additional attributes for snapshots created by this snapshot schedule.
        /// </summary>
        [Input("snapshotSpec")]
        public Input<Inputs.ComputeSnapshotScheduleSnapshotSpecArgs>? SnapshotSpec { get; set; }

        public ComputeSnapshotScheduleArgs()
        {
        }
        public static new ComputeSnapshotScheduleArgs Empty => new ComputeSnapshotScheduleArgs();
    }

    public sealed class ComputeSnapshotScheduleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation timestamp of the snapshot schedule.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Description of the resource.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("diskIds")]
        private InputList<string>? _diskIds;

        /// <summary>
        /// IDs of the disk for snapshot schedule.
        /// </summary>
        public InputList<string> DiskIds
        {
            get => _diskIds ?? (_diskIds = new InputList<string>());
            set => _diskIds = value;
        }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the snapshot schedule.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// A name for the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Retention period applied to snapshots created by this snapshot schedule.
        /// </summary>
        [Input("retentionPeriod")]
        public Input<string>? RetentionPeriod { get; set; }

        /// <summary>
        /// Schedule policy of the snapshot schedule.
        /// </summary>
        [Input("schedulePolicy")]
        public Input<Inputs.ComputeSnapshotScheduleSchedulePolicyGetArgs>? SchedulePolicy { get; set; }

        /// <summary>
        /// Maximum number of snapshots for every disk of the snapshot schedule.
        /// </summary>
        [Input("snapshotCount")]
        public Input<int>? SnapshotCount { get; set; }

        /// <summary>
        /// Additional attributes for snapshots created by this snapshot schedule.
        /// </summary>
        [Input("snapshotSpec")]
        public Input<Inputs.ComputeSnapshotScheduleSnapshotSpecGetArgs>? SnapshotSpec { get; set; }

        /// <summary>
        /// The status of the snapshot schedule.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ComputeSnapshotScheduleState()
        {
        }
        public static new ComputeSnapshotScheduleState Empty => new ComputeSnapshotScheduleState();
    }
}
