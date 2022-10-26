// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    [YandexResourceType("yandex:index/ydbDatabaseServerless:YdbDatabaseServerless")]
    public partial class YdbDatabaseServerless : global::Pulumi.CustomResource
    {
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        [Output("databasePath")]
        public Output<string> DatabasePath { get; private set; } = null!;

        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("documentApiEndpoint")]
        public Output<string> DocumentApiEndpoint { get; private set; } = null!;

        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("locationId")]
        public Output<string> LocationId { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        [Output("tlsEnabled")]
        public Output<bool> TlsEnabled { get; private set; } = null!;

        [Output("ydbApiEndpoint")]
        public Output<string> YdbApiEndpoint { get; private set; } = null!;

        [Output("ydbFullEndpoint")]
        public Output<string> YdbFullEndpoint { get; private set; } = null!;


        /// <summary>
        /// Create a YdbDatabaseServerless resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public YdbDatabaseServerless(string name, YdbDatabaseServerlessArgs? args = null, CustomResourceOptions? options = null)
            : base("yandex:index/ydbDatabaseServerless:YdbDatabaseServerless", name, args ?? new YdbDatabaseServerlessArgs(), MakeResourceOptions(options, ""))
        {
        }

        private YdbDatabaseServerless(string name, Input<string> id, YdbDatabaseServerlessState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/ydbDatabaseServerless:YdbDatabaseServerless", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing YdbDatabaseServerless resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static YdbDatabaseServerless Get(string name, Input<string> id, YdbDatabaseServerlessState? state = null, CustomResourceOptions? options = null)
        {
            return new YdbDatabaseServerless(name, id, state, options);
        }
    }

    public sealed class YdbDatabaseServerlessArgs : global::Pulumi.ResourceArgs
    {
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

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

        [Input("locationId")]
        public Input<string>? LocationId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public YdbDatabaseServerlessArgs()
        {
        }
        public static new YdbDatabaseServerlessArgs Empty => new YdbDatabaseServerlessArgs();
    }

    public sealed class YdbDatabaseServerlessState : global::Pulumi.ResourceArgs
    {
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("databasePath")]
        public Input<string>? DatabasePath { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("documentApiEndpoint")]
        public Input<string>? DocumentApiEndpoint { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("locationId")]
        public Input<string>? LocationId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tlsEnabled")]
        public Input<bool>? TlsEnabled { get; set; }

        [Input("ydbApiEndpoint")]
        public Input<string>? YdbApiEndpoint { get; set; }

        [Input("ydbFullEndpoint")]
        public Input<string>? YdbFullEndpoint { get; set; }

        public YdbDatabaseServerlessState()
        {
        }
        public static new YdbDatabaseServerlessState Empty => new YdbDatabaseServerlessState();
    }
}