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
    /// Creates a Yandex Kubernetes Node Group.
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
    ///     var myNodeGroup = new Yandex.KubernetesNodeGroup("myNodeGroup", new()
    ///     {
    ///         AllocationPolicy = new Yandex.Inputs.KubernetesNodeGroupAllocationPolicyArgs
    ///         {
    ///             Locations = new[]
    ///             {
    ///                 new Yandex.Inputs.KubernetesNodeGroupAllocationPolicyLocationArgs
    ///                 {
    ///                     Zone = "ru-central1-a",
    ///                 },
    ///             },
    ///         },
    ///         ClusterId = yandex_kubernetes_cluster.My_cluster.Id,
    ///         Description = "description",
    ///         InstanceTemplate = new Yandex.Inputs.KubernetesNodeGroupInstanceTemplateArgs
    ///         {
    ///             BootDisk = new Yandex.Inputs.KubernetesNodeGroupInstanceTemplateBootDiskArgs
    ///             {
    ///                 Size = 64,
    ///                 Type = "network-hdd",
    ///             },
    ///             ContainerRuntime = new Yandex.Inputs.KubernetesNodeGroupInstanceTemplateContainerRuntimeArgs
    ///             {
    ///                 Type = "containerd",
    ///             },
    ///             NetworkInterfaces = new[]
    ///             {
    ///                 new Yandex.Inputs.KubernetesNodeGroupInstanceTemplateNetworkInterfaceArgs
    ///                 {
    ///                     Nat = true,
    ///                     SubnetIds = new[]
    ///                     {
    ///                         yandex_vpc_subnet.My_subnet.Id,
    ///                     },
    ///                 },
    ///             },
    ///             PlatformId = "standard-v2",
    ///             Resources = new Yandex.Inputs.KubernetesNodeGroupInstanceTemplateResourcesArgs
    ///             {
    ///                 Cores = 2,
    ///                 Memory = 2,
    ///             },
    ///             SchedulingPolicy = new Yandex.Inputs.KubernetesNodeGroupInstanceTemplateSchedulingPolicyArgs
    ///             {
    ///                 Preemptible = false,
    ///             },
    ///         },
    ///         Labels = 
    ///         {
    ///             { "key", "value" },
    ///         },
    ///         MaintenancePolicy = new Yandex.Inputs.KubernetesNodeGroupMaintenancePolicyArgs
    ///         {
    ///             AutoRepair = true,
    ///             AutoUpgrade = true,
    ///             MaintenanceWindows = new[]
    ///             {
    ///                 new Yandex.Inputs.KubernetesNodeGroupMaintenancePolicyMaintenanceWindowArgs
    ///                 {
    ///                     Day = "monday",
    ///                     Duration = "3h",
    ///                     StartTime = "15:00",
    ///                 },
    ///                 new Yandex.Inputs.KubernetesNodeGroupMaintenancePolicyMaintenanceWindowArgs
    ///                 {
    ///                     Day = "friday",
    ///                     Duration = "4h30m",
    ///                     StartTime = "10:00",
    ///                 },
    ///             },
    ///         },
    ///         ScalePolicy = new Yandex.Inputs.KubernetesNodeGroupScalePolicyArgs
    ///         {
    ///             FixedScale = new Yandex.Inputs.KubernetesNodeGroupScalePolicyFixedScaleArgs
    ///             {
    ///                 Size = 1,
    ///             },
    ///         },
    ///         Version = "1.17",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// A Yandex Kubernetes Node Group can be imported using the `id` of the resource, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import yandex:index/kubernetesNodeGroup:KubernetesNodeGroup default node_group_id
    /// ```
    /// </summary>
    [YandexResourceType("yandex:index/kubernetesNodeGroup:KubernetesNodeGroup")]
    public partial class KubernetesNodeGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
        /// </summary>
        [Output("allocationPolicy")]
        public Output<Outputs.KubernetesNodeGroupAllocationPolicy> AllocationPolicy { get; private set; } = null!;

        /// <summary>
        /// A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
        /// </summary>
        [Output("allowedUnsafeSysctls")]
        public Output<ImmutableArray<string>> AllowedUnsafeSysctls { get; private set; } = null!;

        /// <summary>
        /// The ID of the Kubernetes cluster that this node group belongs to.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// (Computed) The Kubernetes node group creation timestamp.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// Deploy policy of the node group. The structure is documented below.
        /// </summary>
        [Output("deployPolicy")]
        public Output<Outputs.KubernetesNodeGroupDeployPolicy> DeployPolicy { get; private set; } = null!;

        /// <summary>
        /// A description of the Kubernetes node group.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// ID of instance group that is used to manage this Kubernetes node group.
        /// </summary>
        [Output("instanceGroupId")]
        public Output<string> InstanceGroupId { get; private set; } = null!;

        /// <summary>
        /// Template used to create compute instances in this Kubernetes node group. The structure is documented below.
        /// </summary>
        [Output("instanceTemplate")]
        public Output<Outputs.KubernetesNodeGroupInstanceTemplate> InstanceTemplate { get; private set; } = null!;

        /// <summary>
        /// Labels that will be assigned to compute nodes (instances), created by the Node Group.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>> Labels { get; private set; } = null!;

        /// <summary>
        /// (Computed) Maintenance policy for this Kubernetes node group.
        /// If policy is omitted, automatic revision upgrades are enabled and could happen at any time.
        /// Revision upgrades are performed only within the same minor version, e.g. 1.13.
        /// Minor version upgrades (e.g. 1.13-&gt;1.14) should be performed manually. The structure is documented below.
        /// </summary>
        [Output("maintenancePolicy")]
        public Output<Outputs.KubernetesNodeGroupMaintenancePolicy> MaintenancePolicy { get; private set; } = null!;

        /// <summary>
        /// Name template of the instance.
        /// In order to be unique it must contain at least one of instance unique placeholders:
        /// {instance.short_id}
        /// {instance.index}
        /// combination of {instance.zone_id} and {instance.index_in_zone}
        /// Example: my-instance-{instance.index}
        /// If not set, default is used: {instance_group.id}-{instance.short_id}
        /// It may also contain another placeholders, see [Compute Instance group metadata doc](https://cloud.yandex.com/en-ru/docs/compute/api-ref/grpc/instance_group_service) for full list.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
        /// </summary>
        [Output("nodeLabels")]
        public Output<ImmutableDictionary<string, string>?> NodeLabels { get; private set; } = null!;

        /// <summary>
        /// A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
        /// </summary>
        [Output("nodeTaints")]
        public Output<ImmutableArray<string>> NodeTaints { get; private set; } = null!;

        /// <summary>
        /// Scale policy of the node group. The structure is documented below.
        /// </summary>
        [Output("scalePolicy")]
        public Output<Outputs.KubernetesNodeGroupScalePolicy> ScalePolicy { get; private set; } = null!;

        /// <summary>
        /// (Computed) Status of the Kubernetes node group.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Version of Kubernetes that will be used for Kubernetes node group.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// Information about Kubernetes node group version. The structure is documented below.
        /// </summary>
        [Output("versionInfos")]
        public Output<ImmutableArray<Outputs.KubernetesNodeGroupVersionInfo>> VersionInfos { get; private set; } = null!;


        /// <summary>
        /// Create a KubernetesNodeGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public KubernetesNodeGroup(string name, KubernetesNodeGroupArgs args, CustomResourceOptions? options = null)
            : base("yandex:index/kubernetesNodeGroup:KubernetesNodeGroup", name, args ?? new KubernetesNodeGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private KubernetesNodeGroup(string name, Input<string> id, KubernetesNodeGroupState? state = null, CustomResourceOptions? options = null)
            : base("yandex:index/kubernetesNodeGroup:KubernetesNodeGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing KubernetesNodeGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static KubernetesNodeGroup Get(string name, Input<string> id, KubernetesNodeGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new KubernetesNodeGroup(name, id, state, options);
        }
    }

    public sealed class KubernetesNodeGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
        /// </summary>
        [Input("allocationPolicy")]
        public Input<Inputs.KubernetesNodeGroupAllocationPolicyArgs>? AllocationPolicy { get; set; }

        [Input("allowedUnsafeSysctls")]
        private InputList<string>? _allowedUnsafeSysctls;

        /// <summary>
        /// A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
        /// </summary>
        public InputList<string> AllowedUnsafeSysctls
        {
            get => _allowedUnsafeSysctls ?? (_allowedUnsafeSysctls = new InputList<string>());
            set => _allowedUnsafeSysctls = value;
        }

        /// <summary>
        /// The ID of the Kubernetes cluster that this node group belongs to.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Deploy policy of the node group. The structure is documented below.
        /// </summary>
        [Input("deployPolicy")]
        public Input<Inputs.KubernetesNodeGroupDeployPolicyArgs>? DeployPolicy { get; set; }

        /// <summary>
        /// A description of the Kubernetes node group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Template used to create compute instances in this Kubernetes node group. The structure is documented below.
        /// </summary>
        [Input("instanceTemplate", required: true)]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateArgs> InstanceTemplate { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels that will be assigned to compute nodes (instances), created by the Node Group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// (Computed) Maintenance policy for this Kubernetes node group.
        /// If policy is omitted, automatic revision upgrades are enabled and could happen at any time.
        /// Revision upgrades are performed only within the same minor version, e.g. 1.13.
        /// Minor version upgrades (e.g. 1.13-&gt;1.14) should be performed manually. The structure is documented below.
        /// </summary>
        [Input("maintenancePolicy")]
        public Input<Inputs.KubernetesNodeGroupMaintenancePolicyArgs>? MaintenancePolicy { get; set; }

        /// <summary>
        /// Name template of the instance.
        /// In order to be unique it must contain at least one of instance unique placeholders:
        /// {instance.short_id}
        /// {instance.index}
        /// combination of {instance.zone_id} and {instance.index_in_zone}
        /// Example: my-instance-{instance.index}
        /// If not set, default is used: {instance_group.id}-{instance.short_id}
        /// It may also contain another placeholders, see [Compute Instance group metadata doc](https://cloud.yandex.com/en-ru/docs/compute/api-ref/grpc/instance_group_service) for full list.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nodeLabels")]
        private InputMap<string>? _nodeLabels;

        /// <summary>
        /// A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
        /// </summary>
        public InputMap<string> NodeLabels
        {
            get => _nodeLabels ?? (_nodeLabels = new InputMap<string>());
            set => _nodeLabels = value;
        }

        [Input("nodeTaints")]
        private InputList<string>? _nodeTaints;

        /// <summary>
        /// A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
        /// </summary>
        public InputList<string> NodeTaints
        {
            get => _nodeTaints ?? (_nodeTaints = new InputList<string>());
            set => _nodeTaints = value;
        }

        /// <summary>
        /// Scale policy of the node group. The structure is documented below.
        /// </summary>
        [Input("scalePolicy", required: true)]
        public Input<Inputs.KubernetesNodeGroupScalePolicyArgs> ScalePolicy { get; set; } = null!;

        /// <summary>
        /// Version of Kubernetes that will be used for Kubernetes node group.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public KubernetesNodeGroupArgs()
        {
        }
        public static new KubernetesNodeGroupArgs Empty => new KubernetesNodeGroupArgs();
    }

    public sealed class KubernetesNodeGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This argument specify subnets (zones), that will be used by node group compute instances. The structure is documented below.
        /// </summary>
        [Input("allocationPolicy")]
        public Input<Inputs.KubernetesNodeGroupAllocationPolicyGetArgs>? AllocationPolicy { get; set; }

        [Input("allowedUnsafeSysctls")]
        private InputList<string>? _allowedUnsafeSysctls;

        /// <summary>
        /// A list of allowed unsafe sysctl parameters for this node group. For more details see [documentation](https://kubernetes.io/docs/tasks/administer-cluster/sysctl-cluster/).
        /// </summary>
        public InputList<string> AllowedUnsafeSysctls
        {
            get => _allowedUnsafeSysctls ?? (_allowedUnsafeSysctls = new InputList<string>());
            set => _allowedUnsafeSysctls = value;
        }

        /// <summary>
        /// The ID of the Kubernetes cluster that this node group belongs to.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// (Computed) The Kubernetes node group creation timestamp.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// Deploy policy of the node group. The structure is documented below.
        /// </summary>
        [Input("deployPolicy")]
        public Input<Inputs.KubernetesNodeGroupDeployPolicyGetArgs>? DeployPolicy { get; set; }

        /// <summary>
        /// A description of the Kubernetes node group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of instance group that is used to manage this Kubernetes node group.
        /// </summary>
        [Input("instanceGroupId")]
        public Input<string>? InstanceGroupId { get; set; }

        /// <summary>
        /// Template used to create compute instances in this Kubernetes node group. The structure is documented below.
        /// </summary>
        [Input("instanceTemplate")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateGetArgs>? InstanceTemplate { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Labels that will be assigned to compute nodes (instances), created by the Node Group.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// (Computed) Maintenance policy for this Kubernetes node group.
        /// If policy is omitted, automatic revision upgrades are enabled and could happen at any time.
        /// Revision upgrades are performed only within the same minor version, e.g. 1.13.
        /// Minor version upgrades (e.g. 1.13-&gt;1.14) should be performed manually. The structure is documented below.
        /// </summary>
        [Input("maintenancePolicy")]
        public Input<Inputs.KubernetesNodeGroupMaintenancePolicyGetArgs>? MaintenancePolicy { get; set; }

        /// <summary>
        /// Name template of the instance.
        /// In order to be unique it must contain at least one of instance unique placeholders:
        /// {instance.short_id}
        /// {instance.index}
        /// combination of {instance.zone_id} and {instance.index_in_zone}
        /// Example: my-instance-{instance.index}
        /// If not set, default is used: {instance_group.id}-{instance.short_id}
        /// It may also contain another placeholders, see [Compute Instance group metadata doc](https://cloud.yandex.com/en-ru/docs/compute/api-ref/grpc/instance_group_service) for full list.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("nodeLabels")]
        private InputMap<string>? _nodeLabels;

        /// <summary>
        /// A set of key/value label pairs, that are assigned to all the nodes of this Kubernetes node group.
        /// </summary>
        public InputMap<string> NodeLabels
        {
            get => _nodeLabels ?? (_nodeLabels = new InputMap<string>());
            set => _nodeLabels = value;
        }

        [Input("nodeTaints")]
        private InputList<string>? _nodeTaints;

        /// <summary>
        /// A list of Kubernetes taints, that are applied to all the nodes of this Kubernetes node group.
        /// </summary>
        public InputList<string> NodeTaints
        {
            get => _nodeTaints ?? (_nodeTaints = new InputList<string>());
            set => _nodeTaints = value;
        }

        /// <summary>
        /// Scale policy of the node group. The structure is documented below.
        /// </summary>
        [Input("scalePolicy")]
        public Input<Inputs.KubernetesNodeGroupScalePolicyGetArgs>? ScalePolicy { get; set; }

        /// <summary>
        /// (Computed) Status of the Kubernetes node group.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Version of Kubernetes that will be used for Kubernetes node group.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        [Input("versionInfos")]
        private InputList<Inputs.KubernetesNodeGroupVersionInfoGetArgs>? _versionInfos;

        /// <summary>
        /// Information about Kubernetes node group version. The structure is documented below.
        /// </summary>
        public InputList<Inputs.KubernetesNodeGroupVersionInfoGetArgs> VersionInfos
        {
            get => _versionInfos ?? (_versionInfos = new InputList<Inputs.KubernetesNodeGroupVersionInfoGetArgs>());
            set => _versionInfos = value;
        }

        public KubernetesNodeGroupState()
        {
        }
        public static new KubernetesNodeGroupState Empty => new KubernetesNodeGroupState();
    }
}
