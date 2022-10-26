// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbSqlserverCluster
    {
        public static Task<GetMdbSqlserverClusterResult> InvokeAsync(GetMdbSqlserverClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMdbSqlserverClusterResult>("yandex:index/getMdbSqlserverCluster:getMdbSqlserverCluster", args ?? new GetMdbSqlserverClusterArgs(), options.WithDefaults());

        public static Output<GetMdbSqlserverClusterResult> Invoke(GetMdbSqlserverClusterInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMdbSqlserverClusterResult>("yandex:index/getMdbSqlserverCluster:getMdbSqlserverCluster", args ?? new GetMdbSqlserverClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMdbSqlserverClusterArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("sqlcollation")]
        public string? Sqlcollation { get; set; }

        [Input("sqlserverConfig")]
        private Dictionary<string, string>? _sqlserverConfig;
        public Dictionary<string, string> SqlserverConfig
        {
            get => _sqlserverConfig ?? (_sqlserverConfig = new Dictionary<string, string>());
            set => _sqlserverConfig = value;
        }

        public GetMdbSqlserverClusterArgs()
        {
        }
        public static new GetMdbSqlserverClusterArgs Empty => new GetMdbSqlserverClusterArgs();
    }

    public sealed class GetMdbSqlserverClusterInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("sqlcollation")]
        public Input<string>? Sqlcollation { get; set; }

        [Input("sqlserverConfig")]
        private InputMap<string>? _sqlserverConfig;
        public InputMap<string> SqlserverConfig
        {
            get => _sqlserverConfig ?? (_sqlserverConfig = new InputMap<string>());
            set => _sqlserverConfig = value;
        }

        public GetMdbSqlserverClusterInvokeArgs()
        {
        }
        public static new GetMdbSqlserverClusterInvokeArgs Empty => new GetMdbSqlserverClusterInvokeArgs();
    }


    [OutputType]
    public sealed class GetMdbSqlserverClusterResult
    {
        public readonly ImmutableArray<Outputs.GetMdbSqlserverClusterBackupWindowStartResult> BackupWindowStarts;
        public readonly string ClusterId;
        public readonly string CreatedAt;
        public readonly ImmutableArray<Outputs.GetMdbSqlserverClusterDatabaseResult> Databases;
        public readonly bool DeletionProtection;
        public readonly string Description;
        public readonly string Environment;
        public readonly string FolderId;
        public readonly string Health;
        public readonly ImmutableArray<string> HostGroupIds;
        public readonly ImmutableArray<Outputs.GetMdbSqlserverClusterHostResult> Hosts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Name;
        public readonly string NetworkId;
        public readonly ImmutableArray<Outputs.GetMdbSqlserverClusterResourceResult> Resources;
        public readonly ImmutableArray<string> SecurityGroupIds;
        public readonly string Sqlcollation;
        public readonly ImmutableDictionary<string, string> SqlserverConfig;
        public readonly string Status;
        public readonly ImmutableArray<Outputs.GetMdbSqlserverClusterUserResult> Users;
        public readonly string Version;

        [OutputConstructor]
        private GetMdbSqlserverClusterResult(
            ImmutableArray<Outputs.GetMdbSqlserverClusterBackupWindowStartResult> backupWindowStarts,

            string clusterId,

            string createdAt,

            ImmutableArray<Outputs.GetMdbSqlserverClusterDatabaseResult> databases,

            bool deletionProtection,

            string description,

            string environment,

            string folderId,

            string health,

            ImmutableArray<string> hostGroupIds,

            ImmutableArray<Outputs.GetMdbSqlserverClusterHostResult> hosts,

            string id,

            ImmutableDictionary<string, string> labels,

            string name,

            string networkId,

            ImmutableArray<Outputs.GetMdbSqlserverClusterResourceResult> resources,

            ImmutableArray<string> securityGroupIds,

            string sqlcollation,

            ImmutableDictionary<string, string> sqlserverConfig,

            string status,

            ImmutableArray<Outputs.GetMdbSqlserverClusterUserResult> users,

            string version)
        {
            BackupWindowStarts = backupWindowStarts;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            Databases = databases;
            DeletionProtection = deletionProtection;
            Description = description;
            Environment = environment;
            FolderId = folderId;
            Health = health;
            HostGroupIds = hostGroupIds;
            Hosts = hosts;
            Id = id;
            Labels = labels;
            Name = name;
            NetworkId = networkId;
            Resources = resources;
            SecurityGroupIds = securityGroupIds;
            Sqlcollation = sqlcollation;
            SqlserverConfig = sqlserverConfig;
            Status = status;
            Users = users;
            Version = version;
        }
    }
}
