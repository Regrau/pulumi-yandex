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
    /// Manages a ClickHouse cluster within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts).
    /// 
    /// ## Import
    /// 
    /// A cluster can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/mdbClickhouseCluster:MdbClickhouseCluster foo cluster_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster")]
    public partial class MdbClickhouseCluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Access policy to the ClickHouse cluster. The structure is documented below.
        /// </summary>
        [Output("access")]
        public Output<Outputs.MdbClickhouseClusterAccess> Access { get; private set; } = null!;

        /// <summary>
        /// A password used to authorize as user `admin` when `sql_user_management` enabled.
        /// </summary>
        [Output("adminPassword")]
        public Output<string?> AdminPassword { get; private set; } = null!;

        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        [Output("backupWindowStart")]
        public Output<Outputs.MdbClickhouseClusterBackupWindowStart> BackupWindowStart { get; private set; } = null!;

        /// <summary>
        /// Configuration of the ClickHouse subcluster. The structure is documented below.
        /// </summary>
        [Output("clickhouse")]
        public Output<Outputs.MdbClickhouseClusterClickhouse> Clickhouse { get; private set; } = null!;

        [Output("cloudStorage")]
        public Output<Outputs.MdbClickhouseClusterCloudStorage?> CloudStorage { get; private set; } = null!;

        /// <summary>
        /// Whether to copy schema on new ClickHouse hosts.
        /// </summary>
        [Output("copySchemaOnNewHosts")]
        public Output<bool?> CopySchemaOnNewHosts { get; private set; } = null!;

        /// <summary>
        /// Timestamp of cluster creation.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// A database of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        [Output("databases")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterDatabase>> Databases { get; private set; } = null!;

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Description of the shard group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
        /// </summary>
        [Output("embeddedKeeper")]
        public Output<bool> EmbeddedKeeper { get; private set; } = null!;

        /// <summary>
        /// Deployment environment of the ClickHouse cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Output("folderId")]
        public Output<string> FolderId { get; private set; } = null!;

        /// <summary>
        /// A set of protobuf or capnproto format schemas. The structure is documented below.
        /// </summary>
        [Output("formatSchemas")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterFormatSchema>> FormatSchemas { get; private set; } = null!;

        /// <summary>
        /// Aggregated health of the cluster. Can be `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
        /// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/api-ref/Cluster/).
        /// </summary>
        [Output("health")]
        public Output<string> Health { get; private set; } = null!;

        /// <summary>
        /// A host of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        [Output("hosts")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterHost>> Hosts { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the ClickHouse cluster.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        [Output("maintenanceWindow")]
        public Output<Outputs.MdbClickhouseClusterMaintenanceWindow> MaintenanceWindow { get; private set; } = null!;

        /// <summary>
        /// A group of machine learning models. The structure is documented below
        /// </summary>
        [Output("mlModels")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterMlModel>> MlModels { get; private set; } = null!;

        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the network, to which the ClickHouse cluster belongs.
        /// </summary>
        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        /// <summary>
        /// ID of the service account used for access to Yandex Object Storage.
        /// </summary>
        [Output("serviceAccountId")]
        public Output<string> ServiceAccountId { get; private set; } = null!;

        /// <summary>
        /// A group of clickhouse shards. The structure is documented below.
        /// </summary>
        [Output("shardGroups")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterShardGroup>> ShardGroups { get; private set; } = null!;

        /// <summary>
        /// Grants `admin` user database management permission.
        /// </summary>
        [Output("sqlDatabaseManagement")]
        public Output<bool> SqlDatabaseManagement { get; private set; } = null!;

        /// <summary>
        /// Enables `admin` user with user management permission.
        /// </summary>
        [Output("sqlUserManagement")]
        public Output<bool> SqlUserManagement { get; private set; } = null!;

        /// <summary>
        /// Status of the cluster. Can be `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
        /// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/api-ref/Cluster/).
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A user of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        [Output("users")]
        public Output<ImmutableArray<Outputs.MdbClickhouseClusterUser>> Users { get; private set; } = null!;

        /// <summary>
        /// Version of the ClickHouse server software.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        [Output("zookeeper")]
        public Output<Outputs.MdbClickhouseClusterZookeeper> Zookeeper { get; private set; } = null!;


        /// <summary>
        /// Create a MdbClickhouseCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbClickhouseCluster(string name, MdbClickhouseClusterArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster", name, args ?? new MdbClickhouseClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbClickhouseCluster(string name, Input<string> id, MdbClickhouseClusterState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbClickhouseCluster:MdbClickhouseCluster", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/regrau/pulumi-yandex/releases",
                AdditionalSecretOutputs =
                {
                    "adminPassword",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MdbClickhouseCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbClickhouseCluster Get(string name, Input<string> id, MdbClickhouseClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbClickhouseCluster(name, id, state, options);
        }
    }

    public sealed class MdbClickhouseClusterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access policy to the ClickHouse cluster. The structure is documented below.
        /// </summary>
        [Input("access")]
        public Input<Inputs.MdbClickhouseClusterAccessArgs>? Access { get; set; }

        [Input("adminPassword")]
        private Input<string>? _adminPassword;

        /// <summary>
        /// A password used to authorize as user `admin` when `sql_user_management` enabled.
        /// </summary>
        public Input<string>? AdminPassword
        {
            get => _adminPassword;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _adminPassword = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart")]
        public Input<Inputs.MdbClickhouseClusterBackupWindowStartArgs>? BackupWindowStart { get; set; }

        /// <summary>
        /// Configuration of the ClickHouse subcluster. The structure is documented below.
        /// </summary>
        [Input("clickhouse", required: true)]
        public Input<Inputs.MdbClickhouseClusterClickhouseArgs> Clickhouse { get; set; } = null!;

        [Input("cloudStorage")]
        public Input<Inputs.MdbClickhouseClusterCloudStorageArgs>? CloudStorage { get; set; }

        /// <summary>
        /// Whether to copy schema on new ClickHouse hosts.
        /// </summary>
        [Input("copySchemaOnNewHosts")]
        public Input<bool>? CopySchemaOnNewHosts { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbClickhouseClusterDatabaseArgs>? _databases;

        /// <summary>
        /// A database of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterDatabaseArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbClickhouseClusterDatabaseArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the shard group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
        /// </summary>
        [Input("embeddedKeeper")]
        public Input<bool>? EmbeddedKeeper { get; set; }

        /// <summary>
        /// Deployment environment of the ClickHouse cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("formatSchemas")]
        private InputList<Inputs.MdbClickhouseClusterFormatSchemaArgs>? _formatSchemas;

        /// <summary>
        /// A set of protobuf or capnproto format schemas. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterFormatSchemaArgs> FormatSchemas
        {
            get => _formatSchemas ?? (_formatSchemas = new InputList<Inputs.MdbClickhouseClusterFormatSchemaArgs>());
            set => _formatSchemas = value;
        }

        [Input("hosts", required: true)]
        private InputList<Inputs.MdbClickhouseClusterHostArgs>? _hosts;

        /// <summary>
        /// A host of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterHostArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbClickhouseClusterHostArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the ClickHouse cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("maintenanceWindow")]
        public Input<Inputs.MdbClickhouseClusterMaintenanceWindowArgs>? MaintenanceWindow { get; set; }

        [Input("mlModels")]
        private InputList<Inputs.MdbClickhouseClusterMlModelArgs>? _mlModels;

        /// <summary>
        /// A group of machine learning models. The structure is documented below
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterMlModelArgs> MlModels
        {
            get => _mlModels ?? (_mlModels = new InputList<Inputs.MdbClickhouseClusterMlModelArgs>());
            set => _mlModels = value;
        }

        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the ClickHouse cluster belongs.
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
        /// ID of the service account used for access to Yandex Object Storage.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("shardGroups")]
        private InputList<Inputs.MdbClickhouseClusterShardGroupArgs>? _shardGroups;

        /// <summary>
        /// A group of clickhouse shards. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterShardGroupArgs> ShardGroups
        {
            get => _shardGroups ?? (_shardGroups = new InputList<Inputs.MdbClickhouseClusterShardGroupArgs>());
            set => _shardGroups = value;
        }

        /// <summary>
        /// Grants `admin` user database management permission.
        /// </summary>
        [Input("sqlDatabaseManagement")]
        public Input<bool>? SqlDatabaseManagement { get; set; }

        /// <summary>
        /// Enables `admin` user with user management permission.
        /// </summary>
        [Input("sqlUserManagement")]
        public Input<bool>? SqlUserManagement { get; set; }

        [Input("users")]
        private InputList<Inputs.MdbClickhouseClusterUserArgs>? _users;

        /// <summary>
        /// A user of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterUserArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbClickhouseClusterUserArgs>());
            set => _users = value;
        }

        /// <summary>
        /// Version of the ClickHouse server software.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        /// <summary>
        /// Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        [Input("zookeeper")]
        public Input<Inputs.MdbClickhouseClusterZookeeperArgs>? Zookeeper { get; set; }

        public MdbClickhouseClusterArgs()
        {
        }
        public static new MdbClickhouseClusterArgs Empty => new MdbClickhouseClusterArgs();
    }

    public sealed class MdbClickhouseClusterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Access policy to the ClickHouse cluster. The structure is documented below.
        /// </summary>
        [Input("access")]
        public Input<Inputs.MdbClickhouseClusterAccessGetArgs>? Access { get; set; }

        [Input("adminPassword")]
        private Input<string>? _adminPassword;

        /// <summary>
        /// A password used to authorize as user `admin` when `sql_user_management` enabled.
        /// </summary>
        public Input<string>? AdminPassword
        {
            get => _adminPassword;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _adminPassword = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart")]
        public Input<Inputs.MdbClickhouseClusterBackupWindowStartGetArgs>? BackupWindowStart { get; set; }

        /// <summary>
        /// Configuration of the ClickHouse subcluster. The structure is documented below.
        /// </summary>
        [Input("clickhouse")]
        public Input<Inputs.MdbClickhouseClusterClickhouseGetArgs>? Clickhouse { get; set; }

        [Input("cloudStorage")]
        public Input<Inputs.MdbClickhouseClusterCloudStorageGetArgs>? CloudStorage { get; set; }

        /// <summary>
        /// Whether to copy schema on new ClickHouse hosts.
        /// </summary>
        [Input("copySchemaOnNewHosts")]
        public Input<bool>? CopySchemaOnNewHosts { get; set; }

        /// <summary>
        /// Timestamp of cluster creation.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbClickhouseClusterDatabaseGetArgs>? _databases;

        /// <summary>
        /// A database of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterDatabaseGetArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbClickhouseClusterDatabaseGetArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the shard group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
        /// </summary>
        [Input("embeddedKeeper")]
        public Input<bool>? EmbeddedKeeper { get; set; }

        /// <summary>
        /// Deployment environment of the ClickHouse cluster. Can be either `PRESTABLE` or `PRODUCTION`.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("formatSchemas")]
        private InputList<Inputs.MdbClickhouseClusterFormatSchemaGetArgs>? _formatSchemas;

        /// <summary>
        /// A set of protobuf or capnproto format schemas. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterFormatSchemaGetArgs> FormatSchemas
        {
            get => _formatSchemas ?? (_formatSchemas = new InputList<Inputs.MdbClickhouseClusterFormatSchemaGetArgs>());
            set => _formatSchemas = value;
        }

        /// <summary>
        /// Aggregated health of the cluster. Can be `ALIVE`, `DEGRADED`, `DEAD` or `HEALTH_UNKNOWN`.
        /// For more information see `health` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/api-ref/Cluster/).
        /// </summary>
        [Input("health")]
        public Input<string>? Health { get; set; }

        [Input("hosts")]
        private InputList<Inputs.MdbClickhouseClusterHostGetArgs>? _hosts;

        /// <summary>
        /// A host of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterHostGetArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbClickhouseClusterHostGetArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the ClickHouse cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("maintenanceWindow")]
        public Input<Inputs.MdbClickhouseClusterMaintenanceWindowGetArgs>? MaintenanceWindow { get; set; }

        [Input("mlModels")]
        private InputList<Inputs.MdbClickhouseClusterMlModelGetArgs>? _mlModels;

        /// <summary>
        /// A group of machine learning models. The structure is documented below
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterMlModelGetArgs> MlModels
        {
            get => _mlModels ?? (_mlModels = new InputList<Inputs.MdbClickhouseClusterMlModelGetArgs>());
            set => _mlModels = value;
        }

        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the ClickHouse cluster belongs.
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
        /// ID of the service account used for access to Yandex Object Storage.
        /// </summary>
        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        [Input("shardGroups")]
        private InputList<Inputs.MdbClickhouseClusterShardGroupGetArgs>? _shardGroups;

        /// <summary>
        /// A group of clickhouse shards. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterShardGroupGetArgs> ShardGroups
        {
            get => _shardGroups ?? (_shardGroups = new InputList<Inputs.MdbClickhouseClusterShardGroupGetArgs>());
            set => _shardGroups = value;
        }

        /// <summary>
        /// Grants `admin` user database management permission.
        /// </summary>
        [Input("sqlDatabaseManagement")]
        public Input<bool>? SqlDatabaseManagement { get; set; }

        /// <summary>
        /// Enables `admin` user with user management permission.
        /// </summary>
        [Input("sqlUserManagement")]
        public Input<bool>? SqlUserManagement { get; set; }

        /// <summary>
        /// Status of the cluster. Can be `CREATING`, `STARTING`, `RUNNING`, `UPDATING`, `STOPPING`, `STOPPED`, `ERROR` or `STATUS_UNKNOWN`.
        /// For more information see `status` field of JSON representation in [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/api-ref/Cluster/).
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("users")]
        private InputList<Inputs.MdbClickhouseClusterUserGetArgs>? _users;

        /// <summary>
        /// A user of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbClickhouseClusterUserGetArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbClickhouseClusterUserGetArgs>());
            set => _users = value;
        }

        /// <summary>
        /// Version of the ClickHouse server software.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        /// <summary>
        /// Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        [Input("zookeeper")]
        public Input<Inputs.MdbClickhouseClusterZookeeperGetArgs>? Zookeeper { get; set; }

        public MdbClickhouseClusterState()
        {
        }
        public static new MdbClickhouseClusterState Empty => new MdbClickhouseClusterState();
    }
}
