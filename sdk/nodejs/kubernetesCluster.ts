// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Creates a Yandex Kubernetes Cluster.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const zonalClusterResourceName = new yandex.KubernetesCluster("zonal_cluster_resource_name", {
 *     description: "description",
 *     kmsProvider: {
 *         keyId: yandex_kms_symmetric_key_kms_key_resource_name.id,
 *     },
 *     labels: {
 *         my_key: "my_value",
 *         my_other_key: "my_other_value",
 *     },
 *     master: {
 *         maintenancePolicy: {
 *             autoUpgrade: true,
 *             maintenanceWindows: [{
 *                 duration: "3h",
 *                 startTime: "15:00",
 *             }],
 *         },
 *         masterLogging: {
 *             clusterAutoscalerEnabled: true,
 *             enabled: true,
 *             eventsEnabled: true,
 *             kubeApiserverEnabled: true,
 *             logGroupId: yandex_logging_group_log_group_resoruce_name.id,
 *         },
 *         publicIp: true,
 *         securityGroupIds: [yandex_vpc_security_group_security_group_name.id],
 *         version: "1.17",
 *         zonal: {
 *             subnetId: yandex_vpc_subnet_subnet_resource_name.id,
 *             zone: yandex_vpc_subnet_subnet_resource_name.zone,
 *         },
 *     },
 *     networkId: yandex_vpc_network_network_resource_name.id,
 *     networkPolicyProvider: "CALICO",
 *     nodeServiceAccountId: yandex_iam_service_account_node_service_account_resource_name.id,
 *     releaseChannel: "RAPID",
 *     serviceAccountId: yandex_iam_service_account_service_account_resource_name.id,
 * });
 * ```
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const regionalClusterResourceName = new yandex.KubernetesCluster("regional_cluster_resource_name", {
 *     description: "description",
 *     labels: {
 *         my_key: "my_value",
 *         my_other_key: "my_other_value",
 *     },
 *     master: {
 *         maintenancePolicy: {
 *             autoUpgrade: true,
 *             maintenanceWindows: [
 *                 {
 *                     day: "monday",
 *                     duration: "3h",
 *                     startTime: "15:00",
 *                 },
 *                 {
 *                     day: "friday",
 *                     duration: "4h30m",
 *                     startTime: "10:00",
 *                 },
 *             ],
 *         },
 *         masterLogging: {
 *             clusterAutoscalerEnabled: true,
 *             enabled: true,
 *             eventsEnabled: true,
 *             folderId: yandex_resourcemanager_folder_folder_resource_name.id,
 *             kubeApiserverEnabled: true,
 *         },
 *         publicIp: true,
 *         regional: {
 *             locations: [
 *                 {
 *                     subnetId: yandex_vpc_subnet_subnet_a_resource_name.id,
 *                     zone: yandex_vpc_subnet_subnet_a_resource_name.zone,
 *                 },
 *                 {
 *                     subnetId: yandex_vpc_subnet_subnet_b_resource_name.id,
 *                     zone: yandex_vpc_subnet_subnet_b_resource_name.zone,
 *                 },
 *                 {
 *                     subnetId: yandex_vpc_subnet_subnet_c_resource_name.id,
 *                     zone: yandex_vpc_subnet_subnet_c_resource_name.zone,
 *                 },
 *             ],
 *             region: "ru-central1",
 *         },
 *         version: "1.14",
 *     },
 *     networkId: yandex_vpc_network_network_resource_name.id,
 *     nodeServiceAccountId: yandex_iam_service_account_node_service_account_resource_name.id,
 *     releaseChannel: "STABLE",
 *     serviceAccountId: yandex_iam_service_account_service_account_resource_name.id,
 * });
 * ```
 *
 * ## Import
 *
 * A Managed Kubernetes cluster can be imported using the `id` of the resource, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/kubernetesCluster:KubernetesCluster default cluster_id
 * ```
 */
export class KubernetesCluster extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KubernetesClusterState, opts?: pulumi.CustomResourceOptions): KubernetesCluster {
        return new KubernetesCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/kubernetesCluster:KubernetesCluster';

    /**
     * Returns true if the given object is an instance of KubernetesCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KubernetesCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KubernetesCluster.__pulumiType;
    }

    /**
     * CIDR block. IP range for allocating pod addresses.
     * It should not overlap with any subnet in the network the Kubernetes cluster located in. Static routes will be
     * set up for this CIDR blocks in node subnets.
     */
    public readonly clusterIpv4Range!: pulumi.Output<string>;
    /**
     * Identical to clusterIpv4Range but for IPv6 protocol.
     */
    public readonly clusterIpv6Range!: pulumi.Output<string>;
    /**
     * (Computed) The Kubernetes cluster creation timestamp.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * A description of the Kubernetes cluster.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * The ID of the folder that the Kubernetes cluster belongs to.
     * If it is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * (Computed) Health of the Kubernetes cluster.
     */
    public /*out*/ readonly health!: pulumi.Output<string>;
    /**
     * cluster KMS provider parameters.
     */
    public readonly kmsProvider!: pulumi.Output<outputs.KubernetesClusterKmsProvider | undefined>;
    /**
     * A set of key/value label pairs to assign to the Kubernetes cluster.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * (Optional) ID of the Yandex Cloud Logging [Log group](https://cloud.yandex.com/docs/logging/concepts/log-group).
     */
    public /*out*/ readonly logGroupId!: pulumi.Output<string>;
    /**
     * Kubernetes master configuration options. The structure is documented below.
     */
    public readonly master!: pulumi.Output<outputs.KubernetesClusterMaster>;
    /**
     * Name of a specific Kubernetes cluster.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the cluster network.
     */
    public readonly networkId!: pulumi.Output<string>;
    /**
     * (Optional) Network Implementation options. The structure is documented below.
     */
    public readonly networkImplementation!: pulumi.Output<outputs.KubernetesClusterNetworkImplementation | undefined>;
    /**
     * Network policy provider for the cluster. Possible values: `CALICO`.
     */
    public readonly networkPolicyProvider!: pulumi.Output<string | undefined>;
    /**
     * Size of the masks that are assigned to each node in the cluster. Effectively limits maximum number of pods for each node.
     */
    public readonly nodeIpv4CidrMaskSize!: pulumi.Output<number | undefined>;
    /**
     * Service account to be used by the worker nodes of the Kubernetes cluster
     * to access Container Registry or to push node logs and metrics.
     */
    public readonly nodeServiceAccountId!: pulumi.Output<string>;
    /**
     * Cluster release channel.
     */
    public readonly releaseChannel!: pulumi.Output<string>;
    /**
     * Service account to be used for provisioning Compute Cloud and VPC resources
     * for Kubernetes cluster. Selected service account should have `edit` role on the folder where the Kubernetes
     * cluster will be located and on the folder where selected network resides.
     */
    public readonly serviceAccountId!: pulumi.Output<string>;
    /**
     * CIDR block. IP range Kubernetes service Kubernetes cluster
     * IP addresses will be allocated from. It should not overlap with any subnet in the network
     * the Kubernetes cluster located in.
     */
    public readonly serviceIpv4Range!: pulumi.Output<string>;
    /**
     * Identical to serviceIpv4Range but for IPv6 protocol.
     */
    public readonly serviceIpv6Range!: pulumi.Output<string>;
    /**
     * (Computed)Status of the Kubernetes cluster.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;

    /**
     * Create a KubernetesCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KubernetesClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KubernetesClusterArgs | KubernetesClusterState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KubernetesClusterState | undefined;
            resourceInputs["clusterIpv4Range"] = state ? state.clusterIpv4Range : undefined;
            resourceInputs["clusterIpv6Range"] = state ? state.clusterIpv6Range : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["health"] = state ? state.health : undefined;
            resourceInputs["kmsProvider"] = state ? state.kmsProvider : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["logGroupId"] = state ? state.logGroupId : undefined;
            resourceInputs["master"] = state ? state.master : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["networkId"] = state ? state.networkId : undefined;
            resourceInputs["networkImplementation"] = state ? state.networkImplementation : undefined;
            resourceInputs["networkPolicyProvider"] = state ? state.networkPolicyProvider : undefined;
            resourceInputs["nodeIpv4CidrMaskSize"] = state ? state.nodeIpv4CidrMaskSize : undefined;
            resourceInputs["nodeServiceAccountId"] = state ? state.nodeServiceAccountId : undefined;
            resourceInputs["releaseChannel"] = state ? state.releaseChannel : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            resourceInputs["serviceIpv4Range"] = state ? state.serviceIpv4Range : undefined;
            resourceInputs["serviceIpv6Range"] = state ? state.serviceIpv6Range : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as KubernetesClusterArgs | undefined;
            if ((!args || args.master === undefined) && !opts.urn) {
                throw new Error("Missing required property 'master'");
            }
            if ((!args || args.networkId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkId'");
            }
            if ((!args || args.nodeServiceAccountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'nodeServiceAccountId'");
            }
            if ((!args || args.serviceAccountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceAccountId'");
            }
            resourceInputs["clusterIpv4Range"] = args ? args.clusterIpv4Range : undefined;
            resourceInputs["clusterIpv6Range"] = args ? args.clusterIpv6Range : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["kmsProvider"] = args ? args.kmsProvider : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["master"] = args ? args.master : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["networkId"] = args ? args.networkId : undefined;
            resourceInputs["networkImplementation"] = args ? args.networkImplementation : undefined;
            resourceInputs["networkPolicyProvider"] = args ? args.networkPolicyProvider : undefined;
            resourceInputs["nodeIpv4CidrMaskSize"] = args ? args.nodeIpv4CidrMaskSize : undefined;
            resourceInputs["nodeServiceAccountId"] = args ? args.nodeServiceAccountId : undefined;
            resourceInputs["releaseChannel"] = args ? args.releaseChannel : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["serviceIpv4Range"] = args ? args.serviceIpv4Range : undefined;
            resourceInputs["serviceIpv6Range"] = args ? args.serviceIpv6Range : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["health"] = undefined /*out*/;
            resourceInputs["logGroupId"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(KubernetesCluster.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KubernetesCluster resources.
 */
export interface KubernetesClusterState {
    /**
     * CIDR block. IP range for allocating pod addresses.
     * It should not overlap with any subnet in the network the Kubernetes cluster located in. Static routes will be
     * set up for this CIDR blocks in node subnets.
     */
    clusterIpv4Range?: pulumi.Input<string>;
    /**
     * Identical to clusterIpv4Range but for IPv6 protocol.
     */
    clusterIpv6Range?: pulumi.Input<string>;
    /**
     * (Computed) The Kubernetes cluster creation timestamp.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * A description of the Kubernetes cluster.
     */
    description?: pulumi.Input<string>;
    /**
     * The ID of the folder that the Kubernetes cluster belongs to.
     * If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * (Computed) Health of the Kubernetes cluster.
     */
    health?: pulumi.Input<string>;
    /**
     * cluster KMS provider parameters.
     */
    kmsProvider?: pulumi.Input<inputs.KubernetesClusterKmsProvider>;
    /**
     * A set of key/value label pairs to assign to the Kubernetes cluster.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * (Optional) ID of the Yandex Cloud Logging [Log group](https://cloud.yandex.com/docs/logging/concepts/log-group).
     */
    logGroupId?: pulumi.Input<string>;
    /**
     * Kubernetes master configuration options. The structure is documented below.
     */
    master?: pulumi.Input<inputs.KubernetesClusterMaster>;
    /**
     * Name of a specific Kubernetes cluster.
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of the cluster network.
     */
    networkId?: pulumi.Input<string>;
    /**
     * (Optional) Network Implementation options. The structure is documented below.
     */
    networkImplementation?: pulumi.Input<inputs.KubernetesClusterNetworkImplementation>;
    /**
     * Network policy provider for the cluster. Possible values: `CALICO`.
     */
    networkPolicyProvider?: pulumi.Input<string>;
    /**
     * Size of the masks that are assigned to each node in the cluster. Effectively limits maximum number of pods for each node.
     */
    nodeIpv4CidrMaskSize?: pulumi.Input<number>;
    /**
     * Service account to be used by the worker nodes of the Kubernetes cluster
     * to access Container Registry or to push node logs and metrics.
     */
    nodeServiceAccountId?: pulumi.Input<string>;
    /**
     * Cluster release channel.
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * Service account to be used for provisioning Compute Cloud and VPC resources
     * for Kubernetes cluster. Selected service account should have `edit` role on the folder where the Kubernetes
     * cluster will be located and on the folder where selected network resides.
     */
    serviceAccountId?: pulumi.Input<string>;
    /**
     * CIDR block. IP range Kubernetes service Kubernetes cluster
     * IP addresses will be allocated from. It should not overlap with any subnet in the network
     * the Kubernetes cluster located in.
     */
    serviceIpv4Range?: pulumi.Input<string>;
    /**
     * Identical to serviceIpv4Range but for IPv6 protocol.
     */
    serviceIpv6Range?: pulumi.Input<string>;
    /**
     * (Computed)Status of the Kubernetes cluster.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a KubernetesCluster resource.
 */
export interface KubernetesClusterArgs {
    /**
     * CIDR block. IP range for allocating pod addresses.
     * It should not overlap with any subnet in the network the Kubernetes cluster located in. Static routes will be
     * set up for this CIDR blocks in node subnets.
     */
    clusterIpv4Range?: pulumi.Input<string>;
    /**
     * Identical to clusterIpv4Range but for IPv6 protocol.
     */
    clusterIpv6Range?: pulumi.Input<string>;
    /**
     * A description of the Kubernetes cluster.
     */
    description?: pulumi.Input<string>;
    /**
     * The ID of the folder that the Kubernetes cluster belongs to.
     * If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * cluster KMS provider parameters.
     */
    kmsProvider?: pulumi.Input<inputs.KubernetesClusterKmsProvider>;
    /**
     * A set of key/value label pairs to assign to the Kubernetes cluster.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Kubernetes master configuration options. The structure is documented below.
     */
    master: pulumi.Input<inputs.KubernetesClusterMaster>;
    /**
     * Name of a specific Kubernetes cluster.
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of the cluster network.
     */
    networkId: pulumi.Input<string>;
    /**
     * (Optional) Network Implementation options. The structure is documented below.
     */
    networkImplementation?: pulumi.Input<inputs.KubernetesClusterNetworkImplementation>;
    /**
     * Network policy provider for the cluster. Possible values: `CALICO`.
     */
    networkPolicyProvider?: pulumi.Input<string>;
    /**
     * Size of the masks that are assigned to each node in the cluster. Effectively limits maximum number of pods for each node.
     */
    nodeIpv4CidrMaskSize?: pulumi.Input<number>;
    /**
     * Service account to be used by the worker nodes of the Kubernetes cluster
     * to access Container Registry or to push node logs and metrics.
     */
    nodeServiceAccountId: pulumi.Input<string>;
    /**
     * Cluster release channel.
     */
    releaseChannel?: pulumi.Input<string>;
    /**
     * Service account to be used for provisioning Compute Cloud and VPC resources
     * for Kubernetes cluster. Selected service account should have `edit` role on the folder where the Kubernetes
     * cluster will be located and on the folder where selected network resides.
     */
    serviceAccountId: pulumi.Input<string>;
    /**
     * CIDR block. IP range Kubernetes service Kubernetes cluster
     * IP addresses will be allocated from. It should not overlap with any subnet in the network
     * the Kubernetes cluster located in.
     */
    serviceIpv4Range?: pulumi.Input<string>;
    /**
     * Identical to serviceIpv4Range but for IPv6 protocol.
     */
    serviceIpv6Range?: pulumi.Input<string>;
}
