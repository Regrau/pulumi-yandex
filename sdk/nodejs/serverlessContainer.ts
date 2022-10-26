// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class ServerlessContainer extends pulumi.CustomResource {
    /**
     * Get an existing ServerlessContainer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServerlessContainerState, opts?: pulumi.CustomResourceOptions): ServerlessContainer {
        return new ServerlessContainer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/serverlessContainer:ServerlessContainer';

    /**
     * Returns true if the given object is an instance of ServerlessContainer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServerlessContainer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServerlessContainer.__pulumiType;
    }

    public readonly concurrency!: pulumi.Output<number | undefined>;
    public readonly coreFraction!: pulumi.Output<number>;
    public readonly cores!: pulumi.Output<number | undefined>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly executionTimeout!: pulumi.Output<string>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly image!: pulumi.Output<outputs.ServerlessContainerImage>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Container memory in megabytes, should be aligned to 128
     */
    public readonly memory!: pulumi.Output<number>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly revisionId!: pulumi.Output<string>;
    public readonly secrets!: pulumi.Output<outputs.ServerlessContainerSecret[]>;
    public readonly serviceAccountId!: pulumi.Output<string | undefined>;
    public /*out*/ readonly url!: pulumi.Output<string>;

    /**
     * Create a ServerlessContainer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerlessContainerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServerlessContainerArgs | ServerlessContainerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ServerlessContainerState | undefined;
            resourceInputs["concurrency"] = state ? state.concurrency : undefined;
            resourceInputs["coreFraction"] = state ? state.coreFraction : undefined;
            resourceInputs["cores"] = state ? state.cores : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["executionTimeout"] = state ? state.executionTimeout : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["image"] = state ? state.image : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["memory"] = state ? state.memory : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["revisionId"] = state ? state.revisionId : undefined;
            resourceInputs["secrets"] = state ? state.secrets : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
        } else {
            const args = argsOrState as ServerlessContainerArgs | undefined;
            if ((!args || args.image === undefined) && !opts.urn) {
                throw new Error("Missing required property 'image'");
            }
            if ((!args || args.memory === undefined) && !opts.urn) {
                throw new Error("Missing required property 'memory'");
            }
            resourceInputs["concurrency"] = args ? args.concurrency : undefined;
            resourceInputs["coreFraction"] = args ? args.coreFraction : undefined;
            resourceInputs["cores"] = args ? args.cores : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["executionTimeout"] = args ? args.executionTimeout : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["image"] = args ? args.image : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["memory"] = args ? args.memory : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["secrets"] = args ? args.secrets : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["revisionId"] = undefined /*out*/;
            resourceInputs["url"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ServerlessContainer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServerlessContainer resources.
 */
export interface ServerlessContainerState {
    concurrency?: pulumi.Input<number>;
    coreFraction?: pulumi.Input<number>;
    cores?: pulumi.Input<number>;
    createdAt?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    executionTimeout?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    image?: pulumi.Input<inputs.ServerlessContainerImage>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Container memory in megabytes, should be aligned to 128
     */
    memory?: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    revisionId?: pulumi.Input<string>;
    secrets?: pulumi.Input<pulumi.Input<inputs.ServerlessContainerSecret>[]>;
    serviceAccountId?: pulumi.Input<string>;
    url?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServerlessContainer resource.
 */
export interface ServerlessContainerArgs {
    concurrency?: pulumi.Input<number>;
    coreFraction?: pulumi.Input<number>;
    cores?: pulumi.Input<number>;
    description?: pulumi.Input<string>;
    executionTimeout?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    image: pulumi.Input<inputs.ServerlessContainerImage>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Container memory in megabytes, should be aligned to 128
     */
    memory: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    secrets?: pulumi.Input<pulumi.Input<inputs.ServerlessContainerSecret>[]>;
    serviceAccountId?: pulumi.Input<string>;
}
