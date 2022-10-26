// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export function getIotCoreRegistry(args?: GetIotCoreRegistryArgs, opts?: pulumi.InvokeOptions): Promise<GetIotCoreRegistryResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getIotCoreRegistry:getIotCoreRegistry", {
        "folderId": args.folderId,
        "name": args.name,
        "registryId": args.registryId,
    }, opts);
}

/**
 * A collection of arguments for invoking getIotCoreRegistry.
 */
export interface GetIotCoreRegistryArgs {
    folderId?: string;
    name?: string;
    registryId?: string;
}

/**
 * A collection of values returned by getIotCoreRegistry.
 */
export interface GetIotCoreRegistryResult {
    readonly certificates: string[];
    readonly createdAt: string;
    readonly description: string;
    readonly folderId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name?: string;
    readonly passwords: string[];
    readonly registryId?: string;
}

export function getIotCoreRegistryOutput(args?: GetIotCoreRegistryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIotCoreRegistryResult> {
    return pulumi.output(args).apply(a => getIotCoreRegistry(a, opts))
}

/**
 * A collection of arguments for invoking getIotCoreRegistry.
 */
export interface GetIotCoreRegistryOutputArgs {
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    registryId?: pulumi.Input<string>;
}
