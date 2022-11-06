// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbClickhouseCluster
    {
        /// <summary>
        /// Get information about a Yandex Managed ClickHouse cluster. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts).
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var foo = Yandex.GetMdbClickhouseCluster.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["networkId"] = foo.Apply(getMdbClickhouseClusterResult =&gt; getMdbClickhouseClusterResult.NetworkId),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetMdbClickhouseClusterResult> InvokeAsync(GetMdbClickhouseClusterArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMdbClickhouseClusterResult>("yandex:index/getMdbClickhouseCluster:getMdbClickhouseCluster", args ?? new GetMdbClickhouseClusterArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Managed ClickHouse cluster. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts).
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using Pulumi;
        /// using Yandex = Pulumi.Yandex;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var foo = Yandex.GetMdbClickhouseCluster.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["networkId"] = foo.Apply(getMdbClickhouseClusterResult =&gt; getMdbClickhouseClusterResult.NetworkId),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetMdbClickhouseClusterResult> Invoke(GetMdbClickhouseClusterInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMdbClickhouseClusterResult>("yandex:index/getMdbClickhouseCluster:getMdbClickhouseCluster", args ?? new GetMdbClickhouseClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMdbClickhouseClusterArgs : global::Pulumi.InvokeArgs
    {
        [Input("cloudStorage")]
        public Inputs.GetMdbClickhouseClusterCloudStorageArgs? CloudStorage { get; set; }

        /// <summary>
        /// The ID of the ClickHouse cluster.
        /// </summary>
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// The name of the ClickHouse cluster.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("serviceAccountId")]
        public string? ServiceAccountId { get; set; }

        public GetMdbClickhouseClusterArgs()
        {
        }
        public static new GetMdbClickhouseClusterArgs Empty => new GetMdbClickhouseClusterArgs();
    }

    public sealed class GetMdbClickhouseClusterInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("cloudStorage")]
        public Input<Inputs.GetMdbClickhouseClusterCloudStorageInputArgs>? CloudStorage { get; set; }

        /// <summary>
        /// The ID of the ClickHouse cluster.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// The name of the ClickHouse cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("serviceAccountId")]
        public Input<string>? ServiceAccountId { get; set; }

        public GetMdbClickhouseClusterInvokeArgs()
        {
        }
        public static new GetMdbClickhouseClusterInvokeArgs Empty => new GetMdbClickhouseClusterInvokeArgs();
    }


    [OutputType]
    public sealed class GetMdbClickhouseClusterResult
    {
        /// <summary>
        /// Access policy to the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterAccessResult> Accesses;
        /// <summary>
        /// Time to start the daily backup, in the UTC timezone. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterBackupWindowStartResult> BackupWindowStarts;
        /// <summary>
        /// Configuration of the ClickHouse subcluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseResult> Clickhouses;
        public readonly Outputs.GetMdbClickhouseClusterCloudStorageResult? CloudStorage;
        public readonly string ClusterId;
        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// A database of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterDatabaseResult> Databases;
        public readonly bool DeletionProtection;
        /// <summary>
        /// Description of the shard group.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
        /// </summary>
        public readonly bool EmbeddedKeeper;
        /// <summary>
        /// Deployment environment of the ClickHouse cluster.
        /// </summary>
        public readonly string Environment;
        public readonly string FolderId;
        /// <summary>
        /// A set of protobuf or cap'n proto format schemas. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterFormatSchemaResult> FormatSchemas;
        /// <summary>
        /// Aggregated health of the cluster.
        /// </summary>
        public readonly string Health;
        /// <summary>
        /// A host of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterHostResult> Hosts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A set of key/value label pairs to assign to the ClickHouse cluster.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterMaintenanceWindowResult> MaintenanceWindows;
        /// <summary>
        /// A group of machine learning models. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterMlModelResult> MlModels;
        /// <summary>
        /// Graphite rollup configuration name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// ID of the network, to which the ClickHouse cluster belongs.
        /// </summary>
        public readonly string NetworkId;
        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly string ServiceAccountId;
        /// <summary>
        /// A group of clickhouse shards. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterShardGroupResult> ShardGroups;
        /// <summary>
        /// Grants `admin` user database management permission.
        /// </summary>
        public readonly bool SqlDatabaseManagement;
        /// <summary>
        /// Enables `admin` user with user management permission.
        /// </summary>
        public readonly bool SqlUserManagement;
        /// <summary>
        /// Status of the cluster.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// A user of the ClickHouse cluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterUserResult> Users;
        public readonly string Version;
        /// <summary>
        /// Configuration of the ZooKeeper subcluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbClickhouseClusterZookeeperResult> Zookeepers;

        [OutputConstructor]
        private GetMdbClickhouseClusterResult(
            ImmutableArray<Outputs.GetMdbClickhouseClusterAccessResult> accesses,

            ImmutableArray<Outputs.GetMdbClickhouseClusterBackupWindowStartResult> backupWindowStarts,

            ImmutableArray<Outputs.GetMdbClickhouseClusterClickhouseResult> clickhouses,

            Outputs.GetMdbClickhouseClusterCloudStorageResult? cloudStorage,

            string clusterId,

            string createdAt,

            ImmutableArray<Outputs.GetMdbClickhouseClusterDatabaseResult> databases,

            bool deletionProtection,

            string description,

            bool embeddedKeeper,

            string environment,

            string folderId,

            ImmutableArray<Outputs.GetMdbClickhouseClusterFormatSchemaResult> formatSchemas,

            string health,

            ImmutableArray<Outputs.GetMdbClickhouseClusterHostResult> hosts,

            string id,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<Outputs.GetMdbClickhouseClusterMaintenanceWindowResult> maintenanceWindows,

            ImmutableArray<Outputs.GetMdbClickhouseClusterMlModelResult> mlModels,

            string name,

            string networkId,

            ImmutableArray<string> securityGroupIds,

            string serviceAccountId,

            ImmutableArray<Outputs.GetMdbClickhouseClusterShardGroupResult> shardGroups,

            bool sqlDatabaseManagement,

            bool sqlUserManagement,

            string status,

            ImmutableArray<Outputs.GetMdbClickhouseClusterUserResult> users,

            string version,

            ImmutableArray<Outputs.GetMdbClickhouseClusterZookeeperResult> zookeepers)
        {
            Accesses = accesses;
            BackupWindowStarts = backupWindowStarts;
            Clickhouses = clickhouses;
            CloudStorage = cloudStorage;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            Databases = databases;
            DeletionProtection = deletionProtection;
            Description = description;
            EmbeddedKeeper = embeddedKeeper;
            Environment = environment;
            FolderId = folderId;
            FormatSchemas = formatSchemas;
            Health = health;
            Hosts = hosts;
            Id = id;
            Labels = labels;
            MaintenanceWindows = maintenanceWindows;
            MlModels = mlModels;
            Name = name;
            NetworkId = networkId;
            SecurityGroupIds = securityGroupIds;
            ServiceAccountId = serviceAccountId;
            ShardGroups = shardGroups;
            SqlDatabaseManagement = sqlDatabaseManagement;
            SqlUserManagement = sqlUserManagement;
            Status = status;
            Users = users;
            Version = version;
            Zookeepers = zookeepers;
        }
    }
}
