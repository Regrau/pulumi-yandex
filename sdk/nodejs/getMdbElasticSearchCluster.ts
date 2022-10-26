// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getMdbElasticSearchCluster(args?: GetMdbElasticSearchClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetMdbElasticSearchClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getMdbElasticSearchCluster:getMdbElasticSearchCluster", {
        "clusterId": args.clusterId,
        "deletionProtection": args.deletionProtection,
        "description": args.description,
        "folderId": args.folderId,
        "labels": args.labels,
        "name": args.name,
        "securityGroupIds": args.securityGroupIds,
        "serviceAccountId": args.serviceAccountId,
    }, opts);
}

/**
 * A collection of arguments for invoking getMdbElasticSearchCluster.
 */
export interface GetMdbElasticSearchClusterArgs {
    clusterId?: string;
    deletionProtection?: boolean;
    description?: string;
    folderId?: string;
    labels?: {[key: string]: string};
    name?: string;
    securityGroupIds?: string[];
    serviceAccountId?: string;
}

/**
 * A collection of values returned by getMdbElasticSearchCluster.
 */
export interface GetMdbElasticSearchClusterResult {
    readonly clusterId: string;
    readonly configs: outputs.GetMdbElasticSearchClusterConfig[];
    readonly createdAt: string;
    readonly deletionProtection: boolean;
    readonly description: string;
    readonly environment: string;
    readonly folderId: string;
    readonly health: string;
    readonly hosts: outputs.GetMdbElasticSearchClusterHost[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly maintenanceWindows: outputs.GetMdbElasticSearchClusterMaintenanceWindow[];
    readonly name: string;
    readonly networkId: string;
    readonly securityGroupIds: string[];
    readonly serviceAccountId: string;
    readonly status: string;
}

export function getMdbElasticSearchClusterOutput(args?: GetMdbElasticSearchClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMdbElasticSearchClusterResult> {
    return pulumi.output(args).apply(a => getMdbElasticSearchCluster(a, opts))
}

/**
 * A collection of arguments for invoking getMdbElasticSearchCluster.
 */
export interface GetMdbElasticSearchClusterOutputArgs {
    clusterId?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    serviceAccountId?: pulumi.Input<string>;
}