// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Get information about a Yandex CDN Resource. For more information, see
 * [the official documentation](https://cloud.yandex.ru/docs/cdn/concepts/resource).
 *
 * > **_NOTE:_**  CDN provider must be activated prior usage of CDN resources, either via UI console or via yc cli command: ```yc cdn provider activate --folder-id <folder-id> --type gcore```
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const myResource = pulumi.output(yandex.getCdnResource({
 *     resourceId: "some resource id",
 * }));
 *
 * export const resourceCname = myResource.cname!;
 * ```
 */
export function getCdnResource(args?: GetCdnResourceArgs, opts?: pulumi.InvokeOptions): Promise<GetCdnResourceResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getCdnResource:getCdnResource", {
        "active": args.active,
        "cname": args.cname,
        "folderId": args.folderId,
        "options": args.options,
        "originGroupId": args.originGroupId,
        "originGroupName": args.originGroupName,
        "originProtocol": args.originProtocol,
        "resourceId": args.resourceId,
        "secondaryHostnames": args.secondaryHostnames,
        "sslCertificate": args.sslCertificate,
        "updatedAt": args.updatedAt,
    }, opts);
}

/**
 * A collection of arguments for invoking getCdnResource.
 */
export interface GetCdnResourceArgs {
    /**
     * Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
     */
    active?: boolean;
    /**
     * CDN endpoint CNAME, must be unique among resources.
     */
    cname?: string;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: string;
    /**
     * CDN Resource settings and options to tune CDN edge behavior.
     */
    options?: inputs.GetCdnResourceOptions;
    originGroupId?: number;
    originGroupName?: string;
    originProtocol?: string;
    resourceId?: string;
    /**
     * list of secondary hostname strings.
     */
    secondaryHostnames?: string[];
    /**
     * SSL certificate of CDN resource.
     */
    sslCertificate?: inputs.GetCdnResourceSslCertificate;
    updatedAt?: string;
}

/**
 * A collection of values returned by getCdnResource.
 */
export interface GetCdnResourceResult {
    readonly active?: boolean;
    readonly cname: string;
    readonly createdAt: string;
    readonly folderId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly options: outputs.GetCdnResourceOptions;
    readonly originGroupId?: number;
    readonly originGroupName?: string;
    readonly originProtocol?: string;
    readonly resourceId: string;
    readonly secondaryHostnames?: string[];
    readonly sslCertificate: outputs.GetCdnResourceSslCertificate;
    readonly updatedAt: string;
}

export function getCdnResourceOutput(args?: GetCdnResourceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCdnResourceResult> {
    return pulumi.output(args).apply(a => getCdnResource(a, opts))
}

/**
 * A collection of arguments for invoking getCdnResource.
 */
export interface GetCdnResourceOutputArgs {
    /**
     * Flag to create Resource either in active or disabled state. True - the content from CDN is available to clients.
     */
    active?: pulumi.Input<boolean>;
    /**
     * CDN endpoint CNAME, must be unique among resources.
     */
    cname?: pulumi.Input<string>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * CDN Resource settings and options to tune CDN edge behavior.
     */
    options?: pulumi.Input<inputs.GetCdnResourceOptionsArgs>;
    originGroupId?: pulumi.Input<number>;
    originGroupName?: pulumi.Input<string>;
    originProtocol?: pulumi.Input<string>;
    resourceId?: pulumi.Input<string>;
    /**
     * list of secondary hostname strings.
     */
    secondaryHostnames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * SSL certificate of CDN resource.
     */
    sslCertificate?: pulumi.Input<inputs.GetCdnResourceSslCertificateArgs>;
    updatedAt?: pulumi.Input<string>;
}
