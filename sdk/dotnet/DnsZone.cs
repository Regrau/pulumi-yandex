// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/dnsZone:DnsZone")]
    public partial class DnsZone : global::Pulumi.CustomResource
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

        [Output("privateNetworks")]
        public Output<ImmutableArray<string>> PrivateNetworks { get; private set; } = null!;

        [Output("public")]
        public Output<bool> Public { get; private set; } = null!;

        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a DnsZone resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DnsZone(string name, DnsZoneArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/dnsZone:DnsZone", name, args ?? new DnsZoneArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DnsZone(string name, Input<string> id, DnsZoneState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/dnsZone:DnsZone", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DnsZone resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DnsZone Get(string name, Input<string> id, DnsZoneState? state = null, CustomResourceOptions? options = null)
        {
            return new DnsZone(name, id, state, options);
        }
    }

    public sealed class DnsZoneArgs : global::Pulumi.ResourceArgs
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

        [Input("privateNetworks")]
        private InputList<string>? _privateNetworks;
        public InputList<string> PrivateNetworks
        {
            get => _privateNetworks ?? (_privateNetworks = new InputList<string>());
            set => _privateNetworks = value;
        }

        [Input("public")]
        public Input<bool>? Public { get; set; }

        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public DnsZoneArgs()
        {
        }
        public static new DnsZoneArgs Empty => new DnsZoneArgs();
    }

    public sealed class DnsZoneState : global::Pulumi.ResourceArgs
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

        [Input("privateNetworks")]
        private InputList<string>? _privateNetworks;
        public InputList<string> PrivateNetworks
        {
            get => _privateNetworks ?? (_privateNetworks = new InputList<string>());
            set => _privateNetworks = value;
        }

        [Input("public")]
        public Input<bool>? Public { get; set; }

        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public DnsZoneState()
        {
        }
        public static new DnsZoneState Empty => new DnsZoneState();
    }
}
