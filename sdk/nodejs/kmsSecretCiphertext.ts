// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class KmsSecretCiphertext extends pulumi.CustomResource {
    /**
     * Get an existing KmsSecretCiphertext resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KmsSecretCiphertextState, opts?: pulumi.CustomResourceOptions): KmsSecretCiphertext {
        return new KmsSecretCiphertext(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/kmsSecretCiphertext:KmsSecretCiphertext';

    /**
     * Returns true if the given object is an instance of KmsSecretCiphertext.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KmsSecretCiphertext {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KmsSecretCiphertext.__pulumiType;
    }

    public readonly aadContext!: pulumi.Output<string | undefined>;
    public /*out*/ readonly ciphertext!: pulumi.Output<string>;
    public readonly keyId!: pulumi.Output<string>;
    public readonly plaintext!: pulumi.Output<string>;

    /**
     * Create a KmsSecretCiphertext resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KmsSecretCiphertextArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KmsSecretCiphertextArgs | KmsSecretCiphertextState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as KmsSecretCiphertextState | undefined;
            resourceInputs["aadContext"] = state ? state.aadContext : undefined;
            resourceInputs["ciphertext"] = state ? state.ciphertext : undefined;
            resourceInputs["keyId"] = state ? state.keyId : undefined;
            resourceInputs["plaintext"] = state ? state.plaintext : undefined;
        } else {
            const args = argsOrState as KmsSecretCiphertextArgs | undefined;
            if ((!args || args.keyId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'keyId'");
            }
            if ((!args || args.plaintext === undefined) && !opts.urn) {
                throw new Error("Missing required property 'plaintext'");
            }
            resourceInputs["aadContext"] = args ? args.aadContext : undefined;
            resourceInputs["keyId"] = args ? args.keyId : undefined;
            resourceInputs["plaintext"] = args ? args.plaintext : undefined;
            resourceInputs["ciphertext"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(KmsSecretCiphertext.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KmsSecretCiphertext resources.
 */
export interface KmsSecretCiphertextState {
    aadContext?: pulumi.Input<string>;
    ciphertext?: pulumi.Input<string>;
    keyId?: pulumi.Input<string>;
    plaintext?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a KmsSecretCiphertext resource.
 */
export interface KmsSecretCiphertextArgs {
    aadContext?: pulumi.Input<string>;
    keyId: pulumi.Input<string>;
    plaintext: pulumi.Input<string>;
}