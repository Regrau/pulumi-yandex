// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/loggingGroup:LoggingGroup")]
    public partial class LoggingGroup : global::Pulumi.CustomResource
    {
        [Output("cloudId")]
        public Output<string> CloudId { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("retentionPeriod")]
        public Output<string> RetentionPeriod { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a LoggingGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoggingGroup(string name, LoggingGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/loggingGroup:LoggingGroup", name, args ?? new LoggingGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoggingGroup(string name, Input<string> id, LoggingGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/loggingGroup:LoggingGroup", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoggingGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoggingGroup Get(string name, Input<string> id, LoggingGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new LoggingGroup(name, id, state, options);
        }
    }

    public sealed class LoggingGroupArgs : global::Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("retentionPeriod")]
        public Input<string>? RetentionPeriod { get; set; }

        public LoggingGroupArgs()
        {
        }
        public static new LoggingGroupArgs Empty => new LoggingGroupArgs();
    }

    public sealed class LoggingGroupState : global::Pulumi.ResourceArgs
    {
        [Input("cloudId")]
        public Input<string>? CloudId { get; set; }

        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("retentionPeriod")]
        public Input<string>? RetentionPeriod { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        public LoggingGroupState()
        {
        }
        public static new LoggingGroupState Empty => new LoggingGroupState();
    }
}
