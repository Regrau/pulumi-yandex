// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Allows management of Yandex Cloud Serverless Containers
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const test_container = new yandex.ServerlessContainer("test-container", {
 *     coreFraction: 100,
 *     cores: 1,
 *     description: "any description",
 *     executionTimeout: "15s",
 *     image: {
 *         url: "cr.yandex/yc/test-image:v1",
 *     },
 *     memory: 256,
 *     secrets: [{
 *         environmentVariable: "ENV_VARIABLE",
 *         id: yandex_lockbox_secret_secret.id,
 *         key: "secret-key",
 *         versionId: yandex_lockbox_secret_version_secret_version.id,
 *     }],
 *     serviceAccountId: "are1service2account3id",
 * });
 * ```
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as yandex from "@pulumi/yandex";
 *
 * const test_container_with_digest = new yandex.ServerlessContainer("test-container-with-digest", {
 *     image: {
 *         digest: "sha256:e1d772fa8795adac847a2420c87d0d2e3d38fb02f168cab8c0b5fe2fb95c47f4",
 *         url: "cr.yandex/yc/test-image:v1",
 *     },
 *     memory: 128,
 * });
 * ```
 */
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

    /**
     * Concurrency of Yandex Cloud Serverless Container
     */
    public readonly concurrency!: pulumi.Output<number | undefined>;
    /**
     * Network access. If specified the revision will be attached to specified network
     * * `connectivity.0.network_id` - Network the revision will have access to
     */
    public readonly connectivity!: pulumi.Output<outputs.ServerlessContainerConnectivity | undefined>;
    /**
     * Core fraction (**0...100**) of the Yandex Cloud Serverless Container
     */
    public readonly coreFraction!: pulumi.Output<number>;
    public readonly cores!: pulumi.Output<number | undefined>;
    /**
     * Creation timestamp of the Yandex Cloud Serverless Container
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Description of the Yandex Cloud Serverless Container
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Execution timeout in seconds (**duration format**) for Yandex Cloud Serverless Container
     */
    public readonly executionTimeout!: pulumi.Output<string>;
    /**
     * Folder ID for the Yandex Cloud Serverless Container
     */
    public readonly folderId!: pulumi.Output<string>;
    /**
     * Revision deployment image for Yandex Cloud Serverless Container
     * * `image.0.url` (Required) - URL of image that will be deployed as Yandex Cloud Serverless Container
     * * `image.0.work_dir` - Working directory for Yandex Cloud Serverless Container
     * * `image.0.digest` - Digest of image that will be deployed as Yandex Cloud Serverless Container.
     * If presented, should be equal to digest that will be resolved at server side by URL.
     * Container will be updated on digest change even if `image.0.url` stays the same.
     * If field not specified then its value will be computed.
     * * `image.0.command` - List of commands for Yandex Cloud Serverless Container
     * * `image.0.args` - List of arguments for Yandex Cloud Serverless Container
     * * `image.0.environment` -  A set of key/value environment variable pairs for Yandex Cloud Serverless Container
     */
    public readonly image!: pulumi.Output<outputs.ServerlessContainerImage>;
    /**
     * A set of key/value label pairs to assign to the Yandex Cloud Serverless Container
     */
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Serverless Container
     */
    public readonly memory!: pulumi.Output<number>;
    /**
     * Yandex Cloud Serverless Container name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Last revision ID of the Yandex Cloud Serverless Container
     */
    public /*out*/ readonly revisionId!: pulumi.Output<string>;
    /**
     * Secrets for Yandex Cloud Serverless Container
     */
    public readonly secrets!: pulumi.Output<outputs.ServerlessContainerSecret[]>;
    /**
     * Service account ID for Yandex Cloud Serverless Container
     */
    public readonly serviceAccountId!: pulumi.Output<string | undefined>;
    /**
     * Invoke URL for the Yandex Cloud Serverless Container
     */
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
            resourceInputs["connectivity"] = state ? state.connectivity : undefined;
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
            resourceInputs["connectivity"] = args ? args.connectivity : undefined;
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
    /**
     * Concurrency of Yandex Cloud Serverless Container
     */
    concurrency?: pulumi.Input<number>;
    /**
     * Network access. If specified the revision will be attached to specified network
     * * `connectivity.0.network_id` - Network the revision will have access to
     */
    connectivity?: pulumi.Input<inputs.ServerlessContainerConnectivity>;
    /**
     * Core fraction (**0...100**) of the Yandex Cloud Serverless Container
     */
    coreFraction?: pulumi.Input<number>;
    cores?: pulumi.Input<number>;
    /**
     * Creation timestamp of the Yandex Cloud Serverless Container
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Description of the Yandex Cloud Serverless Container
     */
    description?: pulumi.Input<string>;
    /**
     * Execution timeout in seconds (**duration format**) for Yandex Cloud Serverless Container
     */
    executionTimeout?: pulumi.Input<string>;
    /**
     * Folder ID for the Yandex Cloud Serverless Container
     */
    folderId?: pulumi.Input<string>;
    /**
     * Revision deployment image for Yandex Cloud Serverless Container
     * * `image.0.url` (Required) - URL of image that will be deployed as Yandex Cloud Serverless Container
     * * `image.0.work_dir` - Working directory for Yandex Cloud Serverless Container
     * * `image.0.digest` - Digest of image that will be deployed as Yandex Cloud Serverless Container.
     * If presented, should be equal to digest that will be resolved at server side by URL.
     * Container will be updated on digest change even if `image.0.url` stays the same.
     * If field not specified then its value will be computed.
     * * `image.0.command` - List of commands for Yandex Cloud Serverless Container
     * * `image.0.args` - List of arguments for Yandex Cloud Serverless Container
     * * `image.0.environment` -  A set of key/value environment variable pairs for Yandex Cloud Serverless Container
     */
    image?: pulumi.Input<inputs.ServerlessContainerImage>;
    /**
     * A set of key/value label pairs to assign to the Yandex Cloud Serverless Container
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Serverless Container
     */
    memory?: pulumi.Input<number>;
    /**
     * Yandex Cloud Serverless Container name
     */
    name?: pulumi.Input<string>;
    /**
     * Last revision ID of the Yandex Cloud Serverless Container
     */
    revisionId?: pulumi.Input<string>;
    /**
     * Secrets for Yandex Cloud Serverless Container
     */
    secrets?: pulumi.Input<pulumi.Input<inputs.ServerlessContainerSecret>[]>;
    /**
     * Service account ID for Yandex Cloud Serverless Container
     */
    serviceAccountId?: pulumi.Input<string>;
    /**
     * Invoke URL for the Yandex Cloud Serverless Container
     */
    url?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServerlessContainer resource.
 */
