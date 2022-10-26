// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetMdbElasticSearchCluster
    {
        /// <summary>
        /// Get information about a Yandex Managed Elasticsearch cluster. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/concepts).
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
        ///     var foo = Yandex.GetMdbElasticSearchCluster.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["networkId"] = foo.Apply(getMdbElasticSearchClusterResult =&gt; getMdbElasticSearchClusterResult.NetworkId),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetMdbElasticSearchClusterResult> InvokeAsync(GetMdbElasticSearchClusterArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMdbElasticSearchClusterResult>("yandex:index/getMdbElasticSearchCluster:getMdbElasticSearchCluster", args ?? new GetMdbElasticSearchClusterArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Managed Elasticsearch cluster. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-elasticsearch/concepts).
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
        ///     var foo = Yandex.GetMdbElasticSearchCluster.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["networkId"] = foo.Apply(getMdbElasticSearchClusterResult =&gt; getMdbElasticSearchClusterResult.NetworkId),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetMdbElasticSearchClusterResult> Invoke(GetMdbElasticSearchClusterInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetMdbElasticSearchClusterResult>("yandex:index/getMdbElasticSearchCluster:getMdbElasticSearchCluster", args ?? new GetMdbElasticSearchClusterInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMdbElasticSearchClusterArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the Elasticsearch cluster.
        /// </summary>
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("deletionProtection")]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the Elasticsearch cluster.
        /// </summary>
        [Input("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        [Input("labels")]
        private Dictionary<string, string>? _labels;

        /// <summary>
        /// A set of key/value label pairs to assign to the Elasticsearch cluster.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get => _labels ?? (_labels = new Dictionary<string, string>());
            set => _labels = value;
        }

        /// <summary>
        /// The name of the Elasticsearch cluster.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        [Input("securityGroupIds")]
        private List<string>? _securityGroupIds;

        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new List<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// ID of the service account authorized for this cluster.
        /// </summary>
        [Input("serviceAccountId")]
        public string? ServiceAccountId { get; set; }

        public GetMdbElasticSearchClusterArgs()
        {
        }
        public static new GetMdbElasticSearchClusterArgs Empty => new GetMdbElasticSearchClusterArgs();
    }

    public sealed class GetMdbElasticSearchClusterInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the Elasticsearch cluster.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("deletionProtection")]
        public Input<bool>? DeletionProtection { get; set; }

        /// <summary>
        /// Description of the Elasticsearch cluster.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

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

        /// <summary>
        /// The name of the Elasticsearch cluster.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

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

        public GetMdbElasticSearchClusterInvokeArgs()
        {
        }
        public static new GetMdbElasticSearchClusterInvokeArgs Empty => new GetMdbElasticSearchClusterInvokeArgs();
    }


    [OutputType]
    public sealed class GetMdbElasticSearchClusterResult
    {
        public readonly string ClusterId;
        /// <summary>
        /// Configuration of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbElasticSearchClusterConfigResult> Configs;
        /// <summary>
        /// Creation timestamp of the key.
        /// </summary>
        public readonly string CreatedAt;
        public readonly bool DeletionProtection;
        /// <summary>
        /// Description of the Elasticsearch cluster.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Deployment environment of the Elasticsearch cluster.
        /// </summary>
        public readonly string Environment;
        public readonly string FolderId;
        /// <summary>
        /// Aggregated health of the cluster.
        /// </summary>
        public readonly string Health;
        /// <summary>
        /// A host of the Elasticsearch cluster. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMdbElasticSearchClusterHostResult> Hosts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A set of key/value label pairs to assign to the Elasticsearch cluster.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly ImmutableArray<Outputs.GetMdbElasticSearchClusterMaintenanceWindowResult> MaintenanceWindows;
        public readonly string Name;
        /// <summary>
        /// ID of the network, to which the Elasticsearch cluster belongs.
        /// </summary>
        public readonly string NetworkId;
        /// <summary>
        /// A set of ids of security groups assigned to hosts of the cluster.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupIds;
        /// <summary>
        /// ID of the service account authorized for this cluster.
        /// </summary>
        public readonly string ServiceAccountId;
        /// <summary>
        /// Status of the cluster.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetMdbElasticSearchClusterResult(
            string clusterId,

            ImmutableArray<Outputs.GetMdbElasticSearchClusterConfigResult> configs,

            string createdAt,

            bool deletionProtection,

            string description,

            string environment,

            string folderId,

            string health,

            ImmutableArray<Outputs.GetMdbElasticSearchClusterHostResult> hosts,

            string id,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<Outputs.GetMdbElasticSearchClusterMaintenanceWindowResult> maintenanceWindows,

            string name,

            string networkId,

            ImmutableArray<string> securityGroupIds,

            string serviceAccountId,

            string status)
        {
            ClusterId = clusterId;
            Configs = configs;
            CreatedAt = createdAt;
            DeletionProtection = deletionProtection;
            Description = description;
            Environment = environment;
            FolderId = folderId;
            Health = health;
            Hosts = hosts;
            Id = id;
            Labels = labels;
            MaintenanceWindows = maintenanceWindows;
            Name = name;
            NetworkId = networkId;
            SecurityGroupIds = securityGroupIds;
            ServiceAccountId = serviceAccountId;
            Status = status;
        }
    }
}
