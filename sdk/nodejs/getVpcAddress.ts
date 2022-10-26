// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export function getVpcAddress(args?: GetVpcAddressArgs, opts?: pulumi.InvokeOptions): Promise<GetVpcAddressResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getVpcAddress:getVpcAddress", {
        "addressId": args.addressId,
        "folderId": args.folderId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getVpcAddress.
 */
export interface GetVpcAddressArgs {
    addressId?: string;
    folderId?: string;
    name?: string;
}

/**
 * A collection of values returned by getVpcAddress.
 */
export interface GetVpcAddressResult {
    readonly addressId: string;
    readonly createdAt: string;
    readonly description: string;
    readonly externalIpv4Addresses: outputs.GetVpcAddressExternalIpv4Address[];
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly labels: {[key: string]: string};
    readonly name: string;
    readonly reserved: boolean;
    readonly used: boolean;
}

export function getVpcAddressOutput(args?: GetVpcAddressOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetVpcAddressResult> {
    return pulumi.output(args).apply(a => getVpcAddress(a, opts))
}

/**
 * A collection of arguments for invoking getVpcAddress.
 */
export interface GetVpcAddressOutputArgs {
    addressId?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}
