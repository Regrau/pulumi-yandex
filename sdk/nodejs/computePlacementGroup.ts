// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * A Placement group resource. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/compute/concepts/placement-groups).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const group1 = new yandex.ComputePlacementGroup("group1", {
 *     description: "my description",
 *     folderId: "abc*********123",
 * });
 * ```
 */
export class ComputePlacementGroup extends pulumi.CustomResource {
    /**
     * Get an existing ComputePlacementGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ComputePlacementGroupState, opts?: pulumi.CustomResourceOptions): ComputePlacementGroup {
        return new ComputePlacementGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/computePlacementGroup:ComputePlacementGroup';

    /**
     * Returns true if the given object is an instance of ComputePlacementGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ComputePlacementGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ComputePlacementGroup.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * A description of the Placement Group.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * A set of key/value label pairs to assign to the Placement Group.
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The name of the Placement Group.
     */
    public readonly name!: pulumi.Output<string>;

    /**
     * Create a ComputePlacementGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ComputePlacementGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ComputePlacementGroupArgs | ComputePlacementGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ComputePlacementGroupState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as ComputePlacementGroupArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ComputePlacementGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ComputePlacementGroup resources.
 */
export interface ComputePlacementGroupState {
    createdAt?: pulumi.Input<string>;
    /**
     * A description of the Placement Group.
     */
    description?: pulumi.Input<string>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs to assign to the Placement Group.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the Placement Group.
     */
    name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ComputePlacementGroup resource.
 */
export interface ComputePlacementGroupArgs {
    /**
     * A description of the Placement Group.
     */
    description?: pulumi.Input<string>;
    /**
     * Folder that the resource belongs to. If value is omitted, the default provider folder is used.
     */
    folderId?: pulumi.Input<string>;
    /**
     * A set of key/value label pairs to assign to the Placement Group.
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the Placement Group.
     */
    name?: pulumi.Input<string>;
}
