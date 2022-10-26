// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class Function extends pulumi.CustomResource {
    /**
     * Get an existing Function resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FunctionState, opts?: pulumi.CustomResourceOptions): Function {
        return new Function(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/function:Function';

    /**
     * Returns true if the given object is an instance of Function.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Function {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Function.__pulumiType;
    }

    public readonly content!: pulumi.Output<outputs.FunctionContent | undefined>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly entrypoint!: pulumi.Output<string>;
    public readonly environment!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly executionTimeout!: pulumi.Output<string | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public /*out*/ readonly imageSize!: pulumi.Output<number>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public /*out*/ readonly loggroupId!: pulumi.Output<string>;
    public readonly memory!: pulumi.Output<number>;
    public readonly name!: pulumi.Output<string>;
    public readonly package!: pulumi.Output<outputs.FunctionPackage | undefined>;
    public readonly runtime!: pulumi.Output<string>;
    public readonly secrets!: pulumi.Output<outputs.FunctionSecret[]>;
    public readonly serviceAccountId!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<string[]>;
    public readonly userHash!: pulumi.Output<string>;
    public /*out*/ readonly version!: pulumi.Output<string>;

    /**
     * Create a Function resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FunctionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FunctionArgs | FunctionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FunctionState | undefined;
            resourceInputs["content"] = state ? state.content : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["entrypoint"] = state ? state.entrypoint : undefined;
            resourceInputs["environment"] = state ? state.environment : undefined;
            resourceInputs["executionTimeout"] = state ? state.executionTimeout : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["imageSize"] = state ? state.imageSize : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["loggroupId"] = state ? state.loggroupId : undefined;
            resourceInputs["memory"] = state ? state.memory : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["package"] = state ? state.package : undefined;
            resourceInputs["runtime"] = state ? state.runtime : undefined;
            resourceInputs["secrets"] = state ? state.secrets : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["userHash"] = state ? state.userHash : undefined;
            resourceInputs["version"] = state ? state.version : undefined;
        } else {
            const args = argsOrState as FunctionArgs | undefined;
            if ((!args || args.entrypoint === undefined) && !opts.urn) {
                throw new Error("Missing required property 'entrypoint'");
            }
            if ((!args || args.memory === undefined) && !opts.urn) {
                throw new Error("Missing required property 'memory'");
            }
            if ((!args || args.runtime === undefined) && !opts.urn) {
                throw new Error("Missing required property 'runtime'");
            }
            if ((!args || args.userHash === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userHash'");
            }
            resourceInputs["content"] = args ? args.content : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["entrypoint"] = args ? args.entrypoint : undefined;
            resourceInputs["environment"] = args ? args.environment : undefined;
            resourceInputs["executionTimeout"] = args ? args.executionTimeout : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["memory"] = args ? args.memory : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["package"] = args ? args.package : undefined;
            resourceInputs["runtime"] = args ? args.runtime : undefined;
            resourceInputs["secrets"] = args ? args.secrets : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["userHash"] = args ? args.userHash : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["imageSize"] = undefined /*out*/;
            resourceInputs["loggroupId"] = undefined /*out*/;
            resourceInputs["version"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Function.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Function resources.
 */
export interface FunctionState {
    content?: pulumi.Input<inputs.FunctionContent>;
    createdAt?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    entrypoint?: pulumi.Input<string>;
    environment?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    executionTimeout?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    imageSize?: pulumi.Input<number>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    loggroupId?: pulumi.Input<string>;
    memory?: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    package?: pulumi.Input<inputs.FunctionPackage>;
    runtime?: pulumi.Input<string>;
    secrets?: pulumi.Input<pulumi.Input<inputs.FunctionSecret>[]>;
    serviceAccountId?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    userHash?: pulumi.Input<string>;
    version?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Function resource.
 */
export interface FunctionArgs {
    content?: pulumi.Input<inputs.FunctionContent>;
    description?: pulumi.Input<string>;
    entrypoint: pulumi.Input<string>;
    environment?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    executionTimeout?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    memory: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    package?: pulumi.Input<inputs.FunctionPackage>;
    runtime: pulumi.Input<string>;
    secrets?: pulumi.Input<pulumi.Input<inputs.FunctionSecret>[]>;
    serviceAccountId?: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<string>[]>;
    userHash: pulumi.Input<string>;
}