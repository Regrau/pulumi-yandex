// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## yandex\_kms\_asymmetric\_encryption\_key\_iam\_binding
 *
 * Allows creation and management of a single binding within IAM policy for
 * an existing Yandex KMS Asymmetric Encryption Key.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const your_key = new yandex.KmsAsymetricEncryptionKey("your-key", {folderId: "your-folder-id"});
 * const viewer = new yandex.KmsAsymetricEncryptionKeyIamBinding("viewer", {
 *     asymmetricEncryptionKeyId: your_key.id,
 *     role: "viewer",
 *     members: ["userAccount:foo_user_id"],
 * });
 * ```
 *
 * ## Import
 *
 * IAM binding imports use space-delimited identifiers; first the resource in question and then the role. These bindings can be imported using the `asymmetric_encryption_key_id` and role, e.g.
 *
 * ```sh
 *  $ pulumi import yandex:index/kmsAsymetricEncryptionKeyIamBinding:KmsAsymetricEncryptionKeyIamBinding viewer "asymmetric_encryption_key_id viewer"
 * ```
 */
export class KmsAsymetricEncryptionKeyIamBinding extends pulumi.CustomResource {
    /**
     * Get an existing KmsAsymetricEncryptionKeyIamBinding resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KmsAsymetricEncryptionKeyIamBindingState, opts?: pulumi.CustomResourceOptions): KmsAsymetricEncryptionKeyIamBinding {
        return new KmsAsymetricEncryptionKeyIamBinding(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/kmsAsymetricEncryptionKeyIamBinding:KmsAsymetricEncryptionKeyIamBinding';

    /**
     * Returns true if the given object is an instance of KmsAsymetricEncryptionKeyIamBinding.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KmsAsymetricEncryptionKeyIamBinding {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KmsAsymetricEncryptionKeyIamBinding.__pulumiType;
    }

    /**
     * The [Yandex Key Management Service](https://cloud.yandex.com/docs/kms/) Asymmetric Encryption Key ID to apply a binding to.
     */
    public readonly asymmetricEncryptionKeyId!: pulumi.Output<string>;
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
     */
    public readonly members!: pulumi.Output<string[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/kms/security/).
     */
    public readonly role!: pulumi.Output<string>;
    public readonly sleepAfter!: pulumi.Output<number | undefined>;

    /**
     * Create a KmsAsymetricEncryptionKeyIamBinding resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KmsAsymetricEncryptionKeyIamBindingArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KmsAsymetricEncryptionKeyIamBindingArgs | KmsAsymetricEncryptionKeyIamBindingState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KmsAsymetricEncryptionKeyIamBindingState | undefined;
            resourceInputs["asymmetricEncryptionKeyId"] = state ? state.asymmetricEncryptionKeyId : undefined;
            resourceInputs["members"] = state ? state.members : undefined;
            resourceInputs["role"] = state ? state.role : undefined;
            resourceInputs["sleepAfter"] = state ? state.sleepAfter : undefined;
        } else {
            const args = argsOrState as KmsAsymetricEncryptionKeyIamBindingArgs | undefined;
            if ((!args || args.asymmetricEncryptionKeyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'asymmetricEncryptionKeyId'");
            }
            if ((!args || args.members === undefined) && !opts.urn) {
                throw new Error("Missing required property 'members'");
            }
            if ((!args || args.role === undefined) && !opts.urn) {
                throw new Error("Missing required property 'role'");
            }
            resourceInputs["asymmetricEncryptionKeyId"] = args ? args.asymmetricEncryptionKeyId : undefined;
            resourceInputs["members"] = args ? args.members : undefined;
            resourceInputs["role"] = args ? args.role : undefined;
            resourceInputs["sleepAfter"] = args ? args.sleepAfter : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(KmsAsymetricEncryptionKeyIamBinding.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KmsAsymetricEncryptionKeyIamBinding resources.
 */
export interface KmsAsymetricEncryptionKeyIamBindingState {
    /**
     * The [Yandex Key Management Service](https://cloud.yandex.com/docs/kms/) Asymmetric Encryption Key ID to apply a binding to.
     */
    asymmetricEncryptionKeyId?: pulumi.Input<string>;
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
     */
    members?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/kms/security/).
     */
    role?: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a KmsAsymetricEncryptionKeyIamBinding resource.
 */
export interface KmsAsymetricEncryptionKeyIamBindingArgs {
    /**
     * The [Yandex Key Management Service](https://cloud.yandex.com/docs/kms/) Asymmetric Encryption Key ID to apply a binding to.
     */
    asymmetricEncryptionKeyId: pulumi.Input<string>;
    /**
     * Identities that will be granted the privilege in `role`.
     * Each entry can have one of the following values:
     * * **userAccount:{user_id}**: A unique user ID that represents a specific Yandex account.
     * * **serviceAccount:{service_account_id}**: A unique service account ID.
     * * **system:{allUsers|allAuthenticatedUsers}**: see [system groups](https://cloud.yandex.com/docs/iam/concepts/access-control/system-group)
     */
    members: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The role that should be applied. See [roles](https://cloud.yandex.com/docs/kms/security/).
     */
    role: pulumi.Input<string>;
    sleepAfter?: pulumi.Input<number>;
}
