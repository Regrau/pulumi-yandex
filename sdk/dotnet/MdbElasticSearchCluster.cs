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
    /// Manages a Elasticsearch cluster within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/concepts).
    /// 
    /// ## Import
    /// 
    /// A cluster can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/mdbElasticSearchCluster:MdbElasticSearchCluster foo cluster_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/mdbElasticSearchCluster:MdbElasticSearchCluster")]
    public partial class MdbElasticSearchCluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Configuration of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        [Output("config")]
        public Output<Outputs.MdbElasticSearchClusterConfig> Config { get; private set; } = null!;

        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Description of the Elasticsearch cluster.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
        /// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
        /// </summary>
        [Output("health")]
        public Output<string> Health { get; private set; } = null!;

        /// <summary>
        /// A host of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        [Output("hosts")]
        public Output<ImmutableArray<Outputs.MdbElasticSearchClusterHost>> Hosts { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the Elasticsearch cluster.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        [Output("maintenanceWindow")]
        public Output<Outputs.MdbElasticSearchClusterMaintenanceWindow> MaintenanceWindow { get; private set; } = null!;

        /// <summary>
        /// User defined host name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the network, to which the Elasticsearch cluster belongs.
        /// </summary>
        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        /// <summary>
        /// ID of the service account authorized for this cluster.
        /// </summary>
        [Output("serviceAccountId")]
        public Output<string?> ServiceAccountId { get; private set; } = null!;

        /// <summary>
        /// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
        /// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;


        /// <summary>
        /// Create a MdbElasticSearchCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbElasticSearchCluster(string name, MdbElasticSearchClusterArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbElasticSearchCluster:MdbElasticSearchCluster", name, args ?? new MdbElasticSearchClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbElasticSearchCluster(string name, Input<string> id, MdbElasticSearchClusterState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbElasticSearchCluster:MdbElasticSearchCluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MdbElasticSearchCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbElasticSearchCluster Get(string name, Input<string> id, MdbElasticSearchClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbElasticSearchCluster(name, id, state, options);
        }
    }

    public sealed class MdbElasticSearchClusterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        [Input("config", required: true)]
        public Input<Inputs.MdbElasticSearchClusterConfigArgs> Config { get; set; } = null!;

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the Elasticsearch cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("hosts")]
        private InputList<Inputs.MdbElasticSearchClusterHostArgs>? _hosts;

        /// <summary>
        /// A host of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbElasticSearchClusterHostArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbElasticSearchClusterHostArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Elasticsearch cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("maintenanceWindow")]
        public Input<Inputs.MdbElasticSearchClusterMaintenanceWindowArgs>? MaintenanceWindow { get; set; }

        /// <summary>
        /// User defined host name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the Elasticsearch cluster belongs.
        /// </summary>
        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// ID of the service account authorized for this cluster.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        public MdbElasticSearchClusterArgs()
        {
        }
        public static new MdbElasticSearchClusterArgs Empty => new MdbElasticSearchClusterArgs();
    }

    public sealed class MdbElasticSearchClusterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        [Input("config")]
        public Input<Inputs.MdbElasticSearchClusterConfigGetArgs>? Config { get; set; }

        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the Elasticsearch cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Deployment environment of the Elasticsearch cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Aggregated health of the cluster. Can be either `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
        /// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
        /// </summary>
        [Input("health")]
        public Input<string>? Health { get; set; }

        [Input("hosts")]
        private InputList<Inputs.MdbElasticSearchClusterHostGetArgs>? _hosts;

        /// <summary>
        /// A host of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbElasticSearchClusterHostGetArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbElasticSearchClusterHostGetArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Elasticsearch cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("maintenanceWindow")]
        public Input<Inputs.MdbElasticSearchClusterMaintenanceWindowGetArgs>? MaintenanceWindow { get; set; }

        /// <summary>
        /// User defined host name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the Elasticsearch cluster belongs.
        /// </summary>
        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// ID of the service account authorized for this cluster.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        /// <summary>
        /// Status of the cluster. Can be either `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
        /// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/api-ref/Cluster/).
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public MdbElasticSearchClusterState()
        {
        }
        public static new MdbElasticSearchClusterState Empty => new MdbElasticSearchClusterState();
    }
}
