// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class IamServiceAccountApiKey extends pulumi.CustomResource {
    /**
     * Get an existing IamServiceAccountApiKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IamServiceAccountApiKeyState, opts?: pulumi.CustomResourceOptions): IamServiceAccountApiKey {
        return new IamServiceAccountApiKey(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/iamServiceAccountApiKey:IamServiceAccountApiKey';

    /**
     * Returns true if the given object is an instance of IamServiceAccountApiKey.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IamServiceAccountApiKey {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IamServiceAccountApiKey.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly encryptedSecretKey!: pulumi.Output<string>;
    public /*out*/ readonly keyFingerprint!: pulumi.Output<string>;
    public readonly pgpKey!: pulumi.Output<string | undefined>;
    public /*out*/ readonly secretKey!: pulumi.Output<string>;
    public readonly serviceAccountId!: pulumi.Output<string>;

    /**
     * Create a IamServiceAccountApiKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IamServiceAccountApiKeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IamServiceAccountApiKeyArgs | IamServiceAccountApiKeyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as IamServiceAccountApiKeyState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["encryptedSecretKey"] = state ? state.encryptedSecretKey : undefined;
            resourceInputs["keyFingerprint"] = state ? state.keyFingerprint : undefined;
            resourceInputs["pgpKey"] = state ? state.pgpKey : undefined;
            resourceInputs["secretKey"] = state ? state.secretKey : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
        } else {
            const args = argsOrState as IamServiceAccountApiKeyArgs | undefined;
            if ((!args || args.serviceAccountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceAccountId'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["pgpKey"] = args ? args.pgpKey : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["encryptedSecretKey"] = undefined /*out*/;
            resourceInputs["keyFingerprint"] = undefined /*out*/;
            resourceInputs["secretKey"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(IamServiceAccountApiKey.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IamServiceAccountApiKey resources.
 */
export interface IamServiceAccountApiKeyState {
    createdAt?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    encryptedSecretKey?: pulumi.Input<string>;
    keyFingerprint?: pulumi.Input<string>;
    pgpKey?: pulumi.Input<string>;
    secretKey?: pulumi.Input<string>;
    serviceAccountId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IamServiceAccountApiKey resource.
 */
export interface IamServiceAccountApiKeyArgs {
    description?: pulumi.Input<string>;
    pgpKey?: pulumi.Input<string>;
    serviceAccountId: pulumi.Input<string>;
}
