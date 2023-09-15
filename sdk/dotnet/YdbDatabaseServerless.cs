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
    /// Yandex Database (serverless) resource. For more information, see
    ///     [the official documentation](https://cloud.yandex.com/en/docs/ydb/concepts/serverless_and_dedicated).
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
    ///     var database1 = new Yandex.YdbDatabaseServerless("database1", new()
    ///     {
    ///         DeletionProtection = true,
    ///         FolderId = data.Yandex_resourcemanager_folder.Test_folder.Id,
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/ydbDatabaseServerless:YdbDatabaseServerless")]
    public partial class YdbDatabaseServerless : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The Yandex Database serverless cluster creation timestamp.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Full database path of the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        [Output("databasePath")]
        public Output<string> DatabasePath { get; private set; } = null!;

        /// <summary>
        /// Inhibits deletion of the database. Can be either `true` or `false`
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool?> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// A description for the Yandex Database serverless cluster.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Document API endpoint of the Yandex Database serverless cluster.
        /// </summary>
        [Output("documentApiEndpoint")]
        public Output<string> DocumentApiEndpoint { get; private set; } = null!;

        /// <summary>
        /// ID of the folder that the Yandex Database serverless cluster belongs to.
        /// It will be deduced from provider configuration if not set explicitly.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Location ID for the Yandex Database serverless cluster.
        /// </summary>
        [Output("locationId")]
        public Output<string> LocationId { get; private set; } = null!;

        /// <summary>
        /// Name for the Yandex Database serverless cluster.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("serverlessDatabases")]
        public Output<ImmutableArray<Outputs.YdbDatabaseServerlessServerlessDatabase>> ServerlessDatabases { get; private set; } = null!;

        /// <summary>
        /// Status of the Yandex Database serverless cluster.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Whether TLS is enabled for the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        [Output("tlsEnabled")]
        public Output<bool> TlsEnabled { get; private set; } = null!;

        /// <summary>
        /// API endpoint of the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        [Output("ydbApiEndpoint")]
        public Output<string> YdbApiEndpoint { get; private set; } = null!;

        /// <summary>
        /// Full endpoint of the Yandex Database serverless cluster.
        /// </summary>
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
                PluginDownloadURL = "https://github.com/regrau/pulumi-yandex/releases",
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
        /// <summary>
        /// Inhibits deletion of the database. Can be either `true` or `false`
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// A description for the Yandex Database serverless cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the folder that the Yandex Database serverless cluster belongs to.
        /// It will be deduced from provider configuration if not set explicitly.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Location ID for the Yandex Database serverless cluster.
        /// </summary>
        [Input("locationId")]
        public Input<string>? LocationId { get; set; }

        /// <summary>
        /// Name for the Yandex Database serverless cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("serverlessDatabases")]
        private InputList<Inputs.YdbDatabaseServerlessServerlessDatabaseArgs>? _serverlessDatabases;
        public InputList<Inputs.YdbDatabaseServerlessServerlessDatabaseArgs> ServerlessDatabases
        {
            get => _serverlessDatabases ?? (_serverlessDatabases = new InputList<Inputs.YdbDatabaseServerlessServerlessDatabaseArgs>());
            set => _serverlessDatabases = value;
        }

        public YdbDatabaseServerlessArgs()
        {
        }
        public static new YdbDatabaseServerlessArgs Empty => new YdbDatabaseServerlessArgs();
    }

    public sealed class YdbDatabaseServerlessState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Yandex Database serverless cluster creation timestamp.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Full database path of the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        [Input("databasePath")]
        public Input<string>? DatabasePath { get; set; }

        /// <summary>
        /// Inhibits deletion of the database. Can be either `true` or `false`
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// A description for the Yandex Database serverless cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Document API endpoint of the Yandex Database serverless cluster.
        /// </summary>
        [Input("documentApiEndpoint")]
        public Input<string>? DocumentApiEndpoint { get; set; }

        /// <summary>
        /// ID of the folder that the Yandex Database serverless cluster belongs to.
        /// It will be deduced from provider configuration if not set explicitly.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Yandex Database serverless cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Location ID for the Yandex Database serverless cluster.
        /// </summary>
        [Input("locationId")]
        public Input<string>? LocationId { get; set; }

        /// <summary>
        /// Name for the Yandex Database serverless cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("serverlessDatabases")]
        private InputList<Inputs.YdbDatabaseServerlessServerlessDatabaseGetArgs>? _serverlessDatabases;
        public InputList<Inputs.YdbDatabaseServerlessServerlessDatabaseGetArgs> ServerlessDatabases
        {
            get => _serverlessDatabases ?? (_serverlessDatabases = new InputList<Inputs.YdbDatabaseServerlessServerlessDatabaseGetArgs>());
            set => _serverlessDatabases = value;
        }

        /// <summary>
        /// Status of the Yandex Database serverless cluster.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Whether TLS is enabled for the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        [Input("tlsEnabled")]
        public Input<bool>? TlsEnabled { get; set; }

        /// <summary>
        /// API endpoint of the Yandex Database serverless cluster.
        /// Useful for SDK configuration.
        /// </summary>
        [Input("ydbApiEndpoint")]
        public Input<string>? YdbApiEndpoint { get; set; }

        /// <summary>
        /// Full endpoint of the Yandex Database serverless cluster.
        /// </summary>
        [Input("ydbFullEndpoint")]
        public Input<string>? YdbFullEndpoint { get; set; }

        public YdbDatabaseServerlessState()
        {
        }
        public static new YdbDatabaseServerlessState Empty => new YdbDatabaseServerlessState();
    }
}
