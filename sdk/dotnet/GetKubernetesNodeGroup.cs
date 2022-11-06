// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex
{
    public static class GetKubernetesNodeGroup
    {
        /// <summary>
        /// Get information about a Yandex Kubernetes Node Group. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-kubernetes/concepts/#node-group).
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
        ///     var myNodeGroup = Yandex.GetKubernetesNodeGroup.Invoke(new()
        ///     {
        ///         NodeGroupId = "some_k8s_node_group_id",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["myNodeGroup.status"] = myNodeGroup.Apply(getKubernetesNodeGroupResult =&gt; getKubernetesNodeGroupResult.Status),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetKubernetesNodeGroupResult> InvokeAsync(GetKubernetesNodeGroupArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetKubernetesNodeGroupResult>("yandex:index/getKubernetesNodeGroup:getKubernetesNodeGroup", args ?? new GetKubernetesNodeGroupArgs(), options.WithDefaults());

        /// <summary>
        /// Get information about a Yandex Kubernetes Node Group. For more information, see
        /// [the official documentation](https://cloud.yandex.com/docs/managed-kubernetes/concepts/#node-group).
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
        ///     var myNodeGroup = Yandex.GetKubernetesNodeGroup.Invoke(new()
        ///     {
        ///         NodeGroupId = "some_k8s_node_group_id",
        ///     });
        /// 
        ///     return new Dictionary&lt;string, object?&gt;
        ///     {
        ///         ["myNodeGroup.status"] = myNodeGroup.Apply(getKubernetesNodeGroupResult =&gt; getKubernetesNodeGroupResult.Status),
        ///     };
        /// });
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetKubernetesNodeGroupResult> Invoke(GetKubernetesNodeGroupInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetKubernetesNodeGroupResult>("yandex:index/getKubernetesNodeGroup:getKubernetesNodeGroup", args ?? new GetKubernetesNodeGroupInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetKubernetesNodeGroupArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Name of a specific Kubernetes node group.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of a specific Kubernetes node group.
        /// </summary>
        [Input("nodeGroupId")]
        public string? NodeGroupId { get; set; }

        public GetKubernetesNodeGroupArgs()
        {
        }
        public static new GetKubernetesNodeGroupArgs Empty => new GetKubernetesNodeGroupArgs();
    }

    public sealed class GetKubernetesNodeGroupInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Folder that the resource belongs to. If value is omitted, the default provider folder is used.
        /// </summary>
        [Input("folderId")]
        public Input<string>? FolderId { get; set; }

        /// <summary>
        /// Name of a specific Kubernetes node group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of a specific Kubernetes node group.
        /// </summary>
        [Input("nodeGroupId")]
        public Input<string>? NodeGroupId { get; set; }

        public GetKubernetesNodeGroupInvokeArgs()
        {
        }
        public static new GetKubernetesNodeGroupInvokeArgs Empty => new GetKubernetesNodeGroupInvokeArgs();
    }


    [OutputType]
    public sealed class GetKubernetesNodeGroupResult
    {
        /// <summary>
        /// This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupAllocationPolicyResult> AllocationPolicies;
        /// <summary>
        /// A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
        /// </summary>
        public readonly ImmutableArray<string> AllowedUnsafeSysctls;
        /// <summary>
        /// The ID of the Kubernetes cluster that this node group belongs to.
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// The Kubernetes node group creation timestamp.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Deploy policy of the node group. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupDeployPolicyResult> DeployPolicies;
        /// <summary>
        /// A description of the Kubernetes node group.
        /// </summary>
        public readonly string Description;
        public readonly string FolderId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// ID of instance group that is used to manage this Kubernetes node group.
        /// </summary>
        public readonly string InstanceGroupId;
        /// <summary>
        /// Template used to create compute instances in this Kubernetes node group. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateResult> InstanceTemplates;
        /// <summary>
        /// Labels assigned to compute nodes (instances), created by the Node Group.
        /// ---
        /// </summary>
        public readonly ImmutableDictionary<string, string> Labels;
        /// <summary>
        /// Information about maintenance policy for this Kubernetes node group. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupMaintenancePolicyResult> MaintenancePolicies;
        /// <summary>
        /// Name template of the instance.
        /// </summary>
        public readonly string Name;
        public readonly string NodeGroupId;
        /// <summary>
        /// A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
        /// </summary>
        public readonly ImmutableDictionary<string, string> NodeLabels;
        /// <summary>
        /// A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
        /// </summary>
        public readonly ImmutableArray<string> NodeTaints;
        /// <summary>
        /// Scale policy of the node group. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupScalePolicyResult> ScalePolicies;
        /// <summary>
        /// Status of the Kubernetes node group.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Information about Kubernetes node group version. The structure is documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKubernetesNodeGroupVersionInfoResult> VersionInfos;

        [OutputConstructor]
        private GetKubernetesNodeGroupResult(
            ImmutableArray<Outputs.GetKubernetesNodeGroupAllocationPolicyResult> allocationPolicies,

            ImmutableArray<string> allowedUnsafeSysctls,

            string clusterId,

            string createdAt,

            ImmutableArray<Outputs.GetKubernetesNodeGroupDeployPolicyResult> deployPolicies,

            string description,

            string folderId,

            string id,

            string instanceGroupId,

            ImmutableArray<Outputs.GetKubernetesNodeGroupInstanceTemplateResult> instanceTemplates,

            ImmutableDictionary<string, string> labels,

            ImmutableArray<Outputs.GetKubernetesNodeGroupMaintenancePolicyResult> maintenancePolicies,

            string name,

            string nodeGroupId,

            ImmutableDictionary<string, string> nodeLabels,

            ImmutableArray<string> nodeTaints,

            ImmutableArray<Outputs.GetKubernetesNodeGroupScalePolicyResult> scalePolicies,

            string status,

            ImmutableArray<Outputs.GetKubernetesNodeGroupVersionInfoResult> versionInfos)
        {
            AllocationPolicies = allocationPolicies;
            AllowedUnsafeSysctls = allowedUnsafeSysctls;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            DeployPolicies = deployPolicies;
            Description = description;
            FolderId = folderId;
            Id = id;
            InstanceGroupId = instanceGroupId;
            InstanceTemplates = instanceTemplates;
            Labels = labels;
            MaintenancePolicies = maintenancePolicies;
            Name = name;
            NodeGroupId = nodeGroupId;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            ScalePolicies = scalePolicies;
            Status = status;
            VersionInfos = versionInfos;
        }
    }
}