export interface ServerlessContainerArgs {
    /**
     * Concurrency of Yandex Cloud Serverless Container
     */
    concurrency?: pulumi.Input<number>;
    /**
     * Network access. If specified the revision will be attached to specified network
     * * `connectivity.0.network_id` - Network the revision will have access to
     */
    connectivity?: pulumi.Input<inputs.ServerlessContainerConnectivity>;
    /**
     * Core fraction (**0...100**) of the Yandex Cloud Serverless Container
     */
    coreFraction?: pulumi.Input<number>;
    cores?: pulumi.Input<number>;
    /**
     * Description of the Yandex Cloud Serverless Container
     */
    description?: pulumi.Input<string>;
    /**
     * Execution timeout in seconds (**duration format**) for Yandex Cloud Serverless Container
     */
    executionTimeout?: pulumi.Input<string>;
    /**
     * Folder ID for the Yandex Cloud Serverless Container
     */
    folderId?: pulumi.Input<string>;
    /**
     * Revision deployment image for Yandex Cloud Serverless Container
     * * `image.0.url` (Required) - URL of image that will be deployed as Yandex Cloud Serverless Container
     * * `image.0.work_dir` - Working directory for Yandex Cloud Serverless Container
     * * `image.0.digest` - Digest of image that will be deployed as Yandex Cloud Serverless Container.
     * If presented, should be equal to digest that will be resolved at server side by URL.
     * Container will be updated on digest change even if `image.0.url` stays the same.
     * If field not specified then its value will be computed.
     * * `image.0.command` - List of commands for Yandex Cloud Serverless Container
     * * `image.0.args` - List of arguments for Yandex Cloud Serverless Container
     * * `image.0.environment` -  A set of key/value environment variable pairs for Yandex Cloud Serverless Container
     */
    image: pulumi.Input<inputs.ServerlessContainerImage>;
    /**
     * A set of key/value label pairs to assign to the Yandex Cloud Serverless Container
     */
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Memory in megabytes (**aligned to 128MB**) for Yandex Cloud Serverless Container
     */
    memory: pulumi.Input<number>;
    /**
     * Yandex Cloud Serverless Container name
     */
    name?: pulumi.Input<string>;
    /**
     * Secrets for Yandex Cloud Serverless Container
     */
    secrets?: pulumi.Input<pulumi.Input<inputs.ServerlessContainerSecret>[]>;
    /**
     * Service account ID for Yandex Cloud Serverless Container
     */
    serviceAccountId?: pulumi.Input<string>;
}
