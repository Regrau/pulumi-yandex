// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/lbNetworkLoadBalancer:LbNetworkLoadBalancer")]
    public partial class LbNetworkLoadBalancer : global::Pulumi.CustomResource
    {
        [Output("attachedTargetGroups")]
        public Output<ImmutableArray<Outputs.LbNetworkLoadBalancerAttachedTargetGroup>> AttachedTargetGroups { get; private set; } = null!;

        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("listeners")]
        public Output<ImmutableArray<Outputs.LbNetworkLoadBalancerListener>> Listeners { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("regionId")]
        public Output<string?> RegionId { get; private set; } = null!;

        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a LbNetworkLoadBalancer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LbNetworkLoadBalancer(string name, LbNetworkLoadBalancerArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/lbNetworkLoadBalancer:LbNetworkLoadBalancer", name, args ?? new LbNetworkLoadBalancerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LbNetworkLoadBalancer(string name, Input<string> id, LbNetworkLoadBalancerState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/lbNetworkLoadBalancer:LbNetworkLoadBalancer", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LbNetworkLoadBalancer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LbNetworkLoadBalancer Get(string name, Input<string> id, LbNetworkLoadBalancerState? state = null, CustomResourceOptions? options = null)
        {
            return new LbNetworkLoadBalancer(name, id, state, options);
        }
    }

    public sealed class LbNetworkLoadBalancerArgs : global::Pulumi.ResourceArgs
    {
        [Input("attachedTargetGroups")]
        private InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupArgs>? _attachedTargetGroups;
        public InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupArgs> AttachedTargetGroups
        {
            get => _attachedTargetGroups ?? (_attachedTargetGroups = new InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupArgs>());
            set => _attachedTargetGroups = value;
        }

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

        [Input("listeners")]
        private InputList<Inputs.LbNetworkLoadBalancerListenerArgs>? _listeners;
        public InputList<Inputs.LbNetworkLoadBalancerListenerArgs> Listeners
        {
            get => _listeners ?? (_listeners = new InputList<Inputs.LbNetworkLoadBalancerListenerArgs>());
            set => _listeners = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("regionId")]
        public Input<string>? RegionId { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public LbNetworkLoadBalancerArgs()
        {
        }
        public static new LbNetworkLoadBalancerArgs Empty => new LbNetworkLoadBalancerArgs();
    }

    public sealed class LbNetworkLoadBalancerState : global::Pulumi.ResourceArgs
    {
        [Input("attachedTargetGroups")]
        private InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupGetArgs>? _attachedTargetGroups;
        public InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupGetArgs> AttachedTargetGroups
        {
            get => _attachedTargetGroups ?? (_attachedTargetGroups = new InputList<Inputs.LbNetworkLoadBalancerAttachedTargetGroupGetArgs>());
            set => _attachedTargetGroups = value;
        }

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

        [Input("listeners")]
        private InputList<Inputs.LbNetworkLoadBalancerListenerGetArgs>? _listeners;
        public InputList<Inputs.LbNetworkLoadBalancerListenerGetArgs> Listeners
        {
            get => _listeners ?? (_listeners = new InputList<Inputs.LbNetworkLoadBalancerListenerGetArgs>());
            set => _listeners = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("regionId")]
        public Input<string>? RegionId { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public LbNetworkLoadBalancerState()
        {
        }
        public static new LbNetworkLoadBalancerState Empty => new LbNetworkLoadBalancerState();
    }
}
