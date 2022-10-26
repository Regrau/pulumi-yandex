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
    /// Manages a SQLServer cluster within the Yandex.Cloud. For more information, see
    /// [the official documentation](https://cloud.yandex.com/docs/managed-sqlserver/).
    /// 
    /// Please read [Pricing for Managed Service for SQL Server](https://cloud.yandex.com/docs/managed-sqlserver/pricing#prices) before using SQLServer cluster.
    /// 
    /// ## Example Usage
    /// 
    /// Example of creating a Single Node SQLServer.
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Yandex = Pulumi.Yandex;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var fooVpcNetwork = new Yandex.VpcNetwork("fooVpcNetwork");
    /// 
    ///     var fooVpcSubnet = new Yandex.VpcSubnet("fooVpcSubnet", new()
    ///     {
    ///         Zone = "ru-central1-a",
    ///         NetworkId = fooVpcNetwork.Id,
    ///         V4CidrBlocks = new[]
    ///         {
    ///             "10.5.0.0/24",
    ///         },
    ///     });
    /// 
    ///     var test_sg_x = new Yandex.VpcSecurityGroup("test-sg-x", new()
    ///     {
    ///         NetworkId = fooVpcNetwork.Id,
    ///         Ingresses = new[]
    ///         {
    ///             new Yandex.Inputs.VpcSecurityGroupIngressArgs
    ///             {
    ///                 Protocol = "ANY",
    ///                 Description = "Allow incoming traffic from members of the same security group",
    ///                 FromPort = 0,
    ///                 ToPort = 65535,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "0.0.0.0/0",
    ///                 },
    ///             },
    ///         },
    ///         Egresses = new[]
    ///         {
    ///             new Yandex.Inputs.VpcSecurityGroupEgressArgs
    ///             {
    ///                 Protocol = "ANY",
    ///                 Description = "Allow outgoing traffic to members of the same security group",
    ///                 FromPort = 0,
    ///                 ToPort = 65535,
    ///                 V4CidrBlocks = new[]
    ///                 {
    ///                     "0.0.0.0/0",
    ///                 },
    ///             },
    ///         },
    ///     });
    /// 
    ///     var fooMdbSqlServerCluster = new Yandex.MdbSqlServerCluster("fooMdbSqlServerCluster", new()
    ///     {
    ///         Environment = "PRESTABLE",
    ///         NetworkId = fooVpcNetwork.Id,
    ///         Version = "2016sp2std",
    ///         Resources = new Yandex.Inputs.MdbSqlServerClusterResourcesArgs
    ///         {
    ///             ResourcePresetId = "s2.small",
    ///             DiskTypeId = "network-ssd",
    ///             DiskSize = 20,
    ///         },
    ///         Labels = 
    ///         {
    ///             { "test_key", "test_value" },
    ///         },
    ///         BackupWindowStart = new Yandex.Inputs.MdbSqlServerClusterBackupWindowStartArgs
    ///         {
    ///             Hours = 20,
    ///             Minutes = 30,
    ///         },
    ///         SqlserverConfig = 
    ///         {
    ///             { "fill_factor_percent", "49" },
    ///             { "optimize_for_ad_hoc_workloads", "true" },
    ///         },
    ///         Databases = new[]
    ///         {
    ///             new Yandex.Inputs.MdbSqlServerClusterDatabaseArgs
    ///             {
    ///                 Name = "db_name_a",
    ///             },
    ///             new Yandex.Inputs.MdbSqlServerClusterDatabaseArgs
    ///             {
    ///                 Name = "db_name",
    ///             },
    ///             new Yandex.Inputs.MdbSqlServerClusterDatabaseArgs
    ///             {
    ///                 Name = "db_name_b",
    ///             },
    ///         },
    ///         Users = new[]
    ///         {
    ///             new Yandex.Inputs.MdbSqlServerClusterUserArgs
    ///             {
    ///                 Name = "bob",
    ///                 Password = "mysecurepassword",
    ///             },
    ///             new Yandex.Inputs.MdbSqlServerClusterUserArgs
    ///             {
    ///                 Name = "alice",
    ///                 Password = "mysecurepassword",
    ///                 Permissions = new[]
    ///                 {
    ///                     new Yandex.Inputs.MdbSqlServerClusterUserPermissionArgs
    ///                     {
    ///                         DatabaseName = "db_name",
    ///                         Roles = new[]
    ///                         {
    ///                             "DDLADMIN",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             new Yandex.Inputs.MdbSqlServerClusterUserArgs
    ///             {
    ///                 Name = "chuck",
    ///                 Password = "mysecurepassword",
    ///                 Permissions = new[]
    ///                 {
    ///                     new Yandex.Inputs.MdbSqlServerClusterUserPermissionArgs
    ///                     {
    ///                         DatabaseName = "db_name_a",
    ///                         Roles = new[]
    ///                         {
    ///                             "OWNER",
    ///                         },
    ///                     },
    ///                     new Yandex.Inputs.MdbSqlServerClusterUserPermissionArgs
    ///                     {
    ///                         DatabaseName = "db_name",
    ///                         Roles = new[]
    ///                         {
    ///                             "OWNER",
    ///                             "DDLADMIN",
    ///                         },
    ///                     },
    ///                     new Yandex.Inputs.MdbSqlServerClusterUserPermissionArgs
    ///                     {
    ///                         DatabaseName = "db_name_b",
    ///                         Roles = new[]
    ///                         {
    ///                             "OWNER",
    ///                             "DDLADMIN",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         Hosts = new[]
    ///         {
    ///             new Yandex.Inputs.MdbSqlServerClusterHostArgs
    ///             {
    ///                 Zone = "ru-central1-a",
    ///                 SubnetId = fooVpcSubnet.Id,
    ///             },
    ///         },
    ///         SecurityGroupIds = new[]
    ///         {
    ///             test_sg_x.Id,
    ///         },
    ///         HostGroupIds = new[]
    ///         {
    ///             "host_group_1",
    ///             "host_group_2",
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// ## SQLServer config
    /// 
    /// If not specified `sqlserver_config` then does not make any changes.
    /// 
    /// * max_degree_of_parallelism - Limits the number of processors to use in parallel plan execution per task. See in-depth description in [SQL Server documentation](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/configure-the-max-degree-of-parallelism-server-configuration-option?view=sql-server-2016).
    /// 
    /// * cost_threshold_for_parallelism - Specifies the threshold at which SQL Server creates and runs parallel plans for queries. SQL Server creates and runs a parallel plan for a query only when the estimated cost to run a serial plan for the same query is higher than the value of the option. See in-depth description in [SQL Server documentation](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/configure-the-cost-threshold-for-parallelism-server-configuration-option?view=sql-server-2016).
    /// 
    /// * audit_level - Describes how to configure login auditing to monitor SQL Server Database Engine login activity. Possible values:
    ///   - 0 — do not log login attempts,˚√
    ///   - 1 — log only failed login attempts,
    ///   - 2 — log only successful login attempts (not recommended),
    ///   - 3 — log all login attempts (not recommended).
    ///      See in-depth description in [SQL Server documentation](https://docs.microsoft.com/en-us/sql/ssms/configure-login-auditing-sql-server-management-studio?view=sql-server-2016).
    /// 
    /// * fill_factor_percent - Manages the fill factor server configuration option. When an index is created or rebuilt the fill factor determines the percentage of space on each index leaf-level page to be filled with data, reserving the rest as free space for future growth. Values 0 and 100 mean full page usage (no space reserved). See in-depth description in [SQL Server documentation](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/configure-the-fill-factor-server-configuration-option?view=sql-server-2016).
    /// * optimize_for_ad_hoc_workloads - Determines whether plans should be cached only after second execution. Allows to avoid SQL cache bloat because of single-use plans. See in-depth description in [SQL Server documentation](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/optimize-for-ad-hoc-workloads-server-configuration-option?view=sql-server-2016).
    /// 
    /// ## Import
    /// 
    /// A cluster can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/mdbSqlServerCluster:MdbSqlServerCluster foo cluster_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/mdbSqlServerCluster:MdbSqlServerCluster")]
    public partial class MdbSqlServerCluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Time to start the daily backup, in the UTC. The structure is documented below.
        /// </summary>
        [Output("backupWindowStart")]
        public Output<Outputs.MdbSqlServerClusterBackupWindowStart> BackupWindowStart { get; private set; } = null!;

        /// <summary>
        /// Creation timestamp of the cluster.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// A database of the SQLServer cluster. The structure is documented below.
        /// </summary>
        [Output("databases")]
        public Output<ImmutableArray<Outputs.MdbSqlServerClusterDatabase>> Databases { get; private set; } = null!;

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Output("deletionProtection")]
        public Output<bool> DeletionProtection { get; private set; } = null!;

        /// <summary>
        /// Description of the SQLServer cluster.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Deployment environment of the SQLServer cluster. (PRODUCTION, PRESTABLE)
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
        /// Aggregated health of the cluster.
        /// </summary>
        [Output("health")]
        public Output<string> Health { get; private set; } = null!;

        /// <summary>
        /// A list of IDs of the host groups hosting VMs of the cluster.
        /// </summary>
        [Output("hostGroupIds")]
        public Output<ImmutableArray<string>> HostGroupIds { get; private set; } = null!;

        /// <summary>
        /// A host of the SQLServer cluster. The structure is documented below.
        /// </summary>
        [Output("hosts")]
        public Output<ImmutableArray<Outputs.MdbSqlServerClusterHost>> Hosts { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs to assign to the SQLServer cluster.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the network, to which the SQLServer cluster uses.
        /// </summary>
        [Output("networkId")]
        public Output<string> NetworkId { get; private set; } = null!;

        /// <summary>
        /// Resources allocated to hosts of the SQLServer cluster. The structure is documented below.
        /// </summary>
        [Output("resources")]
        public Output<Outputs.MdbSqlServerClusterResources> Resources { get; private set; } = null!;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        [Output("securityGroupIds")]
        public Output<ImmutableArray<string>> SecurityGroupIds { get; private set; } = null!;

        /// <summary>
        /// SQL Collation cluster will be created with. This attribute cannot be changed when cluster is created!
        /// </summary>
        [Output("sqlcollation")]
        public Output<string> Sqlcollation { get; private set; } = null!;

        /// <summary>
        /// SQLServer cluster config. Detail info in "SQLServer config" section (documented below).
        /// </summary>
        [Output("sqlserverConfig")]
        public Output<ImmutableDictionary<string, string>> SqlserverConfig { get; private set; } = null!;

        /// <summary>
        /// Status of the cluster.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// A user of the SQLServer cluster. The structure is documented below.
        /// </summary>
        [Output("users")]
        public Output<ImmutableArray<Outputs.MdbSqlServerClusterUser>> Users { get; private set; } = null!;

        /// <summary>
        /// Version of the SQLServer cluster. (2016sp2std, 2016sp2ent)
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a MdbSqlServerCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MdbSqlServerCluster(string name, MdbSqlServerClusterArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/mdbSqlServerCluster:MdbSqlServerCluster", name, args ?? new MdbSqlServerClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MdbSqlServerCluster(string name, Input<string> id, MdbSqlServerClusterState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/mdbSqlServerCluster:MdbSqlServerCluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MdbSqlServerCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MdbSqlServerCluster Get(string name, Input<string> id, MdbSqlServerClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new MdbSqlServerCluster(name, id, state, options);
        }
    }

    public sealed class MdbSqlServerClusterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Time to start the daily backup, in the UTC. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart")]
        public Input<Inputs.MdbSqlServerClusterBackupWindowStartArgs>? BackupWindowStart { get; set; }

        [Input("databases", required: true)]
        private InputList<Inputs.MdbSqlServerClusterDatabaseArgs>? _databases;

        /// <summary>
        /// A database of the SQLServer cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbSqlServerClusterDatabaseArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbSqlServerClusterDatabaseArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the SQLServer cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Deployment environment of the SQLServer cluster. (PRODUCTION, PRESTABLE)
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("hostGroupIds")]
        private InputList<string>? _hostGroupIds;

        /// <summary>
        /// A list of IDs of the host groups hosting VMs of the cluster.
        /// </summary>
        public InputList<string> HostGroupIds
        {
            get => _hostGroupIds ?? (_hostGroupIds = new InputList<string>());
            set => _hostGroupIds = value;
        }

        [Input("hosts", required: true)]
        private InputList<Inputs.MdbSqlServerClusterHostArgs>? _hosts;

        /// <summary>
        /// A host of the SQLServer cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbSqlServerClusterHostArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbSqlServerClusterHostArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the SQLServer cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the SQLServer cluster uses.
        /// </summary>
        [Input("networkId", required: true)]
        public Input<string> NetworkId { get; set; } = null!;

        /// <summary>
        /// Resources allocated to hosts of the SQLServer cluster. The structure is documented below.
        /// </summary>
        [Input("resources", required: true)]
        public Input<Inputs.MdbSqlServerClusterResourcesArgs> Resources { get; set; } = null!;

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
        /// SQL Collation cluster will be created with. This attribute cannot be changed when cluster is created!
        /// </summary>
        [Input("sqlcollation")]
        public Input<string>? Sqlcollation { get; set; }

        [Input("sqlserverConfig")]
        private InputMap<string>? _sqlserverConfig;

        /// <summary>
        /// SQLServer cluster config. Detail info in "SQLServer config" section (documented below).
        /// </summary>
        public InputMap<string> SqlserverConfig
        {
            get => _sqlserverConfig ?? (_sqlserverConfig = new InputMap<string>());
            set => _sqlserverConfig = value;
        }

        [Input("users", required: true)]
        private InputList<Inputs.MdbSqlServerClusterUserArgs>? _users;

        /// <summary>
        /// A user of the SQLServer cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbSqlServerClusterUserArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbSqlServerClusterUserArgs>());
            set => _users = value;
        }

        /// <summary>
        /// Version of the SQLServer cluster. (2016sp2std, 2016sp2ent)
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public MdbSqlServerClusterArgs()
        {
        }
        public static new MdbSqlServerClusterArgs Empty => new MdbSqlServerClusterArgs();
    }

    public sealed class MdbSqlServerClusterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Time to start the daily backup, in the UTC. The structure is documented below.
        /// </summary>
        [Input("backupWindowStart")]
        public Input<Inputs.MdbSqlServerClusterBackupWindowStartGetArgs>? BackupWindowStart { get; set; }

        /// <summary>
        /// Creation timestamp of the cluster.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("databases")]
        private InputList<Inputs.MdbSqlServerClusterDatabaseGetArgs>? _databases;

        /// <summary>
        /// A database of the SQLServer cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbSqlServerClusterDatabaseGetArgs> Databases
        {
            get => _databases ?? (_databases = new InputList<Inputs.MdbSqlServerClusterDatabaseGetArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// Inhibits deletion of the cluster.  Can be either `true` or `false`.
        /// </summary>
        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the SQLServer cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Deployment environment of the SQLServer cluster. (PRODUCTION, PRESTABLE)
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it
        /// is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Aggregated health of the cluster.
        /// </summary>
        [Input("health")]
        public Input<string>? Health { get; set; }

        [Input("hostGroupIds")]
        private InputList<string>? _hostGroupIds;

        /// <summary>
        /// A list of IDs of the host groups hosting VMs of the cluster.
        /// </summary>
        public InputList<string> HostGroupIds
        {
            get => _hostGroupIds ?? (_hostGroupIds = new InputList<string>());
            set => _hostGroupIds = value;
        }

        [Input("hosts")]
        private InputList<Inputs.MdbSqlServerClusterHostGetArgs>? _hosts;

        /// <summary>
        /// A host of the SQLServer cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbSqlServerClusterHostGetArgs> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<Inputs.MdbSqlServerClusterHostGetArgs>());
            set => _hosts = value;
        }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the SQLServer cluster.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the network, to which the SQLServer cluster uses.
        /// </summary>
        [Input("networkId")]
        public Input<string>? NetworkId { get; set; }

        /// <summary>
        /// Resources allocated to hosts of the SQLServer cluster. The structure is documented below.
        /// </summary>
        [Input("resources")]
        public Input<Inputs.MdbSqlServerClusterResourcesGetArgs>? Resources { get; set; }

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
        /// SQL Collation cluster will be created with. This attribute cannot be changed when cluster is created!
        /// </summary>
        [Input("sqlcollation")]
        public Input<string>? Sqlcollation { get; set; }

        [Input("sqlserverConfig")]
        private InputMap<string>? _sqlserverConfig;

        /// <summary>
        /// SQLServer cluster config. Detail info in "SQLServer config" section (documented below).
        /// </summary>
        public InputMap<string> SqlserverConfig
        {
            get => _sqlserverConfig ?? (_sqlserverConfig = new InputMap<string>());
            set => _sqlserverConfig = value;
        }

        /// <summary>
        /// Status of the cluster.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("users")]
        private InputList<Inputs.MdbSqlServerClusterUserGetArgs>? _users;

        /// <summary>
        /// A user of the SQLServer cluster. The structure is documented below.
        /// </summary>
        public InputList<Inputs.MdbSqlServerClusterUserGetArgs> Users
        {
            get => _users ?? (_users = new InputList<Inputs.MdbSqlServerClusterUserGetArgs>());
            set => _users = value;
        }

        /// <summary>
        /// Version of the SQLServer cluster. (2016sp2std, 2016sp2ent)
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public MdbSqlServerClusterState()
        {
        }
        public static new MdbSqlServerClusterState Empty => new MdbSqlServerClusterState();
    }
}
