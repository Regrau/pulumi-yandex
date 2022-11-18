// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Manages a PostgreSQL user within the Yandex.Cloud. For more information, see
 * [the official documentation](https://cloud.yandex.com/docs/managed-postgresql/).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const fooVpcNetwork = new yandex.VpcNetwork("fooVpcNetwork", {});
 * const fooVpcSubnet = new yandex.VpcSubnet("fooVpcSubnet", {
 *     zone: "ru-central1-a",
 *     networkId: fooVpcNetwork.id,
 *     v4CidrBlocks: ["10.5.0.0/24"],
 * });
 * const fooMdbPostgresqlCluster = new yandex.MdbPostgresqlCluster("fooMdbPostgresqlCluster", {
 *     environment: "PRESTABLE",
 *     networkId: fooVpcNetwork.id,
 *     config: {
 *         version: "15",
 *         resources: {
 *             resourcePresetId: "s2.micro",
 *             diskTypeId: "network-ssd",
 *             diskSize: 16,
 *         },
 *     },
 *     hosts: [{
 *         zone: "ru-central1-a",
 *         subnetId: fooVpcSubnet.id,
 *     }],
 * });
 * const foomdbPostgresqlUser = new yandex.MdbPostgresqlUser("foomdbPostgresqlUser", {
 *     clusterId: fooMdbPostgresqlCluster.id,
 *     password: "password",
 *     connLimit: 50,
 *     settings: {
 *         default_transaction_isolation: "read committed",
 *         log_min_duration_statement: "5000",
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * A PostgreSQL user can be imported using the following format
 *
 * ```sh
 *  $ pulumi import yandex:index/mdbPostgresqlUser:mdbPostgresqlUser foo {{cluster_id}}:{{username}}
 * ```
 */
export class MdbPostgresqlUser extends pulumi.CustomResource {
    /**
     * Get an existing MdbPostgresqlUser resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MdbPostgresqlUserState, opts?: pulumi.CustomResourceOptions): MdbPostgresqlUser {
        return new MdbPostgresqlUser(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/mdbPostgresqlUser:mdbPostgresqlUser';

    /**
     * Returns true if the given object is an instance of MdbPostgresqlUser.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MdbPostgresqlUser {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MdbPostgresqlUser.__pulumiType;
    }

    public readonly clusterId!: pulumi.Output<string>;
    /**
     * The maximum number of connections per user. (Default 50)
     */
    public readonly connLimit!: pulumi.Output<number>;
    /**
     * List of the user's grants.
     */
    public readonly grants!: pulumi.Output<string[]>;
    /**
     * User's ability to login.
     */
    public readonly login!: pulumi.Output<boolean | undefined>;
    /**
     * The name of the user.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The password of the user.
     */
    public readonly password!: pulumi.Output<string>;
    /**
     * Set of permissions granted to the user. The structure is documented below.
     */
    public readonly permissions!: pulumi.Output<outputs.MdbPostgresqlUserPermission[]>;
    /**
     * Map of user settings. List of settings is documented below.
     */
    public readonly settings!: pulumi.Output<{[key: string]: string}>;

    /**
     * Create a MdbPostgresqlUser resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MdbPostgresqlUserArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MdbPostgresqlUserArgs | MdbPostgresqlUserState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MdbPostgresqlUserState | undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["connLimit"] = state ? state.connLimit : undefined;
            resourceInputs["grants"] = state ? state.grants : undefined;
            resourceInputs["login"] = state ? state.login : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["permissions"] = state ? state.permissions : undefined;
            resourceInputs["settings"] = state ? state.settings : undefined;
        } else {
            const args = argsOrState as MdbPostgresqlUserArgs | undefined;
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.password === undefined) && !opts.urn) {
                throw new Error("Missing required property 'password'");
            }
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["connLimit"] = args ? args.connLimit : undefined;
            resourceInputs["grants"] = args ? args.grants : undefined;
            resourceInputs["login"] = args ? args.login : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["password"] = args?.password ? pulumi.secret(args.password) : undefined;
            resourceInputs["permissions"] = args ? args.permissions : undefined;
            resourceInputs["settings"] = args ? args.settings : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["password"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(MdbPostgresqlUser.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering mdbPostgresqlUser resources.
 */
export interface MdbPostgresqlUserState {
    clusterId?: pulumi.Input<string>;
    /**
     * The maximum number of connections per user. (Default 50)
     */
    connLimit?: pulumi.Input<number>;
    /**
     * List of the user's grants.
     */
    grants?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * User's ability to login.
     */
    login?: pulumi.Input<boolean>;
    /**
     * The name of the user.
     */
    name?: pulumi.Input<string>;
    /**
     * The password of the user.
     */
    password?: pulumi.Input<string>;
    /**
     * Set of permissions granted to the user. The structure is documented below.
     */
    permissions?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlUserPermission>[]>;
    /**
     * Map of user settings. List of settings is documented below.
     */
    settings?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a MdbPostgresqlUser resource.
 */
export interface MdbPostgresqlUserArgs {
    clusterId: pulumi.Input<string>;
    /**
     * The maximum number of connections per user. (Default 50)
     */
    connLimit?: pulumi.Input<number>;
    /**
     * List of the user's grants.
     */
    grants?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * User's ability to login.
     */
    login?: pulumi.Input<boolean>;
    /**
     * The name of the user.
     */
    name?: pulumi.Input<string>;
    /**
     * The password of the user.
     */
    password: pulumi.Input<string>;
    /**
     * Set of permissions granted to the user. The structure is documented below.
     */
    permissions?: pulumi.Input<pulumi.Input<inputs.MdbPostgresqlUserPermission>[]>;
    /**
     * Map of user settings. List of settings is documented below.
     */
    settings?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
