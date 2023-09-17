// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Yandex.Inputs
{

    public sealed class KubernetesNodeGroupInstanceTemplateGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The specifications for boot disks that will be attached to the instance. The structure is documented below.
        /// </summary>
        [Input("bootDisk")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateBootDiskGetArgs>? BootDisk { get; set; }

        /// <summary>
        /// Container network configuration. The structure is documented below.
        /// </summary>
        [Input("containerNetwork")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateContainerNetworkGetArgs>? ContainerNetwork { get; set; }

        /// <summary>
        /// Container runtime configuration. The structure is documented below.
        /// </summary>
        [Input("containerRuntime")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateContainerRuntimeGetArgs>? ContainerRuntime { get; set; }

        /// <summary>
        /// GPU settings. The structure is documented below.
        /// ---
        /// </summary>
        [Input("gpuSettings")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateGpuSettingsGetArgs>? GpuSettings { get; set; }

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

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// The set of metadata `key:value` pairs assigned to this instance template. This includes custom metadata and predefined keys. **Note**: key "user-data" won't be provided into instances. It reserved for internal activity in `kubernetes_node_group` resource.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

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

        /// <summary>
        /// A public address that can be used to access the internet over NAT.
        /// </summary>
        [Input("nat")]
        public Input<bool>? Nat { get; set; }

        /// <summary>
        /// Type of network acceleration. Values: `standard`, `software_accelerated`.
        /// </summary>
        [Input("networkAccelerationType")]
        public Input<string>? NetworkAccelerationType { get; set; }

        [Input("networkInterfaces")]
        private InputList<Inputs.KubernetesNodeGroupInstanceTemplateNetworkInterfaceGetArgs>? _networkInterfaces;

        /// <summary>
        /// An array with the network interfaces that will be attached to the instance. The structure is documented below.
        /// </summary>
        public InputList<Inputs.KubernetesNodeGroupInstanceTemplateNetworkInterfaceGetArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.KubernetesNodeGroupInstanceTemplateNetworkInterfaceGetArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The placement policy configuration. The structure is documented below.
        /// </summary>
        [Input("placementPolicy")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplatePlacementPolicyGetArgs>? PlacementPolicy { get; set; }

        /// <summary>
        /// The ID of the hardware platform configuration for the node group compute instances.
        /// </summary>
        [Input("platformId")]
        public Input<string>? PlatformId { get; set; }

        [Input("resources")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateResourcesGetArgs>? Resources { get; set; }

        /// <summary>
        /// The scheduling policy for the instances in node group. The structure is documented below.
        /// </summary>
        [Input("schedulingPolicy")]
        public Input<Inputs.KubernetesNodeGroupInstanceTemplateSchedulingPolicyGetArgs>? SchedulingPolicy { get; set; }

        public KubernetesNodeGroupInstanceTemplateGetArgs()
        {
        }
        public static new KubernetesNodeGroupInstanceTemplateGetArgs Empty => new KubernetesNodeGroupInstanceTemplateGetArgs();
    }
}
