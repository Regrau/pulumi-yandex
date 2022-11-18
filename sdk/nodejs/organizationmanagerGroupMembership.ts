// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Allows members management of a single Yandex.Cloud Organization Manager Group. For more information, see [the official documentation](https://cloud.yandex.com/en-ru/docs/organization/manage-groups#add-member).
 *
 * > **Note:** Multiple `yandexOrganizationmanagerGroupIamBinding` resources with the same group id will produce inconsistent behavior!
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const group = new yandex.organizationmanagerGroupMembership("group", {
 *     groupId: "sdf4*********3fr",
 *     members: ["xdf********123"],
 * });
 * ```
 */
export class OrganizationmanagerGroupMembership extends pulumi.CustomResource {
    /**
     * Get an existing OrganizationmanagerGroupMembership resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OrganizationmanagerGroupMembershipState, opts?: pulumi.CustomResourceOptions): OrganizationmanagerGroupMembership {
        return new OrganizationmanagerGroupMembership(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/organizationmanagerGroupMembership:organizationmanagerGroupMembership';

    /**
     * Returns true if the given object is an instance of OrganizationmanagerGroupMembership.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OrganizationmanagerGroupMembership {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OrganizationmanagerGroupMembership.__pulumiType;
    }

    /**
     * The Group to add/remove members to/from.
     */
    public readonly groupId!: pulumi.Output<string>;
    /**
     * A set of members of the Group. Each member is represented by an id.
     */
    public readonly members!: pulumi.Output<string[]>;

    /**
     * Create a OrganizationmanagerGroupMembership resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OrganizationmanagerGroupMembershipArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OrganizationmanagerGroupMembershipArgs | OrganizationmanagerGroupMembershipState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OrganizationmanagerGroupMembershipState | undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
            resourceInputs["members"] = state ? state.members : undefined;
        } else {
            const args = argsOrState as OrganizationmanagerGroupMembershipArgs | undefined;
            if ((!args || args.groupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupId'");
            }
            if ((!args || args.members === undefined) && !opts.urn) {
                throw new Error("Missing required property 'members'");
            }
            resourceInputs["groupId"] = args ? args.groupId : undefined;
            resourceInputs["members"] = args ? args.members : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OrganizationmanagerGroupMembership.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering organizationmanagerGroupMembership resources.
 */
export interface OrganizationmanagerGroupMembershipState {
    /**
     * The Group to add/remove members to/from.
     */
    groupId?: pulumi.Input<string>;
    /**
     * A set of members of the Group. Each member is represented by an id.
     */
    members?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a OrganizationmanagerGroupMembership resource.
 */
export interface OrganizationmanagerGroupMembershipArgs {
    /**
     * The Group to add/remove members to/from.
     */
    groupId: pulumi.Input<string>;
    /**
     * A set of members of the Group. Each member is represented by an id.
     */
    members: pulumi.Input<pulumi.Input<string>[]>;
}