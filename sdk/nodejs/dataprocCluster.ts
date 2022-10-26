// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

export class DataprocCluster extends pulumi.CustomResource {
    /**
     * Get an existing DataprocCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DataprocClusterState, opts?: pulumi.CustomResourceOptions): DataprocCluster {
        return new DataprocCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'yandex:index/dataprocCluster:DataprocCluster';

    /**
     * Returns true if the given object is an instance of DataprocCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DataprocCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DataprocCluster.__pulumiType;
    }

    public readonly bucket!: pulumi.Output<string | undefined>;
    public readonly clusterConfig!: pulumi.Output<outputs.DataprocClusterClusterConfig>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public readonly deletionProtection!: pulumi.Output<boolean>;
    public readonly description!: pulumi.Output<string | undefined>;
    public readonly folderId!: pulumi.Output<string>;
    public readonly hostGroupIds!: pulumi.Output<string[] | undefined>;
    public readonly labels!: pulumi.Output<{[key: string]: string} | undefined>;
    public readonly name!: pulumi.Output<string>;
    public readonly securityGroupIds!: pulumi.Output<string[] | undefined>;
    public readonly serviceAccountId!: pulumi.Output<string>;
    public readonly uiProxy!: pulumi.Output<boolean | undefined>;
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a DataprocCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DataprocClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DataprocClusterArgs | DataprocClusterState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DataprocClusterState | undefined;
            resourceInputs["bucket"] = state ? state.bucket : undefined;
            resourceInputs["clusterConfig"] = state ? state.clusterConfig : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["deletionProtection"] = state ? state.deletionProtection : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["folderId"] = state ? state.folderId : undefined;
            resourceInputs["hostGroupIds"] = state ? state.hostGroupIds : undefined;
            resourceInputs["labels"] = state ? state.labels : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
            resourceInputs["serviceAccountId"] = state ? state.serviceAccountId : undefined;
            resourceInputs["uiProxy"] = state ? state.uiProxy : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as DataprocClusterArgs | undefined;
            if ((!args || args.clusterConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterConfig'");
            }
            if ((!args || args.serviceAccountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceAccountId'");
            }
            resourceInputs["bucket"] = args ? args.bucket : undefined;
            resourceInputs["clusterConfig"] = args ? args.clusterConfig : undefined;
            resourceInputs["deletionProtection"] = args ? args.deletionProtection : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["folderId"] = args ? args.folderId : undefined;
            resourceInputs["hostGroupIds"] = args ? args.hostGroupIds : undefined;
            resourceInputs["labels"] = args ? args.labels : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
            resourceInputs["serviceAccountId"] = args ? args.serviceAccountId : undefined;
            resourceInputs["uiProxy"] = args ? args.uiProxy : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
            resourceInputs["createdAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DataprocCluster.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DataprocCluster resources.
 */
export interface DataprocClusterState {
    bucket?: pulumi.Input<string>;
    clusterConfig?: pulumi.Input<inputs.DataprocClusterClusterConfig>;
    createdAt?: pulumi.Input<string>;
    deletionProtection?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    hostGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    serviceAccountId?: pulumi.Input<string>;
    uiProxy?: pulumi.Input<boolean>;
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DataprocCluster resource.
 */
export interface DataprocClusterArgs {
    bucket?: pulumi.Input<string>;
    clusterConfig: pulumi.Input<inputs.DataprocClusterClusterConfig>;
    deletionProtection?: pulumi.Input<boolean>;
    description?: pulumi.Input<string>;
    folderId?: pulumi.Input<string>;
    hostGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    labels?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    name?: pulumi.Input<string>;
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
    serviceAccountId: pulumi.Input<string>;
    uiProxy?: pulumi.Input<boolean>;
    zoneId?: pulumi.Input<string>;
}
