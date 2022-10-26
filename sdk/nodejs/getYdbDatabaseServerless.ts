// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getYdbDatabaseServerless(args?: GetYdbDatabaseServerlessArgs, opts?: pulumi.InvokeOptions): Promise<GetYdbDatabaseServerlessResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getYdbDatabaseServerless:getYdbDatabaseServerless", {
        "databaseId": args.databaseId,
        "deletionProtection": args.deletionProtection,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getYdbDatabaseServerless.
 */
export interface GetYdbDatabaseServerlessArgs {
    databaseId?: string;
    deletionProtection?: boolean;
    folderId?: string;
    name?: string;
}

/**
 * A collection of values returned by getYdbDatabaseServerless.
 */
export interface GetYdbDatabaseServerlessResult {
    readonly createdAt: string;
    readonly databaseId?: string;
    readonly databasePath: string;
    readonly deletionProtection: boolean;
    readonly description: string;
    readonly documentApiEndpoint: string;
    readonly folderId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly locationId: string;
    readonly name?: string;
    readonly status: string;
    readonly tlsEnabled: boolean;
    readonly ydbApiEndpoint: string;
    readonly ydbFullEndpoint: string;
}

export function getYdbDatabaseServerlessOutput(args?: GetYdbDatabaseServerlessOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetYdbDatabaseServerlessResult> {
    return pulumi.output(args).apply(a => getYdbDatabaseServerless(a, opts))
}

/**
 * A collection of arguments for invoking getYdbDatabaseServerless.
 */
export interface GetYdbDatabaseServerlessOutputArgs {
    databaseId?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}