// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/lbTargetGroup:LbTargetGroup")]
    public partial class LbTargetGroup : global::Pulumi.CustomResource
    {
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

        [Output("regionId")]
        public Output<string?> RegionId { get; private set; } = null!;

        [Output("targets")]
        public Output<ImmutableArray<Outputs.LbTargetGroupTarget>> Targets { get; private set; } = null!;


        /// <summary>
        /// Create a LbTargetGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LbTargetGroup(string name, LbTargetGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/lbTargetGroup:LbTargetGroup", name, args ?? new LbTargetGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LbTargetGroup(string name, Input<string> id, LbTargetGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/lbTargetGroup:LbTargetGroup", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github/regrau/pulumi-yandex/releases",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LbTargetGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LbTargetGroup Get(string name, Input<string> id, LbTargetGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new LbTargetGroup(name, id, state, options);
        }
    }

    public sealed class LbTargetGroupArgs : global::Pulumi.ResourceArgs
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

        [Input("regionId")]
        public Input<string>? RegionId { get; set; }

        [Input("targets")]
        private InputList<Inputs.LbTargetGroupTargetArgs>? _targets;
        public InputList<Inputs.LbTargetGroupTargetArgs> Targets
        {
            get => _targets ?? (_targets = new InputList<Inputs.LbTargetGroupTargetArgs>());
            set => _targets = value;
        }

        public LbTargetGroupArgs()
        {
        }
        public static new LbTargetGroupArgs Empty => new LbTargetGroupArgs();
    }

    public sealed class LbTargetGroupState : global::Pulumi.ResourceArgs
    {
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

        [Input("regionId")]
        public Input<string>? RegionId { get; set; }

        [Input("targets")]
        private InputList<Inputs.LbTargetGroupTargetGetArgs>? _targets;
        public InputList<Inputs.LbTargetGroupTargetGetArgs> Targets
        {
            get => _targets ?? (_targets = new InputList<Inputs.LbTargetGroupTargetGetArgs>());
            set => _targets = value;
        }

        public LbTargetGroupState()
        {
        }
        public static new LbTargetGroupState Empty => new LbTargetGroupState();
    }
}
