// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a Yandex Managed Redis cluster. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-redis/concepts).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const foo = pulumi.output(yandex.getMdbRedisCluster({
 *     name: "test",
 * }));
 *
 * export const networkId = foo.networkId;
 * ```
 */
export function getMdbRedisCluster(args?: GetMdbRedisClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetMdbRedisClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getMdbRedisCluster:getMdbRedisCluster", {
        "clusterId": args.clusterId,
        "deletionProtection": args.deletionProtection,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getMdbRedisCluster.
 */
export interface GetMdbRedisClusterArgs {
    /**
     * The ID of the Redis cluster.
     */
    clusterId?: string;
    deletionProtection?: boolean;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: string;
    /**
     * The name of the Redis cluster.
     */
    name?: string;
}

/**
 * A collection of values returned by getMdbRedisCluster.
 */
export interface GetMdbRedisClusterResult {
    /**
     * Announce fqdn instead of ip address.
     */
    readonly announceHostnames: boolean;
    readonly clusterId: string;
    /**
     * Configuration of the Redis cluster. The structure is documented below.
     */
    readonly configs: outputs.GetMdbRedisClusterConfig[];
    /**
     * Creation timestamp of the key.
     */
    readonly createdAt: string;
    readonly deletionProtection: boolean;
    /**
     * Description of the Redis cluster.
     */
    readonly description: string;
    /**
     * Deployment environment of the Redis cluster.
     */
    readonly environment: string;
    readonly folderId: string;
    /**
     * Aggregated health of the cluster.
     */
    readonly health: string;
    /**
     * A host of the Redis cluster. The structure is documented below.
     */
    readonly hosts: outputs.GetMdbRedisClusterHost[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A set of key/value label pairs to assign to the Redis cluster.
     */
    readonly labels: {[key: string]: string};
    readonly maintenanceWindows: outputs.GetMdbRedisClusterMaintenanceWindow[];
    readonly name: string;
    /**
     * ID of the network, to which the Redis cluster belongs.
     */
    readonly networkId: string;
    /**
     * Persistence mode.
     */
    readonly persistenceMode: string;
    /**
     * Resources allocated to hosts of the Redis cluster. The structure is documented below.
     */
    readonly resources: outputs.GetMdbRedisClusterResource[];
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    readonly securityGroupIds: string[];
    /**
     * Redis Cluster mode enabled/disabled.
     */
    readonly sharded: boolean;
    /**
     * Status of the cluster.
     */
    readonly status: string;
    /**
     * TLS support mode enabled/disabled.
     */
    readonly tlsEnabled: boolean;
}

export function getMdbRedisClusterOutput(args?: GetMdbRedisClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMdbRedisClusterResult> {
    return pulumi.output(args).apply(a => getMdbRedisCluster(a, opts))
}

/**
 * A collection of arguments for invoking getMdbRedisCluster.
 */
export interface GetMdbRedisClusterOutputArgs {
    /**
     * The ID of the Redis cluster.
     */
    clusterId?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * The name of the Redis cluster.
     */
    name?: pulumi.Input<string>;
}
