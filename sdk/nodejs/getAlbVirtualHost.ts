// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Get information about a Yandex ALB Virtual Host. For more information, see
 * [Yandex.Cloud Application Load Balancer](https://cloud.yandex.com/en/docs/application-load-balancer/quickstart).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const my-vh-data = yandex.getAlbVirtualHost({
 *     name: yandex_alb_virtual_host["my-vh"].name,
 *     httpRouterId: yandex_alb_virtual_host["my-router"].id,
 * });
 * ```
 *
 * This data source is used to define [Application Load Balancer Virtual Host] that can be used by other resources.
 */
export function getAlbVirtualHost(args?: GetAlbVirtualHostArgs, opts?: pulumi.InvokeOptions): Promise<GetAlbVirtualHostResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("yandex:index/getAlbVirtualHost:getAlbVirtualHost", {
        "httpRouterId": args.httpRouterId,
        "name": args.name,
        "virtualHostId": args.virtualHostId,
    }, opts);
}

/**
 * A collection of arguments for invoking getAlbVirtualHost.
 */
export interface GetAlbVirtualHostArgs {
    /**
     * HTTP Router that the resource belongs to.
     */
    httpRouterId?: string;
    /**
     * Name of the Virtual Host.
     */
    name?: string;
    /**
     * The ID of a specific Virtual Host. Virtual Host ID is concatenation of HTTP Router ID
     * and Virtual Host name with `/` symbol between them. For Example, "http_router_id/vhost_name".
     */
    virtualHostId?: string;
}

/**
 * A collection of values returned by getAlbVirtualHost.
 */
export interface GetAlbVirtualHostResult {
    /**
     * A list of domains (host/authority header) that will be matched to this virtual host. Wildcard hosts are
     * supported in the form of '*.foo.com' or '*-bar.foo.com'. If not specified, all domains will be matched.
     */
    readonly authorities: string[];
    readonly httpRouterId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Apply the following modifications to the request headers. The structure is documented
     * below.
     */
    readonly modifyRequestHeaders: outputs.GetAlbVirtualHostModifyRequestHeader[];
    /**
     * Apply the following modifications to the response headers. The structure is documented
     * below.
     */
    readonly modifyResponseHeaders: outputs.GetAlbVirtualHostModifyResponseHeader[];
    /**
     * name of the route.
     */
    readonly name: string;
    readonly routeOptions: outputs.GetAlbVirtualHostRouteOption[];
    /**
     * A Route resource. Routes are matched *in-order*. Be careful when adding them to the end. For instance,
     * having http '/' match first makes all other routes unused. The structure is documented below.
     */
    readonly routes: outputs.GetAlbVirtualHostRoute[];
    readonly virtualHostId: string;
}

export function getAlbVirtualHostOutput(args?: GetAlbVirtualHostOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAlbVirtualHostResult> {
    return pulumi.output(args).apply(a => getAlbVirtualHost(a, opts))
}

/**
 * A collection of arguments for invoking getAlbVirtualHost.
 */
export interface GetAlbVirtualHostOutputArgs {
    /**
     * HTTP Router that the resource belongs to.
     */
    httpRouterId?: pulumi.Input<string>;
    /**
     * Name of the Virtual Host.
     */
    name?: pulumi.Input<string>;
    /**
     * The ID of a specific Virtual Host. Virtual Host ID is concatenation of HTTP Router ID
     * and Virtual Host name with `/` symbol between them. For Example, "http_router_id/vhost_name".
     */
    virtualHostId?: pulumi.Input<string>;
}
