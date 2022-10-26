// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Get information about a Yandex Kubernetes Cluster.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const myCluster = pulumi.output(yandex.getKubernetesCluster({
 *     clusterId: "some_k8s_cluster_id",
 * }));
 *
 * export const clusterExternalV4Endpoint = myCluster.masters[0].externalV4Endpoint;
 * ```
 */
export function getKubernetesCluster(args?: GetKubernetesClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetKubernetesClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getKubernetesCluster:getKubernetesCluster", {
        "clusterId": args.clusterId,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getKubernetesCluster.
 */
export interface GetKubernetesClusterArgs {
    /**
     * ID of a specific Kubernetes cluster.
     */
    clusterId?: string;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: string;
    /**
     * Name of a specific Kubernetes cluster.
     */
    name?: string;
}

/**
 * A collection of values returned by getKubernetesCluster.
 */
export interface GetKubernetesClusterResult {
    readonly clusterId: string;
    /**
     * IP range for allocating pod addresses.
     */
    readonly clusterIpv4Range: string;
    /**
     * Identical to clusterIpv4Range but for the IPv6 protocol.
     */
    readonly clusterIpv6Range: string;
    /**
     * The Kubernetes cluster creation timestamp.
     */
    readonly createdAt: string;
    /**
     * A description of the Kubernetes cluster.
     */
    readonly description: string;
    readonly folderId: string;
    /**
     * Health of the Kubernetes cluster.
     */
    readonly health: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * cluster KMS provider parameters.
     */
    readonly kmsProviders: outputs.GetKubernetesClusterKmsProvider[];
    /**
     * A set of key/value label pairs to assign to the Kubernetes cluster.
     */
    readonly labels: {[key: string]: string};
    /**
     * Log group where cluster stores cluster system logs, like audit, events, or controlplane logs.
     */
    readonly logGroupId: string;
    /**
     * Kubernetes master configuration options. The structure is documented below.
     */
    readonly masters: outputs.GetKubernetesClusterMaster[];
    readonly name: string;
    /**
     * The ID of the cluster network.
     */
    readonly networkId: string;
    /**
     * (Optional) Network Implementation options. The structure is documented below.
     */
    readonly networkImplementations: outputs.GetKubernetesClusterNetworkImplementation[];
    /**
     * Network policy provider for the cluster, if present. Possible values: `CALICO`.
     */
    readonly networkPolicyProvider: string;
    /**
     * Size of the masks that are assigned to each node in the cluster.
     */
    readonly nodeIpv4CidrMaskSize: number;
    /**
     * Service account to be used by the worker nodes of the Kubernetes cluster
     * to access Container Registry or to push node logs and metrics.
     */
    readonly nodeServiceAccountId: string;
    /**
     * Cluster release channel.
     */
    readonly releaseChannel: string;
    /**
     * Service account to be used for provisioning Compute Cloud and VPC resources
     * for Kubernetes cluster. Selected service account should have `edit` role on the folder where the Kubernetes
     * cluster will be located and on the folder where selected network resides.
     */
    readonly serviceAccountId: string;
    /**
     * IP range Kubernetes services Kubernetes cluster IP addresses will be allocated from.
     */
    readonly serviceIpv4Range: string;
    /**
     * Identical to serviceIpv4Range but for the IPv6 protocol.
     */
    readonly serviceIpv6Range: string;
    /**
     * Status of the Kubernetes cluster.
     */
    readonly status: string;
}

export function getKubernetesClusterOutput(args?: GetKubernetesClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetKubernetesClusterResult> {
    return pulumi.output(args).apply(a => getKubernetesCluster(a, opts))
}

/**
 * A collection of arguments for invoking getKubernetesCluster.
 */
export interface GetKubernetesClusterOutputArgs {
    /**
     * ID of a specific Kubernetes cluster.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Name of a specific Kubernetes cluster.
     */
    name?: pulumi.Input<string>;
}
