// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Manages a gateway within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/vpc/concepts/gateway#gateway).
 *
 * * How-to Guides
 *     * [Cloud Networking](https://cloud.yandex.com/docs/vpc/)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const defaultvpcGateway = new yandex.vpcGateway("default", {
 *     sharedEgressGateway: {},
 * });
 * ```
 *
 * ## Import
 *
 * A gateway can be imported using the `id` of the resource, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/vpcGateway:vpcGateway default gateway_id
 * ```
 */
export class VpcGateway extends pulumi.CustomResource {
    /**
     * Get an existing VpcGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcGatewayState, opts?: pulumi.CustomResourceOptions): VpcGateway {
        return new VpcGateway(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/vpcGateway:vpcGateway';

    /**
     * Returns true if the given object is an instance of VpcGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpcGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpcGateway.__pulumiType;
    }

    /**
     * Creation timestamp of the key.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * Labels to apply to this VPC Gateway. A list of key/value pairs.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string}>;
    /**
     * Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Shared egress gateway configuration. Currently empty.
     */
    public readonly sharedEgressGateway!: pulumi.Output<outputs.VpcGatewaySharedEgressGateway | undefined>;

    /**
     * Create a VpcGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: VpcGatewayArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcGatewayArgs | VpcGatewayState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VpcGatewayState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["sharedEgressGateway"] = state ? state.sharedEgressGateway : undefined;
        } else {
            const args = argsOrState as VpcGatewayArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["sharedEgressGateway"] = args ? args.sharedEgressGateway : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VpcGateway.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering vpcGateway resources.
 */
export interface VpcGatewayState {
    /**
     * Creation timestamp of the key.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Labels to apply to this VPC Gateway. A list of key/value pairs.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
     */
    name?: pulumi.Input<string>;
    /**
     * Shared egress gateway configuration. Currently empty.
     */
    sharedEgressGateway?: pulumi.Input<inputs.VpcGatewaySharedEgressGateway>;
}

/**
 * The set of arguments for constructing a VpcGateway resource.
 */
export interface VpcGatewayArgs {
    /**
     * An optional description of this resource. Provide this property when
     * you create the resource.
     */
    description?: pulumi.Input<string>;
    /**
     * ID of the folder that the resource belongs to. If it
     * is not provided, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * Labels to apply to this VPC Gateway. A list of key/value pairs.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Name of the VPC Gateway. Provided by the client when the VPC Gateway is created.
     */
    name?: pulumi.Input<string>;
    /**
     * Shared egress gateway configuration. Currently empty.
     */
    sharedEgressGateway?: pulumi.Input<inputs.VpcGatewaySharedEgressGateway>;
}
