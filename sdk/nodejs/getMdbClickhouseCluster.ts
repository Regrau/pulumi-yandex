// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a Yandex Managed ClickHouse cluster. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-clickhouse/concepts).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const foo = pulumi.output(yandex.getMdbClickhouseCluster({
 *     name: "test",
 * }));
 *
 * export const networkId = foo.networkId;
 * ```
 */
export function getMdbClickhouseCluster(args?: GetMdbClickhouseClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetMdbClickhouseClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getMdbClickhouseCluster:getMdbClickhouseCluster", {
        "cloudStorage": args.cloudStorage,
        "clusterId": args.clusterId,
        "deletionProtection": args.deletionProtection,
        "folderId": args.folderId,
        "name": args.name,
        "serviceAccountId": args.serviceAccountId,
        "shards": args.shards,
    }, opts);
}

/**
 * A collection of arguments for invoking getMdbClickhouseCluster.
 */
export interface GetMdbClickhouseClusterArgs {
    cloudStorage?: inputs.GetMdbClickhouseClusterCloudStorage;
    /**
     * The ID of the ClickHouse cluster.
     */
    clusterId?: string;
    deletionProtection?: boolean;
    /**
     * The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
     */
    folderId?: string;
    /**
     * The name of the ClickHouse cluster.
     */
    name?: string;
    serviceAccountId?: string;
    /**
     * A shard of the ClickHouse cluster. The structure is documented below.
     */
    shards?: inputs.GetMdbClickhouseClusterShard[];
}

/**
 * A collection of values returned by getMdbClickhouseCluster.
 */
export interface GetMdbClickhouseClusterResult {
    /**
     * Access policy to the ClickHouse cluster. The structure is documented below.
     */
    readonly accesses: outputs.GetMdbClickhouseClusterAccess[];
    /**
     * Time to start the daily backup, in the UTC timezone. The structure is documented below.
     */
    readonly backupWindowStarts: outputs.GetMdbClickhouseClusterBackupWindowStart[];
    /**
     * Configuration of the ClickHouse subcluster. The structure is documented below.
     */
    readonly clickhouses: outputs.GetMdbClickhouseClusterClickhouse[];
    readonly cloudStorage: outputs.GetMdbClickhouseClusterCloudStorage;
    readonly clusterId: string;
    /**
     * Creation timestamp of the key.
     */
    readonly createdAt: string;
    /**
     * A database of the ClickHouse cluster. The structure is documented below.
     */
    readonly databases: outputs.GetMdbClickhouseClusterDatabase[];
    readonly deletionProtection: boolean;
    /**
     * Description of the shard group.
     */
    readonly description: string;
    /**
     * Whether to use ClickHouse Keeper as a coordination system and place it on the same hosts with ClickHouse. If not, it's used ZooKeeper with placement on separate hosts.
     */
    readonly embeddedKeeper: boolean;
    /**
     * Deployment environment of the ClickHouse cluster.
     */
    readonly environment: string;
    readonly folderId: string;
    /**
     * A set of protobuf or cap'n proto format schemas. The structure is documented below.
     */
    readonly formatSchemas: outputs.GetMdbClickhouseClusterFormatSchema[];
    /**
     * Aggregated health of the cluster.
     */
    readonly health: string;
    /**
     * A host of the ClickHouse cluster. The structure is documented below.
     */
    readonly hosts: outputs.GetMdbClickhouseClusterHost[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A set of key/value label pairs to assign to the ClickHouse cluster.
     */
    readonly labels: {[key: string]: string};
    readonly maintenanceWindows: outputs.GetMdbClickhouseClusterMaintenanceWindow[];
    /**
     * A group of machine learning models. The structure is documented below.
     */
    readonly mlModels: outputs.GetMdbClickhouseClusterMlModel[];
    /**
     * Graphite rollup configuration name.
     */
    readonly name: string;
    /**
     * ID of the network, to which the ClickHouse cluster belongs.
     */
    readonly networkId: string;
    /**
     * A set of ids of security groups assigned to hosts of the cluster.
     */
    readonly securityGroupIds: string[];
    readonly serviceAccountId: string;
    /**
     * A group of clickhouse shards. The structure is documented below.
     */
    readonly shardGroups: outputs.GetMdbClickhouseClusterShardGroup[];
    /**
     * A shard of the ClickHouse cluster. The structure is documented below.
     */
    readonly shards: outputs.GetMdbClickhouseClusterShard[];
    /**
     * Grants `admin` user database management permission.
     */
    readonly sqlDatabaseManagement: boolean;
    /**
     * Enables `admin` user with user management permission.
     */
    readonly sqlUserManagement: boolean;
    /**
     * Status of the cluster.
     */
    readonly status: string;
    /**
     * A user of the ClickHouse cluster. The structure is documented below.
     */
    readonly users: outputs.GetMdbClickhouseClusterUser[];
    readonly version: string;
    /**
     * Configuration of the ZooKeeper subcluster. The structure is documented below.
     */
    readonly zookeepers: outputs.GetMdbClickhouseClusterZookeeper[];
}

export function getMdbClickhouseClusterOutput(args?: GetMdbClickhouseClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMdbClickhouseClusterResult> {
    return pulumi.output(args).apply(a => getMdbClickhouseCluster(a, opts))
}

/**
 * A collection of arguments for invoking getMdbClickhouseCluster.
 */
export interface GetMdbClickhouseClusterOutputArgs {
    cloudStorage?: pulumi.Input<inputs.GetMdbClickhouseClusterCloudStorageArgs>;
    /**
     * The ID of the ClickHouse cluster.
     */
    clusterId?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * The ID of the folder that the resource belongs to. If it is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * The name of the ClickHouse cluster.
     */
    name?: pulumi.Input<string>;
    serviceAccountId?: pulumi.Input<string>;
    /**
     * A shard of the ClickHouse cluster. The structure is documented below.
     */
    shards?: pulumi.Input<pulumi.Input<inputs.GetMdbClickhouseClusterShardArgs>[]>;
}
