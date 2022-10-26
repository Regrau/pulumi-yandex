// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class AlbBackendGroup extends pulumi.CustomResource {
    /**
     * Get an existing AlbBackendGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AlbBackendGroupState, opts?: pulumi.CustomResourceOptions): AlbBackendGroup {
        return new AlbBackendGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/albBackendGroup:AlbBackendGroup';

    /**
     * Returns true if the given object is an instance of AlbBackendGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AlbBackendGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AlbBackendGroup.__pulumiType;
    }

    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly grpcBackends!: pulumi.Output<outputs.AlbBackendGroupGrpcBackend[] | undefined>;
    public readonly httpBackends!: pulumi.Output<outputs.AlbBackendGroupHttpBackend[] | undefined>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly sessionAffinity!: pulumi.Output<outputs.AlbBackendGroupSessionAffinity | undefined>;
    public readonly streamBackends!: pulumi.Output<outputs.AlbBackendGroupStreamBackend[] | undefined>;

    /**
     * Create a AlbBackendGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: AlbBackendGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AlbBackendGroupArgs | AlbBackendGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AlbBackendGroupState | undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["grpcBackends"] = state ? state.grpcBackends : undefined;
            resourceInputs["httpBackends"] = state ? state.httpBackends : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["sessionAffinity"] = state ? state.sessionAffinity : undefined;
            resourceInputs["streamBackends"] = state ? state.streamBackends : undefined;
        } else {
            const args = argsOrState as AlbBackendGroupArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["grpcBackends"] = args ? args.grpcBackends : undefined;
            resourceInputs["httpBackends"] = args ? args.httpBackends : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["sessionAffinity"] = args ? args.sessionAffinity : undefined;
            resourceInputs["streamBackends"] = args ? args.streamBackends : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AlbBackendGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AlbBackendGroup resources.
 */
export interface AlbBackendGroupState {
    createdAt?: pulumi.Input<string>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    grpcBackends?: pulumi.Input<pulumi.Input<inputs.AlbBackendGroupGrpcBackend>[]>;
    httpBackends?: pulumi.Input<pulumi.Input<inputs.AlbBackendGroupHttpBackend>[]>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    sessionAffinity?: pulumi.Input<inputs.AlbBackendGroupSessionAffinity>;
    streamBackends?: pulumi.Input<pulumi.Input<inputs.AlbBackendGroupStreamBackend>[]>;
}

/**
 * The set of arguments for constructing a AlbBackendGroup resource.
 */
export interface AlbBackendGroupArgs {
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    grpcBackends?: pulumi.Input<pulumi.Input<inputs.AlbBackendGroupGrpcBackend>[]>;
    httpBackends?: pulumi.Input<pulumi.Input<inputs.AlbBackendGroupHttpBackend>[]>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    sessionAffinity?: pulumi.Input<inputs.AlbBackendGroupSessionAffinity>;
    streamBackends?: pulumi.Input<pulumi.Input<inputs.AlbBackendGroupStreamBackend>[]>;
}