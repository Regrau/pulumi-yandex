// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

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
    clusterId?: string;
    deletionProtection?: boolean;
    folderId?: string;
    name?: string;
}

/**
 * A collection of values returned by getMdbRedisCluster.
 */
export interface GetMdbRedisClusterResult {
    readonly clusterId: string;
    readonly configs: outputs.GetMdbRedisClusterConfig[];
    readonly createdAt: string;
    readonly deletionProtection: boolean;
    readonly description: string;
    readonly environment: string;
    readonly folderId: string;
    readonly health: string;
    readonly hosts: outputs.GetMdbRedisClusterHost[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly maintenanceWindows: outputs.GetMdbRedisClusterMaintenanceWindow[];
    readonly name: string;
    readonly networkId: string;
    readonly persistenceMode: string;
    readonly resources: outputs.GetMdbRedisClusterResource[];
    readonly securityGroupIds: string[];
    readonly sharded: boolean;
    readonly status: string;
    readonly tlsEnabled: boolean;
}

export function getMdbRedisClusterOutput(args?: GetMdbRedisClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMdbRedisClusterResult> {
    return pulumi.output(args).apply(a => getMdbRedisCluster(a, opts))
}

/**
 * A collection of arguments for invoking getMdbRedisCluster.
 */
export interface GetMdbRedisClusterOutputArgs {
    clusterId?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}