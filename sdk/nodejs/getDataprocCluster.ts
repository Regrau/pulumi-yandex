// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getDataprocCluster(args?: GetDataprocClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetDataprocClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getDataprocCluster:getDataprocCluster", {
        "clusterId": args.clusterId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getDataprocCluster.
 */
export interface GetDataprocClusterArgs {
    clusterId?: string;
    name?: string;
}

/**
 * A collection of values returned by getDataprocCluster.
 */
export interface GetDataprocClusterResult {
    readonly bucket: string;
    readonly clusterConfigs: outputs.GetDataprocClusterClusterConfig[];
    readonly clusterId: string;
    readonly createdAt: string;
    readonly deletionProtection: boolean;
    readonly description: string;
    readonly folderId: string;
    readonly hostGroupIds: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly securityGroupIds: string[];
    readonly serviceAccountId: string;
    readonly uiProxy: boolean;
    readonly zoneId: string;
}

export function getDataprocClusterOutput(args?: GetDataprocClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDataprocClusterResult> {
    return pulumi.output(args).apply(a => getDataprocCluster(a, opts))
}

/**
 * A collection of arguments for invoking getDataprocCluster.
 */
export interface GetDataprocClusterOutputArgs {
    clusterId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}
